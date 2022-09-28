namespace Infra
{
    public static class AutorMensagens
    {
        public static void Inserir(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de autor foi gravado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível gravar o cadastro de autor!");
                    break;
            }
        }
        public static void Alterar(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de autor foi alterado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível alterar o cadastro de autor!");
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
