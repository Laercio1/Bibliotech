using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model.Cache;
namespace Model
{
    public class UserDAL : DbConnection
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        //
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: Password recovery request",
                            body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "your current password is: " + accountPassword +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "Please check your mai: " + userMail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                        return "Sorry, you do not have an account with that mail or username";
                }
            }
        }
        public void AnyMethod()
        {
            if (UserCache.Position == Positions.Administrador)
            {
                //codes
            }
            if (UserCache.Position == Positions.Vendedor || UserCache.Position == Positions.Comprador)
            {
                //codes
            }
        }
    }
}
