using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarLeitor : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string nomeLeitor;
        public string endereco;
        public string telefone;
        public FormSelecionarLeitor()
        {
            InitializeComponent();
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonBuscar_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            leitorDataGridView_DoubleClick(null, null);
        }

        private void leitorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (leitorBindingSource.Count == 0 || leitorBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)leitorBindingSource.Current).Row["CODIGO"]);
            nomeLeitor = Convert.ToString(((DataRowView)leitorBindingSource.Current).Row["NOME_LEITOR"]);
            endereco = Convert.ToString(((DataRowView)leitorBindingSource.Current).Row["ENDERECO"]);
            telefone = Convert.ToString(((DataRowView)leitorBindingSource.Current).Row["TELEFONE"]);
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            LeitorBLL livroBLL = new LeitorBLL();
            leitorBindingSource.DataSource = livroBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarLeitor_Load(object sender, EventArgs e)
        {
            LeitorBLL livroBLL = new LeitorBLL();
            leitorBindingSource.DataSource = livroBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (FormCadastroLeitor frm = new FormCadastroLeitor(this))
            {
                frm.ShowDialog();
            }
        }
    }
}
