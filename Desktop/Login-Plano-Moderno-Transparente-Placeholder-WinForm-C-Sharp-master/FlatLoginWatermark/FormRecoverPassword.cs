using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace FlatLoginWatermark
{
    public partial class FormRecoverPassword : Form
    {
        public FormRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            var user = new User();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResult.Visible = true;
            lblResult.Text = result;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
