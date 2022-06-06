using BLL;
using System;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormConsultaOrder : Form
    {
        public FormConsultaOrder()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            orderBindingSource.DataSource = orderBLL.Buscar(buscaTextBox.Text);
        }
    }
}
