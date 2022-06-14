using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : Conexao
    {
        public bool Login(string user, string pass)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where UserName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User.IdUser = reader.GetInt32(0);
                            User.Email = reader.GetString(3);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
