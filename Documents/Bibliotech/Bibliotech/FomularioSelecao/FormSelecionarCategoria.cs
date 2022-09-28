using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarCategoria : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string descricaoCategoria;
        public FormSelecionarCategoria()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            categoriaDataGridView_DoubleClick(null, null);
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
        private void categoriaDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Count == 0 || categoriaBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)categoriaBindingSource.Current).Row["CODIGO"]);
            descricaoCategoria = Convert.ToString(((DataRowView)categoriaBindingSource.Current).Row["DESCRICAO_CATEGORIA"]);
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            categoriaBindingSource.DataSource = categoriaBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            categoriaBindingSource.DataSource = categoriaBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (FormCadastroCategoria frm = new FormCadastroCategoria(this))
            {
                frm.ShowDialog();
            }
        }
    }
}
