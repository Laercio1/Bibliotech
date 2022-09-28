using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class CompraDAL
    {
        //Método de inserir compra que executa as requisições de cadastro de compra ao banco de dados.
        public Compra Inserir(Compra _compra)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_COMPRA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _compra.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO", SqlDbType.VarChar)
                {
                    Value = _compra.DESCRICAO
                };
                cmd.Parameters.Add(pdescricao);

                SqlParameter pquantidade = new SqlParameter("@QUANTIDADE", SqlDbType.Int)
                {
                    Value = _compra.QUANTIDADE
                };
                cmd.Parameters.Add(pquantidade);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.Date)
                {
                    Value = _compra.DATA_CADASTRO
                };
                cmd.Parameters.Add(pdataCadastro);

                cn.Open();
                _compra.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _compra;
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
        //Método de alterar compra que executa as requisições de alteração de informações do compra ao banco de dados.
        public Compra Alterar(Compra _compra)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_COMPRA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _compra.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO", SqlDbType.VarChar);
                pdescricao.Value = _compra.DESCRICAO;
                cmd.Parameters.Add(pdescricao);

                SqlParameter pquantidade = new SqlParameter("@QUANTIDADE", SqlDbType.Int);
                pquantidade.Value = _compra.QUANTIDADE;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.Date);
                pdataCadastro.Value = _compra.DATA_CADASTRO;
                cmd.Parameters.Add(pdataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _compra;
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
        //Método de buscar compra que executa as requisições de consulta de cadastros de compras ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_COMPRA";
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
        //Método de excluir compra que executa as requisições de exlusão de cadastro de compra ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_COMPRA";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a compra: " + _codigo.ToString());

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
        //Método de buscar compra por data inicial e data final, que executa as requisições de consulta de cadastros de compras ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_POR_DATA";
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
