using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderDAO : ConnectionSql
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"Select o.Id, 
                                            o.OrderDate, 
                                            c.FirstName+', '+c.LastName as Customer,
                                            Product=stuff((select ' - ' +'x'+convert(varchar (10),oi2.Quantity)+' '+ ProductName
                                            from OrderItem oi2
                                            inner join Product on Product.Id= oi2.ProductId
                                            where oi2.OrderId = oi1.OrderId
                                            for xml path('')), 1, 2, ''),
                                            sum((Quantity*UnitPrice) as TotalAmount
                                            from Order o
                                            inner join Customer c on c.Id=o.CustomerId
                                            inner join OrderItem oi1 on oi1.OrderId =o.Id
                                            where o.OrderDate between @fromDate and @toDate
                                            group by o.Id, oi1.OrderId, o.OrderDate, c.FirstName, c.LastName
                                            order by o.Id asc";
                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                    command.CommandType = CommandType.Text;

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
