using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class SupplierBLL
    {
        public Supplier Inserir(Supplier _supplier)
        {
            if (_supplier.CompanyName == "")
                throw new Exception("Nome do fornecedor é obrigatório");
            if (_supplier.ContactName == "")
                throw new Exception("O contado do fornecedor é obrigatório");
            if (_supplier.Phone == "")
                throw new Exception("O telefone do fornecedor é obrigatório");

            SupplierDAL supplierDAL = new SupplierDAL();
            return supplierDAL.Inserir(_supplier);
        }
        public Supplier Alterar(Supplier _supplier)
        {
            SupplierDAL supplierDAL = new SupplierDAL();
            return supplierDAL.Alterar(_supplier);
        }
        public DataTable Buscar(string _filtro)
        {
            SupplierDAL supplierDAL = new SupplierDAL();
            return supplierDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            SupplierDAL supplierDAL = new SupplierDAL();
            supplierDAL.Excluir(_id);
        }
    }
}
