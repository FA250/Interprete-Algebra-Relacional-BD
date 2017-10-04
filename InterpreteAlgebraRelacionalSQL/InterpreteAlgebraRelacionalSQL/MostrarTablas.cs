using InterpreteAlgebraRelacionalSQL.BD;
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
    public partial class frmMostrarTablas : Form
    {
        String BDActual;
        ClaseMD MD = new ClaseMD();

        public frmMostrarTablas(String BD)
        {
            BDActual = BD;
            InitializeComponent();
        }

        private void frmMostrarTablas_Load(object sender, EventArgs e)
        {
            ArrayList nombreTablas = new ArrayList();            
            nombreTablas = MD.select_NombreTablas(BDActual);

            foreach (String nombre in nombreTablas)
            {
                cmbTablas.Items.Add(nombre.ToString());
            }
        }


        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            DataRow Reglon;
            ArrayList columnas=new ArrayList();

            String tabla=cmbTablas.SelectedItem.ToString();
            columnas=MD.select_NombreColumnas(BDActual,tabla);

            ArrayList tuplas = MD.Seleccionar_tabla(BDActual, tabla,columnas);

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
