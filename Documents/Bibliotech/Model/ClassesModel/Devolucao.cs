using System;

namespace Model.ClassesModel
{
    public class Devolucao
    {
        //propierts private 
        private int codigo;
        private int codigoEmprestimo;
        private int codigoLivro;
        private string titulo;
        private int codigoLeitor;
        private string nomeLeitor;
        private int codigoUsuario;
        private string nomeUsuario;
        private DateTime dataHoraEmprestimo;
        private DateTime dataHoraDevolucao;
        private int exemplar;
        private string tombo;
        private string isbn;
        private string volume;
        private string enderecoLeitor;
        private string telefoneLeitor;
        private string enderecoUsuario;
        private string telefoneUsuario;

        //propierts public
        public string TELEFONE_USUARIO
        {
            get { return telefoneUsuario; }
            set { telefoneUsuario = value; }
        }
        public string ENDERECO_USUARIO
        {
            get { return enderecoUsuario; }
            set { enderecoUsuario = value; }
        }
        public string TELEFONE_LEITOR
        {
            get { return telefoneLeitor; }
            set { telefoneLeitor = value; }
        }
        public string ENDERECO_LEITOR
        {
            get { return enderecoLeitor; }
            set { enderecoLeitor = value; }
        }
        public string VOLUME
        {
            get { return volume; }
            set { volume = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string TOMBO
        {
            get { return tombo; }
            set { tombo = value; }
        }
        public DateTime DATA_HORA_EMPRESTIMO
        {
            get { return dataHoraEmprestimo; }
            set { dataHoraEmprestimo = value; }
        }
        public int EXEMPLAR
        {
            get { return exemplar; }
            set { exemplar = value; }
        }
        public int CODIGO_EMPRESTIMO
        {
            get { return codigoEmprestimo; }
            set { codigoEmprestimo = value; }
        }
        public string NOME_USUARIO
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public string NOME_LEITOR
        {
            get { return nomeLeitor; }
            set { nomeLeitor = value; }
        }
        public int CODIGO
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string TITULO
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public DateTime DATA_HORA_DEVOLUCAO
        {
            get { return dataHoraDevolucao; }
            set { dataHoraDevolucao = value; }
        }
        public int CODIGO_USUARIO
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }
        public int CODIGO_LEITOR
        {
            get { return codigoLeitor; }
            set { codigoLeitor = value; }
        }
        public int CODIGO_LIVRO
        {
            get { return codigoLivro; }
            set { codigoLivro = value; }
        }
    }
}
