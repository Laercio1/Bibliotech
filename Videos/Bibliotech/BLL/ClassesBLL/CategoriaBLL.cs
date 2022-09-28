using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class CategoriaBLL
    {
        //Método de inserir categoria que armazena dados do cadastro de categoria no banco de dados.
        public Categoria Inserir(Categoria _categoria)
        {
            if (_categoria.DESCRICAO_CATEGORIA == "")
                throw new Exception("Por favor, informe a descrição!");

            CategoriaDAL categoriaDAL = new CategoriaDAL();
            return categoriaDAL.Inserir(_categoria);
        }
        //Método de alterar categoria que armazena dados de alteração de informações da categoria no banco de dados.
        public Categoria Alterar(Categoria _categoria)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            return categoriaDAL.Alterar(_categoria);
        }
        //Método de buscar cadastros de categorias que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            return categoriaDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de categoria que estão armazenadas no banco de dados.
        public void Excluir(int _id)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            categoriaDAL.Excluir(_id);
        }
    }
}
