﻿namespace InterpreteAlgebraRelacionalSQL
{
    partial class frmIngreso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtBDNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(60, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngreso.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(195, 210);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(108, 38);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // txtBDNueva
            // 
            this.txtBDNueva.Location = new System.Drawing.Point(161, 152);
            this.txtBDNueva.Name = "txtBDNueva";
            this.txtBDNueva.Size = new System.Drawing.Size(142, 20);
            this.txtBDNueva.TabIndex = 7;
            this.txtBDNueva.Text = "bdproy1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base de datos:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DisplayMember = "Selección";
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbUsuario.Items.AddRange(new object[] {
            "dbaproy1",
            "usproy1"});
            this.cmbUsuario.Location = new System.Drawing.Point(161, 104);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(142, 21);
            this.cmbUsuario.TabIndex = 8;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(365, 280);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.txtBDNueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox txtBDNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuario;
    }
}

