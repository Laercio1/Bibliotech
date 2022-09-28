using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class UsuarioDAL : Conexao
    {
        //Método de inserir usuário que executa as requisições de cadastro de usuário ao banco de dados.
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_USUARIO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _usuario.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@NOME_USUARIO", SqlDbType.VarChar)
                {
                    Value = _usuario.NOME_USUARIO
                };
                cmd.Parameters.Add(pnome);

                SqlParameter psexo = new SqlParameter("@SEXO", SqlDbType.VarChar)
                {
                    Value = _usuario.SEXO
                };
                cmd.Parameters.Add(psexo);

                SqlParameter pendereco = new SqlParameter("@ENDERECO", SqlDbType.VarChar)
                {
                    Value = _usuario.ENDERECO
                };
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@BAIRRO", SqlDbType.VarChar)
                {
                    Value = _usuario.BAIRRO
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CODIGO_CIDADE", SqlDbType.Int)
                {
                    Value = _usuario.CODIGO_CIDADE
                };
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CODIGO_ESTADO", SqlDbType.Int)
                {
                    Value = _usuario.CODIGO_ESTADO
                };
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar)
                {
                    Value = _usuario.CEP
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@CPF", SqlDbType.VarChar)
                {
                    Value = _usuario.CPF
                };
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar)
                {
                    Value = _usuario.RG
                };
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@TELEFONE", SqlDbType.VarChar)
                {
                    Value = _usuario.TELEFONE
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@EMAIL", SqlDbType.VarChar)
                {
                    Value = _usuario.EMAIL
                };
                cmd.Parameters.Add(pemail);

                SqlParameter puserName = new SqlParameter("@USERNAME", SqlDbType.VarChar)
                {
                    Value = _usuario.USERNAME
                };
                cmd.Parameters.Add(puserName);

                SqlParameter psenha = new SqlParameter("@SENHA", SqlDbType.VarChar)
                {
                    Value = _usuario.SENHA
                };
                cmd.Parameters.Add(psenha);

                SqlParameter pdataNascimento = new SqlParameter("@DATA_NASCIMENTO", SqlDbType.DateTime)
                {
                    Value = _usuario.DATA_NASCIMENTO
                };

                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                _usuario.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
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
        //Método de alterar usuário que executa as requisições de alteração de informações do usuário ao banco de dados.
        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_USUARIO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _usuario.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@NOME_USUARIO", SqlDbType.VarChar);
                pnome.Value = _usuario.NOME_USUARIO;
                cmd.Parameters.Add(pnome);

                SqlParameter psexo = new SqlParameter("@SEXO", SqlDbType.VarChar);
                psexo.Value = _usuario.SEXO;
                cmd.Parameters.Add(psexo);

                SqlParameter pendereco = new SqlParameter("@ENDERECO", SqlDbType.VarChar);
                pendereco.Value = _usuario.ENDERECO;
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@BAIRRO", SqlDbType.VarChar);
                pbairro.Value = _usuario.BAIRRO;
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CODIGO_CIDADE", SqlDbType.Int);
                pcodigoCidade.Value = _usuario.CODIGO_CIDADE;
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CODIGO_ESTADO", SqlDbType.Int);
                pcodigoEstado.Value = _usuario.CODIGO_ESTADO;
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar);
                pcep.Value = _usuario.CEP;
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@CPF", SqlDbType.VarChar);
                pcpf.Value = _usuario.CPF;
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar);
                prg.Value = _usuario.RG;
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@TELEFONE", SqlDbType.VarChar);
                ptelefone.Value = _usuario.TELEFONE;
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@EMAIL", SqlDbType.VarChar);
                pemail.Value = _usuario.EMAIL;
                cmd.Parameters.Add(pemail);

                SqlParameter puserName = new SqlParameter("@USERNAME", SqlDbType.VarChar);
                puserName.Value = _usuario.USERNAME;
                cmd.Parameters.Add(puserName);

                SqlParameter psenha = new SqlParameter("@SENHA", SqlDbType.VarChar);
                psenha.Value = _usuario.SENHA;
                cmd.Parameters.Add(psenha);

                SqlParameter pdataNascimento = new SqlParameter("@DATA_NASCIMENTO", SqlDbType.DateTime);
                pdataNascimento.Value = _usuario.DATA_NASCIMENTO;
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _usuario;
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
        //Método de buscar usuário que executa as requisições de consulta de cadastros de usuários ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_USUARIO";
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
        //Método de buscar usuário que executa as requisições de consulta de cadastros de usuários ao banco de dados para realizar Login.
        public DataTable BuscarUsuario(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_USUARIO_LOGIN";
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
        //Método de excluir usuário que executa as requisições de exlusão de cadastro de usuário ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_USUARIO";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o usuário: " + _codigo.ToString());

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
