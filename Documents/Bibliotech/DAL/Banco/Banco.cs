using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Banco
{
    public class Banco
    {

        private static SqlConnection conexao;

        //Método de consulta dql que faz consultas no banco de dados.
        public static DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, cn);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable Consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection(@"Data Source = NSYS-CDS-0301\SQLDESENVOLVEDOR; Initial Catalog = Biblioteca; Integrated Security = True");
            conexao.Open();
            return conexao;
        }
    }
}
