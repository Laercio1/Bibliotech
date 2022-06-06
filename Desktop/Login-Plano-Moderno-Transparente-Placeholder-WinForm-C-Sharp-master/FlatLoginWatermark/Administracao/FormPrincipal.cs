using Model.Cache;
using System;
using System.Drawing;
using System.Linq;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
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
            //AbrirFormEnPanel(new FormConsultaPurchase());
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
            //AbrirFormEnPanel(new FormConsultaSupplier());
        }

        private void buttonProduto_Click_1(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
            AbrirFormEnPanel(new FormConsultaProduct());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
           // ManagePermissions();
        }
        private void ManagePermissions()
        {
            //Manage Permissions
            if (UserCache.Position == Positions.Vendedor)
            {
                buttonDashboard.Enabled = false;
                buttonDespesa.Enabled = false;
                buttonFornecedor.Enabled = false;
            }
            if (UserCache.Position == Positions.Comprador)
            {
                buttonDashboard.Enabled = false;
                buttonReceita.Enabled = false;
                buttonCliente.Enabled = false;
            }
        }
        private void LoadUserData()
        {
            lblNome.Text = UserCache.FirstName+" "+UserCache.LastName;
            lblPosition.Text = UserCache.Position;
            lblEmail.Text = UserCache.Email;
        }
    }
}
