using BLL;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class F_Principal : Form
    {
        string idSelecionado;
        public F_Principal()
        {
            InitializeComponent();
        }

        private void buttonComentario_Click(object sender, EventArgs e)
        {
            using (F_Comentario frm = new F_Comentario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            TarefaBLL tarefaBLL = new TarefaBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
            tarefaBLL.Excluir(id);
            tarefaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonNovaTarefa_Click(object sender, EventArgs e)
        {
            using (F_NovaTarefa frm = new F_NovaTarefa())
            {
                frm.ShowDialog();
            }
            buttomBuscar_Click(null, null);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void tarefaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            int contLinhas = dvg.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = tarefaDataGridView.Rows[tarefaDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"SELECT 
                                              Descricao,
                                              IdUsuario,
                                              Estatus
                                        FROM
                                            Tarefa  
                                        WHERE 
                                            Id = " + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                txtUsuario.Text = dt.Rows[0].Field<Int64>("IdUsuario").ToString();
                txtDescricao.Text = dt.Rows[0].Field<string>("Descricao");
                txtEstatus.Text = dt.Rows[0].Field<string>("Estatus");

            }
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            tarefaBindingSource.DataSource = tarefaBLL.Buscar(TextBoxBuscar.Text);
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttomBuscar_Click(object sender, EventArgs e)
        {
        }
    }
}
