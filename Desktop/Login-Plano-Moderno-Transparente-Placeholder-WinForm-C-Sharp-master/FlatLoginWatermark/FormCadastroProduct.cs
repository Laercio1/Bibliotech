using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormCadastroProduct : Form
    {
        private bool inserindoNovo;
        public FormCadastroProduct()
        {
            InitializeComponent();
            productBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroProduct(object _current)
        {
            InitializeComponent();
            productBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo)
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);

            }
        }
        private void Inserir()
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();

            product.Id = Convert.ToInt32(idTextBox.Text);
            product.ProductName = ProductNameTextBox.Text;
            product.SupplierId = Convert.ToInt32(supplierIdTextBox.Tag);
            product.UnitPrice = Convert.ToDecimal(unitPriceTextBox.Text);
            product.Package = PackageTextBox.Text;
            product.Stock = Convert.ToInt32(stockTextBox.Text);
            product.IsDiscontinued = isDsicontinuedCheckBox.Checked;

            if (inserindoNovo)
                productBLL.Inserir(product);
            else
                productBLL.Alterar(product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelecionarSupplier formSelecionarSupplier = new FormSelecionarSupplier(this);
            formSelecionarSupplier.ShowDialog();
        }
    }
}
