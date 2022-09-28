using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class AutorBLL
    {
        //Método de inserir autor que armazena dados do cadastro de autor no banco de dados.
        public Autor Inserir(Autor _autor)
        {
            if (_autor.NOME_AUTOR == "")
                throw new Exception("Por favor, informe o nome!");
            /* if (_autor.NomeAutor == Convert.ToString(new AutorDAL().Buscar(_autor.NomeAutor.ToUpper().ToString()).Rows[0]["NomeAutor"]))
                 throw new Exception("Atenção!, Já existe esse registro, favor alterar o nome do autor!");*/

            AutorDAL autorDAL = new AutorDAL();
            return autorDAL.Inserir(_autor);
        }
        //Método de alterar autor que armazena dados de alteração de informações do autor no banco de dados.
        public Autor Alterar(Autor _leitor)
        {
            AutorDAL autorDAL = new AutorDAL();
            return autorDAL.Alterar(_leitor);
        }
        //Método de buscar cadastros de autores que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            AutorDAL autorDAL = new AutorDAL();
            return autorDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de autor que estão armazenado no banco de dados.
        public void Excluir(int _id)
        {
            AutorDAL autorDAL = new AutorDAL();
            autorDAL.Excluir(_id);
        }
    }
}
