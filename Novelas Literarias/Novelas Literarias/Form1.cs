using System;
using System.Linq;
using System.Windows.Forms;
using DS;
/*
 
 @author 19100234
 */
namespace Novelas_Literarias {
    public partial class FormPrincipal : Form {


        private SimpleSortedList<NovelaLiteraria> listaNovelas;
        private NovelaLiteraria currentNovela = null;
        public FormPrincipal(bool blnOrdenados=true, bool blnDuplicados=false) {
            InitializeComponent();
            listaNovelas = new SimpleSortedList<NovelaLiteraria>(blnDuplicados, blnOrdenados);
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
                    ISBN = long.Parse(txtID.Text),
                    Autor = txtAutor.Text,
                    ClasificacionDeEdad = cboClasificacionEdad.SelectedItem.ToString()[0],
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
                dtgNovelas.ClearSelection();
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
            dtgNovelas.ClearSelection();
            currentNovela = null;
            txtID.Clear();
        }

        private void RefrescarListaNovelas() {
            dtgNovelas.Rows.Clear();
            foreach(NovelaLiteraria novela in listaNovelas) {
                dtgNovelas.Rows.Add(novela.ISBN, novela.NumeroDePaginas, novela.Precio
                    , novela.Titulo, novela.ClasificacionDeEdad, novela.FechaDePublicacion.ToShortDateString(),
                    novela.TieneVersionDigital, novela.RutaFotografia, novela.Autor,
                    novela.Editorial, novela.TipoDeEdicion);
            }
        }



        private void VisualizarNovela(NovelaLiteraria currentNovela) {
            txtID.Text = currentNovela.ISBN.ToString();
            txtAutor.Text = currentNovela.Autor;
            txtEditorial.Text = currentNovela.Editorial;
            txtNumeroDePaginas.Text = currentNovela.NumeroDePaginas.ToString();
            txtPrecio.Text = currentNovela.Precio.ToString();
            txtRutaFotografia.Text = currentNovela.RutaFotografia;
            txtTitulo.Text = currentNovela.Titulo;
            chkTieneVersionDigital.Checked = currentNovela.TieneVersionDigital;
            dtpFechaDePublicacion.Value = currentNovela.FechaDePublicacion;

                 /* 0 E - Everyone (para todos)
                    1 M - Mature (17+)
                    2 Y - Young (Jovenes de 13 a 16 años)
                    3 C - Adultos (18+)
                    4 B - Babies ( menores de 13)
                    5 O - Old (50+)*/
            switch (currentNovela.ClasificacionDeEdad) {
                case 'E': cboClasificacionEdad.SelectedIndex = 0; break;
                case 'M': cboClasificacionEdad.SelectedIndex = 1; break;
                case 'Y': cboClasificacionEdad.SelectedIndex = 2; break;
                case 'C': cboClasificacionEdad.SelectedIndex = 3; break;
                case 'B': cboClasificacionEdad.SelectedIndex = 4; break;
                case 'O': cboClasificacionEdad.SelectedIndex = 5; break;
            }

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
                MessageBox.Show("Selecciona una novela", "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Estas a punto de borrar una novela ", "Borrando a "+currentNovela.Titulo, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                try {
                   listaNovelas.Borrar(currentNovela);
                } catch (Exception ex) {
                    MessageBox.Show("Error inesperado "+ex.Message, "Operacion fallida"
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
                MessageBox.Show("Se elimino a\n"+currentNovela.ToString(), "Operacion exitosa"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentNovela = null;
                RefrescarListaNovelas();
                LimpiarCampos();
            }



        }

        private void btnEliminarTodasLasNovelas_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta a punto de borrar todas las novelas registradas.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                listaNovelas.Limpiar();
                RefrescarListaNovelas();
                currentNovela = null;
                LimpiarCampos();
                MessageBox.Show("Todas las novelas fueron borradas.", "Operacion exitosa"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e) {
            LimpiarCampos();
        }



        private void dtgNovelas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dtgNovelas.CurrentRow == null) return;
            SetCurrentNovela();
            VisualizarNovela(currentNovela);
        }

        private void SetCurrentNovela() {
            currentNovela = new NovelaLiteraria() {
                ISBN = long.Parse(dtgNovelas.CurrentRow.Cells[0].Value.ToString()),
                NumeroDePaginas = int.Parse(dtgNovelas.CurrentRow.Cells[1].Value.ToString()),
                Precio = double.Parse(dtgNovelas.CurrentRow.Cells[2].Value.ToString()),
                Titulo = dtgNovelas.CurrentRow.Cells[3].Value.ToString(),
                ClasificacionDeEdad = char.Parse(dtgNovelas.CurrentRow.Cells[4].Value.ToString()),
                FechaDePublicacion = DateTime.Parse(dtgNovelas.CurrentRow.Cells[5].Value.ToString()),
                TieneVersionDigital = bool.Parse(dtgNovelas.CurrentRow.Cells[6].Value.ToString()),
                RutaFotografia = dtgNovelas.CurrentRow.Cells[7].Value.ToString(),
                Autor = dtgNovelas.CurrentRow.Cells[8].Value.ToString(),
                Editorial = dtgNovelas.CurrentRow.Cells[9].Value.ToString(),
                TipoDeEdicion = dtgNovelas.CurrentRow.Cells[10].Value.ToString()
            };
        }


        private void btnCantidadDeNovelas_Click(object sender, EventArgs e) {
            MessageBox.Show(listaNovelas.Size + " novelas registradas", "Informacion de novelas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarNovela_Click(object sender, EventArgs e) {

            NovelaLiteraria novelaQueBusco;

            novelaQueBusco = listaNovelas.BuscarSi(n => n.ISBN == long.Parse(txtBuscarNovela.Text));

            if (novelaQueBusco != default) {
                MessageBox.Show("Encontrado!!");
                ResaltarNovela(novelaQueBusco.ISBN.ToString());
            } else {
                MessageBox.Show("Noooo!");
            }

        }

        private void ResaltarNovela(string strID) {
            DataGridViewRow seleccionada =
                dtgNovelas.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells["clmnID"].Value.ToString().Equals(strID))
                .First();

            dtgNovelas.Rows[seleccionada.Index].Selected = true;
            dtgNovelas.CurrentCell  = dtgNovelas.Rows[seleccionada.Index].Cells[0];

            SetCurrentNovela();
            VisualizarNovela(currentNovela);

        }
    
    }
}
