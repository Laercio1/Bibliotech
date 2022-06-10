using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderDAL
    {
        public Order Inserir(Order _order)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirOrder";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _order.Id
                };
                cmd.Parameters.Add(pid);

                /*SqlParameter porderDate = new SqlParameter("@Order")*/

                SqlParameter porderNumber = new SqlParameter("@Order", SqlDbType.DateTime)
                {
                    Value = _order.OrderNumber
                };
                cmd.Parameters.Add(porderNumber);

                SqlParameter pcustomerId = new SqlParameter("@CustomerId", SqlDbType.Int)
                {
                    Value = _order.CustomerId
                };
                cmd.Parameters.Add(pcustomerId);

                SqlParameter ptotalAmount = new SqlParameter("@TotalAmount", SqlDbType.Decimal)
                {
                    Value = _order.TotalAmount
                };
                cmd.Parameters.Add(ptotalAmount);

                cn.Open();
                _order.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _order;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarOrder";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@Filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
