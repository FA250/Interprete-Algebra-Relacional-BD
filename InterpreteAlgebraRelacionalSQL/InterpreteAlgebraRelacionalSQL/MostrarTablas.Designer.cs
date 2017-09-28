namespace InterpreteAlgebraRelacionalSQL
{
    partial class frmMostrarTablas
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
            this.Atributo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
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
            this.dgvResultado.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tabla:";
            // 
            // cmbTablas
            // 
            this.cmbTablas.DisplayMember = "Selección";
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTablas.Location = new System.Drawing.Point(362, 30);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(184, 21);
            this.cmbTablas.TabIndex = 8;
            // 
            // frmMostrarTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmMostrarTablas";
            this.Text = "MostrarTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTablas;
    }
}