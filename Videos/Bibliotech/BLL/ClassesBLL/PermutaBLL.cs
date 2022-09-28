using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class PermutaBLL
    {
        //Método de inserir permuta que armazena dados do cadastro de permuta no banco de dados.
        public Permuta Inserir(Permuta _permuta)
        {
            if (_permuta.DESCRICAO == "")
                throw new Exception("Por favor, informe a descrição!");
            if (_permuta.QUANTIDADE == 0)
                throw new Exception("Por favor, informe a quantidade!");

            PermutaDAL permutaDAL = new PermutaDAL();
            return permutaDAL.Inserir(_permuta);
        }
        //Método de alterar permuta que armazena dados de alteração de informações do permuta no banco de dados.
        public Permuta Alterar(Permuta _permuta)
        {
            PermutaDAL permutaDAL = new PermutaDAL();
            return permutaDAL.Alterar(_permuta);
        }
        //Método de buscar cadastros de permutas que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            PermutaDAL permutaDAL = new PermutaDAL();
            return permutaDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de permuta que estão armazenada no banco de dados.
        public void Excluir(int _id)
        {
            PermutaDAL permutaDAL = new PermutaDAL();
            permutaDAL.Excluir(_id);
        }
        //Método de buscar cadastros de permutas por data inicial e data final que estão armazenados no banco de dados.
        public DataTable BuscarPorData(DateTime fromDate, DateTime toDate)
        {
            PermutaDAL permutaDAL = new PermutaDAL();
            return permutaDAL.BuscarPorData(fromDate, toDate);
        }
    }
}
