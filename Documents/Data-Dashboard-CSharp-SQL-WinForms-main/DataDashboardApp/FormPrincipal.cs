using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormPrincipal : Form
    {
        //Fields
        private Button currentButton;

        //Constructor
        public FormPrincipal()
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashboard());
            SetDateMenuButtonsUI(sender);
        }

        private void collapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
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
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButonn in panelMenu.Controls.OfType<Button>())
                {
                    menuButonn.Text = "  " + menuButonn.Tag.ToString();
                    menuButonn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButonn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultaCustomer());
            SetDateMenuButtonsUI(sender);
        }

        private void buttonReceita_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultaOrder());
            SetDateMenuButtonsUI(sender);
        }

        private void buttonDespesa_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
        }

        private void buttonProduto_Click_1(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
            AbrirFormEnPanel(new FormConsultaProduct());
        }
    }
}
