using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class F_Comentario : Form
    {
        public F_Comentario()
        {
            InitializeComponent();
        }

        private void buttonNovoComentario_Click(object sender, EventArgs e)
        {
            using (F_NovoComentario frm = new F_NovoComentario())
            {
                frm.ShowDialog();
            }
        }
    }
}
