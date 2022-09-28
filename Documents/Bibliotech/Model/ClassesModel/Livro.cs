using System;

namespace Model.ClassesModel
{
    public class Livro
    {
        //propierts private
        private int codigo;
        private string tombo;
        private int codigoSituacao;
        private string descricaoSituacao;
        private string titulo;
        private int codigoAutor;
        private string nomeAutor;
        private int codigoCategoria;
        private string descricaoCategoria;
        private int codigoEditora;
        private string nome;
        private string ano;
        private DateTime dataCadastro;
        private string classificacao;
        private int exemplar;
        private string isbn;
        private string issn;
        private string material;
        private string volume;
        private string localPublicacao;
        private string assunto;
        private string areaConhecimento;

        //propierts public 
        public string AREA_CONHECIMENTO
        {
            get { return areaConhecimento; }
            set { areaConhecimento = value; }
        }
        public string ASSUNTO
        {
            get { return assunto; }
            set { assunto = value; }
        }
        public string LOCAL_PUBLICACAO
        {
            get { return localPublicacao; }
            set { localPublicacao = value; }
        }
        public string VOLUME
        {
            get { return volume; }
            set { volume = value; }
        }
        public string ISSN
        {
            get { return issn; }
            set { issn = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string CLASSIFICACAO
        {
            get { return classificacao; }
            set { classificacao = value; }
        }
        public DateTime DATA_CADASTRO
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public string ANO
        {
            get { return ano; }
            set { ano = value; }
        }
        public int CODIGO_EDITORA
        {
            get { return codigoEditora; }
            set { codigoEditora = value; }
        }
        public string NOME
        {
            get { return nome; }
            set { nome = value; }
        }
        public int CODIGO_CATEGORIA
        {
            get { return codigoCategoria; }
            set { codigoCategoria = value; }
        }
        public string DESCRICAO_CATEGORIA
        {
            get { return descricaoCategoria; }
            set { descricaoCategoria = value; }
        }
        public int CODIGO_AUTOR
        {
            get { return codigoAutor; }
            set { codigoAutor = value; }
        }
        public string NOME_AUTOR
        {
            get { return nomeAutor; }
            set { nomeAutor = value; }
        }
        public string TITULO
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int CODIGO_SITUACAO
        {
            get { return codigoSituacao; }
            set { codigoSituacao = value; }
        }
        public string DESCRICAO_SITUACAO
        {
            get { return descricaoSituacao; }
            set { descricaoSituacao = value; }
        }
        public string TOMBO
        {
            get { return tombo; }
            set { tombo = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int EXEMPLAR
        {
            get
            {
                return exemplar;
            }
            set
            {
                exemplar = value;
            }
        }
        public string MATERIAL
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }
    }
}
