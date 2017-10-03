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
    }
}
