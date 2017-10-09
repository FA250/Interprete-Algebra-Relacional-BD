﻿using InterpreteAlgebraRelacionalSQL.BD;
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
        String BDActual;
        String algebraLineal;
        String SQLOp;
        String SQLGuardarTabla;
        ClaseMD MD = new ClaseMD();
        public frmTablaResultado(String BD,ArrayList columnasTabla,ArrayList tuplasTabla,String algebraLinealOP,String OperacionSQL, String SQLGuardarTablaTemp)
        {
            columnas = columnasTabla;
            tuplas = tuplasTabla;
            BDActual = BD;
            algebraLineal = algebraLinealOP;
            SQLOp = OperacionSQL;
            SQLGuardarTabla = SQLGuardarTablaTemp;
            InitializeComponent();
        }

        private void frmTablaResultado_Load(object sender, EventArgs e)
        {
            lblAlgebraLineal.Text = " " + algebraLineal;
            lblSQL.Text = SQLOp;

            DataTable Table = new DataTable();
            DataRow Reglon;

            foreach (String columna in columnas)
            {
                bool noExisteCol=true;
                foreach (Object colExistente in Table.Columns)
                {
                    if (columna == colExistente.ToString())
                    {
                        noExisteCol = false;
                    }
                }
                if (noExisteCol)
                {
                    Table.Columns.Add(new DataColumn(columna.ToString()));
                }
                else
                {
                    Table.Columns.Add(new DataColumn(columna.ToString()+"B"));
                }
                
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

        String ultNombreTabla = " ";
        private void txtNombreTabla_TextChanged(object sender, EventArgs e)
        {

            
            //lblAlgebraLineal.Text.ToString().Split(' ')[1]
            if (txtNombreTabla.Text.Trim() == "")
            {
                btnGuardarTabla.Enabled = false;
                lblAlgebraLineal.Text = lblAlgebraLineal.Text.ToString().Replace(ultNombreTabla + " <- ", " ");
                ultNombreTabla = " ";      
            }
            else
            {
                lblAlgebraLineal.Text = lblAlgebraLineal.Text.ToString().Replace(ultNombreTabla + " <- ", " ");
                lblAlgebraLineal.Text = txtNombreTabla.Text +" <-"+ lblAlgebraLineal.Text;
                btnGuardarTabla.Enabled = true;
                ultNombreTabla = txtNombreTabla.Text;            
            }
        }

        private void txtNombreTabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void btnGuardarTabla_Click_1(object sender, EventArgs e)
        {
            Boolean existeTemp = false;
            foreach (String tabla in VGlobal.tablasTemporales)
            {
                if (txtNombreTabla.Text == tabla)
                {
                    DialogResult result = MessageBox.Show("La tabla temporal " + txtNombreTabla.Text + " ya existe ¿desea sobreescribirla?", "Aviso", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        String error=MD.Crear_tabla_temp(BDActual, txtNombreTabla.Text, SQLGuardarTabla);
                        if (error == null)
                        {
                            MessageBox.Show("No se pudo guardar la tabla " + txtNombreTabla.Text, "Error");
                        }
                        else
                        {
                            MessageBox.Show("Tabla " + txtNombreTabla.Text + " guardada exitosamente", "Aviso");
                        }
                    }
                    existeTemp = true;
                    break;                   
                }
            }

            if (!existeTemp)
            {
                if(MD.verificar_Tabla(BDActual,txtNombreTabla.Text)=="existe"){
                    MessageBox.Show("ERROR: NO SE PUEDE DEJAR EL RESULTADO EN UNA TABLA PERMANENTE DE LA BASE DE DATOS.", "Error");
                }
                else
                {
                    String error = MD.Crear_tabla_temp(BDActual, txtNombreTabla.Text, SQLGuardarTabla);
                    if (error == null)
                    {
                        MessageBox.Show("No se pudo guardar la tabla "+txtNombreTabla.Text, "Error");
                    }
                    else
                    {
                        VGlobal.tablasTemporales.Add(txtNombreTabla.Text);
                        MessageBox.Show("Tabla " + txtNombreTabla.Text+" guardada exitosamente", "Aviso");
                    }                   
                }
            }


        }
    }
}
