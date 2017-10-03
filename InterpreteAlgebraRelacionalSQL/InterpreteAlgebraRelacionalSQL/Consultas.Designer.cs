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
            this.lblTabla = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.lblPredicado = new System.Windows.Forms.Label();
            this.txtPredicado = new System.Windows.Forms.TextBox();
            this.lblTabla2 = new System.Windows.Forms.Label();
            this.txtTabla2 = new System.Windows.Forms.TextBox();
            this.lblOpAgregacion = new System.Windows.Forms.Label();
            this.lblAgrupaciones = new System.Windows.Forms.Label();
            this.txtAgrupaciones = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(15, 70);
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
            this.cmbOperacion.Location = new System.Drawing.Point(125, 74);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(184, 21);
            this.cmbOperacion.TabIndex = 7;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // btnOperacion
            // 
            this.btnOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperacion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacion.Location = new System.Drawing.Point(719, 290);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(140, 68);
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
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.White;
            this.lblTabla.Location = new System.Drawing.Point(12, 154);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(62, 26);
            this.lblTabla.TabIndex = 4;
            this.lblTabla.Text = "Tabla:";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(139, 158);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(189, 20);
            this.txtTabla.TabIndex = 5;
            // 
            // lblPredicado
            // 
            this.lblPredicado.AutoSize = true;
            this.lblPredicado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredicado.ForeColor = System.Drawing.Color.White;
            this.lblPredicado.Location = new System.Drawing.Point(12, 192);
            this.lblPredicado.Name = "lblPredicado";
            this.lblPredicado.Size = new System.Drawing.Size(99, 26);
            this.lblPredicado.TabIndex = 4;
            this.lblPredicado.Text = "Predicado:";
            // 
            // txtPredicado
            // 
            this.txtPredicado.Location = new System.Drawing.Point(139, 196);
            this.txtPredicado.Multiline = true;
            this.txtPredicado.Name = "txtPredicado";
            this.txtPredicado.Size = new System.Drawing.Size(546, 73);
            this.txtPredicado.TabIndex = 5;
            // 
            // lblTabla2
            // 
            this.lblTabla2.AutoSize = true;
            this.lblTabla2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla2.ForeColor = System.Drawing.Color.White;
            this.lblTabla2.Location = new System.Drawing.Point(369, 154);
            this.lblTabla2.Name = "lblTabla2";
            this.lblTabla2.Size = new System.Drawing.Size(77, 26);
            this.lblTabla2.TabIndex = 4;
            this.lblTabla2.Text = "Tabla 2:";
            this.lblTabla2.Visible = false;
            // 
            // txtTabla2
            // 
            this.txtTabla2.Location = new System.Drawing.Point(496, 158);
            this.txtTabla2.Name = "txtTabla2";
            this.txtTabla2.Size = new System.Drawing.Size(189, 20);
            this.txtTabla2.TabIndex = 5;
            this.txtTabla2.Visible = false;
            // 
            // lblOpAgregacion
            // 
            this.lblOpAgregacion.AutoSize = true;
            this.lblOpAgregacion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpAgregacion.ForeColor = System.Drawing.Color.White;
            this.lblOpAgregacion.Location = new System.Drawing.Point(7, 190);
            this.lblOpAgregacion.Name = "lblOpAgregacion";
            this.lblOpAgregacion.Size = new System.Drawing.Size(135, 26);
            this.lblOpAgregacion.TabIndex = 10;
            this.lblOpAgregacion.Text = "Op agregación:";
            this.lblOpAgregacion.Visible = false;
            // 
            // lblAgrupaciones
            // 
            this.lblAgrupaciones.AutoSize = true;
            this.lblAgrupaciones.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrupaciones.ForeColor = System.Drawing.Color.White;
            this.lblAgrupaciones.Location = new System.Drawing.Point(7, 279);
            this.lblAgrupaciones.Name = "lblAgrupaciones";
            this.lblAgrupaciones.Size = new System.Drawing.Size(131, 26);
            this.lblAgrupaciones.TabIndex = 10;
            this.lblAgrupaciones.Text = "Agrupaciones:";
            this.lblAgrupaciones.Visible = false;
            // 
            // txtAgrupaciones
            // 
            this.txtAgrupaciones.Location = new System.Drawing.Point(139, 285);
            this.txtAgrupaciones.Multiline = true;
            this.txtAgrupaciones.Name = "txtAgrupaciones";
            this.txtAgrupaciones.Size = new System.Drawing.Size(546, 73);
            this.txtAgrupaciones.TabIndex = 5;
            this.txtAgrupaciones.Visible = false;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(871, 390);
            this.Controls.Add(this.txtAgrupaciones);
            this.Controls.Add(this.lblAgrupaciones);
            this.Controls.Add(this.txtPredicado);
            this.Controls.Add(this.lblOpAgregacion);
            this.Controls.Add(this.btnReferenciaCruzada);
            this.Controls.Add(this.btnTablasTemporales);
            this.Controls.Add(this.btnVerTablas);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.txtTabla2);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.lblBDActual);
            this.Controls.Add(this.lblPredicado);
            this.Controls.Add(this.lblTabla2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultas_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBDActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnVerTablas;
        private System.Windows.Forms.Button btnTablasTemporales;
        private System.Windows.Forms.Button btnReferenciaCruzada;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label lblPredicado;
        private System.Windows.Forms.TextBox txtPredicado;
        private System.Windows.Forms.Label lblTabla2;
        private System.Windows.Forms.TextBox txtTabla2;
        private System.Windows.Forms.Label lblOpAgregacion;
        private System.Windows.Forms.Label lblAgrupaciones;
        private System.Windows.Forms.TextBox txtAgrupaciones;
    }
}