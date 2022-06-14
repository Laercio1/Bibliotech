using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class TarefaBLL
    {
        public Tarefa Inserir(Tarefa _tarefa)
        {
            if (_tarefa.IdUsuario == 0)
                throw new Exception("Infome o usuario");
            if (_tarefa.Descricao == "")
                throw new Exception("Informe a descrição");
            if (_tarefa.Estatus == "")
                throw new Exception("Informe o status");

            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Inserir(_tarefa);
        }
        public Tarefa Alterar(Tarefa _usuario)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Alterar(_usuario);
        }
        public DataTable Buscar(string _filtro)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            tarefaDAL.Excluir(_id);
        }
    }
}
