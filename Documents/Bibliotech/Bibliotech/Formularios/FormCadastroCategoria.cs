using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroCategoria : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroCategoria()
        {
            InitializeComponent();
            categoriaCadastroBindingSource.AddNew();
            inserindoNovo = true;
            groupBoxLivros.Visible = false;
            descricaoCategoriaTextBox.Focus();
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && descricaoCategoriaTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //Metodo de inserir categoria
        private void Inserir()
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            Categoria categoria = new Categoria();

            categoria.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            categoria.DESCRICAO_CATEGORIA = descricaoCategoriaTextBox.Text;

            if (inserindoNovo)
                categoriaBLL.Inserir(categoria);
            else
                categoriaBLL.Alterar(categoria);
            categoriaCadastroBindingSource.AddNew();
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            categoriaCadastroBindingSource.AddNew();
            groupBoxLivros.Visible = false;
            descricaoCategoriaTextBox.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Count == 0 || categoriaBindingSource.Count == null)
                return;
            tabControl1.SelectedTab = tabPageCadastro;
            CategoriaBLL editoraBLL = new CategoriaBLL();
            LivroBLL livroBLL = new LivroBLL();
            categoriaCadastroBindingSource.DataSource = editoraBLL.Buscar(((DataRowView)categoriaBindingSource.Current).Row["CODIGO"].ToString());//Buscando a categoria por Id e passando os valores para o BindingSource.
            inserindoNovo = false;
            livroBindingSource.DataSource = livroBLL.BuscarLivroPorCategoria(Convert.ToInt32(((DataRowView)categoriaBindingSource.Current).Row["CODIGO"]));
            groupBoxLivros.Visible = true;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Count == 0 || categoriaBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            CategoriaBLL categoriaBLL = new CategoriaBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)categoriaBindingSource.Current).Row["CODIGO"]);
            categoriaBLL.Excluir(codigo);
            categoriaBindingSource.RemoveCurrent();
            CategoriaMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            categoriaBindingSource.DataSource = categoriaBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            categoriaBindingSource.DataSource = categoriaBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    CategoriaMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    CategoriaMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                descricaoCategoriaTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            categoriaCadastroBindingSource.AddNew();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            categoriaCadastroBindingSource.AddNew();
        }

        private void categoriaDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }
    }
}
