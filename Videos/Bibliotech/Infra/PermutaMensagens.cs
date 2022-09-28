using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class PermutaMensagens
    {
        public static void Inserir(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de permuta foi gravado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível gravar o cadastro de permuta!");
                    break;
            }
        }
        public static void Alterar(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de permuta foi alterado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível alterar o cadastro de permuta!");
                    break;
            }
        }
        public static void Exluir(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "Registro excluido com sucesso!");
                    break;
            }
        }
    }
}
