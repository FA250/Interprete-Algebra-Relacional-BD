namespace InterpreteAlgebraRelacionalSQL
{
    partial class OtrasConsultas
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
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnRealizarConsulta = new System.Windows.Forms.Button();
            this.lblBDActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(190, 87);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(618, 104);
            this.txtTabla.TabIndex = 12;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.White;
            this.lblTabla.Location = new System.Drawing.Point(21, 87);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(130, 26);
            this.lblTabla.TabIndex = 11;
            this.lblTabla.Text = "Consulta SQL:";
            // 
            // btnRealizarConsulta
            // 
            this.btnRealizarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRealizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarConsulta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarConsulta.Location = new System.Drawing.Point(681, 236);
            this.btnRealizarConsulta.Name = "btnRealizarConsulta";
            this.btnRealizarConsulta.Size = new System.Drawing.Size(178, 38);
            this.btnRealizarConsulta.TabIndex = 10;
            this.btnRealizarConsulta.Text = "Realizar Consulta";
            this.btnRealizarConsulta.UseVisualStyleBackColor = false;
            // 
            // lblBDActual
            // 
            this.lblBDActual.AutoSize = true;
            this.lblBDActual.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(59)))));
            this.lblBDActual.Location = new System.Drawing.Point(203, 28);
            this.lblBDActual.Name = "lblBDActual";
            this.lblBDActual.Size = new System.Drawing.Size(87, 25);
            this.lblBDActual.TabIndex = 13;
            this.lblBDActual.Text = "Ninguna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Base de datos actual:";
            // 
            // OtrasConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(871, 286);
            this.Controls.Add(this.lblBDActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.btnRealizarConsulta);
            this.Name = "OtrasConsultas";
            this.Text = "Otras Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnRealizarConsulta;
        private System.Windows.Forms.Label lblBDActual;
        private System.Windows.Forms.Label label1;
    }
}