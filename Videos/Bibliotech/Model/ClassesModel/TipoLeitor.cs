namespace Model.ClassesModel
{
    public class TipoLeitor
    {
        //propierts private
        private int codigo;
        private int descricao;

        //propierts public 
        public int DESCRICAO
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
