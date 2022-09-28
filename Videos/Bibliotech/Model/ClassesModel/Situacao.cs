namespace Model.ClassesModel
{
    public class Situacao
    {
        //propierts private 
        private int codigo;
        private string descricao;

        //propierts public 
        public string DESCRICAO
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
