using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroPermuta : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroPermuta()
        {
            InitializeComponent();
            permutaCadastroBindingSource.AddNew();
            inserindoNovo = true;
            textBoxDescricao.Focus();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            permutaCadastroBindingSource.AddNew();
            LimpaForm();
            textBoxDescricao.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (permutaBindingSource.Count == 0 || permutaBindingSource.Count == null)
                return;

            tabControl1.SelectedTab = tabPageCadastro;
            PermutaBLL permutaBLL = new PermutaBLL();
            permutaCadastroBindingSource.DataSource = permutaBLL.Buscar(((DataRowView)permutaBindingSource.Current).Row["CODIGO"].ToString());//Buscando a devolucao por Id e passando os valores para o BindingSource.
            inserindoNovo = false;
            textBoxDescricao.Focus();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (permutaBindingSource.Count == 0 || permutaBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            PermutaBLL permutaBLL = new PermutaBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)permutaBindingSource.Current).Row["CODIGO"]);
            permutaBLL.Excluir(codigo);
            permutaBindingSource.RemoveCurrent();
            PermutaMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            PermutaBLL permutaBLL = new PermutaBLL();
            permutaBindingSource.DataSource = permutaBLL.BuscarPorData(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            checkBoxMostrarTodos.Checked = false;
            TextBoxBuscar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PermutaBLL permutaBLL = new PermutaBLL();
            permutaBindingSource.DataSource = permutaBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            PermutaBLL permutaBLL = new PermutaBLL();
            permutaBindingSource.DataSource = permutaBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }
        //Metodo de inserir uma nova permuta.
        private void Inserir()
        {
            PermutaBLL permutaBLL = new PermutaBLL();
            Permuta permuta = new Permuta();

            permuta.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            permuta.DESCRICAO = textBoxDescricao.Text;
            permuta.QUANTIDADE = Convert.ToInt32(textBoxQuantidade.Text);
            permuta.DATA_CADASTRO = dataDateTimePicker.Value;

            if (inserindoNovo)
                permutaBLL.Inserir(permuta);
            else
                permutaBLL.Alterar(permuta);
            permutaCadastroBindingSource.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                permutaCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    PermutaMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    PermutaMensagens.Alterar(1);
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
            permutaCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            permutaCadastroBindingSource.AddNew();
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
