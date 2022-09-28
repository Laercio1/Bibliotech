using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormCadastroAutor : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        FormSelecionarAutor FormAutor;
        public FormCadastroAutor(FormSelecionarAutor f)
        {
            InitializeComponent();
            BindingSourceCadastroAutor.AddNew();
            inserindoNovo = true;
            FormAutor = f;
            nomeAutorTextBox.Focus();
        }
        //Metodo de inserir autor
        private void Inserir()
        {
            AutorBLL autorBLL = new AutorBLL();
            Autor autor = new Autor();

            autor.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            autor.NOME_AUTOR = nomeAutorTextBox.Text;

            if (inserindoNovo)
                autorBLL.Inserir(autor);
            else
                autorBLL.Alterar(autor);
            BindingSourceCadastroAutor.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceCadastroAutor.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    AutorMensagens.Inserir(1);
                    Close();
                }
                if (inserindoNovo == false)
                {
                    AutorMensagens.Alterar(1);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeAutorTextBox.Focus();
            }
            AutorBLL autorBLL = new AutorBLL();
            FormAutor.autorBindingSource.DataSource = autorBLL.Buscar(nomeAutorTextBox.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
