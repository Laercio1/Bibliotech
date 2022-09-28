using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarAutor : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string nomeAutor;
        public FormSelecionarAutor()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            autorDataGridView_DoubleClick(null, null);
        }

        private void autorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (autorBindingSource.Count == 0 || autorBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)autorBindingSource.Current).Row["CODIGO"]);
            nomeAutor = Convert.ToString(((DataRowView)autorBindingSource.Current).Row["NOME_AUTOR"]);
            Close();
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
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            AutorBLL autorBLL = new AutorBLL();
            autorBindingSource.DataSource = autorBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarAutor_Load(object sender, EventArgs e)
        {
            AutorBLL autorBLL = new AutorBLL();
            autorBindingSource.DataSource = autorBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (FormCadastroAutor frm = new FormCadastroAutor(this))
            {
                frm.ShowDialog();
            }
        }
    }
}
