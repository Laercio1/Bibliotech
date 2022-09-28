using BLL.ClassesBLL;
using DAL.Banco;
using DAL.ClassesDAL;
using Infra;
using Model.ClassesModel;
using System;
using System.Windows.Forms;

namespace Bibliotech.FomularioSelecao
{
    public partial class FormCadastroLivro : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        FormSelecionarLivro formLivro;
        public FormCadastroLivro(FormSelecionarLivro f)
        {
            InitializeComponent();
            BindingSourceCadastroLivro.AddNew();
            inserindoNovo = true;
            formLivro = f;
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && areaConhecimentoTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Inserir()
        {
            LivroBLL livroBLL = new LivroBLL();
            Livro livro = new Livro();

            livro.CODIGO = Convert.ToInt32(codigoTextBox.Text);
            livro.TOMBO = tomboTextBox.Text;
            livro.CODIGO_SITUACAO = Convert.ToInt32(cmbSituacao.SelectedValue.ToString());
            livro.TITULO = tituloTextBox.Text;
            livro.CODIGO_AUTOR = Convert.ToInt32(TextBoxAutor.Tag);
            livro.CODIGO_CATEGORIA = Convert.ToInt32(TextBoxCategoria.Tag);
            livro.CODIGO_EDITORA = Convert.ToInt32(TextBoxEditora.Tag);
            livro.ANO = anoTextBox.Text;
            livro.DATA_CADASTRO = DateTime.Now;
            livro.CLASSIFICACAO = classificacaoTextBox.Text;
            livro.EXEMPLAR = Convert.ToInt32(exemplarTextBox.Text);
            livro.ISBN = isbnTextBox.Text;
            livro.ISSN = issnTextBox.Text;
            livro.MATERIAL = materialTextBox.Text;
            livro.VOLUME = volumeTextBox.Text;
            livro.LOCAL_PUBLICACAO = localPublicacaoTextBox.Text;
            livro.ASSUNTO = assuntoTextBox.Text;
            livro.AREA_CONHECIMENTO = areaConhecimentoTextBox.Text;

            if (inserindoNovo)
                livroBLL.Inserir(livro);
            else
                livroBLL.Alterar(livro);
            BindingSourceCadastroLivro.AddNew();
        }
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceCadastroLivro.EndEdit();
                Inserir();
                if (inserindoNovo == true)
                {
                    LivroMensagens.Inserir(1);
                    Close();
                }
                if (inserindoNovo == false)
                {
                    LivroMensagens.Alterar(1);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                tituloTextBox.Focus();
            }
            LivroBLL livroBLL = new LivroBLL();
            formLivro.livroBindingSource.DataSource = livroBLL.Buscar(areaConhecimentoTextBox.Text);
        }
        //Metodo que retorna as situações cadastradas no banco de dados.
        private void RetornarSituacao()
        {
            LivroDAL livro = new LivroDAL();

            cmbSituacao.Items.Clear();
            cmbSituacao.DataSource = Banco.dql(livro.vquerySituacao);
            cmbSituacao.DisplayMember = "DESCRICAO_SITUACAO";
            cmbSituacao.ValueMember = "CODIGO";
        }
        private void FormCadastroLivro_Load(object sender, EventArgs e)
        {
            RetornarSituacao();
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inserindoNovo == true)
            {
                Random numTomboAleatorio = new Random();
                int tomboGerado = numTomboAleatorio.Next(10000, 90000);
                tomboTextBox.Text = tomboGerado.ToString();
                tomboTextBox.Tag = tomboGerado.ToString();
            }
        }

        private void exemplarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (tomboTextBox.Text == "")
                tomboTextBox.Text = "0";
        }

        private void exemplarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void buttonPesquisaCategoria_Click(object sender, EventArgs e)
        {
            using (FormSelecionarCategoria frm = new FormSelecionarCategoria())
            {
                frm.ShowDialog();
                TextBoxCategoria.Tag = frm.codigo;
                TextBoxCategoria.Text = frm.descricaoCategoria;
            }
        }

        private void buttonPesquisaAutor_Click(object sender, EventArgs e)
        {
            using (FormSelecionarAutor frm = new FormSelecionarAutor())
            {
                frm.ShowDialog();
                TextBoxAutor.Tag = frm.codigo;
                TextBoxAutor.Text = frm.nomeAutor;
            }
        }

        private void buttonPesquisaEditora_Click(object sender, EventArgs e)
        {
            using (FormSelecionarEditora frm = new FormSelecionarEditora())
            {
                frm.ShowDialog();
                TextBoxEditora.Tag = frm.codigo;
                TextBoxEditora.Text = frm.nome;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
