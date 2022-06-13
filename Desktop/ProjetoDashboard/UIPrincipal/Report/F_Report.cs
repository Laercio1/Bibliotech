using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewApp
{
    public partial class F_Report : Form
    {
        //Fields
        private Button currentButton;
        public F_Report()
        {
            InitializeComponent();
            buttonLast7Days.Select();
            SetDateMenuButtonsUI(buttonLast7Days);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private void getRelatorioVendas(DateTime startDate, DateTime endDate)
        {
            RelatorioVendasDAL reportModel = new RelatorioVendasDAL();
            reportModel.criarRelatorioEncomendasVendas(startDate, endDate);

            RelatorioVendasDALBindingSource.DataSource = reportModel;
            ListaVendasBindingSource.DataSource = reportModel.listaVendas;
            VendasLiquidasPorPeriodoBindingSource.DataSource = reportModel.vendasLiquidasPorPeriodos;

            this.reportViewer1.RefreshReport();
        }
        private void SetDateMenuButtonsUI(Object button)
        {
            var btn = (Button)button;
            //HighLight button
            btn.BackColor = buttonLast7Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //HighLight button
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.Gainsboro;
                currentButton.ForeColor = Color.Black;
            }
            currentButton = btn;//Set current button
        }
        private void buttonToday_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            getRelatorioVendas(fromDate, toDate);
            SetDateMenuButtonsUI(sender);
        }

        private void buttonLast7Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            getRelatorioVendas(fromDate, toDate);
            SetDateMenuButtonsUI(sender);
        }

        private void buttonThisMonth_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;
            getRelatorioVendas(fromDate, toDate);
            SetDateMenuButtonsUI(sender);
        }

        private void buttonLast30Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            getRelatorioVendas(fromDate, toDate);
            SetDateMenuButtonsUI(sender);
        }

        private void buttonThisYear_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;
            getRelatorioVendas(fromDate, toDate);
            SetDateMenuButtonsUI(sender);
        }

        private void buttonApplyCustomDate_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFromDate.Value;
            var toDate = dateTimePickerToDate.Value;
            getRelatorioVendas(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
        }
    }
}