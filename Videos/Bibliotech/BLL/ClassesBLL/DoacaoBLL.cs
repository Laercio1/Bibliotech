using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class DoacaoBLL
    {
        //Método de inserir doação que armazena dados do cadastro de doação no banco de dados.
        public Doacao Inserir(Doacao _doacao)
        {
            if (_doacao.DESCRICAO == "")
                throw new Exception("Por favor, informe a descrição!");
            if (_doacao.QUANTIDADE == 0)
                throw new Exception("Por favor, informe a quantidade!");

            DoacaoDAL doacaoDAL = new DoacaoDAL();
            return doacaoDAL.Inserir(_doacao);
        }
        //Método de alterar doação que armazena dados de alteração de informações do doação no banco de dados.
        public Doacao Alterar(Doacao _doacao)
        {
            DoacaoDAL doacaoDAL = new DoacaoDAL();
            return doacaoDAL.Alterar(_doacao);
        }
        //Método de buscar cadastros de doações que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            DoacaoDAL doacaoDAL = new DoacaoDAL();
            return doacaoDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de doação que estão armazenada no banco de dados.
        public void Excluir(int _id)
        {
            DoacaoDAL doacaoDAL = new DoacaoDAL();
            doacaoDAL.Excluir(_id);
        }
        //Método de buscar cadastros de doações por data inicial e data final que estão armazenados no banco de dados.
        public DataTable BuscarPorData(DateTime fromDate, DateTime toDate)
        {
            DoacaoDAL doacaoDAL = new DoacaoDAL();
            return doacaoDAL.BuscarPorData(fromDate, toDate);
        }
    }
}
