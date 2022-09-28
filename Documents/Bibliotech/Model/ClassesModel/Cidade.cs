namespace Model.ClassesModel
{
    public class Cidade
    {
        //propierts private 
        private int codigo;
        private string descricaoCidade;

        //propierts public 
        public string DESCRICAO_CIDADE
        {
            get { return descricaoCidade; }
            set { descricaoCidade = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
