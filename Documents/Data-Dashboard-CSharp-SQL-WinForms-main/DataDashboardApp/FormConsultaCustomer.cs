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
    public partial class FormConsultaCustomer : Form
    {
        public FormConsultaCustomer()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            customerBindingSource.DataSource = customerBLL.Buscar(buscaTextBox.Text);
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroCustomer frm = new FormCadastroCustomer())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroCustomer frm = new FormCadastroCustomer(customerBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CustomerBLL usuarioBLL = new CustomerBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)customerBindingSource.Current).Row["Id"]);
            usuarioBLL.Excluir(id);
            customerBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
