using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class EditoraBLL
    {
        //Método de inserir editora que armazena dados do cadastro de editora no banco de dados.
        public Editora Inserir(Editora _editora)
        {
            if (_editora.NOME == "")
                throw new Exception("Por favor, informe o nome!");

            EditoraDAL editoraDAL = new EditoraDAL();
            return editoraDAL.Inserir(_editora);
        }
        //Método de alterar editora que armazena dados de alteração de informações da editora no banco de dados.
        public Editora Alterar(Editora _editora)
        {
            EditoraDAL editoraDAL = new EditoraDAL();
            return editoraDAL.Alterar(_editora);
        }
        //Método de buscar cadastros de editoras que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            EditoraDAL editoraDAL = new EditoraDAL();
            return editoraDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de editora que estão armazenadas no banco de dados.
        public void Excluir(int _id)
        {
            EditoraDAL editoraDAL = new EditoraDAL();
            editoraDAL.Excluir(_id);
        }
    }
}
