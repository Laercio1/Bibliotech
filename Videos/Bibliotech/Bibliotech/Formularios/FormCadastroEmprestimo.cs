using Bibliotech.FomularioSelecao;
using BLL.ClassesBLL;
using DAL.Banco;
using Infra;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Model.ClassesModel;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormCadastroEmprestimo : Form
    {
        //Atributos e propiedades
        private bool inserindoNovo;
        public int codigoUsuario;
        FormPrincipal form;
        string enderecoUsuario;
        string telefoneUsuario;
        public FormCadastroEmprestimo(FormPrincipal f)
        {
            InitializeComponent();
            emprestimoCadastroBindingSource.AddNew();
            inserindoNovo = true;
            dataHoraDevolucaoDateTimePicker.Value = DateTime.Today.AddDays(+6);
            exemplarTextBox.Text = "1";
            form = f;
        }
        //Método processCmdKey.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && TextBoxBuscar.Focused)
            {
                buttonPesquisar_Click(null, null);
                return true;
            }
            if (keyData == Keys.Enter && exemplarTextBox.Focused)
            {
                buttonGravar_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPageCadastro;
                inserindoNovo = true;
                emprestimoCadastroBindingSource.AddNew();
                buttonGravar.Enabled = true;
                SetUsuario();
                LimpaForm();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (emprestimoBindingSource.Count == 0 || emprestimoBindingSource.Count == null)
                return;
            tabControl1.SelectedTab = tabPageCadastro;
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoCadastroBindingSource.DataSource = emprestimoBLL.Buscar(((DataRowView)emprestimoBindingSource.Current).Row["CODIGO"].ToString());//Buscando o emprestimo por Id e passando os valores para o BindingSource.
            TextBoxLeitor.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["CODIGO_LEITOR"].ToString());
            TextBoxLeitor.Text = (((DataRowView)emprestimoBindingSource.Current).Row["NOME_LEITOR"].ToString());
            TextBoxLivro.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["CODIGO_LIVRO"].ToString());
            TextBoxLivro.Text = (((DataRowView)emprestimoBindingSource.Current).Row["TITULO"].ToString());
            textBoxTombo.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["TOMBO"].ToString());
            textBoxTombo.Text = (((DataRowView)emprestimoBindingSource.Current).Row["TOMBO"].ToString());
            textBoxISBN.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["ISBN"].ToString());
            textBoxISBN.Text = (((DataRowView)emprestimoBindingSource.Current).Row["ISBN"].ToString());
            textBoxVolume.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["VOLUME"].ToString());
            textBoxVolume.Text = (((DataRowView)emprestimoBindingSource.Current).Row["VOLUME"].ToString());
            textBoxEnderecoLeitor.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["ENDERECO_LEITOR"].ToString());
            textBoxEnderecoLeitor.Text = (((DataRowView)emprestimoBindingSource.Current).Row["ENDERECO_LEITOR"].ToString());
            textBoxTelefoneLeitor.Tag = (((DataRowView)emprestimoBindingSource.Current).Row["TELEFONE_LEITOR"].ToString());
            textBoxTelefoneLeitor.Text = (((DataRowView)emprestimoBindingSource.Current).Row["TELEFONE_LEITOR"].ToString());
            exemplarTextBox.Text = (((DataRowView)emprestimoBindingSource.Current).Row["EXEMPLAR"].ToString());
            inserindoNovo = false;
            buttonGravar.Enabled = false;
        }
        private void SetUsuario()
        {
            enderecoUsuario = form.enderecoUsuario;
            telefoneUsuario = form.telefoneUsuario;
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (emprestimoBindingSource.Count == 0 || emprestimoBindingSource.Count == null)
                return;

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            int codigo;
            codigo = Convert.ToInt32(((DataRowView)emprestimoBindingSource.Current).Row["CODIGO"]);
            emprestimoBLL.Excluir(codigo);
            emprestimoBindingSource.RemoveCurrent();
            EmprestimoMensagens.Exluir(1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoBindingSource.DataSource = emprestimoBLL.Buscar(TextBoxBuscar.Text);
            checkBoxMostrarTodos.Checked = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoBindingSource.DataSource = emprestimoBLL.BuscarEmprestimoPorData(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            checkBoxMostrarTodos.Checked = false;
            TextBoxBuscar.Clear();
        }

        private void checkBoxMostrarTodos_Click(object sender, EventArgs e)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoBindingSource.DataSource = emprestimoBLL.Buscar(TextBoxBuscar.Text);
            TextBoxBuscar.Clear();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                emprestimoCadastroBindingSource.EndEdit();

                EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                Emprestimo emprestimo = new Emprestimo();

                emprestimo.CODIGO = Convert.ToInt32(codigoTextBox.Text);
                emprestimo.CODIGO_LIVRO = Convert.ToInt32(TextBoxLivro.Tag);
                emprestimo.TOMBO = textBoxTombo.Text;
                emprestimo.ISBN = textBoxISBN.Text;
                emprestimo.VOLUME = textBoxVolume.Text;
                emprestimo.CODIGO_LEITOR = Convert.ToInt32(TextBoxLeitor.Tag);
                emprestimo.ENDERECO_LEITOR = textBoxEnderecoLeitor.Text;
                emprestimo.TELEFONE_LEITOR = textBoxTelefoneLeitor.Text;
                emprestimo.CODIGO_USUARIO = form.codigoUsuario;
                emprestimo.ENDERECO_USUARIO = enderecoUsuario;
                emprestimo.TELEFONE_USUARIO = telefoneUsuario;
                emprestimo.EXEMPLAR = 1;
                emprestimo.DATA_HORA_EMPRESTIMO = DateTime.Now;
                if (EhDiaUtil(DateTime.Today.AddDays(+9)) != true)
                {
                    emprestimo.DATA_HORA_DEVOLUCAO = DateTime.Today.AddDays(+10);
                }
                else
                    emprestimo.DATA_HORA_DEVOLUCAO = DateTime.Today.AddDays(+6);
                emprestimo.STATUS = "Pendente";

                if (inserindoNovo == true)
                {
                    emprestimoBLL.Inserir(emprestimo);
                    EmprestimoMensagens.Inserir(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                if (inserindoNovo == false)
                {
                    emprestimoBLL.Alterar(emprestimo);
                    EmprestimoMensagens.Alterar(1);
                    tabControl1.SelectedTab = tabPageConsulta;
                }
                emprestimoCadastroBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Mensagens.Afirmacao(3, ex.Message);
                exemplarTextBox.Focus();
            }
            buttonPesquisar_Click(null, null);
        }
        public bool EhDiaUtil(DateTime data)
        {
            return !DiasUteis.EhFinalDeSemana(data);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            emprestimoCadastroBindingSource.AddNew();
            LimpaForm();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            tabControl1.SelectedTab = tabPageConsulta;
            emprestimoCadastroBindingSource.AddNew();
            LimpaForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FormSelecionarLivro frm = new FormSelecionarLivro())
            {
                frm.ShowDialog();
                if (frm.codigo > 0)
                {
                    TextBoxLivro.Tag = frm.codigo;
                    TextBoxLivro.Text = frm.titulo;
                    textBoxTombo.Text = frm.tombo;
                    textBoxISBN.Text = frm.isbn;
                    textBoxVolume.Text = frm.volume;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormSelecionarLeitor frm = new FormSelecionarLeitor())
            {
                frm.ShowDialog();
                if (frm.codigo > 0)
                {
                    TextBoxLeitor.Tag = frm.codigo;
                    TextBoxLeitor.Text = frm.nomeLeitor;
                    textBoxEnderecoLeitor.Text = frm.endereco;
                    textBoxTelefoneLeitor.Text = frm.telefone;
                }
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                emprestimoBindingSource.DataSource = emprestimoBLL.BuscarEmprestimoPendente(TextBoxBuscar.Text);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                emprestimoBindingSource.DataSource = emprestimoBLL.BuscarEmprestimoDevolvido(TextBoxBuscar.Text);
            }
            if (comboBox2.SelectedIndex == 2)
            {
                EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                emprestimoBindingSource.DataSource = emprestimoBLL.BuscarEmprestimoAtrasado(TextBoxBuscar.Text);
            }
            checkBoxMostrarTodos.Checked = false;
        }

        private void emprestimoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonAlterar_Click(null, null);
        }

        private void exemplarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void exemplarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (exemplarTextBox.Text == "")
                exemplarTextBox.Text = "0";
        }
        private void LimpaForm()
        {
            codigoTextBox.Text = "0";
            TextBoxLeitor.Clear();
            TextBoxLivro.Clear();
            textBoxTombo.Clear();
            textBoxISBN.Clear();
            textBoxVolume.Clear();
            textBoxEnderecoLeitor.Clear();
            textBoxTelefoneLeitor.Clear();
            exemplarTextBox.Text = "1";
            dataHoraDevolucaoDateTimePicker.Value = DateTime.Today.AddDays(+6);
            dateTimePicker.Value = DateTime.Now;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (TextBoxLivro.Text == "")
                return;
            if (TextBoxLeitor.Text == "")
                return;

            string nomeArquivo = Globais.caminho + @"\comprovante.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A5);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            Image logo = Image.GetInstance(Globais.caminho + @"\logoSenai.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_CENTER;

            doc.Open();
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados, new Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("BIBLIOTECH\n\n");

            paragrafo.Font = new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Comprovante de Empréstimo\n\n");

            Paragraph paragrafo1 = new Paragraph(dados, new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Font = new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
            paragrafo1.Alignment = Element.ALIGN_LEFT;
            paragrafo1.Add("Informações do Empréstimo:" +
                          "\nData do Empréstimo: " + dateTimePicker.Value.ToString("dd/MM/yyyy") +
                          "\nData da Devolução: " + dataHoraDevolucaoDateTimePicker.Value.ToString("dd/MM/yyyy") +
                          "\nNº de Exemplar: " + exemplarTextBox.Text);

            Paragraph paragrafo2 = new Paragraph(dados, new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Font = new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
            paragrafo2.Alignment = Element.ALIGN_LEFT;
            paragrafo2.Add("\nInformações do Livro:" +
                          "\nTítulo: " + TextBoxLivro.Text +
                          "\nTombo: " + textBoxTombo.Text +
                          "\nISBN: " + textBoxISBN.Text +
                          "\nVolume: " + textBoxVolume.Text);

            Paragraph paragrafo3 = new Paragraph(dados, new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo3.Font = new Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
            paragrafo3.Alignment = Element.ALIGN_LEFT;
            paragrafo3.Add("\nInformações do Leitor:" +
                          "\nNome: " + TextBoxLeitor.Text +
                          "\nEndereço: " + textBoxEnderecoLeitor.Text +
                          "\nTelefone: " + textBoxTelefoneLeitor.Text);

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(paragrafo3);
            doc.Close();

            System.Diagnostics.Process.Start(Globais.caminho + @"\comprovante.pdf");
        }
    }
}
