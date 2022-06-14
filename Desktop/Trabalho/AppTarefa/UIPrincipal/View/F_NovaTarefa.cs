using BLL;
using DAL;
using Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class F_NovaTarefa : Form
    {
        private bool inserindoNovo;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public F_NovaTarefa()
        {
            InitializeComponent();
            tarefaBindingSource.AddNew();
            inserindoNovo = true;

        }
        public F_NovaTarefa(object _current)
        {
            InitializeComponent();
            tarefaBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tarefaBindingSource.EndEdit();
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
            TarefaBLL tarefaBLL = new TarefaBLL();
            Tarefa tarefa = new Tarefa();

            tarefa.Id = Convert.ToInt32(idTextBox.Text);
            tarefa.IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue.ToString());
            tarefa.Descricao = descricaoTextBox.Text;
            tarefa.Estatus = cmbEstatus.SelectedItem.ToString();
            tarefa.Imagem = destinoCompleto;

            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "Erro", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    imagemTextBox.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar:", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (inserindoNovo)
                tarefaBLL.Inserir(tarefa);
            else
                tarefaBLL.Alterar(tarefa);
        }
        private void RetornarUsuarios()
        {
            string vqueryUsuarios = @"SELECT 
                                            UserID,
                                            UserName 
                                      FROM 
                                            Users
                                      ORDER BY
                                            UserID";

            cmbUsuario.Items.Clear();
            cmbUsuario.DataSource = Banco.dql(vqueryUsuarios);
            cmbUsuario.DisplayMember = "UserName";
            cmbUsuario.ValueMember = "UserID";

        }
        private void F_NovaTarefa_Load(object sender, EventArgs e)
        {
            RetornarUsuarios();
        }

        private void buttonSelecionarImagem_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            else
                return;

            if (File.Exists(destinoCompleto))
                if (MessageBox.Show("Arquivo já existe, deseja substituir", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
                imagemTextBox.ImageLocation = destinoCompleto;
            else
                MessageBox.Show("Arquivo não copiado");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
