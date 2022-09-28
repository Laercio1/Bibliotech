using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroDoacao : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroDoacao()
        {
            InitializeComponent();
            doacaoCadastroBindingSource.AddNew();
            inserindoNovo = true;
            textBoxDescricao.Focus();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            doacaoCadastroBindingSource.AddNew();
            LimpaForm();
            textBoxDescricao.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (doacaoBindingSource.Count == 0 || doacaoBindingSource.Count == null)
                return;

            tabControl1.SelectedTab = tabPageCadastro;
            DoacaoBLL doacaoBLL = new DoacaoBLL();
            doacaoCadastroBindingSource.DataSource = doacaoBLL.Buscar(((DataRowView)doacaoBindingSource.Current).Row["CODIGO"].ToString());//Buscando a devolucao por Id e passando os valores para o BindingSource.
            inserindoNovo = false;
            textBoxDescricao.Focus();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (doacaoBindingSource.Count == 0 || doacaoBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DoacaoBLL doacaoBLL = new DoacaoBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)doacaoBindingSource.Current).Row["CODIGO"]);
            doacaoBLL.Excluir(codigo);
            doacaoBindingSource.RemoveCurrent();
            DoacaoMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisarPorData_Click(object sender, EventArgs e)
        {
            DoacaoBLL doacaoBLL = new DoacaoBLL();
            doacaoBindingSource.DataSource = doacaoBLL.BuscarPorData(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            checkBoxMostrarTodos.Checked = false;
            TextBoxBuscar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            DoacaoBLL doacaoBLL = new DoacaoBLL();
            doacaoBindingSource.DataSource = doacaoBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            DoacaoBLL doacaoBLL = new DoacaoBLL();
            doacaoBindingSource.DataSource = doacaoBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }
        //Metodo de inserir uma nova doação.
        private void Inserir()
        {
            DoacaoBLL doacaoBLL = new DoacaoBLL();
            Doacao doacao = new Doacao();

            doacao.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            doacao.DESCRICAO = textBoxDescricao.Text;
            doacao.QUANTIDADE = Convert.ToInt32(textBoxQuantidade.Text);
            doacao.DATA_CADASTRO = dataDateTimePicker.Value;

            if (inserindoNovo)
                doacaoBLL.Inserir(doacao);
            else
                doacaoBLL.Alterar(doacao);
            doacaoCadastroBindingSource.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                doacaoCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    DoacaoMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    DoacaoMensagens.Alterar(1);
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
            doacaoCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            doacaoCadastroBindingSource.AddNew();
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
