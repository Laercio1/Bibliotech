using BLL;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            CustomizeComponents();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void F_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath ButtonPath = new GraphicsPath();
            Rectangle myrectangle = buttonLogin.ClientRectangle;
            myrectangle.Inflate(0, 30);
            ButtonPath.AddEllipse(myrectangle);
            buttonLogin.Region = new Region(ButtonPath);
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
        }
        private void CustomizeComponents()
        {
            txtUser.AutoSize = false;
            txtUser.Size = new Size(350, 35);

            txtPass.AutoSize = false;
            txtPass.Size = new Size(350, 35);
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (txtPass.Text != "")
                {
                    UserBLL user = new UserBLL();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        //FormWelcome welcome = new FormWelcome();
                        //welcome.ShowDialog();
                        F_Principal mainMenu = new F_Principal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please try again.");
                        txtUser.Focus();
                        txtPass.Text = "";
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");
        }
    }
}
