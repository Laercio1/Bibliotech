using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();
        public bool LoginUser(string user, string pass)
        {
            return userDAL.Login(user, pass);
        }
    }
}
