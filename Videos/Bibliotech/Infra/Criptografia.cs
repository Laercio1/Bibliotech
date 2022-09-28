using System.Web.Security;

namespace Infra
{
    public static class AcaoCriptografarSenhaParaHash
    {
        //Método de criptografar senha do usuário.
        public static string Cript_md5(this string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "md5");
        }
    }
}

