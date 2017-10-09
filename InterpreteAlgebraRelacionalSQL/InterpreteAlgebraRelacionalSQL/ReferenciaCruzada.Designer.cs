namespace InterpreteAlgebraRelacionalSQL
{
    partial class frmReferenciaCruzada
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
            this.dgvTablasDeAtributo = new System.Windows.Forms.DataGridView();
            this.cmbAtributos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasDeAtributo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablasDeAtributo
            // 
            this.dgvTablasDeAtributo.AllowUserToAddRows = false;
            this.dgvTablasDeAtributo.AllowUserToDeleteRows = false;
            this.dgvTablasDeAtributo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablasDeAtributo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablasDeAtributo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablasDeAtributo.Location = new System.Drawing.Point(12, 69);
            this.dgvTablasDeAtributo.Name = "dgvTablasDeAtributo";
            this.dgvTablasDeAtributo.ReadOnly = true;
            this.dgvTablasDeAtributo.Size = new System.Drawing.Size(999, 511);
            this.dgvTablasDeAtributo.TabIndex = 2;
            // 
            // cmbAtributos
            // 
            this.cmbAtributos.DisplayMember = "Selección";
            this.cmbAtributos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtributos.FormattingEnabled = true;
            this.cmbAtributos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbAtributos.Location = new System.Drawing.Point(464, 29);
            this.cmbAtributos.Name = "cmbAtributos";
            this.cmbAtributos.Size = new System.Drawing.Size(184, 21);
            this.cmbAtributos.TabIndex = 10;
            this.cmbAtributos.SelectedIndexChanged += new System.EventHandler(this.cmbAtributos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Atibuto:";
            // 
            // frmReferenciaCruzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1023, 592);
            this.Controls.Add(this.cmbAtributos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTablasDeAtributo);
            this.Name = "frmReferenciaCruzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referencia Cruzada";
            this.Load += new System.EventHandler(this.ReferenciaCruzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasDeAtributo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablasDeAtributo;
        private System.Windows.Forms.ComboBox cmbAtributos;
        private System.Windows.Forms.Label label1;
    }
}