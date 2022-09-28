using System;

namespace Model.ClassesModel
{
    public class Leitor
    {
        //propierts private
        private int codigo;
        private int codigoTipoLeitor;
        private string descricao;
        private string nomeLeitor;
        private string sexo;
        private string endereco;
        private string bairro;
        private int codigoCidade;
        private string descricaoCidade;
        private int codigoEstado;
        private string descricaoEstado;
        private string cep;
        private string cpf;
        private string rg;
        private string telefone;
        private string email;
        private DateTime dataCadastro;
        private DateTime dataNascimento;

        //propierts public
        public string SEXO
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string NOME_LEITOR
        {
            get { return nomeLeitor; }
            set { nomeLeitor = value; }
        }
        public int CODIGO_TIPO_LEITOR
        {
            get { return codigoTipoLeitor; }
            set { codigoTipoLeitor = value; }
        }
        public string DESCRICAO
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public DateTime DATA_NASCIMENTO
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public DateTime DATA_CADASTRO
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string TELEFONE
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string ENDERECO
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public int CODIGO_ESTADO
        {
            get { return codigoEstado; }
            set { codigoEstado = value; }
        }
        public string DESCRICAO_ESTADO
        {
            get { return descricaoEstado; }
            set { descricaoEstado = value; }
        }
        public int CODIGO_CIDADE
        {
            get { return codigoCidade; }
            set { codigoCidade = value; }
        }
        public string DESCRICAO_CIDADE
        {
            get { return descricaoCidade; }
            set { descricaoCidade = value; }
        }
        public string BAIRRO
        {
            get { return bairro; }
            set { bairro = value; }
        }
    }
}
