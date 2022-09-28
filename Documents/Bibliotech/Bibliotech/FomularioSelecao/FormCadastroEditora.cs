using BLL.ClassesBLL;
using Infra;
using Model.ClassesModel;
using System;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormCadastroEditora : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        FormSelecionarEditora formEditora;
        public FormCadastroEditora(FormSelecionarEditora f)
        {
            InitializeComponent();
            BindingSourceCadastroEditora.AddNew();
            inserindoNovo = true;
            formEditora = f;
            nomeTextBox.Focus();
        }
        //Metodo de inserir editora
        private void Inserir()
        {
            EditoraBLL editoraBLL = new EditoraBLL();
            Editora editora = new Editora();

            editora.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            editora.NOME = nomeTextBox.Text;

            if (inserindoNovo)
                editoraBLL.Inserir(editora);
            else
                editoraBLL.Alterar(editora);
            BindingSourceCadastroEditora.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceCadastroEditora.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    EditoraMensagens.Inserir(1);
                    Close();
                }
                if (inserindoNovo == false)
                {
                    EditoraMensagens.Alterar(1);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                nomeTextBox.Focus();
            }
            EditoraBLL editoraBLL = new EditoraBLL();
            formEditora.editoraBindingSource.DataSource = editoraBLL.Buscar(nomeTextBox.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
