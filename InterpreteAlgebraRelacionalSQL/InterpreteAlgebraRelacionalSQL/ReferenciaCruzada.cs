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
    public partial class frmReferenciaCruzada : Form
    {
        String BDActual;
        ClaseMD MD = new ClaseMD();

        public frmReferenciaCruzada(String BD)
        {
            BDActual = BD;
            InitializeComponent();
        }

        private void ReferenciaCruzada_Load(object sender, EventArgs e)
        {

            ArrayList nombre_Atributos = MD.Todos_atributos(BDActual);
            foreach (String nombre in nombre_Atributos)
            {
                cmbAtributos.Items.Add(nombre);
            }            
        }

        private void cmbAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable Table = new DataTable();
            ArrayList tuplas = MD.Datos_atributos(BDActual, cmbAtributos.Text);
            DataRow Reglon;

            Table.Columns.Add(new DataColumn("Tabla"));
            Table.Columns.Add(new DataColumn("Tipo"));
            Table.Columns.Add(new DataColumn("Longitud de caracter"));
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
       

            dgvTablasDeAtributo.DataSource = Table;
        }
    }
}
