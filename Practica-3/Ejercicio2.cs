using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{

    public partial class Ejercicio2 : Form
    {

        public Ejercicio2()
        {
            InitializeComponent();            
        }
        

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

            //seteando enabled de los groupbox
            grpOpc1.Enabled = false;
            grpOpc2.Enabled = false;
            grpOpc3.Enabled = false;

            //el usuario no podra editar las opciones del cbo
            cboOpcion.DropDownStyle = ComboBoxStyle.DropDownList;


            //lleno de opciones al primer cbo
            cboOpcion.Items.Clear();
            cboOpcion.Items.Add("Ingresar datos");
            cboOpcion.Items.Add("Ver listado");
            cboOpcion.Items.Add("Ver reportes");
        }
        Student student = new Student();

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //segun la opción seleccionada, 
        private void cboOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpcion.SelectedItem.ToString() == "Ingresar datos")
            {
                grpOpc1.Enabled = true;                
            }
            else
            {
                grpOpc1.Enabled = false;                
            }

            if (cboOpcion.SelectedItem.ToString() == "Ver reportes")
            {
                grpOpc2.Enabled = true;                                
                student.mostrar(lsbMostrar); //metodo para mostrar reporte de alumnos
            }
            else
            {
                grpOpc2.Enabled = false;
                lsbMostrar.Items.Clear();
            }

            if (cboOpcion.SelectedItem.ToString() == "Ver listado")
            {
                grpOpc3.Enabled = true;
                student.listado(lsbReportes); //metodo para mostrar datos de estudiantes registrados
            }
            else
            {
                grpOpc3.Enabled = false;
                lsbReportes.Items.Clear();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {                                   
            student.Llenado(nudTamaño); //mando como el value del nud para el arreglo
        }

        private void nudTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
