using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class OrderBLL
    {
        public Order Inserir(Order _order)
        {
            /*            if (_order.OrderNumber == "")
                            throw new Exception("Por favor, informar o número da venda");*/
            if (_order.CustomerId == 0)
                throw new Exception("Por favor, Informar o cliente");
            if (_order.TotalAmount == 0)
                throw new Exception("Por favor, informar o valor total");
            OrderDAL orderDAL = new OrderDAL();
            return orderDAL.Inserir(_order);
        }
/*        public Order Alterar(Order _order)
        {
            OrderDAL orderDAL = new OrderDAL();
            return orderDAL.Alterar(_order);
        }*/
        public DataTable Buscar(string _filtro)
        {
            OrderDAL orderDAL = new OrderDAL();
            return orderDAL.Buscar(_filtro);
        }
/*        public void Excluir(int _id)
        {
            OrderDAL orderDAL = new OrderDAL();
            return orderDAL.Excluir(_id);
        }*/
    }
}
