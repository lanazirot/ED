namespace Novelas_Literarias {
    partial class Inicio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.grbOpcionesInicio = new System.Windows.Forms.GroupBox();
            this.chkDesordenados = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.btnAbrirPrograma = new System.Windows.Forms.Button();
            this.grbOpcionesInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpcionesInicio
            // 
            this.grbOpcionesInicio.Controls.Add(this.chkDesordenados);
            this.grbOpcionesInicio.Controls.Add(this.chkDuplicados);
            this.grbOpcionesInicio.Location = new System.Drawing.Point(12, 12);
            this.grbOpcionesInicio.Name = "grbOpcionesInicio";
            this.grbOpcionesInicio.Size = new System.Drawing.Size(343, 114);
            this.grbOpcionesInicio.TabIndex = 0;
            this.grbOpcionesInicio.TabStop = false;
            this.grbOpcionesInicio.Text = "Configuracion de contenedor";
            // 
            // chkDesordenados
            // 
            this.chkDesordenados.AutoSize = true;
            this.chkDesordenados.Location = new System.Drawing.Point(109, 66);
            this.chkDesordenados.Name = "chkDesordenados";
            this.chkDesordenados.Size = new System.Drawing.Size(124, 17);
            this.chkDesordenados.TabIndex = 1;
            this.chkDesordenados.Text = "Datos desordenados";
            this.chkDesordenados.UseVisualStyleBackColor = true;
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(109, 43);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(114, 17);
            this.chkDuplicados.TabIndex = 0;
            this.chkDuplicados.Text = "Permitir duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPrograma
            // 
            this.btnAbrirPrograma.Location = new System.Drawing.Point(137, 135);
            this.btnAbrirPrograma.Name = "btnAbrirPrograma";
            this.btnAbrirPrograma.Size = new System.Drawing.Size(98, 23);
            this.btnAbrirPrograma.TabIndex = 1;
            this.btnAbrirPrograma.Text = "Continuar";
            this.btnAbrirPrograma.UseVisualStyleBackColor = true;
            this.btnAbrirPrograma.Click += new System.EventHandler(this.btnAbrirPrograma_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 170);
            this.Controls.Add(this.btnAbrirPrograma);
            this.Controls.Add(this.grbOpcionesInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novelas Literarias - Inicio";
            this.grbOpcionesInicio.ResumeLayout(false);
            this.grbOpcionesInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpcionesInicio;
        private System.Windows.Forms.CheckBox chkDesordenados;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.Button btnAbrirPrograma;
    }
}