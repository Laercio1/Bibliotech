namespace Model.ClassesModel
{
    public class Estado
    {
        //propierts private 
        private int codigo;
        private string descricaoEstado;

        //propierts public 
        public string DESCRICAO_ESTADO
        {
            get { return descricaoEstado; }
            set { descricaoEstado = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
