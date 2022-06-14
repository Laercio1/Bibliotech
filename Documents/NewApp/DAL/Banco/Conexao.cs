using System.Data.SqlClient;

namespace DAL
{
    public abstract class Conexao
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source = NSYS-CDS-0301\SQLDESENVOLVEDOR; Initial Catalog = NorthwindStore; Integrated Security = True");
        }
    }
}
