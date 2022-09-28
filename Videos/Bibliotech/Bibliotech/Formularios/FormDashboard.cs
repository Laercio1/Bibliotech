using BLL.ClassesBLL;
using DAL.ClassesDAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormDashboard : Form
    {
        //Fields
        private DashboardDAL dashboardDAL;
        private Button currentButton;
        public FormDashboard()
        {
            InitializeComponent();
            //Padrão - Últimos 7 dias
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            SetDateMenuButtonsUI(btnLast7Days);
            dashboardDAL = new DashboardDAL();
            LoadData();
        }
        //Métodos Privados
        private void LoadData()
        {
            var refreshData = dashboardDAL.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = dashboardDAL.Numero_Emprestimos.ToString();
                lblTotalRevenue.Text = dashboardDAL.Total_Livros_Emprestados.ToString();
                lblTotalProfit.Text = dashboardDAL.Total_Devolucoes.ToString();

                lblNumCustomers.Text = dashboardDAL.Numero_Leitores.ToString();
                lblNumSuppliers.Text = dashboardDAL.Numero_Autores.ToString();
                lblNumProducts.Text = dashboardDAL.Numero_Livros.ToString();

                chartGrossRevenue.DataSource = dashboardDAL.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "DATA";
                chartGrossRevenue.Series[0].YValueMembers = "TOTAL_LIVROS";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = dashboardDAL.Top_Livros_List;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void SetDateMenuButtonsUI(Object button)
        {
            var btn = (Button)button;
            //HighLight button
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //HighLight button
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn;//Definir botão atual

            //Enable custom dates
            if (btn == btnCustomDate)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOkCustomDate.Visible = true;
                lblStartDate.Cursor = Cursors.Hand;
                lblEndDate.Cursor = Cursors.Hand;
            }
            //Disable custom dates
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOkCustomDate.Visible = false;
                lblStartDate.Cursor = Cursors.Default;
                lblEndDate.Cursor = Cursors.Default;
            }
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            dgvUnderstock.DataSource = emprestimoBLL.BuscarEmprestimoAtrasado(lblStartDate.Text);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
            SetDateMenuButtonsUI(sender);
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
