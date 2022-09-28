using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class PermutaDAL
    {
        //Método de inserir permuta que executa as requisições de cadastro de permuta ao banco de dados.
        public Permuta Inserir(Permuta _permuta)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_PERMUTA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _permuta.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO", SqlDbType.VarChar)
                {
                    Value = _permuta.DESCRICAO
                };
                cmd.Parameters.Add(pdescricao);

                SqlParameter pquantidade = new SqlParameter("@QUANTIDADE", SqlDbType.Int)
                {
                    Value = _permuta.QUANTIDADE
                };
                cmd.Parameters.Add(pquantidade);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.Date)
                {
                    Value = _permuta.DATA_CADASTRO
                };
                cmd.Parameters.Add(pdataCadastro);

                cn.Open();
                _permuta.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _permuta;
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
        //Método de alterar permuta que executa as requisições de alteração de informações do permuta ao banco de dados.
        public Permuta Alterar(Permuta _permuta)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_PERMUTA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _permuta.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO", SqlDbType.VarChar);
                pdescricao.Value = _permuta.DESCRICAO;
                cmd.Parameters.Add(pdescricao);

                SqlParameter pquantidade = new SqlParameter("@QUANTIDADE", SqlDbType.Int);
                pquantidade.Value = _permuta.QUANTIDADE;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.Date);
                pdataCadastro.Value = _permuta.DATA_CADASTRO;
                cmd.Parameters.Add(pdataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _permuta;
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
        //Método de buscar permuta que executa as requisições de consulta de cadastros de permutas ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_PERMUTA";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@FILTRO", SqlDbType.VarChar);
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
        //Método de excluir permuta que executa as requisições de exlusão de cadastro de permuta ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_PERMUTA";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a permuta: " + _codigo.ToString());

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
        //Método de buscar permuta por data inicial e data final, que executa as requisições de consulta de cadastros de permutas ao banco de dados.
        public DataTable BuscarPorData(DateTime fromDate, DateTime toDate)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_PERMUTA_POR_DATA";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pfromDate = new SqlParameter("@FROM_DATE", SqlDbType.DateTime);
                pfromDate.Value = fromDate;
                da.SelectCommand.Parameters.Add(pfromDate);

                SqlParameter ptoDate = new SqlParameter("@TO_DATE", SqlDbType.DateTime);
                ptoDate.Value = toDate;
                da.SelectCommand.Parameters.Add(ptoDate);

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
    }
}
