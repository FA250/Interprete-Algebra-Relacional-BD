namespace InterpreteAlgebraRelacionalSQL
{
    partial class frmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBDNueva = new System.Windows.Forms.TextBox();
            this.btnActualizarBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBDActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.btnVerTablas = new System.Windows.Forms.Button();
            this.btnTablasTemporales = new System.Windows.Forms.Button();
            this.btnReferenciaCruzada = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(751, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base de datos:";
            // 
            // txtBDNueva
            // 
            this.txtBDNueva.Location = new System.Drawing.Point(139, 68);
            this.txtBDNueva.Name = "txtBDNueva";
            this.txtBDNueva.Size = new System.Drawing.Size(142, 20);
            this.txtBDNueva.TabIndex = 5;
            // 
            // btnActualizarBD
            // 
            this.btnActualizarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnActualizarBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarBD.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBD.Location = new System.Drawing.Point(287, 62);
            this.btnActualizarBD.Name = "btnActualizarBD";
            this.btnActualizarBD.Size = new System.Drawing.Size(91, 32);
            this.btnActualizarBD.TabIndex = 6;
            this.btnActualizarBD.Text = "Actualizar";
            this.btnActualizarBD.UseVisualStyleBackColor = false;
            this.btnActualizarBD.Click += new System.EventHandler(this.btnActualizarBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base de datos actual:";
            // 
            // lblBDActual
            // 
            this.lblBDActual.AutoSize = true;
            this.lblBDActual.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDActual.ForeColor = System.Drawing.Color.Red;
            this.lblBDActual.Location = new System.Drawing.Point(194, 23);
            this.lblBDActual.Name = "lblBDActual";
            this.lblBDActual.Size = new System.Drawing.Size(87, 25);
            this.lblBDActual.TabIndex = 4;
            this.lblBDActual.Text = "Ninguna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operación:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DisplayMember = "Selección";
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Selección",
            "Proyección generalizada",
            "Unión",
            "Diferencia de conjuntos",
            "Producto cartesiano",
            "Intersección",
            "División",
            "Renombrar relación y atributos",
            "Concatenación (join)",
            "Concatenación natural",
            "Agregación",
            "Agrupación"});
            this.cmbOperacion.Location = new System.Drawing.Point(515, 73);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(184, 21);
            this.cmbOperacion.TabIndex = 7;
            // 
            // btnOperacion
            // 
            this.btnOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperacion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacion.Location = new System.Drawing.Point(682, 542);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(177, 38);
            this.btnOperacion.TabIndex = 8;
            this.btnOperacion.Text = "Realizar operación";
            this.btnOperacion.UseVisualStyleBackColor = false;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnVerTablas
            // 
            this.btnVerTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnVerTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTablas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTablas.Location = new System.Drawing.Point(719, 62);
            this.btnVerTablas.Name = "btnVerTablas";
            this.btnVerTablas.Size = new System.Drawing.Size(140, 38);
            this.btnVerTablas.TabIndex = 9;
            this.btnVerTablas.Text = "Tablas BD";
            this.btnVerTablas.UseVisualStyleBackColor = false;
            this.btnVerTablas.Click += new System.EventHandler(this.btnVerTablas_Click);
            // 
            // btnTablasTemporales
            // 
            this.btnTablasTemporales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTablasTemporales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTablasTemporales.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablasTemporales.Location = new System.Drawing.Point(719, 106);
            this.btnTablasTemporales.Name = "btnTablasTemporales";
            this.btnTablasTemporales.Size = new System.Drawing.Size(140, 61);
            this.btnTablasTemporales.TabIndex = 9;
            this.btnTablasTemporales.Text = "Tablas Temporales";
            this.btnTablasTemporales.UseVisualStyleBackColor = false;
            this.btnTablasTemporales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReferenciaCruzada
            // 
            this.btnReferenciaCruzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReferenciaCruzada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReferenciaCruzada.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferenciaCruzada.Location = new System.Drawing.Point(719, 173);
            this.btnReferenciaCruzada.Name = "btnReferenciaCruzada";
            this.btnReferenciaCruzada.Size = new System.Drawing.Size(140, 61);
            this.btnReferenciaCruzada.TabIndex = 9;
            this.btnReferenciaCruzada.Text = "Referencia Cruzada";
            this.btnReferenciaCruzada.UseVisualStyleBackColor = false;
            this.btnReferenciaCruzada.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.btnAcercaDe.BackgroundImage = global::InterpreteAlgebraRelacionalSQL.Properties.Resources.InformacionBlanco;
            this.btnAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.Red;
            this.btnAcercaDe.Location = new System.Drawing.Point(659, 12);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(40, 40);
            this.btnAcercaDe.TabIndex = 3;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.btnAyuda.BackgroundImage = global::InterpreteAlgebraRelacionalSQL.Properties.Resources.AyudaBlanco;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.btnAyuda.Location = new System.Drawing.Point(705, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.btnReferenciaCruzada);
            this.Controls.Add(this.btnTablasTemporales);
            this.Controls.Add(this.btnVerTablas);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnActualizarBD);
            this.Controls.Add(this.txtBDNueva);
            this.Controls.Add(this.lblBDActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultas_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBDNueva;
        private System.Windows.Forms.Button btnActualizarBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBDActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnVerTablas;
        private System.Windows.Forms.Button btnTablasTemporales;
        private System.Windows.Forms.Button btnReferenciaCruzada;
    }
}