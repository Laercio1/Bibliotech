using System;
using System.IO;
using System.Text;

namespace Infra
{
    public static class Arquivo
    {
        //Metódo estático que grava texto no final do arquivo.
        public static void GravarTextoNoFinalDoArquivo(string _texto, string _caminho)
        {
            FileStream fileStream = new FileStream(_caminho, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.WriteLine(_texto);

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
        //Metódo estático que gravar o texto e adiciona no documento do diretório.
        public static void GravarLog(string _texto)
        {
            GravarTextoNoFinalDoArquivo(DateTime.Now.ToString() + ": " + _texto, Constante.DiretorioDeLog + "\\" + Constante.NomeArquivoLog);
        }
    }
}
