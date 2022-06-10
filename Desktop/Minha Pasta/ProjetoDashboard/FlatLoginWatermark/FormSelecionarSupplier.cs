using BLL;
using System;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormSelecionarSupplier : Form
    {
        FormCadastroProduct formProduct;
        public FormSelecionarSupplier(FormCadastroProduct f)
        {
            InitializeComponent();
            formProduct = f;
        }

        private void FormSelecionarSupplier_Load(object sender, EventArgs e)
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            supplierBindingSource.DataSource = supplierBLL.Buscar(buscaTextBox.Text);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            supplierBindingSource.DataSource = supplierBLL.Buscar(buscaTextBox.Text);
        }

        private void supplierDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            formProduct.supplierIdTextBox.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
            formProduct.supplierIdTextBox.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
            Close();
        }
    }
}
