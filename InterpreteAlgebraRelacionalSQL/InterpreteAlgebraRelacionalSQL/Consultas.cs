using System;
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
    public partial class frmConsultas : Form
    {
        bool Salir = false;
        string BDActual;
        Form FormIngreso;
        public frmConsultas(Form Ingreso,String BD)
        {
            BDActual = BD;
            FormIngreso = Ingreso;
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

            lblBDActual.Text = BDActual;
            lblBDActual.ForeColor = System.Drawing.Color.Green;
            cmbOperacion.SelectedIndex = 0;
        }

        private void frmConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Salir)
            {
                //Al cerrar la ventana muestra la ventana de ingreso
                FormIngreso.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea salir
            DialogResult result = MessageBox.Show("Si sale se borraran las tablas temporales existentes, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //TODO borrar tablas temporales

                //Cierra la aplicacion
                Salir = true;
                Application.Exit();                                
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se desplegara el manual de usuario", "WIP");//Mensaje que indica al usuario ingresar la placa y verificarlo
        }

       

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            //Muestra la ventana con la tabla resultante de la operacion
            Form TablaResultado = new frmTablaResultado();
            TablaResultado.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            string AcercaDe = "Intérprete de Álgebra Relacional\n"
                            +"En conjunto con la DBMS SQL Server\n"
                            +"Autores:\n"
                            +"\tDavid Valverde\n"
                            + "\tFabián Piedra\n"
                            + "\tJose Madrigal\n"
                            + "Fecha Creación: 25/09/2017\n"
                            + "Última Actualización: 28/09/2017\n"
                            +"Versión: 0.1";

            MessageBox.Show(AcercaDe, "Acerda De");//Mensaje que indica al usuario ingresar la placa y verificarlo
        }

        private void btnVerTablas_Click(object sender, EventArgs e)
        {
            if (lblBDActual.Text.Trim() == "Ninguna")
            {
                MessageBox.Show("Primero debe seleccionar una base de datos", "Error");//Mensaje que indica al usuario ingresar la placa y verificarlo
            }
            else
            { 
                //Muestra form con las tablas existentes en la BD
                Form MostrarTablas = new frmMostrarTablas();
                MostrarTablas.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblBDActual.Text.Trim() == "Ninguna")
            {
                MessageBox.Show("Primero debe seleccionar una base de datos", "Error");//Mensaje que indica al usuario ingresar la placa y verificarlo
            }
            else
            {
                //Muestra form con las tablas existentes en la BD
                Form MostrarTablas = new frmMostrarTablas();
                MostrarTablas.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblBDActual.Text.Trim() == "Ninguna")
            {
                MessageBox.Show("Primero debe seleccionar una base de datos", "Error");//Mensaje que indica al usuario ingresar la placa y verificarlo
            }
            else
            { 
                //TODO crear codigo para mostrar las referencias cruzadas de atrubutos / tablas
            }
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dependiendo de la operacion elegida oculta o muestra los objetos necesarios para realizar la operacion
            if (cmbOperacion.SelectedIndex == 0 || cmbOperacion.SelectedIndex == 1 || cmbOperacion.SelectedIndex == 7)
            {
                lblTabla2.Visible = false;
                txtTabla2.Visible = false;                
                lblPredicado.Visible = true;
                txtPredicado.Visible = true;
                lblAgrupaciones.Visible = false;
                lblOpAgregacion.Visible = false;
                txtAgrupaciones.Visible = false;
            }
            else if (cmbOperacion.SelectedIndex == 2 || cmbOperacion.SelectedIndex == 3 || cmbOperacion.SelectedIndex == 4 || cmbOperacion.SelectedIndex == 5 || cmbOperacion.SelectedIndex == 6 || cmbOperacion.SelectedIndex == 9)
            {
                lblTabla2.Visible = true;
                txtTabla2.Visible = true;
                lblPredicado.Visible = true;
                txtPredicado.Visible = true;
                lblAgrupaciones.Visible = false;
                lblOpAgregacion.Visible = false;
                txtAgrupaciones.Visible = false;
            }
            else if (cmbOperacion.SelectedIndex == 8)
            {
                lblTabla2.Visible = true;
                txtTabla2.Visible = true;
                lblPredicado.Visible = true;
                txtPredicado.Visible = true;
                lblAgrupaciones.Visible = false;
                lblOpAgregacion.Visible = false;
                txtAgrupaciones.Visible = false;
            }
            else if (cmbOperacion.SelectedIndex == 10)
            {
                lblTabla2.Visible = false;
                txtTabla2.Visible = false;
                lblPredicado.Visible = false;
                lblOpAgregacion.Visible = true;
                lblAgrupaciones.Visible = false;
                txtPredicado.Visible = true;
                txtAgrupaciones.Visible = false;
            }
            else
            {
                lblTabla2.Visible = false;
                txtTabla2.Visible = false;
                lblPredicado.Visible = false;
                lblOpAgregacion.Visible = true;
                lblAgrupaciones.Visible = true;
                txtPredicado.Visible = true;
                txtAgrupaciones.Visible = true;
            }
        }


    }
}
