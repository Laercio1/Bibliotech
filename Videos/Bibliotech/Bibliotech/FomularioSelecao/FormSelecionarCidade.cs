using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarCidade : Form
    {
        //Atributos e propiedades.
        public int codigo;
        public string descricaoCidade;
        public FormSelecionarCidade()
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
            cidadeDataGridView_DoubleClick(null, null);
        }

        private void cidadeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (cidadeBindingSource.Count == 0 || cidadeBindingSource.Count == null)
                return;
            codigo = Convert.ToInt32(((DataRowView)cidadeBindingSource.Current).Row["CODIGO"]);
            descricaoCidade = Convert.ToString(((DataRowView)cidadeBindingSource.Current).Row["DESCRICAO_CIDADE"]);// Pegando a descrição da cidade selecionada pelo datagridview cidade e setando no campo Text da propiedade cidadeTextBox.
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            cidadeBindingSource.DataSource = cidadeBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarCidade_Load(object sender, EventArgs e)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            cidadeBindingSource.DataSource = cidadeBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
