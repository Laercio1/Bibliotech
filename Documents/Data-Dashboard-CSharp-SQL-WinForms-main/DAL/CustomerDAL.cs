using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerDAL
    {
        public Customer Inserir(Customer _customer)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirCustomer";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _customer.Id
                };
                cmd.Parameters.Add(pid);

                SqlParameter pfirstName = new SqlParameter("@FirstName", SqlDbType.NVarChar)
                {
                    Value = _customer.FirstName
                };
                cmd.Parameters.Add(pfirstName);

                SqlParameter plastName = new SqlParameter("@LastName", SqlDbType.NVarChar)
                {
                    Value = _customer.LastName
                };
                cmd.Parameters.Add(plastName);

                SqlParameter pcity = new SqlParameter("@City", SqlDbType.NVarChar)
                {
                    Value = _customer.City
                };
                cmd.Parameters.Add(pcity);

                SqlParameter pcountry = new SqlParameter("@Country", SqlDbType.NVarChar)
                {
                    Value = _customer.Country
                };
                cmd.Parameters.Add(pcountry);

                SqlParameter pphone = new SqlParameter("@Phone", SqlDbType.NVarChar)
                {
                    Value = _customer.Phone
                };
                cmd.Parameters.Add(pphone);

                cn.Open();
                _customer.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _customer;
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
        public Customer Alterar(Customer _customer)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarCustomer";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _customer.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pfirstName = new SqlParameter("@FirstName", SqlDbType.NVarChar);
                pfirstName.Value = _customer.FirstName;
                cmd.Parameters.Add(pfirstName);

                SqlParameter plastName = new SqlParameter("@LastName", SqlDbType.NVarChar);
                plastName.Value = _customer.LastName;
                cmd.Parameters.Add(plastName);

                SqlParameter pcity = new SqlParameter("@City", SqlDbType.NVarChar);
                pcity.Value = _customer.City;
                cmd.Parameters.Add(pcity);

                SqlParameter pcountry = new SqlParameter("@Country", SqlDbType.NVarChar);
                pcountry.Value = _customer.Country;
                cmd.Parameters.Add(pcountry);

                SqlParameter pphone = new SqlParameter("@Phone", SqlDbType.NVarChar);
                pphone.Value = _customer.Phone;
                cmd.Parameters.Add(pphone);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _customer;
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
                da.SelectCommand.CommandText = "SP_BuscarCustomer";
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
                cmd.CommandText = "SP_ExcluirCustomer";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o cliente: " + _id.ToString());

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
