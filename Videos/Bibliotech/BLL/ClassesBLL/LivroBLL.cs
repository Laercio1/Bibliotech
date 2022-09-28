using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class LivroBLL
    {
        //Método de inserir livro que armazena dados do cadastro de livro no banco de dados.
        public Livro Inserir(Livro _livro)
        {
            if (_livro.TITULO == "")
                throw new Exception("Por favor, infome o título!");
            if (_livro.TOMBO == "")
                throw new Exception("Por favor, informe o tombo!");
            if (_livro.EXEMPLAR == 0)
                throw new Exception("Por favor, informe o exemplar!");
            if (_livro.ISBN == "")
                throw new Exception("Por favor, informe o ISBN!");
            if (_livro.VOLUME == "")
                throw new Exception("Por favor, informe o volume!");
            if (_livro.CLASSIFICACAO == "")
                throw new Exception("Por favor, informe a classificação!");
            if (_livro.LOCAL_PUBLICACAO == "")
                throw new Exception("Por favor, informe o local de publicação!");
            if (_livro.ANO == "")
                throw new Exception("Por favor, informe o ano!");
            if (_livro.CODIGO_CATEGORIA == 0)
                throw new Exception("Por favor, informe a categoria!");
            if (_livro.CODIGO_SITUACAO == 0)
                throw new Exception("Por favor, informe a situação!");
            if (_livro.CODIGO_AUTOR == 0)
                throw new Exception("Por favor, informe o autor!");
            if (_livro.CODIGO_EDITORA == 0)
                throw new Exception("Por favor, informe a editora!");
            if (_livro.ASSUNTO == "" && _livro.ASSUNTO == null)
                throw new Exception("Por favor, informe o assunto!");
            if (_livro.AREA_CONHECIMENTO == "" && _livro.AREA_CONHECIMENTO == null)
                throw new Exception("Por favor, informe a área de conhecimento!");

            /*            if (_livro.Tombo == Convert.ToInt32(new LivroDAL().Buscar(_livro.Codigo.ToString()).Rows[0]["Tombo"]))
                            throw new Exception("Atenção!, já existe um livro cadastrado com o tombo informado no sistema, favor alterar tombo!");

                        if (_livro.Isbn == Convert.ToInt32(new LivroDAL().Buscar(_livro.Codigo.ToString()).Rows[0]["ISBN"]))
                            throw new Exception("Atenção!, já existe um livro cadastrado com o ISBN informado no sistema, favor alterar ISBN!");

                        if (_livro.Issn == Convert.ToInt32(new LivroDAL().Buscar(_livro.Codigo.ToString()).Rows[0]["ISSN"]))
                            throw new Exception("Atenção!, já existe um livro cadastrado com o ISSN informado no sistema, favor alterar ISSN!");*/

            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.Inserir(_livro);
        }
        //Método de alterar livro que armazena dados de alteração de informações do livro no banco de dados.
        public Livro Alterar(Livro _livro)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.Alterar(_livro);
        }
        //Método de buscar cadastros de livros que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de livro que estão armazenados no banco de dados.
        public void Excluir(int _id)
        {
            LivroDAL livroDAL = new LivroDAL();
            livroDAL.Excluir(_id);
        }
        //Método de buscar cadastros de livros por autor que estão cadastrados e armazenados no banco de dados.
        public DataTable BuscarLivroPorAutor(int _codigo)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroPorAutor(_codigo);
        }
        //Método de buscar cadastros de livros por editora que estão cadastrados e armazenados no banco de dados.
        public DataTable BuscarLivroPorEditora(int _codigo)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroPorEditora(_codigo);
        }
        //Método de buscar cadastros de livros por categoria que estão cadastrados e armazenados no banco de dados.
        public DataTable BuscarLivroPorCategoria(int _codigo)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroPorCategoria(_codigo);
        }
        public DataTable BuscarLivroDisponivel(string _filtro)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroDisponivel(_filtro);
        }
        public DataTable BuscarLivroIndisponivel(string _filtro)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroIndisponivel(_filtro);
        }
        public DataTable BuscarLivroExtraviado(string _filtro)
        {
            LivroDAL livroDAL = new LivroDAL();
            return livroDAL.BuscarLivroExtraviado(_filtro);
        }
    }
}
