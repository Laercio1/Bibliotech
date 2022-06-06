using Model;
using DAL;
using System.Data;
using System;

namespace BLL
{
    public class CustomerBLL
    {
        public Customer Inserir(Customer _customer)
        {
            if (_customer.FirstName == "")
                throw new Exception("Primeiro Nome é obrigatório");
            if (_customer.LastName == "")
                throw new Exception("Último Nome é obrigatório");

            CustomerDAL customerDAL = new CustomerDAL();
            return customerDAL.Inserir(_customer);
        }
        public Customer Alterar(Customer _customer)
        {
            CustomerDAL customerDAL = new CustomerDAL();
            return customerDAL.Alterar(_customer);
        }
        public DataTable Buscar(string _filtro)
        {
            CustomerDAL customerDAL = new CustomerDAL();
            return customerDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            CustomerDAL customerDAL = new CustomerDAL();
            customerDAL.Excluir(_id);
        }
    }
}
