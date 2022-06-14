using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TarefaDAL: Conexao
    {
        public Tarefa Inserir(Tarefa _tarefa)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexaoo.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirTarefa";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _tarefa.Id
                };
                cmd.Parameters.Add(pid);

                SqlParameter pidUsuario = new SqlParameter("@IdUsuario", SqlDbType.Int)
                {
                    Value = _tarefa.IdUsuario
                };
                cmd.Parameters.Add(pidUsuario);

                SqlParameter pdescricao = new SqlParameter("@Descricao", SqlDbType.NVarChar)
                {
                    Value = _tarefa.Descricao
                };
                cmd.Parameters.Add(pdescricao);

                SqlParameter pestatus = new SqlParameter("@Estatus", SqlDbType.NVarChar)
                {
                    Value = _tarefa.Estatus
                };
                cmd.Parameters.Add(pestatus);

                SqlParameter pimagem = new SqlParameter("@Imagem", SqlDbType.NVarChar)
                {
                    Value = _tarefa.Imagem
                };
                cmd.Parameters.Add(pimagem);

                cn.Open();
                _tarefa.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _tarefa;
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
        public Tarefa Alterar(Tarefa _tarefa)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexaoo.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarTarefa";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _tarefa.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pidUsuario = new SqlParameter("@IdUsuario", SqlDbType.Int);
                pidUsuario.Value = _tarefa.IdUsuario;
                cmd.Parameters.Add(pidUsuario);

                SqlParameter pdescricao = new SqlParameter("@Descricao", SqlDbType.NVarChar);
                pdescricao.Value = _tarefa.Descricao;
                cmd.Parameters.Add(pdescricao);

                SqlParameter pestatus = new SqlParameter("@Estatus", SqlDbType.NVarChar);
                pestatus.Value = _tarefa.Estatus;
                cmd.Parameters.Add(pestatus);

                SqlParameter pimagem = new SqlParameter("@Imagem", SqlDbType.NVarChar);
                pestatus.Value = _tarefa.Imagem;
                cmd.Parameters.Add(pimagem);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _tarefa;
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
                cn.ConnectionString = Conexaoo.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarTarefa";
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
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexaoo.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirTarefa";
                SqlParameter pcodigo = new SqlParameter("@Id", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a tarefa: " + _codigo.ToString());

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
