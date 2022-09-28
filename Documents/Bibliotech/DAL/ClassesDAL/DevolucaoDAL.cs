using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class DevolucaoDAL
    {
        //Método de inserir devolução que executa as requisições de cadastro de devolução ao banco de dados.
        public Devolucao Inserir(Devolucao _devolucao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_DEVOLUCAO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _devolucao.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoEmprestimo = new SqlParameter("@CODIGO_EMPRESTIMO", SqlDbType.Int)
                {
                    Value = _devolucao.CODIGO_EMPRESTIMO
                };
                cmd.Parameters.Add(pcodigoEmprestimo);

                SqlParameter pcodigoLivro = new SqlParameter("@CODIGO_LIVRO", SqlDbType.Int)
                {
                    Value = _devolucao.CODIGO_LIVRO
                };
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar)
                {
                    Value = _devolucao.TOMBO
                };
                cmd.Parameters.Add(ptombo);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar)
                {
                    Value = _devolucao.ISBN
                };
                cmd.Parameters.Add(pisbn);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar)
                {
                    Value = _devolucao.VOLUME
                };
                cmd.Parameters.Add(pvolume);

                SqlParameter pcodigoLeitor = new SqlParameter("@CODIGO_LEITOR", SqlDbType.Int)
                {
                    Value = _devolucao.CODIGO_LEITOR
                };
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter penderecoLeitor = new SqlParameter("@ENDERECO_LEITOR", SqlDbType.VarChar)
                {
                    Value = _devolucao.ENDERECO_LEITOR
                };
                cmd.Parameters.Add(penderecoLeitor);

                SqlParameter ptelefoneLeitor = new SqlParameter("@TELEFONE_LEITOR", SqlDbType.VarChar)
                {
                    Value = _devolucao.TELEFONE_LEITOR
                };
                cmd.Parameters.Add(ptelefoneLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Int)
                {
                    Value = _devolucao.CODIGO_USUARIO
                };
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter penderecoUsuario = new SqlParameter("@ENDERECO_USUARIO", SqlDbType.VarChar)
                {
                    Value = _devolucao.ENDERECO_USUARIO
                };
                cmd.Parameters.Add(penderecoUsuario);

                SqlParameter ptelefoneUsuario = new SqlParameter("@TELEFONE_USUARIO", SqlDbType.VarChar)
                {
                    Value = _devolucao.TELEFONE_USUARIO
                };
                cmd.Parameters.Add(ptelefoneUsuario);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DATA_HORA_EMPRESTIMO", SqlDbType.DateTime)
                {
                    Value = _devolucao.DATA_HORA_EMPRESTIMO
                };
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DATA_HORA_DEVOLUCAO", SqlDbType.Date)
                {
                    Value = _devolucao.DATA_HORA_DEVOLUCAO
                };
                cmd.Parameters.Add(pdataHoraDevolucao);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int)
                {
                    Value = _devolucao.EXEMPLAR
                };
                cmd.Parameters.Add(pexemplar);

                cn.Open();
                _devolucao.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _devolucao;
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
        //Método de alterar devolução que executa as requisições de alteração de informações da devolução ao banco de dados.
        public Devolucao Alterar(Devolucao _devolucao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_DEVOLUCAO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _devolucao.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoEmprestimo = new SqlParameter("@CODIGO_EMPRESTIMO", SqlDbType.Int);
                pcodigoEmprestimo.Value = _devolucao.CODIGO_EMPRESTIMO;
                cmd.Parameters.Add(pcodigoEmprestimo);

                SqlParameter pcodigoLivro = new SqlParameter("@CODIGO_LIVRO", SqlDbType.Int);
                pcodigoLivro.Value = _devolucao.CODIGO_LIVRO;
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar);
                ptombo.Value = _devolucao.TOMBO;
                cmd.Parameters.Add(ptombo);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar);
                pisbn.Value = _devolucao.ISBN;
                cmd.Parameters.Add(pisbn);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar);
                pvolume.Value = _devolucao.VOLUME;
                cmd.Parameters.Add(pvolume);

                SqlParameter pcodigoLeitor = new SqlParameter("@CODIGO_LEITOR", SqlDbType.Int);
                pcodigoLeitor.Value = _devolucao.CODIGO_LEITOR;
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter penderecoLeitor = new SqlParameter("@ENDERECO_LEITOR", SqlDbType.VarChar);
                penderecoLeitor.Value = _devolucao.ENDERECO_LEITOR;
                cmd.Parameters.Add(penderecoLeitor);

                SqlParameter ptelefoneLeitor = new SqlParameter("@TELEFONE_LEITOR", SqlDbType.VarChar);
                ptelefoneLeitor.Value = _devolucao.TELEFONE_LEITOR;
                cmd.Parameters.Add(ptelefoneLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Int);
                pcodigoUsuario.Value = _devolucao.CODIGO_USUARIO;
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter penderecoUsuario = new SqlParameter("@ENDERECO_USUARIO", SqlDbType.VarChar);
                penderecoUsuario.Value = _devolucao.ENDERECO_USUARIO;
                cmd.Parameters.Add(penderecoUsuario);

                SqlParameter ptelefoneUsuario = new SqlParameter("@TELEFONE_USUARIO", SqlDbType.VarChar);
                ptelefoneUsuario.Value = _devolucao.TELEFONE_USUARIO;
                cmd.Parameters.Add(ptelefoneUsuario);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DATA_HORA_EMPRESTIMO", SqlDbType.DateTime);
                pdataHoraEmprestimo.Value = _devolucao.DATA_HORA_EMPRESTIMO;
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DATA_HORA_DEVOLUCAO", SqlDbType.Date);
                pdataHoraDevolucao.Value = _devolucao.DATA_HORA_DEVOLUCAO;
                cmd.Parameters.Add(pdataHoraDevolucao);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int);
                pexemplar.Value = _devolucao.EXEMPLAR;
                cmd.Parameters.Add(pexemplar);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _devolucao;
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
        //Método de buscar devolução que executa as requisições de consulta de cadastros de devoluções ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_DEVOLUCAO";
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
        //Método de buscar devolução que executa as requisições de consulta de cadastros de devoluções ao banco de dados.
        public DataTable BuscarPorCodigo(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_DEVOLUCAO_POR_CODIGO";
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
        //Método de excluir devolução que executa as requisições de exlusão de cadastro de devolução ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_DEVOLUCAO";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a devolucao: " + _codigo.ToString());

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
        //Método de buscar devolução por data inicial e data final, que executa as requisições de consulta de cadastros de devoluções ao banco de dados.
        public DataTable BuscarDevolucaoPorData(DateTime fromDate, DateTime toDate)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_DEVOLUCAO_POR_DATA";
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
