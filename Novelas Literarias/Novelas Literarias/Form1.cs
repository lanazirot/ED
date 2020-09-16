using System;
using System.Windows.Forms;

namespace Novelas_Literarias {
    public partial class FormPrincipal : Form {

        private ListaOrdenada<NovelaLiteraria> listaNovelas;
        private NovelaLiteraria currentNovela = null;
        public FormPrincipal() {
            InitializeComponent();
            listaNovelas = new ListaOrdenada<NovelaLiteraria>();
        }

        private void btnAbrirFotografia_Click(object sender, System.EventArgs e) {
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                txtRutaFotografia.Text = openFileDialog.FileName;
                picFotografiaNovela.Image = System.Drawing.Image.FromFile(txtRutaFotografia.Text);
                picFotografiaNovela.Refresh();
            }
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e) {
            cboClasificacionEdad.SelectedIndex = 0;
        }

        private void btnAgregarNovela_Click(object sender, System.EventArgs e) {
            NovelaLiteraria miNovelaLiteraria = null;
            try {
                miNovelaLiteraria = new NovelaLiteraria() {
                    Autor = txtAutor.Text,
                    ClasificacionDeEdad = char.Parse(cboClasificacionEdad.SelectedItem.ToString()),
                    Editorial = txtEditorial.Text,
                    FechaDePublicacion = dtpFechaDePublicacion.Value,
                    NumeroDePaginas = int.Parse(txtNumeroDePaginas.Text),
                    Precio = double.Parse(txtPrecio.Text),
                    RutaFotografia = txtRutaFotografia.Text,
                    TieneVersionDigital = chkTieneVersionDigital.Checked,
                    TipoDeEdicion = radEdicionNormal.Checked ? "Normal" : radEdicionEspecial.Checked ? "Especial" : "Deluxe",
                    Titulo = txtTitulo.Text
                };
                 listaNovelas.Agregar(miNovelaLiteraria);
                 RefrescarListaNovelas();
                 LimpiarCampos();
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void LimpiarCampos() {
            foreach (Control control in grbNovelasLiterariasDatos.Controls)
                if (control is TextBox)
                    control.Text = "";

            dtpFechaDePublicacion.ResetText();
            cboClasificacionEdad.SelectedIndex = 0;
            radEdicionNormal.Checked = true;
            picFotografiaNovela.Image = picFotografiaNovela.InitialImage;
            picFotografiaNovela.Update();
            chkTieneVersionDigital.Checked = false;

            currentNovela = null;
        }

        private void RefrescarListaNovelas() {
            dtgNovelas.Rows.Clear();
            foreach(NovelaLiteraria novela in listaNovelas) {
                dtgNovelas.Rows.Add(novela.NumeroDePaginas, novela.Precio
                    , novela.Titulo, novela.ClasificacionDeEdad, novela.FechaDePublicacion.ToShortDateString(),
                    novela.TieneVersionDigital, novela.RutaFotografia, novela.Autor,
                    novela.Editorial, novela.TipoDeEdicion);
            }
        }

        private void dtgNovelas_Click(object sender, EventArgs e) {
            if (dtgNovelas.CurrentRow == null) return;
            currentNovela = new NovelaLiteraria() {
                NumeroDePaginas = int.Parse(dtgNovelas.CurrentRow.Cells[0].Value.ToString()),
                Precio = double.Parse(dtgNovelas.CurrentRow.Cells[1].Value.ToString()),
                Titulo = dtgNovelas.CurrentRow.Cells[2].Value.ToString(),
                ClasificacionDeEdad = char.Parse(dtgNovelas.CurrentRow.Cells[3].Value.ToString()),
                FechaDePublicacion = DateTime.Parse(dtgNovelas.CurrentRow.Cells[4].Value.ToString()),
                TieneVersionDigital = bool.Parse(dtgNovelas.CurrentRow.Cells[5].Value.ToString()),
                RutaFotografia = dtgNovelas.CurrentRow.Cells[6].Value.ToString(),
                Autor = dtgNovelas.CurrentRow.Cells[7].Value.ToString(),
                Editorial = dtgNovelas.CurrentRow.Cells[8].Value.ToString(),
                TipoDeEdicion = dtgNovelas.CurrentRow.Cells[9].Value.ToString()
            };
            VisualizarNovela(currentNovela);
        }

        private void VisualizarNovela(NovelaLiteraria currentNovela) {
            txtAutor.Text = currentNovela.Autor;
            txtEditorial.Text = currentNovela.Editorial;
            txtNumeroDePaginas.Text = currentNovela.NumeroDePaginas.ToString();
            txtPrecio.Text = currentNovela.Precio.ToString();
            txtRutaFotografia.Text = currentNovela.RutaFotografia;
            txtTitulo.Text = currentNovela.Titulo;
            chkTieneVersionDigital.Checked = currentNovela.TieneVersionDigital;
            dtpFechaDePublicacion.Value = currentNovela.FechaDePublicacion;
            cboClasificacionEdad.SelectedItem = currentNovela.ClasificacionDeEdad.ToString();

            try {

                picFotografiaNovela.Image = System.Drawing.Image.FromFile(currentNovela.RutaFotografia);
            }catch(Exception) {
                MessageBox.Show("La ruta especificada no contiene una imagen. ", "Error fatal", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                picFotografiaNovela.Image = null;
                picFotografiaNovela.Update();
            }

            switch (currentNovela.TipoDeEdicion) {
                case "Especial":
                    radEdicionEspecial.Checked = true;
                    break;
                case "Normal":
                    radEdicionNormal.Checked = true;
                    break;
                case "Deluxe":
                    radEdicionDeluxe.Checked = true;
                    break;
                default: break;
            }
        }

        private void btnBorrarNovela_Click(object sender, EventArgs e) {
            if (currentNovela == null) {
                MessageBox.Show("Selecciona una novela", "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Estas a punto de borrar una novela ", "Borrando a "+currentNovela.Titulo, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                listaNovelas.Borrar(currentNovela);
                currentNovela = null;
                RefrescarListaNovelas();
                LimpiarCampos();
                dtgNovelas.ClearSelection();
            }



        }

        private void btnEliminarTodasLasNovelas_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta a punto de borrar todas las novelas registradas.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                listaNovelas.Limpiar();
                RefrescarListaNovelas();
                currentNovela = null;
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e) {
            LimpiarCampos();
        }

    }
}
