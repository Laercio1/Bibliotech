using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace DashboardApp
{
    public partial class FormCadastroCustomer : Form
    {
        private bool inserindoNovo;
        public FormCadastroCustomer()
        {
            InitializeComponent();
            customerBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroCustomer(object _current)
        {
            InitializeComponent();
            customerBindingSource.DataSource = _current;
            inserindoNovo = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.EndEdit();
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
            CustomerBLL customerBLL = new CustomerBLL();
            Customer customer = new Customer();

            customer.Id = Convert.ToInt32(idTextBox.Text);
            customer.FirstName = firstNameTextBox.Text;
            customer.LastName = lastNameTextBox.Text;
            customer.City = cityTextBox.Text;
            customer.Country = countryTextBox.Text;
            customer.Phone = phoneTextBox.Text;

            if (inserindoNovo)
                customerBLL.Inserir(customer);
            else
                customerBLL.Alterar(customer);
        }
    }
}
