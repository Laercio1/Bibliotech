using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassesBLL
{
    public class CompraBLL
    {
        //Método de inserir compra que armazena dados do cadastro de compra no banco de dados.
        public Compra Inserir(Compra _compra)
        {
            if (_compra.DESCRICAO == "")
                throw new Exception("Por favor, informe a descrição!");
            if (_compra.QUANTIDADE == 0)
                throw new Exception("Por favor, informe a quantidade!");

            CompraDAL compraDAL = new CompraDAL();
            return compraDAL.Inserir(_compra);
        }
        //Método de alterar compra que armazena dados de alteração de informações do compra no banco de dados.
        public Compra Alterar(Compra _compra)
        {
            CompraDAL compraDAL = new CompraDAL();
            return compraDAL.Alterar(_compra);
        }
        //Método de buscar cadastros de compras que estão cadastradas e armazenadas no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            CompraDAL compraDAL = new CompraDAL();
            return compraDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de compra que estão armazenada no banco de dados.
        public void Excluir(int _id)
        {
            CompraDAL compraDAL = new CompraDAL();
            compraDAL.Excluir(_id);
        }
        //Método de buscar cadastros de compras por data inicial e data final que estão armazenados no banco de dados.
        public DataTable BuscarPorData(DateTime fromDate, DateTime toDate)
        {
            CompraDAL compraDAL = new CompraDAL();
            return compraDAL.BuscarPorData(fromDate, toDate);
        }
    }
}
