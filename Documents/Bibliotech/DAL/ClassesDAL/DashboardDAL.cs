using DAL.Banco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace DAL.ClassesDAL
{
    public struct RevenueByDate
    {
        public string DATA { get; set; }
        public int TOTAL_LIVROS { get; set; }
    }
    public class DashboardDAL : Conexao
    {
        //Atributos e Propiedades
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int Numero_Leitores { get; private set; }
        public int Numero_Autores { get; private set; }
        public int Numero_Livros { get; private set; }
        public List<KeyValuePair<string, int>> Top_Livros_List { get; private set; }
        public List<KeyValuePair<string, int>> Livros_Baixo_Estoque { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int Numero_Emprestimos { get; set; }
        public int Total_Livros_Emprestados { get; set; }
        public int Total_Devolucoes { get; set; }

        //Construtor
        public DashboardDAL()
        {
        }

        //Metódos Privados
        private void GetNumeroItems()
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Retorna número total de clientes armazenados no banco de dados.
                    command.CommandText = "SELECT COUNT(CODIGO) FROM LEITOR";
                    Numero_Leitores = (int)command.ExecuteScalar();

                    //Retorna número total de fornecedores armazenados no banco de dados.
                    command.CommandText = "	SELECT COUNT(CODIGO) FROM AUTOR";
                    Numero_Autores = (int)command.ExecuteScalar();

                    //Retorna número total de produtos armazenados no banco de dados.
                    command.CommandText = "SELECT COUNT(CODIGO) FROM LIVRO";
                    Numero_Livros = (int)command.ExecuteScalar();

                    //Retorna número total de vendas armazenados no banco de dados.
                    command.CommandText = @"SELECT COUNT(CODIGO) FROM EMPRESTIMO
                                            WHERE DATA_HORA_EMPRESTIMO between @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    Numero_Emprestimos = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetNumeroDevolucao()
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Retorna número total de vendas armazenados no banco de dados.
                    command.CommandText = @"SELECT COUNT(CODIGO) FROM DEVOLUCAO
                                            WHERE DATA_HORA_DEVOLUCAO between  @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    Total_Devolucoes = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetLivroAnalises()
        {
            Top_Livros_List = new List<KeyValuePair<string, int>>();
            Livros_Baixo_Estoque = new List<KeyValuePair<string, int>>();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Retorna os 5 produtos mais faturados na data informada pelo usuário.
                    command.CommandText = @"SELECT TOP 5 L.TITULO, SUM(EMPRESTIMO.EXEMPLAR) AS QUANTIDADE
                                            FROM EMPRESTIMO
                                            inner join LIVRO L ON L.CODIGO = EMPRESTIMO.CODIGO_LIVRO
                                            WHERE DATA_HORA_EMPRESTIMO between @fromDate AND @toDate
                                            GROUP BY L.TITULO
                                            ORDER BY QUANTIDADE DESC";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Top_Livros_List.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Retorna os produtos de estoque inferior a quantidade 6 armazenados no banco de dados.
                    command.CommandText = @"SELECT TITULO, EXEMPLAR
                                            FROM LIVRO
                                            WHERE EXEMPLAR <= 5";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Livros_Baixo_Estoque.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        private void GetEmprestimoAnalises()
        {
            GrossRevenueList = new List<RevenueByDate>();
            Total_Devolucoes = 0;
            Total_Livros_Emprestados = 0;

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT DATA_HORA_EMPRESTIMO, SUM(EXEMPLAR)
                                            FROM EMPRESTIMO
                                            WHERE DATA_HORA_EMPRESTIMO between @fromDate AND @toDate
                                            GROUP BY DATA_HORA_EMPRESTIMO";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                            );
                        Total_Livros_Emprestados += (int)reader[1];
                    }
                    reader.Close();

                    //Agrupando por horas
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                DATA = order.Key,
                                                TOTAL_LIVROS = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Agrupando por dias
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                DATA = order.Key,
                                                TOTAL_LIVROS = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Agrupando por semanas
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                DATA = "Semana " + order.Key.ToString(),
                                                TOTAL_LIVROS = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Agrupando por meses
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                DATA = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TOTAL_LIVROS = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Agrupando por anos 
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                DATA = order.Key,
                                                TOTAL_LIVROS = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }
        //Métodos públicos
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumeroItems();
                GetLivroAnalises();
                GetEmprestimoAnalises();
                GetNumeroDevolucao();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
