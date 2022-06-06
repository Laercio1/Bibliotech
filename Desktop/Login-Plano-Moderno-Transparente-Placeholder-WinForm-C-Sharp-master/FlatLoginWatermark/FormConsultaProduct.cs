using BLL;
using System;
using System.Data;
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            ProductBLL productBLL = new ProductBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)productBindingSource.Current).Row["Id"]);
            productBLL.Excluir(id);
            productBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
