namespace InterpreteAlgebraRelacionalSQL
{
    partial class frmTablaResultado
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnGuardarTabla = new System.Windows.Forms.Button();
            this.lblAlgebraLineal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSQL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnSQL = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.pnSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 177);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(999, 499);
            this.dgvResultado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla resultante";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(96, 32);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(189, 20);
            this.txtNombreTabla.TabIndex = 7;
            this.txtNombreTabla.TextChanged += new System.EventHandler(this.txtNombreTabla_TextChanged);
            this.txtNombreTabla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTabla_KeyPress);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.White;
            this.lblTabla.Location = new System.Drawing.Point(12, 28);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(87, 26);
            this.lblTabla.TabIndex = 6;
            this.lblTabla.Text = "Nombre:";
            // 
            // btnGuardarTabla
            // 
            this.btnGuardarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGuardarTabla.Enabled = false;
            this.btnGuardarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarTabla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTabla.Location = new System.Drawing.Point(871, 14);
            this.btnGuardarTabla.Name = "btnGuardarTabla";
            this.btnGuardarTabla.Size = new System.Drawing.Size(140, 38);
            this.btnGuardarTabla.TabIndex = 10;
            this.btnGuardarTabla.Text = "Guardar Tabla";
            this.btnGuardarTabla.UseVisualStyleBackColor = false;
            this.btnGuardarTabla.Click += new System.EventHandler(this.btnGuardarTabla_Click_1);
            // 
            // lblAlgebraLineal
            // 
            this.lblAlgebraLineal.AutoSize = true;
            this.lblAlgebraLineal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgebraLineal.ForeColor = System.Drawing.Color.White;
            this.lblAlgebraLineal.Location = new System.Drawing.Point(150, 67);
            this.lblAlgebraLineal.Name = "lblAlgebraLineal";
            this.lblAlgebraLineal.Size = new System.Drawing.Size(94, 26);
            this.lblAlgebraLineal.TabIndex = 6;
            this.lblAlgebraLineal.Text = "Predicado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algebra lineal:";
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQL.ForeColor = System.Drawing.Color.White;
            this.lblSQL.Location = new System.Drawing.Point(11, 0);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(94, 26);
            this.lblSQL.TabIndex = 6;
            this.lblSQL.Text = "Predicado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "SQL:";
            // 
            // pnSQL
            // 
            this.pnSQL.AutoScroll = true;
            this.pnSQL.Controls.Add(this.lblSQL);
            this.pnSQL.Location = new System.Drawing.Point(139, 96);
            this.pnSQL.Name = "pnSQL";
            this.pnSQL.Size = new System.Drawing.Size(872, 75);
            this.pnSQL.TabIndex = 11;
            // 
            // frmTablaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1023, 688);
            this.Controls.Add(this.pnSQL);
            this.Controls.Add(this.btnGuardarTabla);
            this.Controls.Add(this.txtNombreTabla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAlgebraLineal);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmTablaResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaResultado";
            this.Load += new System.EventHandler(this.frmTablaResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.pnSQL.ResumeLayout(false);
            this.pnSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnGuardarTabla;
        private System.Windows.Forms.Label lblAlgebraLineal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnSQL;
    }
}