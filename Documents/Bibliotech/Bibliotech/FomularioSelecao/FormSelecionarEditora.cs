using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarEditora : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string nome;
        public FormSelecionarEditora()
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
            editoraDataGridView_DoubleClick(null, null);
        }

        private void editoraDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (editoraBindingSource.Count == 0 || editoraBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)editoraBindingSource.Current).Row["CODIGO"]);
            nome = Convert.ToString(((DataRowView)editoraBindingSource.Current).Row["NOME"]);
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            editoraBindingSource.DataSource = editoraBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarEditora_Load(object sender, EventArgs e)
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            editoraBindingSource.DataSource = editoraBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (FormCadastroEditora frm = new FormCadastroEditora(this))
            {
                frm.ShowDialog();
            }
        }
    }
}
