using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroAutor : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroAutor()
        {
            InitializeComponent();
            autorCadastroBindingSource.AddNew();
            inserindoNovo = true;
            groupBoxLivros.Visible = false;
            nomeAutorTextBox.Focus();
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && nomeAutorTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
            autorCadastroBindingSource.AddNew();
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            autorCadastroBindingSource.AddNew();
            groupBoxLivros.Visible = false;
            nomeAutorTextBox.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Count == 0 || autorBindingSource.Count == null)
                return;
            tabControl1.SelectedTab = tabPageCadastro;
            AutorBLL autorBLL = new AutorBLL();
            LivroBLL livroBLL = new LivroBLL();
            autorCadastroBindingSource.DataSource = autorBLL.Buscar(((DataRowView)autorBindingSource.Current).Row["CODIGO"].ToString());//Buscando o autor por Id e passando os valores para o BindingSource.
            livroBindingSource.DataSource = livroBLL.BuscarLivroPorAutor(Convert.ToInt32(((DataRowView)autorBindingSource.Current).Row["CODIGO"]));
            inserindoNovo = false;
            groupBoxLivros.Visible = true;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Count == 0 || autorBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            AutorBLL autorBLL = new AutorBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)autorBindingSource.Current).Row["CODIGO"]);
            autorBLL.Excluir(codigo);
            autorBindingSource.RemoveCurrent();
            AutorMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AutorBLL autorBLL = new AutorBLL();
            autorBindingSource.DataSource = autorBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            AutorBLL autorBLL = new AutorBLL();
            autorBindingSource.DataSource = autorBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void autorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null,null);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                autorCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    AutorMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    AutorMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeAutorTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            autorCadastroBindingSource.AddNew();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            autorCadastroBindingSource.AddNew();
        }
    }
}
