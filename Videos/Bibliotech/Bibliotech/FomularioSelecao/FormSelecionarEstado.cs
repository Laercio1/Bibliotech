using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarEstado : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string descricaoEstado;
        public FormSelecionarEstado()
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
            estadoDataGridView_DoubleClick(null, null);
        }

        private void estadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (estadoBindingSource.Count == 0 || estadoBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)estadoBindingSource.Current).Row["CODIGO"]);
            descricaoEstado = Convert.ToString(((DataRowView)estadoBindingSource.Current).Row["DESCRICAO_ESTADO"]);
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            estadoBindingSource.DataSource = estadoBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarEstado_Load(object sender, EventArgs e)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            estadoBindingSource.DataSource = estadoBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
