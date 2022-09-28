namespace Model.ClassesModel
{
    public class Editora
    {
        //propierts private 
        private int codigo;
        private string nome;

        //propierts public 
        public string NOME
        {
            get { return nome; }
            set { nome = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
