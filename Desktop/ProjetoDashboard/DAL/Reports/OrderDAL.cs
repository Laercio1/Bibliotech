using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class OrderDAL : Conexao
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"getSalesOrderr";
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
