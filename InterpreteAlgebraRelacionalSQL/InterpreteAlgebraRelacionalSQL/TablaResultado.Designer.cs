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
            this.Atributo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atributo1,
            this.Atributo2,
            this.Atributo3});
            this.dgvResultado.Location = new System.Drawing.Point(12, 71);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(847, 509);
            this.dgvResultado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla resultante";
            // 
            // Atributo1
            // 
            this.Atributo1.HeaderText = "Atributo1";
            this.Atributo1.Name = "Atributo1";
            this.Atributo1.ReadOnly = true;
            // 
            // Atributo2
            // 
            this.Atributo2.HeaderText = "Atributo2";
            this.Atributo2.Name = "Atributo2";
            this.Atributo2.ReadOnly = true;
            // 
            // Atributo3
            // 
            this.Atributo3.HeaderText = "Atributo3";
            this.Atributo3.Name = "Atributo3";
            this.Atributo3.ReadOnly = true;
            // 
            // frmTablaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmTablaResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaResultado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo3;
    }
}