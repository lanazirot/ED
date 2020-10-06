namespace Novelas_Literarias {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbNovelasLiterariasDatos = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.radEdicionDeluxe = new System.Windows.Forms.RadioButton();
            this.radEdicionNormal = new System.Windows.Forms.RadioButton();
            this.radEdicionEspecial = new System.Windows.Forms.RadioButton();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblRutaFotografia = new System.Windows.Forms.Label();
            this.lblFechaDePublicacion = new System.Windows.Forms.Label();
            this.lblClasificacionDeEdad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNoPaginas = new System.Windows.Forms.Label();
            this.btnAbrirFotografia = new System.Windows.Forms.Button();
            this.picFotografiaNovela = new System.Windows.Forms.PictureBox();
            this.txtNumeroDePaginas = new System.Windows.Forms.TextBox();
            this.btnAgregarNovela = new System.Windows.Forms.Button();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtRutaFotografia = new System.Windows.Forms.TextBox();
            this.chkTieneVersionDigital = new System.Windows.Forms.CheckBox();
            this.dtpFechaDePublicacion = new System.Windows.Forms.DateTimePicker();
            this.cboClasificacionEdad = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnEliminarTodasLasNovelas = new System.Windows.Forms.Button();
            this.btnBorrarNovela = new System.Windows.Forms.Button();
            this.dtgNovelas = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCantidadDeNovelas = new System.Windows.Forms.Button();
            this.lblInformacionOrdenamientoNovelas = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabInsertarDatos = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnBuscarNovela = new System.Windows.Forms.Button();
            this.txtBuscarNovela = new System.Windows.Forms.TextBox();
            this.lblQueBuscas = new System.Windows.Forms.Label();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumeroDePaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnClasificacionDeEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFechaDePublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTieneVersionDigital = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnRutaDeFotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTipoDeEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNovelasLiterariasDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografiaNovela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNovelas)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabInsertarDatos.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNovelasLiterariasDatos
            // 
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblID);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtID);
            this.grbNovelasLiterariasDatos.Controls.Add(this.btnLimpiarTodo);
            this.grbNovelasLiterariasDatos.Controls.Add(this.radEdicionDeluxe);
            this.grbNovelasLiterariasDatos.Controls.Add(this.radEdicionNormal);
            this.grbNovelasLiterariasDatos.Controls.Add(this.radEdicionEspecial);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblEditorial);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblAutor);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblRutaFotografia);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblFechaDePublicacion);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblClasificacionDeEdad);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblTitulo);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblPrecio);
            this.grbNovelasLiterariasDatos.Controls.Add(this.lblNoPaginas);
            this.grbNovelasLiterariasDatos.Controls.Add(this.btnAbrirFotografia);
            this.grbNovelasLiterariasDatos.Controls.Add(this.picFotografiaNovela);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtNumeroDePaginas);
            this.grbNovelasLiterariasDatos.Controls.Add(this.btnAgregarNovela);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtEditorial);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtAutor);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtRutaFotografia);
            this.grbNovelasLiterariasDatos.Controls.Add(this.chkTieneVersionDigital);
            this.grbNovelasLiterariasDatos.Controls.Add(this.dtpFechaDePublicacion);
            this.grbNovelasLiterariasDatos.Controls.Add(this.cboClasificacionEdad);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtTitulo);
            this.grbNovelasLiterariasDatos.Controls.Add(this.txtPrecio);
            resources.ApplyResources(this.grbNovelasLiterariasDatos, "grbNovelasLiterariasDatos");
            this.grbNovelasLiterariasDatos.Name = "grbNovelasLiterariasDatos";
            this.grbNovelasLiterariasDatos.TabStop = false;
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // btnLimpiarTodo
            // 
            resources.ApplyResources(this.btnLimpiarTodo, "btnLimpiarTodo");
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // radEdicionDeluxe
            // 
            resources.ApplyResources(this.radEdicionDeluxe, "radEdicionDeluxe");
            this.radEdicionDeluxe.Name = "radEdicionDeluxe";
            this.radEdicionDeluxe.UseVisualStyleBackColor = true;
            // 
            // radEdicionNormal
            // 
            resources.ApplyResources(this.radEdicionNormal, "radEdicionNormal");
            this.radEdicionNormal.Checked = true;
            this.radEdicionNormal.Name = "radEdicionNormal";
            this.radEdicionNormal.TabStop = true;
            this.radEdicionNormal.UseVisualStyleBackColor = true;
            // 
            // radEdicionEspecial
            // 
            resources.ApplyResources(this.radEdicionEspecial, "radEdicionEspecial");
            this.radEdicionEspecial.Name = "radEdicionEspecial";
            this.radEdicionEspecial.UseVisualStyleBackColor = true;
            // 
            // lblEditorial
            // 
            resources.ApplyResources(this.lblEditorial, "lblEditorial");
            this.lblEditorial.Name = "lblEditorial";
            // 
            // lblAutor
            // 
            resources.ApplyResources(this.lblAutor, "lblAutor");
            this.lblAutor.Name = "lblAutor";
            // 
            // lblRutaFotografia
            // 
            resources.ApplyResources(this.lblRutaFotografia, "lblRutaFotografia");
            this.lblRutaFotografia.Name = "lblRutaFotografia";
            // 
            // lblFechaDePublicacion
            // 
            resources.ApplyResources(this.lblFechaDePublicacion, "lblFechaDePublicacion");
            this.lblFechaDePublicacion.Name = "lblFechaDePublicacion";
            // 
            // lblClasificacionDeEdad
            // 
            resources.ApplyResources(this.lblClasificacionDeEdad, "lblClasificacionDeEdad");
            this.lblClasificacionDeEdad.Name = "lblClasificacionDeEdad";
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblPrecio
            // 
            resources.ApplyResources(this.lblPrecio, "lblPrecio");
            this.lblPrecio.Name = "lblPrecio";
            // 
            // lblNoPaginas
            // 
            resources.ApplyResources(this.lblNoPaginas, "lblNoPaginas");
            this.lblNoPaginas.Name = "lblNoPaginas";
            // 
            // btnAbrirFotografia
            // 
            resources.ApplyResources(this.btnAbrirFotografia, "btnAbrirFotografia");
            this.btnAbrirFotografia.Name = "btnAbrirFotografia";
            this.btnAbrirFotografia.UseVisualStyleBackColor = true;
            this.btnAbrirFotografia.Click += new System.EventHandler(this.btnAbrirFotografia_Click);
            // 
            // picFotografiaNovela
            // 
            this.picFotografiaNovela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotografiaNovela.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.picFotografiaNovela, "picFotografiaNovela");
            this.picFotografiaNovela.Name = "picFotografiaNovela";
            this.picFotografiaNovela.TabStop = false;
            // 
            // txtNumeroDePaginas
            // 
            resources.ApplyResources(this.txtNumeroDePaginas, "txtNumeroDePaginas");
            this.txtNumeroDePaginas.Name = "txtNumeroDePaginas";
            // 
            // btnAgregarNovela
            // 
            resources.ApplyResources(this.btnAgregarNovela, "btnAgregarNovela");
            this.btnAgregarNovela.Name = "btnAgregarNovela";
            this.btnAgregarNovela.UseVisualStyleBackColor = true;
            this.btnAgregarNovela.Click += new System.EventHandler(this.btnAgregarNovela_Click);
            // 
            // txtEditorial
            // 
            resources.ApplyResources(this.txtEditorial, "txtEditorial");
            this.txtEditorial.Name = "txtEditorial";
            // 
            // txtAutor
            // 
            resources.ApplyResources(this.txtAutor, "txtAutor");
            this.txtAutor.Name = "txtAutor";
            // 
            // txtRutaFotografia
            // 
            resources.ApplyResources(this.txtRutaFotografia, "txtRutaFotografia");
            this.txtRutaFotografia.Name = "txtRutaFotografia";
            this.txtRutaFotografia.ReadOnly = true;
            // 
            // chkTieneVersionDigital
            // 
            resources.ApplyResources(this.chkTieneVersionDigital, "chkTieneVersionDigital");
            this.chkTieneVersionDigital.Name = "chkTieneVersionDigital";
            this.chkTieneVersionDigital.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDePublicacion
            // 
            resources.ApplyResources(this.dtpFechaDePublicacion, "dtpFechaDePublicacion");
            this.dtpFechaDePublicacion.Name = "dtpFechaDePublicacion";
            // 
            // cboClasificacionEdad
            // 
            this.cboClasificacionEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacionEdad.FormattingEnabled = true;
            this.cboClasificacionEdad.Items.AddRange(new object[] {
            resources.GetString("cboClasificacionEdad.Items"),
            resources.GetString("cboClasificacionEdad.Items1"),
            resources.GetString("cboClasificacionEdad.Items2"),
            resources.GetString("cboClasificacionEdad.Items3"),
            resources.GetString("cboClasificacionEdad.Items4"),
            resources.GetString("cboClasificacionEdad.Items5")});
            resources.ApplyResources(this.cboClasificacionEdad, "cboClasificacionEdad");
            this.cboClasificacionEdad.Name = "cboClasificacionEdad";
            // 
            // txtTitulo
            // 
            resources.ApplyResources(this.txtTitulo, "txtTitulo");
            this.txtTitulo.Name = "txtTitulo";
            // 
            // txtPrecio
            // 
            resources.ApplyResources(this.txtPrecio, "txtPrecio");
            this.txtPrecio.Name = "txtPrecio";
            // 
            // btnEliminarTodasLasNovelas
            // 
            this.btnEliminarTodasLasNovelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTodasLasNovelas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnEliminarTodasLasNovelas, "btnEliminarTodasLasNovelas");
            this.btnEliminarTodasLasNovelas.Name = "btnEliminarTodasLasNovelas";
            this.btnEliminarTodasLasNovelas.UseVisualStyleBackColor = false;
            this.btnEliminarTodasLasNovelas.Click += new System.EventHandler(this.btnEliminarTodasLasNovelas_Click);
            // 
            // btnBorrarNovela
            // 
            this.btnBorrarNovela.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrarNovela.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnBorrarNovela, "btnBorrarNovela");
            this.btnBorrarNovela.Name = "btnBorrarNovela";
            this.btnBorrarNovela.UseVisualStyleBackColor = false;
            this.btnBorrarNovela.Click += new System.EventHandler(this.btnBorrarNovela_Click);
            // 
            // dtgNovelas
            // 
            this.dtgNovelas.AllowUserToAddRows = false;
            this.dtgNovelas.AllowUserToDeleteRows = false;
            this.dtgNovelas.AllowUserToResizeColumns = false;
            this.dtgNovelas.AllowUserToResizeRows = false;
            this.dtgNovelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNovelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgNovelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNovelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnNumeroDePaginas,
            this.clmnPrecio,
            this.clmnTitulo,
            this.clmnClasificacionDeEdad,
            this.clmnFechaDePublicacion,
            this.clmnTieneVersionDigital,
            this.clmnRutaDeFotografia,
            this.clmnAutor,
            this.clmnEditorial,
            this.clmnTipoDeEdicion});
            resources.ApplyResources(this.dtgNovelas, "dtgNovelas");
            this.dtgNovelas.MultiSelect = false;
            this.dtgNovelas.Name = "dtgNovelas";
            this.dtgNovelas.ReadOnly = true;
            this.dtgNovelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNovelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNovelas_CellClick);
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // btnCantidadDeNovelas
            // 
            resources.ApplyResources(this.btnCantidadDeNovelas, "btnCantidadDeNovelas");
            this.btnCantidadDeNovelas.Name = "btnCantidadDeNovelas";
            this.btnCantidadDeNovelas.UseVisualStyleBackColor = true;
            this.btnCantidadDeNovelas.Click += new System.EventHandler(this.btnCantidadDeNovelas_Click);
            // 
            // lblInformacionOrdenamientoNovelas
            // 
            resources.ApplyResources(this.lblInformacionOrdenamientoNovelas, "lblInformacionOrdenamientoNovelas");
            this.lblInformacionOrdenamientoNovelas.Name = "lblInformacionOrdenamientoNovelas";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabInsertarDatos);
            this.tabPrincipal.Controls.Add(this.tabBuscar);
            resources.ApplyResources(this.tabPrincipal, "tabPrincipal");
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            // 
            // tabInsertarDatos
            // 
            this.tabInsertarDatos.Controls.Add(this.grbNovelasLiterariasDatos);
            resources.ApplyResources(this.tabInsertarDatos, "tabInsertarDatos");
            this.tabInsertarDatos.Name = "tabInsertarDatos";
            this.tabInsertarDatos.UseVisualStyleBackColor = true;
            // 
            // tabBuscar
            // 
            this.tabBuscar.Controls.Add(this.lblQueBuscas);
            this.tabBuscar.Controls.Add(this.txtBuscarNovela);
            this.tabBuscar.Controls.Add(this.btnBuscarNovela);
            resources.ApplyResources(this.tabBuscar, "tabBuscar");
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNovela
            // 
            resources.ApplyResources(this.btnBuscarNovela, "btnBuscarNovela");
            this.btnBuscarNovela.Name = "btnBuscarNovela";
            this.btnBuscarNovela.UseVisualStyleBackColor = true;
            this.btnBuscarNovela.Click += new System.EventHandler(this.btnBuscarNovela_Click);
            // 
            // txtBuscarNovela
            // 
            resources.ApplyResources(this.txtBuscarNovela, "txtBuscarNovela");
            this.txtBuscarNovela.Name = "txtBuscarNovela";
            // 
            // lblQueBuscas
            // 
            resources.ApplyResources(this.lblQueBuscas, "lblQueBuscas");
            this.lblQueBuscas.Name = "lblQueBuscas";
            // 
            // clmnID
            // 
            resources.ApplyResources(this.clmnID, "clmnID");
            this.clmnID.Name = "clmnID";
            this.clmnID.ReadOnly = true;
            // 
            // clmnNumeroDePaginas
            // 
            resources.ApplyResources(this.clmnNumeroDePaginas, "clmnNumeroDePaginas");
            this.clmnNumeroDePaginas.Name = "clmnNumeroDePaginas";
            this.clmnNumeroDePaginas.ReadOnly = true;
            // 
            // clmnPrecio
            // 
            dataGridViewCellStyle2.Format = "C";
            this.clmnPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.clmnPrecio, "clmnPrecio");
            this.clmnPrecio.Name = "clmnPrecio";
            this.clmnPrecio.ReadOnly = true;
            // 
            // clmnTitulo
            // 
            resources.ApplyResources(this.clmnTitulo, "clmnTitulo");
            this.clmnTitulo.Name = "clmnTitulo";
            this.clmnTitulo.ReadOnly = true;
            // 
            // clmnClasificacionDeEdad
            // 
            resources.ApplyResources(this.clmnClasificacionDeEdad, "clmnClasificacionDeEdad");
            this.clmnClasificacionDeEdad.Name = "clmnClasificacionDeEdad";
            this.clmnClasificacionDeEdad.ReadOnly = true;
            // 
            // clmnFechaDePublicacion
            // 
            resources.ApplyResources(this.clmnFechaDePublicacion, "clmnFechaDePublicacion");
            this.clmnFechaDePublicacion.Name = "clmnFechaDePublicacion";
            this.clmnFechaDePublicacion.ReadOnly = true;
            // 
            // clmnTieneVersionDigital
            // 
            resources.ApplyResources(this.clmnTieneVersionDigital, "clmnTieneVersionDigital");
            this.clmnTieneVersionDigital.Name = "clmnTieneVersionDigital";
            this.clmnTieneVersionDigital.ReadOnly = true;
            // 
            // clmnRutaDeFotografia
            // 
            resources.ApplyResources(this.clmnRutaDeFotografia, "clmnRutaDeFotografia");
            this.clmnRutaDeFotografia.Name = "clmnRutaDeFotografia";
            this.clmnRutaDeFotografia.ReadOnly = true;
            this.clmnRutaDeFotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnRutaDeFotografia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnAutor
            // 
            resources.ApplyResources(this.clmnAutor, "clmnAutor");
            this.clmnAutor.Name = "clmnAutor";
            this.clmnAutor.ReadOnly = true;
            // 
            // clmnEditorial
            // 
            resources.ApplyResources(this.clmnEditorial, "clmnEditorial");
            this.clmnEditorial.Name = "clmnEditorial";
            this.clmnEditorial.ReadOnly = true;
            // 
            // clmnTipoDeEdicion
            // 
            resources.ApplyResources(this.clmnTipoDeEdicion, "clmnTipoDeEdicion");
            this.clmnTipoDeEdicion.Name = "clmnTipoDeEdicion";
            this.clmnTipoDeEdicion.ReadOnly = true;
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.lblInformacionOrdenamientoNovelas);
            this.Controls.Add(this.btnCantidadDeNovelas);
            this.Controls.Add(this.btnBorrarNovela);
            this.Controls.Add(this.btnEliminarTodasLasNovelas);
            this.Controls.Add(this.dtgNovelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbNovelasLiterariasDatos.ResumeLayout(false);
            this.grbNovelasLiterariasDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografiaNovela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNovelas)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabInsertarDatos.ResumeLayout(false);
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNovelasLiterariasDatos;
        private System.Windows.Forms.Button btnAgregarNovela;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtRutaFotografia;
        private System.Windows.Forms.CheckBox chkTieneVersionDigital;
        private System.Windows.Forms.DateTimePicker dtpFechaDePublicacion;
        private System.Windows.Forms.ComboBox cboClasificacionEdad;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dtgNovelas;
        private System.Windows.Forms.TextBox txtNumeroDePaginas;
        private System.Windows.Forms.PictureBox picFotografiaNovela;
        private System.Windows.Forms.Button btnAbrirFotografia;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblRutaFotografia;
        private System.Windows.Forms.Label lblFechaDePublicacion;
        private System.Windows.Forms.Label lblClasificacionDeEdad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNoPaginas;
        private System.Windows.Forms.RadioButton radEdicionDeluxe;
        private System.Windows.Forms.RadioButton radEdicionNormal;
        private System.Windows.Forms.RadioButton radEdicionEspecial;
        private System.Windows.Forms.Button btnBorrarNovela;
        private System.Windows.Forms.Button btnEliminarTodasLasNovelas;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnCantidadDeNovelas;
        private System.Windows.Forms.Label lblInformacionOrdenamientoNovelas;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabInsertarDatos;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button btnBuscarNovela;
        private System.Windows.Forms.Label lblQueBuscas;
        private System.Windows.Forms.TextBox txtBuscarNovela;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumeroDePaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnClasificacionDeEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFechaDePublicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnTieneVersionDigital;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRutaDeFotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTipoDeEdicion;
    }
}

