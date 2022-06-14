using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Banco
    {
        public static DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = Conexaoo.StringDeConexao;
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
    }
}
