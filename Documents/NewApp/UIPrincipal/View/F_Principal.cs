using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class F_Principal : Form
    {
        //Fields
        private Button currentButton;
        public F_Principal()
        {
            InitializeComponent();
            buttonDashboard.Select();
            SetDateMenuButtonsUI(buttonDashboard);
            collapseMenu();
        }
        private void SetDateMenuButtonsUI(Object button)
        {
            var btn = (Button)button;
            //HighLight button
            btn.BackColor = buttonDashboard.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //HighLight button
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.DarkCyan;
                currentButton.ForeColor = this.BackColor;
            }
            currentButton = btn;//Set current button
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelDesktop.Controls.Count > 0)
                this.panelDesktop.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(fh);
            this.panelDesktop.Tag = fh;
            fh.Show();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }
        private void collapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                lblPosition.Visible = false;
                lblNome.Visible = false;
                lblEmail.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButonn in panelMenu.Controls.OfType<Button>())
                {
                    menuButonn.Text = "";
                    menuButonn.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButonn.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 260;
                pictureBox1.Visible = true;
                lblPosition.Visible = true;
                lblNome.Visible = true;
                lblEmail.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButonn in panelMenu.Controls.OfType<Button>())
                {
                    menuButonn.Text = "  " + menuButonn.Tag.ToString();
                    menuButonn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButonn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            lblNome.Text = User.FirstName + " " + User.LastName;
            lblPosition.Text = User.Position;
            lblEmail.Text = User.Email;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new F_Dashboard());
            SetDateMenuButtonsUI(sender);
        }
    }
}
