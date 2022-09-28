using Bibliotech.FomularioSelecao;
using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroDevolucao : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public int codigoUsuario;
        public string nomeUsuario;
        string enderecoUsuario;
        string telefoneUsuario;
        public FormCadastroDevolucao()
        {
            InitializeComponent();
            devolucaoCadastroBindingSource.AddNew();
            inserindoNovo = true;
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && dataHoraEmprestimoDateTimePicker.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //Metodo de inserir uma nova devolucao.
        private void Inserir()
        {
            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            Devolucao devolucao = new Devolucao();

            devolucao.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            devolucao.CODIGO_EMPRESTIMO = Convert.ToInt32(codigoEmprestimoTextBox.Tag);
            devolucao.CODIGO_LIVRO = Convert.ToInt32(livroTextBox.Tag);
            devolucao.TOMBO = textBoxTombo.Text;
            devolucao.ISBN = textBoxISBN.Text;
            devolucao.VOLUME = textBoxVolume.Text;
            devolucao.CODIGO_LEITOR = Convert.ToInt32(leitorTextBox.Tag);
            devolucao.ENDERECO_LEITOR = textBoxEnderecoLeitor.Text;
            devolucao.TELEFONE_LEITOR = textBoxTelefoneLeitor.Text;
            devolucao.CODIGO_USUARIO = codigoUsuario;
            devolucao.ENDERECO_USUARIO = enderecoUsuario;
            devolucao.TELEFONE_USUARIO = telefoneUsuario;
            devolucao.DATA_HORA_EMPRESTIMO = Convert.ToDateTime(dataHoraEmprestimoDateTimePicker.Text);
            devolucao.DATA_HORA_DEVOLUCAO = DateTime.Now;
            devolucao.EXEMPLAR = Convert.ToInt32(exemplarTextBox.Text);

            if (inserindoNovo)
                devolucaoBLL.Inserir(devolucao);
            else
                devolucaoBLL.Alterar(devolucao);
            devolucaoCadastroBindingSource.AddNew();
        }
        private void buttonNovo_Click(object sender, System.EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            devolucaoCadastroBindingSource.AddNew();
            buttonGravar.Enabled = true;
            LimpaForm();
        }

        private void buttonAlterar_Click(object sender, System.EventArgs e)
        {
            if (devolucaoBindingSource.Count == 0 || devolucaoBindingSource.Count == null)
                return;

            tabControl1.SelectedTab = tabPageCadastro;
            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            devolucaoCadastroBindingSource.DataSource = devolucaoBLL.BuscarPorCodigo(((DataRowView)devolucaoBindingSource.Current).Row["CODIGO"].ToString());//Buscando a devolucao por Id e passando os valores para o BindingSource.
            codigoEmprestimoTextBox.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["CODIGO_EMPRESTIMO"].ToString());
            codigoEmprestimoTextBox.Text = (((DataRowView)devolucaoBindingSource.Current).Row["CODIGO_EMPRESTIMO"].ToString());
            textBoxTombo.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["TOMBO"].ToString());
            textBoxTombo.Text = (((DataRowView)devolucaoBindingSource.Current).Row["TOMBO"].ToString());
            textBoxISBN.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["ISBN"].ToString());
            textBoxISBN.Text = (((DataRowView)devolucaoBindingSource.Current).Row["ISBN"].ToString());
            textBoxVolume.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["VOLUME"].ToString());
            textBoxVolume.Text = (((DataRowView)devolucaoBindingSource.Current).Row["VOLUME"].ToString());
            textBoxEnderecoLeitor.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["ENDERECO_LEITOR"].ToString());
            textBoxEnderecoLeitor.Text = (((DataRowView)devolucaoBindingSource.Current).Row["ENDERECO_LEITOR"].ToString());
            textBoxTelefoneLeitor.Tag = (((DataRowView)devolucaoBindingSource.Current).Row["TELEFONE_LEITOR"].ToString());
            textBoxTelefoneLeitor.Text = (((DataRowView)devolucaoBindingSource.Current).Row["TELEFONE_LEITOR"].ToString());
            inserindoNovo = false;
            buttonGravar.Enabled = false;
        }

        private void buttonExcluir_Click(object sender, System.EventArgs e)
        {
            if (devolucaoBindingSource.Count == 0 || devolucaoBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)devolucaoBindingSource.Current).Row["CODIGO"]);
            devolucaoBLL.Excluir(codigo);
            devolucaoBindingSource.RemoveCurrent();
            DevolucaoMensagens.Exluir(1);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            devolucaoBindingSource.DataSource = devolucaoBLL.BuscarDevolucaoPorData(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            checkBoxMostrarTodos.Checked = false;
            TextBoxBuscar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            devolucaoBindingSource.DataSource = devolucaoBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            DevolucaoBLL devolucaoBLL = new DevolucaoBLL();
            devolucaoBindingSource.DataSource = devolucaoBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                devolucaoCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    DevolucaoMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                    codigoEmprestimoTextBox.Clear();
                }
                if (inserindoNovo == false)
                {
                    DevolucaoMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                buttonPesquisarEmprestimo.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            devolucaoCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            devolucaoCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            LimpaForm();
        }
        private void LimpaForm()
        {
            codigoEmprestimoTextBox.Clear();
            codigoTextBox.Text = "0";
            leitorTextBox.Clear();
            livroTextBox.Clear();
            textBoxTombo.Clear();
            textBoxISBN.Clear();
            textBoxVolume.Clear();
            textBoxEnderecoLeitor.Clear();
            textBoxTelefoneLeitor.Clear();
            exemplarTextBox.Text = "1";
            dataHoraDevolucaoDateTimePicker.Value = DateTime.Now;
            dataHoraEmprestimoDateTimePicker.Value = DateTime.Now;
        }

        private void buttonPesquisarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormSelecionarEmprestimo frm = new FormSelecionarEmprestimo())
            {
                frm.ShowDialog();
                codigoEmprestimoTextBox.Tag = frm.codigo;
                codigoEmprestimoTextBox.Text = frm.codigo.ToString();
                livroTextBox.Tag = frm.codigoLivro;
                livroTextBox.Text = frm.titulo;
                textBoxTombo.Text = frm.tombo;
                textBoxISBN.Text = frm.isbn;
                textBoxVolume.Text = frm.volume;
                leitorTextBox.Tag = frm.codigoLeitor;
                textBoxEnderecoLeitor.Text = frm.enderecoLeitor;
                textBoxTelefoneLeitor.Text = frm.telefoneLeitor;
                leitorTextBox.Text = frm.nomeLeitor;
                codigoUsuario = frm.codigoUsuario;
                enderecoUsuario = frm.enderecoUsuario;
                telefoneUsuario = frm.telefoneUsuario;
                nomeUsuario = frm.nomeUsuario;
                dataHoraEmprestimoDateTimePicker.Value = frm.dataHoraEmprestimo;
                exemplarTextBox.Text = Convert.ToString(frm.exemplar);
            }
        }

        private void devolucaoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }
    }
}
