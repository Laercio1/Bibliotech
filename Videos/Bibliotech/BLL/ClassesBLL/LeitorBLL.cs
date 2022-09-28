using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL.ClassesBLL
{
    public class LeitorBLL
    {
        //Método de inserir leitor que armazena dados do cadastro de leitor no banco de dados.
        public Leitor Inserir(Leitor _leitor)
        {
            if (_leitor.NOME_LEITOR == "")
                throw new Exception("Por favor, informe o nome!");
            if (_leitor.SEXO == "")
                throw new Exception("Por favor, informe o sexo!");
            if (_leitor.ENDERECO == "")
                throw new Exception("Por favor, informe o endereço!");
            if (_leitor.BAIRRO == "")
                throw new Exception("Por favor, informe o bairro!");
            if (_leitor.CODIGO_CIDADE == 0)
                throw new Exception("Por favor, informe a cidade!");
            if (_leitor.CODIGO_ESTADO == 0)
                throw new Exception("Por favor, informe o estado!");
            if (_leitor.CODIGO_TIPO_LEITOR == 0)
                throw new Exception("Por favor, infome o tipo do leitor!");
            if (_leitor.TELEFONE == "")
                throw new Exception("Por favor, informe o telefone!");
            if (ValidarEmail(_leitor.EMAIL) == false && _leitor.EMAIL != "")
                throw new Exception("Por favor, informe um endereço de email válido!");

            /*if (_leitor.CPF == Convert.ToString(new LeitorDAL().Buscar(_leitor.CODIGO.ToString()).Rows[0]["CPF"]))
                throw new Exception("Atenção!, CPF já cadastro no sistema, favor alterar CPF!");*/

            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.Inserir(_leitor);

        }
        //Método de alterar leitor que armazena dados de alteração de informações da leitor no banco de dados.
        public Leitor Alterar(Leitor _leitor)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.Alterar(_leitor);
        }
        //Método de buscar cadastros de leitores que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de leitor que estão armazenadas no banco de dados.
        public void Excluir(int _id)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            leitorDAL.Excluir(_id);
        }
        public DataTable BuscarLeitorAluno(string _filtro)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.BuscarLeitorAluno(_filtro);
        }
        public DataTable BuscarLeitorInstrutor(string _filtro)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.BuscarLeitorInstrutor(_filtro);
        }
        public DataTable BuscarLeitorColaborador(string _filtro)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.BuscarLeitorColaborador(_filtro);
        }
        public DataTable BuscarLeitorOutro(string _filtro)
        {
            LeitorDAL leitorDAL = new LeitorDAL();
            return leitorDAL.BuscarLeitorOutro(_filtro);
        }
        //Método de validar endereço de email do leitor.
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
