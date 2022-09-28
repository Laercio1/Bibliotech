using BLL.ClassesBLL;
using DAL.Banco;
using DAL.ClassesDAL;
using Infra;
using Model.ClassesModel;
using System;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormCadastroLeitor : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        FormSelecionarLeitor fromLeitor;
        public FormCadastroLeitor(FormSelecionarLeitor f)
        {
            InitializeComponent();
            BindingSourceCadastroLeitor.AddNew();
            inserindoNovo = true;
            fromLeitor = f;
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && emailTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
            BindingSourceCadastroLeitor.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceCadastroLeitor.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    LeitorMensagens.Inserir(1);
                    Close();
                }
                if (inserindoNovo == false)
                {
                    LeitorMensagens.Alterar(1);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeLeitorTextBox.Focus();
            }
            LeitorBLL leitorBLL = new LeitorBLL();
            fromLeitor.leitorBindingSource.DataSource = leitorBLL.Buscar(enderecoTextBox.Text);
        }

        private void FormCadastroLeitor_Load(object sender, EventArgs e)
        {
            RetornarTipoLeitor();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
