using DAL.Banco;
using Model.ClassesModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.ClassesDAL
{
    public class LivroDAL
    {
        //propierts public 
        public string vquerySituacao = @"SELECT CODIGO, DESCRICAO_SITUACAO FROM SITUACAO ORDER BY CODIGO";
        //Método de inserir livro que executa as requisições de cadastro de livro ao banco de dados.
        public Livro Inserir(Livro _livro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERIR_LIVRO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int)
                {
                    Value = _livro.CODIGO
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar)
                {
                    Value = _livro.TOMBO
                };
                cmd.Parameters.Add(ptombo);

                SqlParameter pcodigoSituacao = new SqlParameter("@CODIGO_SITUACAO", SqlDbType.Int)
                {
                    Value = _livro.CODIGO_SITUACAO
                };
                cmd.Parameters.Add(pcodigoSituacao);

                SqlParameter ptitulo = new SqlParameter("@TITULO", SqlDbType.VarChar)
                {
                    Value = _livro.TITULO
                };
                cmd.Parameters.Add(ptitulo);

                SqlParameter pcodigoAutor = new SqlParameter("@CODIGO_AUTOR", SqlDbType.Int)
                {
                    Value = _livro.CODIGO_AUTOR
                };
                cmd.Parameters.Add(pcodigoAutor);

                SqlParameter pcodigoCategoria = new SqlParameter("@CODIGO_CATEGORIA", SqlDbType.Int)
                {
                    Value = _livro.CODIGO_CATEGORIA
                };
                cmd.Parameters.Add(pcodigoCategoria);

                SqlParameter pcodigoEditora = new SqlParameter("@CODIGO_EDITORA", SqlDbType.Int)
                {
                    Value = _livro.CODIGO_EDITORA
                };
                cmd.Parameters.Add(pcodigoEditora);

                SqlParameter pano = new SqlParameter("@ANO", SqlDbType.VarChar)
                {
                    Value = _livro.ANO
                };
                cmd.Parameters.Add(pano);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.DateTime)
                {
                    Value = _livro.DATA_CADASTRO
                };
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pclassificacao = new SqlParameter("@CLASSIFICACAO", SqlDbType.VarChar)
                {
                    Value = _livro.CLASSIFICACAO
                };
                cmd.Parameters.Add(pclassificacao);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int)
                {
                    Value = _livro.EXEMPLAR
                };
                cmd.Parameters.Add(pexemplar);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar)
                {
                    Value = _livro.ISBN
                };
                cmd.Parameters.Add(pisbn);

                SqlParameter pissn = new SqlParameter("@ISSN", SqlDbType.VarChar)
                {
                    Value = _livro.ISSN
                };
                cmd.Parameters.Add(pissn);

                SqlParameter pmaterial = new SqlParameter("@MATERIAL", SqlDbType.VarChar)
                {
                    Value = _livro.MATERIAL
                };
                cmd.Parameters.Add(pmaterial);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar)
                {
                    Value = _livro.VOLUME
                };
                cmd.Parameters.Add(pvolume);

                SqlParameter plocalPublicacao = new SqlParameter("@LOCAL_PUBLICACAO", SqlDbType.VarChar)
                {
                    Value = _livro.LOCAL_PUBLICACAO
                };
                cmd.Parameters.Add(plocalPublicacao);

                SqlParameter passunto = new SqlParameter("@ASSUNTO", SqlDbType.VarChar)
                {
                    Value = _livro.ASSUNTO
                };
                cmd.Parameters.Add(passunto);

                SqlParameter pareaConhecimento = new SqlParameter("@AREA_CONHECIMENTO", SqlDbType.VarChar)
                {
                    Value = _livro.AREA_CONHECIMENTO
                };
                cmd.Parameters.Add(pareaConhecimento);

                cn.Open();
                _livro.CODIGO = Convert.ToInt32(cmd.ExecuteScalar());

                return _livro;
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
        //Método de alterar livro que executa as requisições de alteração de informações do livro ao banco de dados.
        public Livro Alterar(Livro _livro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ALTERAR_LIVRO";

                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _livro.CODIGO;
                cmd.Parameters.Add(pcodigo);

                SqlParameter ptombo = new SqlParameter("@TOMBO", SqlDbType.VarChar);
                ptombo.Value = _livro.TOMBO;
                cmd.Parameters.Add(ptombo);

                SqlParameter pcodigoSituacao = new SqlParameter("@CODIGO_SITUACAO", SqlDbType.Int);
                pcodigoSituacao.Value = _livro.CODIGO_SITUACAO;
                cmd.Parameters.Add(pcodigoSituacao);

                SqlParameter ptitulo = new SqlParameter("@TITULO", SqlDbType.VarChar);
                ptitulo.Value = _livro.TITULO;
                cmd.Parameters.Add(ptitulo);

                SqlParameter pcodigoAutor = new SqlParameter("@CODIGO_AUTOR", SqlDbType.Int);
                pcodigoAutor.Value = _livro.CODIGO_AUTOR;
                cmd.Parameters.Add(pcodigoAutor);

                SqlParameter pcodigoCategoria = new SqlParameter("@CODIGO_CATEGORIA", SqlDbType.Int);
                pcodigoCategoria.Value = _livro.CODIGO_CATEGORIA;
                cmd.Parameters.Add(pcodigoCategoria);

                SqlParameter pcodigoEditora = new SqlParameter("@CODIGO_EDITORA", SqlDbType.Int);
                pcodigoEditora.Value = _livro.CODIGO_EDITORA;
                cmd.Parameters.Add(pcodigoEditora);

                SqlParameter pano = new SqlParameter("@ANO", SqlDbType.VarChar);
                pano.Value = _livro.ANO;
                cmd.Parameters.Add(pano);

                SqlParameter pdataCadastro = new SqlParameter("@DATA_CADASTRO", SqlDbType.DateTime);
                pdataCadastro.Value = _livro.DATA_CADASTRO;
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pclassificacao = new SqlParameter("@CLASSIFICACAO", SqlDbType.VarChar);
                pclassificacao.Value = _livro.CLASSIFICACAO;
                cmd.Parameters.Add(pclassificacao);

                SqlParameter pexemplar = new SqlParameter("@EXEMPLAR", SqlDbType.Int);
                pexemplar.Value = _livro.EXEMPLAR;
                cmd.Parameters.Add(pexemplar);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.VarChar);
                pisbn.Value = _livro.ISBN;
                cmd.Parameters.Add(pisbn);

                SqlParameter pissn = new SqlParameter("@ISSN", SqlDbType.VarChar);
                pissn.Value = _livro.ISSN;
                cmd.Parameters.Add(pissn);

                SqlParameter pmaterial = new SqlParameter("@MATERIAL", SqlDbType.VarChar);
                pmaterial.Value = _livro.MATERIAL;
                cmd.Parameters.Add(pmaterial);

                SqlParameter pvolume = new SqlParameter("@VOLUME", SqlDbType.VarChar);
                pvolume.Value = _livro.VOLUME;
                cmd.Parameters.Add(pvolume);

                SqlParameter plocalPublicacao = new SqlParameter("@LOCAL_PUBLICACAO", SqlDbType.VarChar);
                plocalPublicacao.Value = _livro.LOCAL_PUBLICACAO;
                cmd.Parameters.Add(plocalPublicacao);

                SqlParameter passunto = new SqlParameter("@ASSUNTO", SqlDbType.VarChar);
                passunto.Value = _livro.ASSUNTO;
                cmd.Parameters.Add(passunto);

                SqlParameter pareaConhecimento = new SqlParameter("@AREA_CONHECIMENTO", SqlDbType.VarChar);
                pareaConhecimento.Value = _livro.AREA_CONHECIMENTO;
                cmd.Parameters.Add(pareaConhecimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _livro;
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
        //Método de buscar livro que executa as requisições de consulta de cadastros de livros ao banco de dados.
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO";
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
        //Método de excluir livro que executa as requisições de exlusão de cadastro de livro ao banco de dados.
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EXCLUIR_LIVRO";
                SqlParameter pcodigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o livro: " + _codigo.ToString());
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
        //Método de buscar livro por autor que executa as requisições de consulta de cadastros de livros ao banco de dados.
        public DataTable BuscarLivroPorAutor(int _codigo)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_POR_AUTOR";
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
        //Método de buscar livro por editora que executa as requisições de consulta de cadastros de livros ao banco de dados.
        public DataTable BuscarLivroPorEditora(int _codigo)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_POR_EDITORA";
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
        //Método de buscar livro por categoria que executa as requisições de consulta de cadastros de livros ao banco de dados.
        public DataTable BuscarLivroPorCategoria(int _codigo)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_POR_CATEGORIA";
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
        public DataTable BuscarLivroDisponivel(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_DISPONIVEL";
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
        public DataTable BuscarLivroIndisponivel(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_INDISPONIVEL";
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
        public DataTable BuscarLivroExtraviado(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BUSCAR_LIVRO_EXTRAVIADO";
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
