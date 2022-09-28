using System;
using System.Windows.Forms;

namespace Bibliotech.Formularios
{
    public partial class FormPrincipal : Form
    {
        private Form activeForm = null;
        public int codigoUsuario;
        public string enderecoUsuario;
        public string telefoneUsuario;
        public FormPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSubMenuCirculacao.Visible = false;
            panelSubMenuCatalogacao.Visible = false;
            panelSubMenuAdministracao.Visible = false;
            panelSubMenuAquisicao.Visible = false;
        }
        //Método de abrir formulários.
        private void AbrirFormDinamico(Form formASerApresentado)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = formASerApresentado;
            formASerApresentado.TopLevel = false;
            panelConteiner.Controls.Add(formASerApresentado);
            panelConteiner.Tag = formASerApresentado;
            formASerApresentado.Dock = DockStyle.Fill;
            formASerApresentado.Show();
        }
        private void collapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 70;
                buttonCirculacao.Enabled = false;
                buttonCatalogacao.Enabled = false;
                buttonAdministracao.Enabled = false;
                buttonCirculacao.Image = Properties.Resources.setaParaBaixo;
                buttonCatalogacao.Image = Properties.Resources.setaParaBaixo;
                buttonAdministracao.Image = Properties.Resources.setaParaBaixo;
                buttonAquisicao.Image = Properties.Resources.setaParaBaixo;
            }
            else
            {
                panelMenu.Width = 268;
                buttonCirculacao.Enabled = true;
                buttonCatalogacao.Enabled = true;
                buttonAdministracao.Enabled = true;
                buttonAquisicao.Enabled = true;
            }
        }
        private void MudaImagemBotao(Button butao, Panel panel)
        {
            if (!panel.Visible)
                butao.Image = Properties.Resources.setaParaCima;
            else
                butao.Image = Properties.Resources.setaParaBaixo;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuCirculacao.Visible == true)
            {
                panelSubMenuCirculacao.Visible = false;
                buttonCirculacao.Image = Properties.Resources.setaParaBaixo;
            }
            if (panelSubMenuCatalogacao.Visible == true)
            {
                panelSubMenuCatalogacao.Visible = false;
                buttonCatalogacao.Image = Properties.Resources.setaParaBaixo;
            }
            if (panelSubMenuAdministracao.Visible == true)
            {
                panelSubMenuAdministracao.Visible = false;
                buttonAdministracao.Image = Properties.Resources.setaParaBaixo;
            }
            if (panelSubMenuAquisicao.Visible == true)
            {
                panelSubMenuAquisicao.Visible = false;
                buttonAquisicao.Image = Properties.Resources.setaParaBaixo;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonAdministracao_Click(object sender, EventArgs e)
        {
            MudaImagemBotao(buttonAdministracao, panelSubMenuAdministracao);
            showSubMenu(panelSubMenuAdministracao);
        }

        private void buttonCatalogacao_Click(object sender, EventArgs e)
        {
            MudaImagemBotao(buttonCatalogacao, panelSubMenuCatalogacao);
            showSubMenu(panelSubMenuCatalogacao);
        }

        private void buttonCirculacao_Click(object sender, EventArgs e)
        {
            MudaImagemBotao(buttonCirculacao, panelSubMenuCirculacao);
            showSubMenu(panelSubMenuCirculacao);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();
            hideSubMenu();
        }

        private void buttonCadastroLivro_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroLivro());
            hideSubMenu();
        }
        private void buttonCadastroAutor_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroAutor());
            hideSubMenu();
        }

        private void buttonCadastroCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroCategoria());
            hideSubMenu();
        }

        private void buttonCadastroDevolucao_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroDevolucao());
            hideSubMenu();
        }

        private void buttonCadastroEditora_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroEditora());
            hideSubMenu();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            using(FormSobre frm = new FormSobre())
            {
                frm.ShowDialog();
            }
        }

        private void buttonCadastroEmprestimo_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroEmprestimo(this));
            hideSubMenu();
        }

        private void buttonCadastroLeitor_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroLeitor());
            hideSubMenu();
        }

        private void buttonCadastroUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroUsuario());
            hideSubMenu();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente encerrar o programa?", "Sistema Biblioteca informa:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormDashboard());
            hideSubMenu();
        }

        private void buttonAquisicao_Click(object sender, EventArgs e)
        {
            MudaImagemBotao(buttonAquisicao, panelSubMenuAquisicao);
            showSubMenu(panelSubMenuAquisicao);
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroCompra());
            hideSubMenu();
        }

        private void buttonDoacao_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroDoacao());
            hideSubMenu();
        }

        private void buttonPermuta_Click(object sender, EventArgs e)
        {
            AbrirFormDinamico(new FormCadastroPermuta());
            hideSubMenu();
        }
    }
}
