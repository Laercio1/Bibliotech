using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SupplierDAL
    {
        public Supplier Inserir(Supplier _supplier)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirSupplier";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _supplier.Id
                };
                cmd.Parameters.Add(pid);

                SqlParameter pcompanyName = new SqlParameter("@CompanyName", SqlDbType.NVarChar)
                {
                    Value = _supplier.CompanyName
                };
                cmd.Parameters.Add(pcompanyName);

                SqlParameter pcontactName = new SqlParameter("@ContactName", SqlDbType.NVarChar)
                {
                    Value = _supplier.ContactName
                };
                cmd.Parameters.Add(pcontactName);

                SqlParameter pcontactTitle = new SqlParameter("@ContactTitle", SqlDbType.NVarChar)
                {
                    Value = _supplier.ContactTitle
                };
                cmd.Parameters.Add(pcontactTitle);

                SqlParameter pcity = new SqlParameter("@City", SqlDbType.NVarChar)
                {
                    Value = _supplier.City
                };
                cmd.Parameters.Add(pcity);

                SqlParameter pcountry = new SqlParameter("@Country", SqlDbType.NVarChar)
                {
                    Value = _supplier.Country
                };
                cmd.Parameters.Add(pcountry);

                SqlParameter pphone = new SqlParameter("@Phone", SqlDbType.NVarChar)
                {
                    Value = _supplier.Phone
                };
                cmd.Parameters.Add(pphone);

                SqlParameter pfax = new SqlParameter("@Fax", SqlDbType.NVarChar)
                {
                    Value = _supplier.Fax
                };
                cmd.Parameters.Add(pfax);

                cn.Open();
                _supplier.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _supplier;
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
        public Supplier Alterar(Supplier _supplier)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarSupplier";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _supplier.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pcompanyName = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
                pcompanyName.Value = _supplier.CompanyName;
                cmd.Parameters.Add(pcompanyName);

                SqlParameter pcontactName = new SqlParameter("@ContactName", SqlDbType.NVarChar);
                pcontactName.Value = _supplier.ContactName;
                cmd.Parameters.Add(pcontactName);

                SqlParameter pcontactTitle = new SqlParameter("@ContactTitle", SqlDbType.NVarChar);
                pcontactTitle.Value = _supplier.ContactTitle;
                cmd.Parameters.Add(pcontactTitle);

                SqlParameter pcity = new SqlParameter("@City", SqlDbType.NVarChar);
                pcity.Value = _supplier.City;
                cmd.Parameters.Add(pcity);

                SqlParameter pcountry = new SqlParameter("@Country", SqlDbType.NVarChar);
                pcountry.Value = _supplier.Country;
                cmd.Parameters.Add(pcountry);

                SqlParameter pphone = new SqlParameter("@Phone", SqlDbType.NVarChar);
                pphone.Value = _supplier.Phone;
                cmd.Parameters.Add(pphone);

                SqlParameter pfax = new SqlParameter("@Fax", SqlDbType.NVarChar);
                pfax.Value = _supplier.Fax;
                cmd.Parameters.Add(pfax);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _supplier;
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
                da.SelectCommand.CommandText = "SP_BuscarSupplier";
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
                cmd.CommandText = "SP_ExcluirSupplier";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o fornecedor: " + _id.ToString());

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
