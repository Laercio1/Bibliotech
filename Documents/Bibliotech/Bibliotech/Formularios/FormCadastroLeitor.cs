using Bibliotech.FomularioSelecao;
using BLL.ClassesBLL;
using DAL.Banco;
using DAL.ClassesDAL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroLeitor : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroLeitor()
        {
            InitializeComponent();
            leitorCadastroBindingSource.AddNew();
            inserindoNovo = true;
            groupBoxLivros.Visible = false;
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            leitorCadastroBindingSource.AddNew();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (leitorBindingSource.Count == 0 || leitorBindingSource.Count == null)
                return;
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = false;
            groupBoxLivros.Visible = true;
            LeitorBLL leitorBLL = new LeitorBLL();
            leitorCadastroBindingSource.DataSource = leitorBLL.Buscar(((DataRowView)leitorBindingSource.Current).Row["CODIGO"].ToString());//Buscando o leitor por Id e passando os valores para o BindingSource.
            string sexo = (((DataRowView)leitorBindingSource.Current).Row["SEXO"].ToString());
            if (sexo == "Masculino")
                rbMasculino.Checked = true;
            if (sexo == "Feminino")
                rbFeminino.Checked = true;
            if (sexo == "Outro")
                rbOutro.Checked = true;
            TextBoxCidade.Tag = (((DataRowView)leitorBindingSource.Current).Row["CODIGO_CIDADE"].ToString());
            TextBoxCidade.Text = (((DataRowView)leitorBindingSource.Current).Row["DESCRICAO_CIDADE"].ToString());
            TextBoxEstado.Tag = (((DataRowView)leitorBindingSource.Current).Row["CODIGO_ESTADO"].ToString());
            TextBoxEstado.Text = (((DataRowView)leitorBindingSource.Current).Row["DESCRICAO_ESTADO"].ToString());
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoBindingSource.DataSource = emprestimoBLL.BuscarEmprestimoPorLeitor(Convert.ToInt32(((DataRowView)leitorBindingSource.Current).Row["CODIGO"]));
        }
        //Metodo que retorna todos os tipos de usuarios cadastrados no banco de dados.
        private void RetornarTipoLeitor()
        {
            LeitorDAL leitor = new LeitorDAL();

            cmbTipoLeitor.Items.Clear();
            cmbTipoLeitor.DataSource = Banco.dql(leitor.vqueryTipoLeitor);
            cmbTipoLeitor.DisplayMember = "DESCRICAO";
            cmbTipoLeitor.ValueMember = "CODIGO";
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (leitorBindingSource.Count == 0 || leitorBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            LeitorBLL leitorBLL = new LeitorBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)leitorBindingSource.Current).Row["CODIGO"]);
            leitorBLL.Excluir(codigo);
            leitorBindingSource.RemoveCurrent();
            LeitorMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBindingSource.DataSource = leitorBLL.BuscarLeitorAluno(TextBoxBuscar.Text);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBindingSource.DataSource = leitorBLL.BuscarLeitorInstrutor(TextBoxBuscar.Text);
            }
            if (comboBox2.SelectedIndex == 2)
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBindingSource.DataSource = leitorBLL.BuscarLeitorColaborador(TextBoxBuscar.Text);
            }
            if (comboBox2.SelectedIndex == 3)
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBindingSource.DataSource = leitorBLL.BuscarLeitorOutro(TextBoxBuscar.Text);
            }
            checkBoxMostrarTodos.Checked = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            LeitorBLL leitorBLL = new LeitorBLL();
            leitorBindingSource.DataSource = leitorBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            LeitorBLL leitorBLL = new LeitorBLL();
            leitorBindingSource.DataSource = leitorBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }
        //Metodo de inserir leitor
        private void Inserir()
        {
            LeitorBLL leitorBLL = new LeitorBLL();
            Leitor leitor = new Leitor();

            leitor.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            leitor.NOME_LEITOR = nomeLeitorTextBox.Text;
            leitor.DATA_NASCIMENTO = Convert.ToDateTime(dataNascimentoDateTimePicker.Text);
            leitor.CPF = cpfTextBox.Text;
            leitor.RG = rgTextBox.Text;
            if (rbMasculino.Checked)
                leitor.SEXO = "Masculino";
            if (rbFeminino.Checked)
                leitor.SEXO = "Feminino";
            if (rbOutro.Checked)
                leitor.SEXO = "Outro";
            leitor.ENDERECO = enderecoTextBox.Text;
            leitor.BAIRRO = bairroTextBox.Text;
            leitor.CEP = cepTextBox.Text;
            leitor.CODIGO_CIDADE = Convert.ToInt32(TextBoxCidade.Tag);
            leitor.CODIGO_ESTADO = Convert.ToInt32(TextBoxEstado.Tag);
            leitor.CODIGO_TIPO_LEITOR = Convert.ToInt32(cmbTipoLeitor.SelectedValue.ToString());
            leitor.TELEFONE = telefoneTextBox.Text;
            leitor.EMAIL = emailTextBox.Text;
            leitor.DATA_CADASTRO = DateTime.Now;


            if (inserindoNovo)
                leitorBLL.Inserir(leitor);
            else
                leitorBLL.Alterar(leitor);
            leitorCadastroBindingSource.AddNew();
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && emailTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                leitorCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    LeitorMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    LeitorMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeLeitorTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void FormCadastroLeitor_Load(object sender, EventArgs e)
        {
            RetornarTipoLeitor();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            leitorCadastroBindingSource.AddNew();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            groupBoxLivros.Visible = false;
            leitorCadastroBindingSource.AddNew();
        }

        private void buttonPesquisaCidade_Click(object sender, EventArgs e)
        {
            using (FormSelecionarCidade frm = new FormSelecionarCidade())
            {
                frm.ShowDialog();
                TextBoxCidade.Tag = frm.codigo;
                TextBoxCidade.Text = frm.descricaoCidade;
            }
        }

        private void buttonPesquisaEstado_Click(object sender, EventArgs e)
        {
            using (FormSelecionarEstado frm = new FormSelecionarEstado())
            {
                frm.ShowDialog();
                TextBoxEstado.Tag = frm.codigo;
                TextBoxEstado.Text = frm.descricaoEstado;
            }
        }

        private void leitorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }
    }
}
