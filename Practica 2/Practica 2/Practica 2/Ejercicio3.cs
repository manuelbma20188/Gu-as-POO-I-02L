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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //valido que los txt no queden vacíos
            if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text) || string.IsNullOrEmpty(txtC.Text))
            {
                MessageBox.Show("Verifica que todos los campos estén llenos!");
            }
            else
            {
                //tomo valores ingresados de txt's
                string variable1 = txtA.Text.ToString();
                string variable2 = txtB.Text.ToString();
                string variable3 = txtC.Text.ToString();

                double conversion1, conversion2, conversion3 = 0;
                //acá convierto el string a double, si ingresa un valor != a double
                //mostrará mensaje
                if (double.TryParse(variable1, out conversion1) && double.TryParse(variable2, out conversion2) && double.TryParse(variable3, out conversion3))
                {
                    //calculo primero la discriminante por las condiciones de formula cuadratica
                    /** Si d >0 hay dos soluciones, 
                     * si d=0  una sola solucion y 
                     * si d <0 no hay solucion**/

                    double discriminante = ((Math.Pow(conversion2,2) - (4 * conversion1 * conversion3)));
                    
                    if (discriminante > 0)
                    {
                        double x1 = (-conversion2 + Math.Sqrt(discriminante)) / (2 * conversion1);                        

                        double x2 = (-conversion2 - Math.Sqrt(discriminante)) / (2 * conversion1);
                        lblX1.Text = "Resultado de x1: " + x1.ToString();
                        lblX2.Text = "Resultado de x2: " + x2.ToString();
                        Limpiar();//metodo que limpia txt's
                    }

                    if(discriminante == 0)
                    {
                        double x1 = (-conversion2 + Math.Sqrt(discriminante)) / (2 * conversion1);
                        lblX1.Text = "Resultado de x: " + x1.ToString();                        
                        Limpiar();//metodo que limpia txt's
                    }

                    if (discriminante < 0)
                    {
                        lblX1.Text = "No hay solución";
                        Limpiar();//metodo que limpia txt's
                    }                                        
                }
                else
                {
                    MessageBox.Show("Ingresa un valor valido!");
                }//fin if de conversion
            }
        }
    }
}
