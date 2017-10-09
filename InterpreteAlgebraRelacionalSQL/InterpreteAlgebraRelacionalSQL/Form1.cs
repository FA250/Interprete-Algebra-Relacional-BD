using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterpreteAlgebraRelacionalSQL.BD;
using System.Collections;

namespace InterpreteAlgebraRelacionalSQL
{
    public partial class frmIngreso : Form
    {
        bool Salir = true;
        String BDActual = "Ninguna";
        public frmIngreso()
        {
            InitializeComponent();
        }
        ClaseMD MD = new ClaseMD();

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (BDActual == "Ninguna")
            {
                if (txtBDNueva.Text.Trim() == "")
                {
                    MessageBox.Show("El nombre de la nueva base de datos no puede esta en blanco", "Error");//Mensaje de error
                }
                else
                {
                    if (MD.verificar_BD(txtBDNueva.Text) == "existe")
                    {
                        //Cambia la base de datos que se esta utilizando
                        BDActual = txtBDNueva.Text;
                        txtBDNueva.Text = "";

                        VGlobal.usuarioActual = cmbUsuario.Text;

                        MD.Crear_view_diccionario(BDActual);

                        //Abre la ventana de consultas y esconde la ventana de ingreso
                        Form Consultas = new frmConsultas(this, BDActual);
                        Consultas.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La base de datos seleccionada no existe", "Error");//Mensaje de error
                    }
                }
            }
            else
            {
                if (txtBDNueva.Text.Trim() == "")
                {
                    //Abre la ventana de consultas y esconde la ventana de ingreso
                    Form Consultas = new frmConsultas(this, BDActual);
                    Consultas.Show();
                    this.Hide();
                }
                else
                {
                    //Mensaje de aviso preguntando si realmente desea cambiar la base de datos que se esta utilizando actualmente
                    DialogResult result = MessageBox.Show("Si cambia la base de datos que se esta utilizando se borraran las tablas temporales existentes, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {                      

                        if (MD.verificar_BD(txtBDNueva.Text) == "existe")
                        {
                            foreach (String tabla in VGlobal.tablasTemporales)
                            {
                                String error=MD.Borrar_tabla_temp(BDActual, tabla);
                                if (error == null)
                                {
                                    MessageBox.Show("No se pudo borrar la tabla temporal: " +tabla, "Error");
                                }
                               
                            }
                            VGlobal.tablasTemporales = new ArrayList();
                            MD.Borrar_view_diccionario(BDActual);
                            //Cambia la base de datos que se esta utilizando
                            BDActual = txtBDNueva.Text;
                            txtBDNueva.Text = "";

                            //Abre la ventana de consultas y esconde la ventana de ingreso
                            Form Consultas = new frmConsultas(this, BDActual);
                            Consultas.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("La base de datos seleccionada no existe", "Error");//Mensaje de error
                            MessageBox.Show("No se borraron las tablas temporales", "Aviso");//Mensaje de error
                        }
                    }
                }

            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea salir
            DialogResult result = MessageBox.Show("Si sale se borraran las tablas temporales existentes, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (String tabla in VGlobal.tablasTemporales)
                {
                    String error = MD.Borrar_tabla_temp(BDActual, tabla);
                    if (error == null)
                    {
                        MessageBox.Show("No se pudo borrar la tabla temporal: " + tabla, "Error");
                    }
                }
                VGlobal.tablasTemporales = new ArrayList();
                MD.Borrar_view_diccionario(BDActual);
                //Cierra la aplicacion
                Salir = false;
                Application.Exit();
            }
        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Salir && this.Visible)
            {
                //Mensaje de aviso preguntando si realmente desea salir
                DialogResult result = MessageBox.Show("Si sale se borraran las tablas temporales existentes, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (String tabla in VGlobal.tablasTemporales)
                    {
                        String error = MD.Borrar_tabla_temp(BDActual, tabla);
                        if (error == null)
                        {
                            MessageBox.Show("No se pudo borrar la tabla temporal: " + tabla, "Error");
                        }
                    }
                    VGlobal.tablasTemporales = new ArrayList();
                    MD.Borrar_view_diccionario(BDActual);
                }
                else if (result == DialogResult.No)
                {
                    //Evita que la ventana se cierre
                    e.Cancel = true;
                }
                
            }
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = 0;
        }
    }
}
