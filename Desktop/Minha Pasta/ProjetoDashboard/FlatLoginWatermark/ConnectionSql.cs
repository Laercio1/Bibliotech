using System.Data.SqlClient;

namespace FlatLoginWatermark
{
    public abstract class ConnectionSql
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source = NSYS-CDS-0301\SQLDESENVOLVEDOR; Initial Catalog = Bike_Store; Integrated Security = True");
        }
    }
}
