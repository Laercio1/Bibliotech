using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class DevolucaoBLL
    {
        //Método de inserir devolução que armazena dados do cadastro de devolução no banco de dados.
        public Devolucao Inserir(Devolucao _devolucao)
        {
            if (_devolucao.CODIGO_EMPRESTIMO == 0)
                throw new Exception("Por favor, informe o empréstimo!");

            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            return devolucaoDAL.Inserir(_devolucao);
        }
        //Método de alterar devolução que armazena dados de alteração de informações da devolução no banco de dados.
        public Devolucao Alterar(Devolucao _devolucao)
        {
            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            return devolucaoDAL.Alterar(_devolucao);
        }
        //Método de buscar cadastros de devoluções que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            return devolucaoDAL.Buscar(_filtro);
        }
        //Método de buscar cadastros de devoluções que estão cadastradas e armazenadas no banco de dados.
        public DataTable BuscarPorCodigo(string _filtro)
        {
            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            return devolucaoDAL.BuscarPorCodigo(_filtro);
        }
        //Método de excluir cadastro de devolução que estão armazenadas no banco de dados.
        public void Excluir(int _id)
        {
            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            devolucaoDAL.Excluir(_id);
        }
        //Método de buscar cadastros de devoluções por data inicial e data final que estão armazenados no banco de dados.
        public DataTable BuscarDevolucaoPorData(DateTime fromDate, DateTime toDate)
        {
            DevolucaoDAL devolucaoDAL = new DevolucaoDAL();
            return devolucaoDAL.BuscarDevolucaoPorData(fromDate, toDate);
        }
    }
}
