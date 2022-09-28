namespace Infra
{
    public static class LivroMensagens
    {
        public static void Inserir(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de livro foi gravado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível gravar o cadastro de livro!");
                    break;
            }
        }
        public static void Alterar(int tipo)
        {
            switch (tipo)
            {
                //Sucesso
                case 1:
                    Mensagens.Afirmacao(1, "O cadastro de livro foi alterado com sucesso!");
                    break;
                //Erro
                case 2:
                    Mensagens.Afirmacao(3, "Não foi possível alterar o cadastro de livro!");
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
