using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpreteAlgebraRelacionalSQL
{
    public partial class frmTablaResultado : Form
    {
        ArrayList columnas;
        ArrayList tuplas;
        String nombreTabla;
        public frmTablaResultado(ArrayList columnasTabla,ArrayList tuplasTabla)
        {
            columnas = columnasTabla;
            tuplas = tuplasTabla;
            InitializeComponent();
        }

        private void frmTablaResultado_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            DataRow Reglon;

            foreach (String columna in columnas)
            {
                Table.Columns.Add(new DataColumn(columna.ToString()));
            }
            int numeroColumna = 0;
            foreach (ArrayList atributos in tuplas)
            {
                Reglon = Table.NewRow();
                numeroColumna = 0;
                foreach (String item in atributos)
                {
                    Reglon[numeroColumna] = item.ToString();
                    numeroColumna++;
                }

                Table.Rows.Add(Reglon);
            }

            dgvResultado.DataSource = Table;

        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNombreTabla_TextChanged(object sender, EventArgs e)
        {

            
            if (txtNombreTabla.Text.Trim() == "")
            {
                btnGuardarTabla.Enabled = false;
                lblAlgebraLineal.Text = " " + lblAlgebraLineal.Text.ToString().Split(' ')[1];
            }
            else
            {
                lblAlgebraLineal.Text = " " + lblAlgebraLineal.Text.ToString().Split(' ')[1];
                lblAlgebraLineal.Text = txtNombreTabla.Text + lblAlgebraLineal.Text;
                btnGuardarTabla.Enabled = true;
                //TODO verificar que el nombre no sea una tabla fija de la BD
                //TODO guardar tabla temporal
            }
        }

        private void txtNombreTabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
    }
}
