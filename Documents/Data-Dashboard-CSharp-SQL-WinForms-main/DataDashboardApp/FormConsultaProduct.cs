using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormConsultaProduct : Form
    {
        public FormConsultaProduct()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productBindingSource.DataSource = productBLL.Buscar(buscaTextBox.Text);
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroProduct frm = new FormCadastroProduct())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroProduct frm = new FormCadastroProduct(productBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }
    }
}
