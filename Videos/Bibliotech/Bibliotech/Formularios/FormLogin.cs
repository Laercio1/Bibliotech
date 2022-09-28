using BLL.ClassesBLL;
using Infra;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormLogin : Form
    {
        //Atributos e propiedades.
        public bool Logou;
        public string nomeUsuario;
        public int codigoUsuario;
        public string endereco;
        public string telefone;
        public FormLogin()
        {
            InitializeComponent();
        }
        //Dll importada que permite a movimentação do formulário de login.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //Metódo privado que permite a movimentação do formulário de login.
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Evento click do button de encerrar a tela de login.
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                BindingSource usuarioBindingSource = new BindingSource();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuario(usuarioTextBox.Text);

                if (usuarioBindingSource.Count != 0)
                {
                    string userName = ((DataRowView)usuarioBindingSource.Current).Row["USERNAME"].ToString();
                    string senha = ((DataRowView)usuarioBindingSource.Current).Row["SENHA"].ToString();
                    string senhaCriptografada = AcaoCriptografarSenhaParaHash.Cript_md5(senhaTextBox.Text);

                    if (userName == usuarioTextBox.Text && senha == senhaTextBox.Text)
                    {
                        Logou = true;
                        nomeUsuario = ((DataRowView)usuarioBindingSource.Current).Row["NOME_USUARIO"].ToString();
                        codigoUsuario = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["CODIGO"]);
                        endereco = ((DataRowView)usuarioBindingSource.Current).Row["ENDERECO"].ToString();
                        telefone = ((DataRowView)usuarioBindingSource.Current).Row["TELEFONE"].ToString();

                        using(FormPrincipal frm = new FormPrincipal())
                        {
                            frm.codigoUsuario = codigoUsuario;
                            frm.enderecoUsuario = endereco;
                            frm.telefoneUsuario = telefone;
                            frm.ShowDialog();
                        }

                        Arquivo.GravarLog("O usuário logou no sistema.");
                        Close();
                    }
                    else
                    {
                        Arquivo.GravarLog("O usuário informou um nome de usuário ou senha incorreta.");
                        msgError("Usuário ou senha incorreta!");
                        senhaTextBox.Text = "";
                        senhaTextBox.Focus();
                    }
                }
                else
                {
                    Arquivo.GravarLog("O usuário informou um nome de usuário ou senha incorreta.");
                    msgError("Usuário ou senha incorreta!");
                    senhaTextBox.Text = "";
                    senhaTextBox.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && senhaTextBox.Focused)
            {
                btnlogin_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "Usuário")
            {
                usuarioTextBox.Text = "";
                usuarioTextBox.ForeColor = Color.DimGray;
            }
        }

        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "")
            {
                usuarioTextBox.Text = "Usuário";
                usuarioTextBox.ForeColor = Color.DimGray;
            }
        }

        private void senhaTextBox_Enter(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == "Senha")
            {
                senhaTextBox.Text = "";
                senhaTextBox.ForeColor = Color.DimGray;
                senhaTextBox.UseSystemPasswordChar = true;
            }
        }
        private void senhaTextBox_Leave(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == "")
            {
                senhaTextBox.Text = "Senha";
                senhaTextBox.ForeColor = Color.DimGray;
                senhaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

    }
}
