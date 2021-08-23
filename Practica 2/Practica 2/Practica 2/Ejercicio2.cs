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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, para realizar los calculos, presiona ENTER sobre los textbox");
            //deshabilito los groupbox 
            group1.Enabled = false;
            group2.Enabled = false;
            group3.Enabled = false;

            //con esta propiedad el usuario no puede editar las opciones del cbo
            cboTipoConversion.DropDownStyle = ComboBoxStyle.DropDownList;


            //lleno de opciones al primer cbo
            cboTipoConversion.Items.Clear();
            cboTipoConversion.Items.Add("Temperatura");
            cboTipoConversion.Items.Add("Longitud");
            cboTipoConversion.Items.Add("Peso");
        }

        /**el metodo del selecttedindexchanged me va a permitir que cuando seleccione una opc
        se active un group box, acorde  a la opcion seleccionada**/
        private void cboTipoConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoConversion.SelectedItem.ToString() == "Temperatura")
            {
                group1.Enabled = true;
                rdbOpc1Temp.Checked = true;
            }else{
                group1.Enabled = false;
                rdbOpc1Temp.Checked = false;
            }

            if (cboTipoConversion.SelectedItem.ToString() == "Longitud")
            {
                group2.Enabled = true;
                rdbOpc1Long.Checked = true;
            }else{
                group2.Enabled = false;
                rdbOpc1Long.Checked = false;
            }

            if (cboTipoConversion.SelectedItem.ToString() == "Peso")
            {
                group3.Enabled = true;
                rdbOpc1Peso.Checked = true;
            }else{
                group3.Enabled = false;
                rdbOpc1Peso.Checked = false;
            }
        }

        
        private void txtDato2Temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //evento keypress, me ayuda a detectar cuando el user da enter al txt para lanzar directamente el resultado
        //se hace con fines de no usar muchos botones
        private void txtDato1Temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifico que el txt no esté vacío
            if (!string.IsNullOrEmpty(txtDato1Temp.Text))
            {

                //------------------------CONVERSION DE TEMPERATURAS--------------------------------
                //celsius-fahrenheit
                if (rdbOpc1Temp.Checked)
                {
                    //capturo la accion del enter de teclado
                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Temp.Text.ToString();

                        double conversion=0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {
                            double resultado = (conversion * 1.8) + 32;
                            txtDato1Temp.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoTemp.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Temp.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion

                    }//fin de if de capturar enter

                }//fin de if de radiobutton 1 Temperatura

                //fahrenheit-celsius
                if (rdbOpc2Temp.Checked)
                {

                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Temp.Text.ToString();

                        double conversion = 0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {                            
                            double resultado = (conversion - 32) * 5 / 9;
                            txtDato1Temp.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoTemp.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Temp.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion
                    }
                }//fin de if de radiobutton 2 Temperatura

                //------------------------FIN DE CONVERSION DE TEMPERATURAS--------------------------------                               
            }
            else
            {
                MessageBox.Show("Verifica que todos los campos estén llenos!");
            }//fin de if de verificación de txt 
        }

        private void lblResultadoPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtDato1Long_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato1Long.Text))
            {
                //------------------------CONVERSION DE LONGITUDES--------------------------------
                //metros-pies
                if (rdbOpc1Long.Checked)
                {
                    //capturo la accion del enter de teclado
                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Long.Text.ToString();

                        double conversion = 0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {
                            double resultado = (conversion * 3.281);
                            txtDato1Long.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoLongitud.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Long.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion

                    }//fin de if de capturar enter

                }//fin de if de radiobutton 1 Longitud

                //pies-metros
                if (rdbOpc2Long.Checked)
                {
                    //capturo la accion del enter de teclado
                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Long.Text.ToString();

                        double conversion = 0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {
                            double resultado = (conversion / 3.281);
                            txtDato1Long.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoLongitud.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Long.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion

                    }//fin de if de capturar enter

                }//fin de if de radiobutton 2 Longitud

            }
            else
            {
                MessageBox.Show("Verifica que todos los campos estén llenos!");
            }//fin de if de verificación de txt 

            //------------------------FIN CONVERSION DE LONGITUDES--------------------------------
        }

        private void txtDato1Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato1Peso.Text))
            {
                //------------------------CONVERSION DE MASA--------------------------------
                //kg-lb
                if (rdbOpc1Peso.Checked)
                {
                    //capturo la accion del enter de teclado
                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Peso.Text.ToString();

                        double conversion = 0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {
                            double resultado = (conversion * 2.2);
                            txtDato1Peso.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoPeso.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Peso.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion

                    }//fin de if de capturar enter

                }//fin de if de radiobutton 1 Longitud

                //lb-kg
                if (rdbOpc2Peso.Checked)
                {
                    //capturo la accion del enter de teclado
                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        //tomo valor ingresado de txt
                        string dato1 = txtDato1Peso.Text.ToString();

                        double conversion = 0;
                        //acá convierto el string a double, si ingresa un valor != a double
                        //mostrará mensaje
                        if (double.TryParse(dato1, out conversion))
                        {
                            double resultado = (conversion / 2.2);
                            txtDato1Peso.Text = ""; //vacio al txt [error solventado]

                            //imprimo resultado final
                            lblResultadoPeso.Text = "Resultado final: " + resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un valor valido!");
                            txtDato1Peso.Text = ""; //vacio al txt [error solventado]
                        }//fin if de conversion

                    }//fin de if de capturar enter

                }//fin de if de radiobutton 2 Longitud

            }
            else
            {
                MessageBox.Show("Verifica que todos los campos estén llenos!");
            }//fin de if de verificación de txt 

            //------------------------FIN CONVERSION DE LONGITUDES--------------------------------
        }

        private void txtDato1Temp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
