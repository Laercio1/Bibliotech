namespace Model
{
    public class Tarefa
    {
        private int id;
        private int idUsuario;
        private string descricao;
        private string estatus;
        private string imagem;

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
