using Model.Cache;
namespace Model
{
    public class User
    {
        UserDAL userDAL = new UserDAL();
        public bool LoginUser(string user, string pass)
        {
            return userDAL.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDAL.recoverPassword(userRequesting);
        }
        public void AnyMethod()
        {
            //Security and permissions
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
