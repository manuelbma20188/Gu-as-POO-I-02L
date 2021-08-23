using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_2
{
    //Formulario principal que funciona como menú para redirigir a los respectivos ejercicios
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Btn que redirige hacia formulario de ejercicio 1
        private void button1_Click(object sender, EventArgs e)
        {
            //Declaro una instancia para luego mostrar el form
            Ejercicio1 ejercicio1 = new Ejercicio1();            

            //muestro form
            ejercicio1.Show();             
        }

        //Btn que redirige hacia formulario de ejercicio 2
        private void button2_Click(object sender, EventArgs e)
        {
            //Declaro una instancia para luego mostrar el form
            Ejercicio2 ejercicio2 = new Ejercicio2();

            //muestro form
            ejercicio2.Show();
        }

        //Btn que redirige hacia formulario de ejercicio 3
        private void button3_Click(object sender, EventArgs e)
        {
            //Declaro una instancia para luego mostrar el form
            Ejercicio3 ejercicio3 = new Ejercicio3();

            //muestro form
            ejercicio3.Show();
        }

        //Btn que redirige hacia formulario de ejercicio 4
        private void button4_Click(object sender, EventArgs e)
        {
            //Declaro una instancia para luego mostrar el form
            Ejercicio4 ejercicio4 = new Ejercicio4();

            //muestro form
            ejercicio4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierro aplicación
        }
    }
}
