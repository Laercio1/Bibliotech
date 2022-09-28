using System.Data.SqlClient;

namespace DAL.Banco
{
    public class Conexao
    {
        //Propiedade de conexão com o banco de dados.
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA;Initial Catalog=Biblioteca;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
            }
        }
        protected SqlConnection getConnection()
        {
            return new SqlConnection(@"User ID=SA;Initial Catalog=Biblioteca;Data Source=.\SQLEXPRESS2019;Password=Senailab05");
        }
    }
}
