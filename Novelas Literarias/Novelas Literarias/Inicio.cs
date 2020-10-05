using System;
using System.Windows.Forms;

namespace Novelas_Literarias {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        private void btnAbrirPrograma_Click(object sender, EventArgs e) {
            this.Hide();
            FormPrincipal programa = new FormPrincipal(!chkDesordenados.Checked, chkDuplicados.Checked);
            programa.FormClosed += (s, args) => this.Close();
            programa.Show();
        }
    }
}
