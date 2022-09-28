namespace Model.ClassesModel
{
    public class Autor
    {
        //propierts private
        private int codigo;
        private string nomeAutor;

        //propierts public
        public string NOME_AUTOR
        {
            get { return nomeAutor; }
            set { nomeAutor = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
