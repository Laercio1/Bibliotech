using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroEditora : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroEditora()
        {
            InitializeComponent();
            editoraCadastroBindingSource.AddNew();
            inserindoNovo = true;
            groupBoxLivros.Visible = false;
            nomeTextBox.Focus();
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && nomeTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //Metodo de inserir editora
        private void Inserir()
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            Editora editora = new Editora();

            editora.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            editora.NOME = nomeTextBox.Text;

            if (inserindoNovo)
                editoraBLL.Inserir(editora);
            else
                editoraBLL.Alterar(editora);
            editoraCadastroBindingSource.AddNew();
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            editoraCadastroBindingSource.AddNew();
            groupBoxLivros.Visible = false;
            nomeTextBox.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (editoraBindingSource.Count == 0 || editoraBindingSource.Count == null)
                return;
            tabControl1.SelectedTab = tabPageCadastro;
            EditoraBLL editoraBLL = new EditoraBLL();
            LivroBLL livroBLL = new LivroBLL();
            editoraCadastroBindingSource.DataSource = editoraBLL.Buscar(((DataRowView)editoraBindingSource.Current).Row["CODIGO"].ToString());//Buscando a editora por Id e passando os valores para o BindingSource.
            inserindoNovo = false;
            livroBindingSource.DataSource = livroBLL.BuscarLivroPorEditora(Convert.ToInt32(((DataRowView)editoraBindingSource.Current).Row["CODIGO"]));
            groupBoxLivros.Visible = true;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (editoraBindingSource.Count == 0 || editoraBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            EditoraBLL editoraBLL = new EditoraBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)editoraBindingSource.Current).Row["CODIGO"]);
            editoraBLL.Excluir(codigo);
            editoraBindingSource.RemoveCurrent();
            EditoraMensagens.Exluir(1);
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            editoraBindingSource.DataSource = editoraBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            editoraBindingSource.DataSource = editoraBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void editoraDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                editoraCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    EditoraMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    EditoraMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            editoraCadastroBindingSource.AddNew();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            editoraCadastroBindingSource.AddNew();
        }
    }
}
