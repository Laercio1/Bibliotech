using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroCompra : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroCompra()
        {
            InitializeComponent();
            compraCadastroBindingSource.AddNew();
            inserindoNovo = true;
            textBoxDescricao.Focus();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            compraCadastroBindingSource.AddNew();
            LimpaForm();
            textBoxDescricao.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (compraBindingSource.Count == 0 || compraBindingSource.Count == null)
                return;

            tabControl1.SelectedTab = tabPageCadastro;
            CompraBLL compraBLL = new CompraBLL();
            compraCadastroBindingSource.DataSource = compraBLL.Buscar(((DataRowView)compraBindingSource.Current).Row["CODIGO"].ToString());//Buscando a devolucao por Id e passando os valores para o BindingSource.
            inserindoNovo = false;
            textBoxDescricao.Focus();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (compraBindingSource.Count == 0 || compraBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            CompraBLL compraBLL = new CompraBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)compraBindingSource.Current).Row["CODIGO"]);
            compraBLL.Excluir(codigo);
            compraBindingSource.RemoveCurrent();
            CompraMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisarPorData_Click(object sender, EventArgs e)
        {
            CompraBLL compraBLL = new CompraBLL();
            compraBindingSource.DataSource = compraBLL.BuscarPorData(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            checkBoxMostrarTodos.Checked = false;
            TextBoxBuscar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            CompraBLL compraBLL = new CompraBLL();
            compraBindingSource.DataSource = compraBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            CompraBLL compraBLL = new CompraBLL();
            compraBindingSource.DataSource = compraBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }
        //Metodo de inserir uma nova compra.
        private void Inserir()
        {
            CompraBLL compraBLL = new CompraBLL();
            Compra compra = new Compra();

            compra.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            compra.DESCRICAO = textBoxDescricao.Text;
            compra.QUANTIDADE = Convert.ToInt32(textBoxQuantidade.Text);
            compra.DATA_CADASTRO = dataDateTimePicker.Value;

            if (inserindoNovo)
                compraBLL.Inserir(compra);
            else
                compraBLL.Alterar(compra);
            compraCadastroBindingSource.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                compraCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    CompraMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    CompraMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            compraCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            compraCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }
        private void LimpaForm()
        {
            codigoTextBox.Text = "0";
            textBoxDescricao.Clear();
            textBoxQuantidade.Clear();
            dataDateTimePicker.Value = DateTime.Now;
        }

        private void devolucaoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }
    }
}
