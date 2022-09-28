using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ClassesDAL
{
    public class LeitorDAL
    {
        //propierts public 
        public string vqueryTipoLeitor = @"SELECT CODIGO, DESCRICAO FROM TIPO_LEITOR ORDER BY CODIGO";
        //Método de inserir leitor que executa as requisições de cadastro de leitor ao banco de dados.
        public Leitor Inserir(Leitor _leitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_LEITOR";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _leitor.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoTipoLeitor = new SqlParameter("@CODIGO_TIPO_LEITOR", SqlDbType.Int)
                {
                    Value = _leitor.CODIGO_TIPO_LEITOR
                };
                cmd.Parameters.Add(pcodigoTipoLeitor);

                SqlParameter pnome = new SqlParameter("@NOME_LEITOR", SqlDbType.VarChar)
                {
                    Value = _leitor.NOME_LEITOR
                };
                cmd.Parameters.Add(pnome);

                SqlParameter psexo = new SqlParameter("@SEXO", SqlDbType.VarChar)
                {
                    Value = _leitor.SEXO
                };
                cmd.Parameters.Add(psexo);

                SqlParameter pendereco = new SqlParameter("@ENDERECO", SqlDbType.VarChar)
                {
                    Value = _leitor.ENDERECO
                };
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@BAIRRO", SqlDbType.VarChar)
                {
                    Value = _leitor.BAIRRO
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CODIGO_CIDADE", SqlDbType.Int)
                {
                    Value = _leitor.CODIGO_CIDADE
                };
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CODIGO_ESTADO", SqlDbType.Int)
                {
                    Value = _leitor.CODIGO_ESTADO
                };
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar)
                {
                    Value = _leitor.CEP
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@CPF", SqlDbType.VarChar)
                {
                    Value = _leitor.CPF
                };
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar)
                {
                    Value = _leitor.RG
                };
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@TELEFONE", SqlDbType.VarChar)
                {
                    Value = _leitor.TELEFONE
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@EMAIL", SqlDbType.VarChar)
                {
                    Value = _leitor.EMAIL
                };
                cmd.Parameters.Add(pemail);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.DateTime)
                {
                    Value = _leitor.DATA_CADASTRO
                };
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pdataNascimento = new SqlParameter("@DATA_NASCIMENTO", SqlDbType.DateTime)
                {
                    Value = _leitor.DATA_NASCIMENTO
                };
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                _leitor.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _leitor;

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
        //Método de alterar leitor que executa as requisições de alteração de informações do leitor ao banco de dados.
        public Leitor Alterar(Leitor _leitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_LEITOR";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _leitor.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoTipoLeitor = new SqlParameter("@CODIGO_TIPO_LEITOR", SqlDbType.Int);
                pcodigoTipoLeitor.Value = _leitor.CODIGO_TIPO_LEITOR;
                cmd.Parameters.Add(pcodigoTipoLeitor);

                SqlParameter pnome = new SqlParameter("@NOME_LEITOR", SqlDbType.VarChar);
                pnome.Value = _leitor.NOME_LEITOR;
                cmd.Parameters.Add(pnome);

                SqlParameter psexo = new SqlParameter("@SEXO", SqlDbType.VarChar);
                psexo.Value = _leitor.SEXO;
                cmd.Parameters.Add(psexo);

                SqlParameter pendereco = new SqlParameter("@ENDERECO", SqlDbType.VarChar);
                pendereco.Value = _leitor.ENDERECO;
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@BAIRRO", SqlDbType.VarChar);
                pbairro.Value = _leitor.BAIRRO;
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CODIGO_CIDADE", SqlDbType.Int);
                pcodigoCidade.Value = _leitor.CODIGO_CIDADE;
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CODIGO_ESTADO", SqlDbType.Int);
                pcodigoEstado.Value = _leitor.CODIGO_ESTADO;
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar);
                pcep.Value = _leitor.CEP;
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@CPF", SqlDbType.VarChar);
                pcpf.Value = _leitor.CPF;
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar);
                prg.Value = _leitor.RG;
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@TELEFONE", SqlDbType.VarChar);
                ptelefone.Value = _leitor.TELEFONE;
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@EMAIL", SqlDbType.VarChar);
                pemail.Value = _leitor.EMAIL;
                cmd.Parameters.Add(pemail);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.DateTime);
                pdataCadastro.Value = _leitor.DATA_CADASTRO;
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pdataNascimento = new SqlParameter("@DATA_NASCIMENTO", SqlDbType.DateTime);
                pdataNascimento.Value = _leitor.DATA_NASCIMENTO;
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _leitor;
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
        //Método de buscar leitor que executa as requisições de consulta de cadastros de leitores ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LEITOR";
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
        //Método de excluir leitor que executa as requisições de exlusão de cadastro de leitor ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_LEITOR";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o leitor: " + _codigo.ToString());
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
        //Método de buscar leitores do tipo aluno que executa as requisições de consulta de cadastros de leitores alunos ao banco de dados.
        public DataTable BuscarLeitorAluno(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LEITOR_ALUNO";
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
        //Método de buscar leitores do tipo instrutor que executa as requisições de consulta de cadastros de leitores instrutores ao banco de dados.
        public DataTable BuscarLeitorInstrutor(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LEITOR_INSTRUTOR";
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
        //Método de buscar leitores do tipo colaborador que executa as requisições de consulta de cadastros de leitores colaboradores ao banco de dados.
        public DataTable BuscarLeitorColaborador(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LEITOR_COLABORADOR";
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
        //Método de buscar leitores do tipo outro que executa as requisições de consulta de cadastros de leitores do tipo outro ao banco de dados.
        public DataTable BuscarLeitorOutro(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LEITOR_OUTRO";
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
    }
}
