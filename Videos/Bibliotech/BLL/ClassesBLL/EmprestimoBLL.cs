using DAL.ClassesDAL;
using Model.ClassesModel;
using System;
using System.Data;

namespace BLL.ClassesBLL
{
    public class EmprestimoBLL
    {
        //Método de inserir empréstimo que armazena dados do cadastro de empréstimo no banco de dados.
        public Emprestimo Inserir(Emprestimo _emprestimo)
        {
            if (_emprestimo.CODIGO_LIVRO == 0)
                throw new Exception("Por favor, infome o livro!");
            if (_emprestimo.CODIGO_LEITOR == 0)
                throw new Exception("Por favor, Informe o leitor!");
            if (_emprestimo.CODIGO_USUARIO == 0)
                throw new Exception("Por favor, Informe o usuário!");
            if (_emprestimo.EXEMPLAR == 0)
                throw new Exception("Por favor, informe o exemplar!");
            if (_emprestimo.EXEMPLAR > Convert.ToInt32(new LivroDAL().Buscar(_emprestimo.CODIGO_LIVRO.ToString()).Rows[0]["EXEMPLAR"]))
                throw new Exception("Quantidade de exemplar maior que o estoque disponível!");
            if (_emprestimo.EXEMPLAR == Convert.ToInt32(new LivroDAL().Buscar(_emprestimo.CODIGO_LIVRO.ToString()).Rows[0]["EXEMPLAR"]))
                throw new Exception("Quantidade de exemplar maior que o estoque disponível!");

            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.Inserir(_emprestimo);
        }
        //Método de alterar empréstimo que armazena dados de alteração de informações da empréstimo no banco de dados.
        public Emprestimo Alterar(Emprestimo _emprestimo)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.Alterar(_emprestimo);
        }
        //Método de buscar cadastros de empréstimos que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.Buscar(_filtro);
        }
        //Método de excluir cadastro de empréstimo que estão armazenadas no banco de dados.
        public void Excluir(int _id)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            emprestimoDAL.Excluir(_id);
        }
        //Método de buscar cadastros de empréstimos que estão cadastrados e armazenados no banco de dados.
        public DataTable BuscarEmprestimoPorLeitor(int _codigo)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoPorLeitor(_codigo);
        }
        //Método de buscar cadastros de empréstimos que estão cadastrados e armazenados no banco de dados.
        public DataTable BuscarEmprestimoDevolucao(string _filtro)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoDevolucao(_filtro);
        }
        //Método de buscar cadastros de empréstimos pendentes que estão armazenados no banco de dados.
        public DataTable BuscarEmprestimoPendente(string _filtro)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoPendente(_filtro);
        }
        //Método de buscar cadastros de empréstimos devolvidos que estão armazenados no banco de dados.
        public DataTable BuscarEmprestimoDevolvido(string _filtro)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoDevolvido(_filtro);
        }
        //Método de buscar cadastros de empréstimos atrasados que estão armazenados no banco de dados.
        public DataTable BuscarEmprestimoAtrasado(string _filtro)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoAtrasado(_filtro);
        }
        //Método de buscar cadastros de empréstimos por data inicial e data final que estão armazenados no banco de dados.
        public DataTable BuscarEmprestimoPorData(DateTime fromDate, DateTime toDate)
        {
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            return emprestimoDAL.BuscarEmprestimoPorData(fromDate, toDate);
        }
    }
}
