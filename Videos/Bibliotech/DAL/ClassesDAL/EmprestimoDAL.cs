using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class EmprestimoDAL
    {
        //Método de inserir empréstimo que executa as requisições de cadastro de empréstimo ao banco de dados.
        public Emprestimo Inserir(Emprestimo _emprestimo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_EMPRESTIMO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _emprestimo.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CODIGO_LIVRO", SqlDbType.Int)
                {
                    Value = _emprestimo.CODIGO_LIVRO
                };
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar)
                {
                    Value = _emprestimo.TOMBO
                };
                cmd.Parameters.Add(ptombo);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar)
                {
                    Value = _emprestimo.ISBN
                };
                cmd.Parameters.Add(pisbn);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar)
                {
                    Value = _emprestimo.VOLUME
                };
                cmd.Parameters.Add(pvolume);

                SqlParameter pcodigoLeitor = new SqlParameter("@CODIGO_LEITOR", SqlDbType.Int)
                {
                    Value = _emprestimo.CODIGO_LEITOR
                };
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter penderecoLeitor = new SqlParameter("@ENDERECO_LEITOR", SqlDbType.VarChar)
                {
                    Value = _emprestimo.ENDERECO_LEITOR
                };
                cmd.Parameters.Add(penderecoLeitor);

                SqlParameter ptelefoneLeitor = new SqlParameter("@TELEFONE_LEITOR", SqlDbType.VarChar)
                {
                    Value = _emprestimo.TELEFONE_LEITOR
                };
                cmd.Parameters.Add(ptelefoneLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Int)
                {
                    Value = _emprestimo.CODIGO_USUARIO
                };
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter penderecoUsuario = new SqlParameter("@ENDERECO_USUARIO", SqlDbType.VarChar)
                {
                    Value = _emprestimo.ENDERECO_USUARIO
                };
                cmd.Parameters.Add(penderecoUsuario);

                SqlParameter ptelefoneUsuario = new SqlParameter("@TELEFONE_USUARIO", SqlDbType.VarChar)
                {
                    Value = _emprestimo.TELEFONE_USUARIO
                };
                cmd.Parameters.Add(ptelefoneUsuario);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int)
                {
                    Value = _emprestimo.EXEMPLAR
                };
                cmd.Parameters.Add(pexemplar);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DATA_HORA_EMPRESTIMO", SqlDbType.Date)
                {
                    Value = _emprestimo.DATA_HORA_EMPRESTIMO
                };
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DATA_HORA_DEVOLUCAO", SqlDbType.DateTime)
                {
                    Value = _emprestimo.DATA_HORA_DEVOLUCAO
                };
                cmd.Parameters.Add(pdataHoraDevolucao);

                SqlParameter pstatus = new SqlParameter("@STATUS", SqlDbType.VarChar)
                {
                    Value = _emprestimo.STATUS
                };
                cmd.Parameters.Add(pstatus);

                cn.Open();
                _emprestimo.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _emprestimo;
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
        //Método de alterar empréstimo que executa as requisições de alteração de informações do empréstimo ao banco de dados.
        public Emprestimo Alterar(Emprestimo _emprestimo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_EMPRESTIMO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _emprestimo.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CODIGO_LIVRO", SqlDbType.Int);
                pcodigoLivro.Value = _emprestimo.CODIGO_LIVRO;
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar);
                ptombo.Value = _emprestimo.TOMBO;
                cmd.Parameters.Add(ptombo);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar);
                pisbn.Value = _emprestimo.ISBN;
                cmd.Parameters.Add(pisbn);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar);
                pvolume.Value = _emprestimo.VOLUME;
                cmd.Parameters.Add(pvolume);

                SqlParameter pcodigoLeitor = new SqlParameter("@CODIGO_LEITOR", SqlDbType.Int);
                pcodigoLeitor.Value = _emprestimo.CODIGO_LEITOR;
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter penderecoLeitor = new SqlParameter("@ENDERECO_LEITOR", SqlDbType.VarChar);
                penderecoLeitor.Value = _emprestimo.ENDERECO_LEITOR;
                cmd.Parameters.Add(penderecoLeitor);

                SqlParameter ptelefoneLeitor = new SqlParameter("@TELEFONE_LEITOR", SqlDbType.VarChar);
                ptelefoneLeitor.Value = _emprestimo.TELEFONE_LEITOR;
                cmd.Parameters.Add(ptelefoneLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Int);
                pcodigoUsuario.Value = _emprestimo.CODIGO_USUARIO;
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter penderecoUsuario = new SqlParameter("@ENDERECO_USUARIO", SqlDbType.VarChar);
                penderecoUsuario.Value = _emprestimo.ENDERECO_USUARIO;
                cmd.Parameters.Add(penderecoUsuario);

                SqlParameter ptelefoneUsuario = new SqlParameter("@TELEFONE_USUARIO", SqlDbType.VarChar);
                ptelefoneUsuario.Value = _emprestimo.TELEFONE_USUARIO;
                cmd.Parameters.Add(ptelefoneUsuario);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int);
                pexemplar.Value = _emprestimo.EXEMPLAR;
                cmd.Parameters.Add(pexemplar);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DATA_HORA_EMPRESTIMO", SqlDbType.Date);
                pdataHoraEmprestimo.Value = _emprestimo.DATA_HORA_EMPRESTIMO;
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DATA_HORA_DEVOLUCAO", SqlDbType.DateTime);
                pdataHoraDevolucao.Value = _emprestimo.DATA_HORA_DEVOLUCAO;
                cmd.Parameters.Add(pdataHoraDevolucao);

                SqlParameter pstatus = new SqlParameter("@STATUS", SqlDbType.VarChar);
                pstatus.Value = _emprestimo.STATUS;
                cmd.Parameters.Add(pstatus);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _emprestimo;

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
        //Método de buscar empréstimo que executa as requisições de consulta de cadastros de empréstimos ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO";
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
        //Método de excluir empréstimo que executa as requisições de exlusão de cadastro de empréstimo ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_EMPRESTIMO";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o emprestimo: " + _codigo.ToString());

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
        //Método de buscar empréstimo por leitor que executa as requisições de consulta de cadastros de empréstimos ao banco de dados.
        public DataTable BuscarEmprestimoPorLeitor(int _codigo)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_POR_LEITOR";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                da.SelectCommand.Parameters.Add(pcodigo);

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
        //Método de buscar empréstimo para devolução que executa as requisições de consulta de cadastros de empréstimos ao banco de dados.
        public DataTable BuscarEmprestimoDevolucao(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_DEVOLUCAO";
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
        //Método de buscar empréstimos pendentes que executa as requisições de consulta de cadastros de empréstimos pendentes ao banco de dados.
        public DataTable BuscarEmprestimoPendente(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_PENDENTE";
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
        //Método de buscar empréstimos devolvidos que executa as requisições de consulta de cadastros de empréstimos devolvidos ao banco de dados.
        public DataTable BuscarEmprestimoDevolvido(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_DEVOLVIDO";
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
        //Método de buscar empréstimos atrasados que executa as requisições de consulta de cadastros de empréstimos atrasados ao banco de dados.
        public DataTable BuscarEmprestimoAtrasado(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_ATRASADO";
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
        //Método de buscar empréstimos por data inicial e data final, que executa as requisições de consulta de cadastros de empréstimos ao banco de dados.
        public DataTable BuscarEmprestimoPorData(DateTime fromDate, DateTime toDate)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_EMPRESTIMO_POR_DATA";
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
