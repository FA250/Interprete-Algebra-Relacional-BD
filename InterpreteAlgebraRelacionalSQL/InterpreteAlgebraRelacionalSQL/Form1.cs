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
    public partial class frmIngreso : Form
    {
        bool Salir = true;
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //Abre la ventana de consultas y esconde la ventana de ingreso
            Form Consultas = new frmConsultas(this);
            Consultas.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea salir
            DialogResult result = MessageBox.Show("Si sale se borraran las tablas temporales existentes, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //TODO borrar tablas temporales

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
                    //TODO borrar tablas temporales
                }
                else if (result == DialogResult.No)
                {
                    //Evita que la ventana se cierre
                    e.Cancel = true;
                }
                
            }
        }
    }
}
