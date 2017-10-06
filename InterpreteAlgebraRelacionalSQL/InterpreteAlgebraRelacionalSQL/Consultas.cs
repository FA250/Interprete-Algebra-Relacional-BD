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
    public partial class frmConsultas : Form
    {
        bool Salir = false;
        string BDActual;
        Form FormIngreso;
        ArrayList nombreTablas =new ArrayList();
        ClaseMD MD = new ClaseMD();

        public frmConsultas(Form Ingreso,String BD)
        {
            BDActual = BD;
            FormIngreso = Ingreso;
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            nombreTablas = MD.select_NombreTablas(BDActual);
            lblBDActual.Text = BDActual;
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
                foreach (String tabla in VGlobal.tablasTemporales)
                {
                    String error=MD.Borrar_tabla_temp(BDActual, tabla);
                    if (error == null)
                    {
                        MessageBox.Show("No se pudo borrar la tabla temporal:" + tabla, "Error");
                    }
                   
                }
                VGlobal.tablasTemporales = new ArrayList();

                MD.Borrar_view_diccionario(BDActual);
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
            bool mostrarResultado = false;
            ArrayList columnas=new ArrayList();
            ArrayList tuplas = new ArrayList();
            String algebraLineal="";
            String SQL="";

            //------------- Seleccion ------------- 
            if (cmbOperacion.SelectedIndex == 0)
            {
                if (txtTabla.Text.Trim() != "" && txtPredicado.Text.Trim()!="")
                {
                    if (MD.verificar_Tabla(BDActual, txtTabla.Text) == "existe")
                    {
                        //selecciona el esquema de la tabla
                        foreach (ArrayList NombresTablas in nombreTablas)
                        {
                            if (NombresTablas[0].ToString() == txtTabla.Text.Trim())
                            {
                                ArrayList TablaActual = NombresTablas;
                                columnas = MD.select_NombreColumnas(BDActual, txtTabla.Text, TablaActual[1].ToString());
                            }
                        } 
                        tuplas=MD.Operacion_Seleccion(BDActual, txtTabla.Text, txtPredicado.Text, columnas);
                        if (tuplas == null)
                        {
                            MessageBox.Show("Error al realizar la operación", "Error");//Mensaje de error
                        }
                        else
                        {
                            algebraLineal = "σ " + txtPredicado.Text.Trim() + "(" + txtTabla.Text.Trim() + ")";
                            SQL = "SELECT * FROM " + txtTabla.Text + " WHERE " + txtPredicado.Text;
                            mostrarResultado = true;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR: NO EXISTE LA TABLA " + txtTabla.Text, "Error");//Mensaje de error
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una tabla y/o predicado", "Error");//Mensaje de error
                }
            }
            //------------- Proyeccion ------------- 
            else if (cmbOperacion.SelectedIndex == 1)
            {
                if (txtTabla.Text.Trim() != "" && txtPredicado.Text.Trim() != "")
                {
                    if (MD.verificar_Tabla(BDActual, txtTabla.Text) == "existe")
                    {
                        foreach(String atributo in txtPredicado.Text.Split(',').ToList()){
                            columnas.Add(atributo.Trim());
                        }

                        tuplas = MD.Operacion_proyeccion(BDActual, txtPredicado.Text, txtTabla.Text, columnas);
                        if (tuplas == null)
                        {
                            MessageBox.Show("Error al realizar la operación", "Error");//Mensaje de error
                        }
                        else
                        {
                            algebraLineal = "π " + txtPredicado.Text.Trim() + "(" + txtTabla.Text.Trim() + ")";
                            SQL = "SELECT "+ txtPredicado.Text+" FROM " + txtTabla.Text ;
                            mostrarResultado = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("ERROR: NO EXISTE LA TABLA " + txtTabla.Text, "Error");//Mensaje de error
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una tabla y/o los atributos", "Error");//Mensaje de error
                }
            }
            //------------- Union ------------- 
            else if (cmbOperacion.SelectedIndex == 2)
            {
                //TODO
            }
            //------------- Diferencia ------------- 
            else if (cmbOperacion.SelectedIndex == 3)
            {
                //TODO
            }
            //------------- Producto Cartesiano ------------- 
            else if (cmbOperacion.SelectedIndex == 4)
            {
                if (txtTabla.Text.Trim() != "" && txtTabla2.Text.Trim() != "")
                {
                    if (MD.verificar_Tabla(BDActual, txtTabla.Text) == "existe")
                    {
                        if (MD.verificar_Tabla(BDActual, txtTabla2.Text) == "existe")
                        {
                            columnas = MD.Columnas_cartesiano(BDActual, txtTabla.Text, txtTabla2.Text);

                            if (columnas != null)
                            {

                                tuplas = MD.Operacion_producto_cartesiano(BDActual, txtTabla.Text, txtTabla2.Text, columnas);
                                if (tuplas == null)
                                {
                                    MessageBox.Show("Error al realizar la operación", "Error");//Mensaje de error
                                }
                                else
                                {
                                    algebraLineal =txtTabla.Text.Trim() + " X " + txtTabla2.Text.Trim();
                                    SQL = "SELECT * FROM " + txtTabla.Text + "," + txtTabla2.Text;
                                    mostrarResultado = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al recuperar columnas de la operación", "Error");//Mensaje de error
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR: NO EXISTE LA TABLA " + txtTabla2.Text, "Error");//Mensaje de error
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: NO EXISTE LA TABLA " + txtTabla.Text, "Error");//Mensaje de error
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar las 2 tablas", "Error");//Mensaje de error
                }
            }
            //------------- Interseccion ------------- 
            else if (cmbOperacion.SelectedIndex == 5)
            {
                //TODO
            }
            //------------- Division ------------- 
            else if (cmbOperacion.SelectedIndex == 6)
            {
                //TODO
            }
            //------------- Renombrar ------------- 
            else if (cmbOperacion.SelectedIndex == 7)
            {
                //TODO
            }
            //------------- Join ------------- 
            else if (cmbOperacion.SelectedIndex == 8)
            {
                //TODO
            }
            //------------- Natural join ------------- 
            else if (cmbOperacion.SelectedIndex == 9)
            {
                //TODO
            }
            //------------- Agregacion ------------- 
            else if (cmbOperacion.SelectedIndex == 10)
            {
                //TODO
            }
            //------------- Agrupacion ------------- 
            else if (cmbOperacion.SelectedIndex == 11)
            {
                //TODO
            }

            if (mostrarResultado)
            {
                //Muestra la ventana con la tabla resultante de la operacion
                Form TablaResultado = new frmTablaResultado(BDActual,columnas,tuplas,algebraLineal,SQL);
                TablaResultado.Show();
            }
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
                            + "Última Actualización: 06/10/2017\n"
                            +"Versión: 0.7";

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
                Form MostrarTablas = new frmMostrarTablas(BDActual,"BD");
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
                Form MostrarTablas = new frmMostrarTablas(BDActual,"Temporales");
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
                if (cmbOperacion.SelectedIndex == 1)
                {
                    lblPredicado.Text = "Atributos:";
                }
                else
                {
                    lblPredicado.Text = "Predicado:";
                }
            }
            else if (cmbOperacion.SelectedIndex == 4)
            {
                lblTabla2.Visible = true;
                txtTabla2.Visible = true;
                lblPredicado.Visible = false;
                txtPredicado.Visible = false;
                lblAgrupaciones.Visible = false;
                lblOpAgregacion.Visible = false;
                txtAgrupaciones.Visible = false;
            }
            else if (cmbOperacion.SelectedIndex == 2 || cmbOperacion.SelectedIndex == 3 || cmbOperacion.SelectedIndex == 5 || cmbOperacion.SelectedIndex == 6 || cmbOperacion.SelectedIndex == 9)
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
