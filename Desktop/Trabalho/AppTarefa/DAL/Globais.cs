using System;

namespace DAL
{
    public class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; //0=Básico - 1=Gerente - 2=Master
        public static string caminho = Environment.CurrentDirectory;
        public static string nomeBanco = "loja";
        public static string caminhoBanco = @"\banco\";
        public static string caminhoFotos = caminho + @"\Fotos\";
    }
}
