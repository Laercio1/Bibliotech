using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class CategoriaDAL
    {
        //Método de inserir categoria que executa as requisições de cadastro de categoria ao banco de dados.
        public Categoria Inserir(Categoria _categoria)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_CATEGORIA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _categoria.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO_CATEGORIA", SqlDbType.VarChar)
                {
                    Value = _categoria.DESCRICAO_CATEGORIA
                };
                cmd.Parameters.Add(pdescricao);

                cn.Open();
                _categoria.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _categoria;
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
        //Método de alterar categoria que executa as requisições de alteração de informações da categoria ao banco de dados.
        public Categoria Alterar(Categoria _categoria)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_CATEGORIA";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _categoria.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@DESCRICAO_CATEGORIA", SqlDbType.VarChar);
                pdescricao.Value = _categoria.DESCRICAO_CATEGORIA;
                cmd.Parameters.Add(pdescricao);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _categoria;
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
        //Método de buscar categoria que executa as requisições de consulta de cadastros de categorias ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_CATEGORIA";
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
        //Método de excluir categoria que executa as requisições de exlusão de cadastro de categoria ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_CATEGORIA";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a categoria: " + _codigo.ToString());

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
