using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class ProductBLL
    {
        public Product Inserir(Product _product)
        {
            if (_product.ProductName == "")
                throw new Exception("Nome do produto é obrigatório");
            if (_product.SupplierId == 0)
                throw new Exception("Fornecedor é obrigatório");
            if (_product.UnitPrice == 0)
                throw new Exception("Preço Unitário é obrigatório");
            if (_product.Stock == 0)
                throw new Exception("Stock é obrigatório");

            ProductDAL productDAL = new ProductDAL();
            return productDAL.Inserir(_product);
        }
        public Product Alterar(Product _product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Alterar(_product);
        }
        public DataTable Buscar(string _filtro)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.Excluir(_id);
        }
    }
}
