using BLL.ClassesBLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormSelecionarLivro : Form
    {
        //Atributos e propiedades.
        private int situacao;
        public int codigo;
        public string titulo;
        public string tombo;
        public string isbn;
        public string volume;
        public FormSelecionarLivro()
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
            livroDataGridView_DoubleClick(null, null);
        }

        private void livroDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (livroBindingSource.Count == 0 || livroBindingSource.Count == null)
                return;
            try
            {
                situacao = Convert.ToInt32(((DataRowView)livroBindingSource.Current).Row["CODIGO_SITUACAO"].ToString());
                if (situacao == 2)
                {
                    MessageBox.Show("Livro está indisponível no momento!", "Sistema Biblioteca informa:",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (situacao == 3)
                {
                    MessageBox.Show("Livro está extraviado no momento!", "Sistema Biblioteca informa:",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    titulo = Convert.ToString(((DataRowView)livroBindingSource.Current).Row["TITULO"]);
                    codigo = Convert.ToInt32(((DataRowView)livroBindingSource.Current).Row["CODIGO"]);
                    tombo = Convert.ToString(((DataRowView)livroBindingSource.Current).Row["TOMBO"]);
                    isbn = Convert.ToString(((DataRowView)livroBindingSource.Current).Row["ISBN"]);
                    volume = Convert.ToString(((DataRowView)livroBindingSource.Current).Row["VOLUME"]);
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            LivroBLL livroBLL = new LivroBLL();
            livroBindingSource.DataSource = livroBLL.Buscar(TextBoxBuscar.Text);
        }

        private void FormSelecionarLivro_Load(object sender, EventArgs e)
        {
            LivroBLL livroBLL = new LivroBLL();
            livroBindingSource.DataSource = livroBLL.Buscar(TextBoxBuscar.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (FormCadastroLivro frm = new FormCadastroLivro(this))
            {
                frm.ShowDialog();
            }
        }
    }
}
