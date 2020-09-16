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
            this.grbNovelasLiterariasDatos = new System.Windows.Forms.GroupBox();
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbNovelasLiterariasDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografiaNovela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNovelas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNovelasLiterariasDatos
            // 
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
            this.grbNovelasLiterariasDatos.Location = new System.Drawing.Point(12, 12);
            this.grbNovelasLiterariasDatos.Name = "grbNovelasLiterariasDatos";
            this.grbNovelasLiterariasDatos.Size = new System.Drawing.Size(830, 412);
            this.grbNovelasLiterariasDatos.TabIndex = 0;
            this.grbNovelasLiterariasDatos.TabStop = false;
            this.grbNovelasLiterariasDatos.Text = "Datos de la novela literaria";
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(6, 372);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(92, 26);
            this.btnLimpiarTodo.TabIndex = 24;
            this.btnLimpiarTodo.Text = "Limpiar campos";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // radEdicionDeluxe
            // 
            this.radEdicionDeluxe.AutoSize = true;
            this.radEdicionDeluxe.Location = new System.Drawing.Point(374, 287);
            this.radEdicionDeluxe.Name = "radEdicionDeluxe";
            this.radEdicionDeluxe.Size = new System.Drawing.Size(94, 17);
            this.radEdicionDeluxe.TabIndex = 23;
            this.radEdicionDeluxe.Text = "Edicion deluxe";
            this.radEdicionDeluxe.UseVisualStyleBackColor = true;
            // 
            // radEdicionNormal
            // 
            this.radEdicionNormal.AutoSize = true;
            this.radEdicionNormal.Checked = true;
            this.radEdicionNormal.Location = new System.Drawing.Point(166, 287);
            this.radEdicionNormal.Name = "radEdicionNormal";
            this.radEdicionNormal.Size = new System.Drawing.Size(94, 17);
            this.radEdicionNormal.TabIndex = 22;
            this.radEdicionNormal.TabStop = true;
            this.radEdicionNormal.Text = "Edicion normal";
            this.radEdicionNormal.UseVisualStyleBackColor = true;
            // 
            // radEdicionEspecial
            // 
            this.radEdicionEspecial.AutoSize = true;
            this.radEdicionEspecial.Location = new System.Drawing.Point(266, 287);
            this.radEdicionEspecial.Name = "radEdicionEspecial";
            this.radEdicionEspecial.Size = new System.Drawing.Size(102, 17);
            this.radEdicionEspecial.TabIndex = 21;
            this.radEdicionEspecial.Text = "Edicion especial";
            this.radEdicionEspecial.UseVisualStyleBackColor = true;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(116, 256);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 20;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(128, 226);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 19;
            this.lblAutor.Text = "Autor";
            // 
            // lblRutaFotografia
            // 
            this.lblRutaFotografia.AutoSize = true;
            this.lblRutaFotografia.Location = new System.Drawing.Point(57, 200);
            this.lblRutaFotografia.Name = "lblRutaFotografia";
            this.lblRutaFotografia.Size = new System.Drawing.Size(103, 13);
            this.lblRutaFotografia.TabIndex = 18;
            this.lblRutaFotografia.Text = "Ruta de la fotografia";
            // 
            // lblFechaDePublicacion
            // 
            this.lblFechaDePublicacion.AutoSize = true;
            this.lblFechaDePublicacion.Location = new System.Drawing.Point(51, 154);
            this.lblFechaDePublicacion.Name = "lblFechaDePublicacion";
            this.lblFechaDePublicacion.Size = new System.Drawing.Size(109, 13);
            this.lblFechaDePublicacion.TabIndex = 17;
            this.lblFechaDePublicacion.Text = "Fecha de publicacion";
            // 
            // lblClasificacionDeEdad
            // 
            this.lblClasificacionDeEdad.AutoSize = true;
            this.lblClasificacionDeEdad.Location = new System.Drawing.Point(52, 124);
            this.lblClasificacionDeEdad.Name = "lblClasificacionDeEdad";
            this.lblClasificacionDeEdad.Size = new System.Drawing.Size(108, 13);
            this.lblClasificacionDeEdad.TabIndex = 16;
            this.lblClasificacionDeEdad.Text = "Clasificacion de edad";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(127, 98);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(123, 69);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNoPaginas
            // 
            this.lblNoPaginas.AutoSize = true;
            this.lblNoPaginas.Location = new System.Drawing.Point(61, 43);
            this.lblNoPaginas.Name = "lblNoPaginas";
            this.lblNoPaginas.Size = new System.Drawing.Size(99, 13);
            this.lblNoPaginas.TabIndex = 13;
            this.lblNoPaginas.Text = "Numero de paginas";
            // 
            // btnAbrirFotografia
            // 
            this.btnAbrirFotografia.Location = new System.Drawing.Point(433, 195);
            this.btnAbrirFotografia.Name = "btnAbrirFotografia";
            this.btnAbrirFotografia.Size = new System.Drawing.Size(65, 23);
            this.btnAbrirFotografia.TabIndex = 12;
            this.btnAbrirFotografia.Text = "&Elegir foto";
            this.btnAbrirFotografia.UseVisualStyleBackColor = true;
            this.btnAbrirFotografia.Click += new System.EventHandler(this.btnAbrirFotografia_Click);
            // 
            // picFotografiaNovela
            // 
            this.picFotografiaNovela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotografiaNovela.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picFotografiaNovela.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picFotografiaNovela.ErrorImage")));
            this.picFotografiaNovela.Image = ((System.Drawing.Image)(resources.GetObject("picFotografiaNovela.Image")));
            this.picFotografiaNovela.InitialImage = null;
            this.picFotografiaNovela.Location = new System.Drawing.Point(530, 19);
            this.picFotografiaNovela.Name = "picFotografiaNovela";
            this.picFotografiaNovela.Size = new System.Drawing.Size(278, 379);
            this.picFotografiaNovela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotografiaNovela.TabIndex = 11;
            this.picFotografiaNovela.TabStop = false;
            this.picFotografiaNovela.WaitOnLoad = true;
            // 
            // txtNumeroDePaginas
            // 
            this.txtNumeroDePaginas.Location = new System.Drawing.Point(166, 43);
            this.txtNumeroDePaginas.Name = "txtNumeroDePaginas";
            this.txtNumeroDePaginas.Size = new System.Drawing.Size(55, 20);
            this.txtNumeroDePaginas.TabIndex = 1;
            // 
            // btnAgregarNovela
            // 
            this.btnAgregarNovela.Location = new System.Drawing.Point(349, 323);
            this.btnAgregarNovela.Name = "btnAgregarNovela";
            this.btnAgregarNovela.Size = new System.Drawing.Size(149, 43);
            this.btnAgregarNovela.TabIndex = 10;
            this.btnAgregarNovela.Text = "&Agregar novela";
            this.btnAgregarNovela.UseVisualStyleBackColor = true;
            this.btnAgregarNovela.Click += new System.EventHandler(this.btnAgregarNovela_Click);
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(166, 249);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(332, 20);
            this.txtEditorial.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(166, 223);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(332, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txtRutaFotografia
            // 
            this.txtRutaFotografia.Location = new System.Drawing.Point(166, 197);
            this.txtRutaFotografia.Name = "txtRutaFotografia";
            this.txtRutaFotografia.ReadOnly = true;
            this.txtRutaFotografia.Size = new System.Drawing.Size(261, 20);
            this.txtRutaFotografia.TabIndex = 7;
            // 
            // chkTieneVersionDigital
            // 
            this.chkTieneVersionDigital.AutoSize = true;
            this.chkTieneVersionDigital.Location = new System.Drawing.Point(166, 174);
            this.chkTieneVersionDigital.Name = "chkTieneVersionDigital";
            this.chkTieneVersionDigital.Size = new System.Drawing.Size(120, 17);
            this.chkTieneVersionDigital.TabIndex = 6;
            this.chkTieneVersionDigital.Text = "&Tiene versión digital";
            this.chkTieneVersionDigital.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDePublicacion
            // 
            this.dtpFechaDePublicacion.Location = new System.Drawing.Point(166, 148);
            this.dtpFechaDePublicacion.Name = "dtpFechaDePublicacion";
            this.dtpFechaDePublicacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDePublicacion.Size = new System.Drawing.Size(261, 20);
            this.dtpFechaDePublicacion.TabIndex = 5;
            // 
            // cboClasificacionEdad
            // 
            this.cboClasificacionEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacionEdad.FormattingEnabled = true;
            this.cboClasificacionEdad.Items.AddRange(new object[] {
            "E",
            "M",
            "Y",
            "C",
            "B",
            "O"});
            this.cboClasificacionEdad.Location = new System.Drawing.Point(166, 121);
            this.cboClasificacionEdad.Name = "cboClasificacionEdad";
            this.cboClasificacionEdad.Size = new System.Drawing.Size(95, 21);
            this.cboClasificacionEdad.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(166, 95);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(332, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(166, 69);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(55, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // btnEliminarTodasLasNovelas
            // 
            this.btnEliminarTodasLasNovelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTodasLasNovelas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarTodasLasNovelas.Location = new System.Drawing.Point(614, 750);
            this.btnEliminarTodasLasNovelas.Name = "btnEliminarTodasLasNovelas";
            this.btnEliminarTodasLasNovelas.Size = new System.Drawing.Size(228, 41);
            this.btnEliminarTodasLasNovelas.TabIndex = 25;
            this.btnEliminarTodasLasNovelas.Text = "Eliminar todas las novelas";
            this.btnEliminarTodasLasNovelas.UseVisualStyleBackColor = false;
            this.btnEliminarTodasLasNovelas.Click += new System.EventHandler(this.btnEliminarTodasLasNovelas_Click);
            // 
            // btnBorrarNovela
            // 
            this.btnBorrarNovela.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrarNovela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrarNovela.Location = new System.Drawing.Point(614, 707);
            this.btnBorrarNovela.Name = "btnBorrarNovela";
            this.btnBorrarNovela.Size = new System.Drawing.Size(230, 37);
            this.btnBorrarNovela.TabIndex = 24;
            this.btnBorrarNovela.Text = "&Borrar novela seleccionada";
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
            this.dtgNovelas.Location = new System.Drawing.Point(12, 458);
            this.dtgNovelas.Name = "dtgNovelas";
            this.dtgNovelas.ReadOnly = true;
            this.dtgNovelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNovelas.Size = new System.Drawing.Size(830, 226);
            this.dtgNovelas.TabIndex = 1;
            this.dtgNovelas.Click += new System.EventHandler(this.dtgNovelas_Click);
            // 
            // clmnNumeroDePaginas
            // 
            this.clmnNumeroDePaginas.HeaderText = "Numero de paginas";
            this.clmnNumeroDePaginas.Name = "clmnNumeroDePaginas";
            this.clmnNumeroDePaginas.ReadOnly = true;
            // 
            // clmnPrecio
            // 
            this.clmnPrecio.HeaderText = "Precio";
            this.clmnPrecio.Name = "clmnPrecio";
            this.clmnPrecio.ReadOnly = true;
            // 
            // clmnTitulo
            // 
            this.clmnTitulo.HeaderText = "Titulo";
            this.clmnTitulo.Name = "clmnTitulo";
            this.clmnTitulo.ReadOnly = true;
            // 
            // clmnClasificacionDeEdad
            // 
            this.clmnClasificacionDeEdad.HeaderText = "Clasificacion de edad";
            this.clmnClasificacionDeEdad.Name = "clmnClasificacionDeEdad";
            this.clmnClasificacionDeEdad.ReadOnly = true;
            // 
            // clmnFechaDePublicacion
            // 
            this.clmnFechaDePublicacion.HeaderText = "Fecha de publicacion";
            this.clmnFechaDePublicacion.Name = "clmnFechaDePublicacion";
            this.clmnFechaDePublicacion.ReadOnly = true;
            // 
            // clmnTieneVersionDigital
            // 
            this.clmnTieneVersionDigital.HeaderText = "Tiene version digital";
            this.clmnTieneVersionDigital.Name = "clmnTieneVersionDigital";
            this.clmnTieneVersionDigital.ReadOnly = true;
            // 
            // clmnRutaDeFotografia
            // 
            this.clmnRutaDeFotografia.HeaderText = "Ruta de la fotografia";
            this.clmnRutaDeFotografia.Name = "clmnRutaDeFotografia";
            this.clmnRutaDeFotografia.ReadOnly = true;
            this.clmnRutaDeFotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnRutaDeFotografia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnAutor
            // 
            this.clmnAutor.HeaderText = "Autor";
            this.clmnAutor.Name = "clmnAutor";
            this.clmnAutor.ReadOnly = true;
            // 
            // clmnEditorial
            // 
            this.clmnEditorial.HeaderText = "Editorial";
            this.clmnEditorial.Name = "clmnEditorial";
            this.clmnEditorial.ReadOnly = true;
            // 
            // clmnTipoDeEdicion
            // 
            this.clmnTipoDeEdicion.HeaderText = "Tipo de edicion";
            this.clmnTipoDeEdicion.Name = "clmnTipoDeEdicion";
            this.clmnTipoDeEdicion.ReadOnly = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 803);
            this.Controls.Add(this.btnBorrarNovela);
            this.Controls.Add(this.btnEliminarTodasLasNovelas);
            this.Controls.Add(this.dtgNovelas);
            this.Controls.Add(this.grbNovelasLiterariasDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novelas Literarias";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbNovelasLiterariasDatos.ResumeLayout(false);
            this.grbNovelasLiterariasDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografiaNovela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNovelas)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnBorrarNovela;
        private System.Windows.Forms.Button btnEliminarTodasLasNovelas;
        private System.Windows.Forms.Button btnLimpiarTodo;
    }
}

