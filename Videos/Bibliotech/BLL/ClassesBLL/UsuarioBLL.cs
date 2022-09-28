using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL.ClassesBLL
{
    public class UsuarioBLL
    {
        //Método de inserir usuário que armazena dados do cadastro de usuário no banco de dados.
        public Usuario Inserir(Usuario _usuario)
        {
            if (_usuario.NOME_USUARIO == "")
                throw new Exception("Por favor, infome o nome!");
            if (_usuario.SEXO == "")
                throw new Exception("Por favor, informe o sexo!");
            if (_usuario.ENDERECO == "")
                throw new Exception("Por favor, informe o endereço!");
            if (_usuario.BAIRRO == "")
                throw new Exception("Por favor, informe o bairro!");
            if (_usuario.CODIGO_CIDADE == 0)
                throw new Exception("Por favor, informe a cidade!");
            if (_usuario.CODIGO_ESTADO == 0)
                throw new Exception("Por favor, informe o estado!");
            if (_usuario.TELEFONE == "")
                throw new Exception("Por favor, informe o telefone!");
            if (ValidarEmail(_usuario.EMAIL) == false && _usuario.EMAIL != "")
                throw new Exception("Por favor, informe um endereço de email válido!");
            if (_usuario.USERNAME == "")
                throw new Exception("Por favor, informe o nome de usuário!");
            if (_usuario.SENHA == "")
                throw new Exception("Por favor, informe a senha!");

            /*if (_usuario.Cpf == Convert.ToString(new UsuarioDAL().Buscar(_usuario.Codigo.ToString()).Rows[0]["Cpf"]))
                throw new Exception("Atenção!, CPF já cadastro no sistema, favor alterar CPF!");*/

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Inserir(_usuario);
        }
        //Método de alterar usuário que armazena dados de alteração de informações do usuário no banco de dados.
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
        //Método de buscar cadastros de usuários que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
        //Método de buscar cadastros de usuários que estão cadastrados e armazenados no banco de dados para realizar Login.
        public DataTable BuscarUsuario(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarUsuario(_filtro);
        }
        //Método de excluir cadastro de usuário que estão armazenados no banco de dados.
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
        //Método de validar endereço de email do usuário.
        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
