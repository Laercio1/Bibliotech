using System.Windows.Forms;

namespace Infra
{
    public class Mensagens
    {
        private static DialogResult resultado;

        public static void Afirmacao(int tipo, string texto)
        {
            switch (tipo)
            {
                //Informação
                case 1:
                    MessageBox.Show(texto, "Sistema Biblioteca informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                //Alerta
                case 2:
                    MessageBox.Show(texto, "Sistema Biblioteca informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                //Erro
                case 3:
                    MessageBox.Show(texto, "Sistema Biblioteca informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                //Padrão
                default:
                    MessageBox.Show(texto, "Sistema Biblioteca informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
