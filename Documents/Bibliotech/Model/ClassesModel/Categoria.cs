namespace Model.ClassesModel
{
    public class Categoria
    {
        //propierts private
        private int codigo;
        private string descricaoCategoria;

        //propierts public 
        public string DESCRICAO_CATEGORIA
        {
            get { return descricaoCategoria; }
            set { descricaoCategoria = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
