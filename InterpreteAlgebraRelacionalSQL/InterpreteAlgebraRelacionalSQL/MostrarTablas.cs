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
        ArrayList nombreTablas = new ArrayList();
        ArrayList noMostrar = new ArrayList();
        String mostrarTablas;

        public frmMostrarTablas(String BD,String tipoTablas)
        {
            BDActual = BD;
            mostrarTablas = tipoTablas;
            InitializeComponent();
        }


        private void frmMostrarTablas_Load(object sender, EventArgs e)
        {
            if (mostrarTablas == "BD")
            {
                nombreTablas = MD.select_NombreTablas(BDActual);
                noMostrar = VGlobal.tablasTemporales;
                foreach (ArrayList nombre in nombreTablas)
                {
                    bool mostrar = true;
                    foreach (String temp in noMostrar)
                    {
                        if (nombre[0].ToString() == temp)
                        {
                            mostrar = false;
                        }
                    }
                    if (mostrar)
                    {
                        cmbTablas.Items.Add(nombre[0].ToString());
                    }

                }
            }
            else
            {
                foreach (String nombre in VGlobal.tablasTemporales)
                {
                    cmbTablas.Items.Add(nombre);
                }
            }


        }


        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            DataRow Reglon;
            ArrayList columnas=new ArrayList();

            String tabla=cmbTablas.SelectedItem.ToString();

            //selecciona el esquema de la tabla
            int indice=0;
            foreach(ArrayList NombresTablas in nombreTablas){
                if(cmbTablas.SelectedIndex==indice){
                    ArrayList TablaActual = NombresTablas;
                    columnas=MD.select_NombreColumnas(BDActual,tabla,TablaActual[1].ToString());
                }
                indice++;
            }          

            

            ArrayList tuplas = MD.Datos_tabla(BDActual, tabla);


            Table.Columns.Add(new DataColumn("Atributo"));
            Table.Columns.Add(new DataColumn("Tipo de dato"));
            Table.Columns.Add(new DataColumn("Máxima longitud"));
            Table.Columns.Add(new DataColumn("Precisión numérica"));
            Table.Columns.Add(new DataColumn("Escala numérica"));
            Table.Columns.Add(new DataColumn("Llave Primaria"));
            Table.Columns.Add(new DataColumn("Llave Foranea"));
            Table.Columns.Add(new DataColumn("Dominio"));

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
