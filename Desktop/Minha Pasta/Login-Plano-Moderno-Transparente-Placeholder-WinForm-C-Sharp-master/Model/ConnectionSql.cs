using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ConnectionSql
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Data Source = NSYS - CDS - 0301\\SQLDESENVOLVEDOR; Initial Catalog = NorthwindStore; Integrated Security = True");
        }
    }
}
