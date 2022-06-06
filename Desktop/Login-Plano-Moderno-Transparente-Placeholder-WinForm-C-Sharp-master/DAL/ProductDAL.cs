using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductDAL
    {
        public Product Inserir(Product _product)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirProduct";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _product.Id
                };
                cmd.Parameters.Add(pid);

                SqlParameter pproductName = new SqlParameter("@ProductName", SqlDbType.NVarChar)
                {
                    Value = _product.ProductName
                };
                cmd.Parameters.Add(pproductName);

                SqlParameter psupplierId = new SqlParameter("@SupplierId", SqlDbType.Int)
                {
                    Value = _product.SupplierId
                };
                cmd.Parameters.Add(psupplierId);

                SqlParameter punitPrice = new SqlParameter("@UnitPrice", SqlDbType.Decimal)
                {
                    Value = _product.UnitPrice
                };
                cmd.Parameters.Add(punitPrice);

                SqlParameter ppackage = new SqlParameter("@Package", SqlDbType.NVarChar)
                {
                    Value = _product.Package
                };
                cmd.Parameters.Add(ppackage);

                SqlParameter pstock = new SqlParameter("@Stock", SqlDbType.Int)
                {
                    Value = _product.Stock
                };
                cmd.Parameters.Add(pstock);

                SqlParameter pisDiscontinued = new SqlParameter("@IsDiscontinued", SqlDbType.Bit)
                {
                    Value = _product.IsDiscontinued
                };
                cmd.Parameters.Add(pisDiscontinued);

                cn.Open();
                _product.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _product;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Product Alterar(Product _product)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarProduct";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _product.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pproductName = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                pproductName.Value = _product.ProductName;
                cmd.Parameters.Add(pproductName);

                SqlParameter psupplierId = new SqlParameter("@SupplierId", SqlDbType.Int);
                psupplierId.Value = _product.SupplierId;
                cmd.Parameters.Add(psupplierId);

                SqlParameter punitPrice = new SqlParameter("@UnitPrice", SqlDbType.Decimal);
                punitPrice.Value = _product.UnitPrice;
                cmd.Parameters.Add(punitPrice);

                SqlParameter ppackage = new SqlParameter("@Package", SqlDbType.NVarChar);
                ppackage.Value = _product.Package;
                cmd.Parameters.Add(ppackage);

                SqlParameter pstock = new SqlParameter("@Stock", SqlDbType.Int);
                pstock.Value = _product.Stock;
                cmd.Parameters.Add(pstock);

                SqlParameter pisDiscontinued = new SqlParameter("@IsDiscontinued", SqlDbType.Bit);
                pisDiscontinued.Value = _product.IsDiscontinued;
                cmd.Parameters.Add(pisDiscontinued);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _product;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarProduct";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@Filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirProduct";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o produto: " + _id.ToString());

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
