using Bibliotech.FomularioSelecao;
using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroUsuario : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioCadastroBindingSource.AddNew();
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
            if (keyData == Keys.Enter && senhaTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //Metodo de inserir um usuário.
        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            usuario.NOME_USUARIO = nomeUsuarioTextBox.Text;
            if (rbMasculino.Checked)
                usuario.SEXO = "Masculino";
            if (rbFeminino.Checked)
                usuario.SEXO = "Feminino";
            if (rbOutro.Checked)
                usuario.SEXO = "Outro";
            usuario.ENDERECO = enderecoTextBox.Text;
            usuario.BAIRRO = bairroTextBox.Text;
            usuario.CODIGO_CIDADE = Convert.ToInt32(cidadeTextBox.Tag);
            usuario.CODIGO_ESTADO = Convert.ToInt32(estadoTextBox.Tag);
            usuario.CEP = cepTextBox.Text;
            usuario.CPF = cpfTextBox.Text;
            usuario.RG = rgTextBox.Text;
            usuario.TELEFONE = telefoneTextBox.Text;
            usuario.EMAIL = emailTextBox.Text;
            usuario.USERNAME = userNameTextBox.Text;
            usuario.SENHA = AcaoCriptografarSenhaParaHash.Cript_md5(senhaTextBox.Text);
            usuario.DATA_NASCIMENTO = Convert.ToDateTime(dataNascimentoDateTimePicker.Text);

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
            usuarioCadastroBindingSource.AddNew();
        }
        private void buttonNovo_Click(object sender, System.EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCadastro;
            inserindoNovo = true;
            usuarioCadastroBindingSource.AddNew();
        }

        private void buttonAlterar_Click(object sender, System.EventArgs e)
        {
            if (usuarioBindingSource.Count == 0 || usuarioBindingSource.Count == null)
                return;

            tabControl1.SelectedTab = tabPageCadastro;
            UsuarioBLL livroBLL = new UsuarioBLL();
            usuarioCadastroBindingSource.DataSource = livroBLL.Buscar(((DataRowView)usuarioBindingSource.Current).Row["CODIGO"].ToString());//Buscando o usuario por Id e passando os valores para o BindingSource.
            string sexo = (((DataRowView)usuarioBindingSource.Current).Row["SEXO"].ToString());
            if (sexo == "Masculino")
                rbMasculino.Checked = true;
            if (sexo == "Feminino")
                rbFeminino.Checked = true;
            if (sexo == "Outro")
                rbOutro.Checked = true;
            cidadeTextBox.Tag = (((DataRowView)usuarioBindingSource.Current).Row["CODIGO_CIDADE"].ToString());
            cidadeTextBox.Text = (((DataRowView)usuarioBindingSource.Current).Row["DESCRICAO_CIDADE"].ToString());
            estadoTextBox.Tag = (((DataRowView)usuarioBindingSource.Current).Row["CODIGO_ESTADO"].ToString());
            estadoTextBox.Text = (((DataRowView)usuarioBindingSource.Current).Row["DESCRICAO_ESTADO"].ToString());
            inserindoNovo = false;
        }

        private void buttonExcluir_Click(object sender, System.EventArgs e)
        {
            if (usuarioBindingSource.Count == 0 || usuarioBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["CODIGO"]);
            usuarioBLL.Excluir(codigo);
            usuarioBindingSource.RemoveCurrent();
            UsuarioMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioCadastroBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    UsuarioMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    UsuarioMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeUsuarioTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            usuarioCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            limpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            usuarioCadastroBindingSource.AddNew();
            tabControl1.SelectedTab = tabPageConsulta;
            limpaForm();
        }
        //Metódo de limpar formulário de cadastro de um novo usuário.
        private void limpaForm()
        {
            codigoTextBox.Clear();
            nomeUsuarioTextBox.Clear();
            enderecoTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            estadoTextBox.Clear();
            cepTextBox.Clear();
            cpfTextBox.Clear();
            rgTextBox.Clear();
            telefoneTextBox.Clear();
            emailTextBox.Clear();
            senhaTextBox.Clear();
        }

        private void buttonPesquisaCidade_Click(object sender, EventArgs e)
        {
            using (FormSelecionarCidade frm = new FormSelecionarCidade())
            {
                frm.ShowDialog();
                cidadeTextBox.Tag = frm.codigo;
                cidadeTextBox.Text = frm.descricaoCidade;
            }
        }

        private void buttonPesquisaEstado_Click(object sender, EventArgs e)
        {
            using (FormSelecionarEstado frm = new FormSelecionarEstado())
            {
                frm.ShowDialog();
                estadoTextBox.Tag = frm.codigo;
                estadoTextBox.Text = frm.descricaoEstado;
            }
        }
    }
}
