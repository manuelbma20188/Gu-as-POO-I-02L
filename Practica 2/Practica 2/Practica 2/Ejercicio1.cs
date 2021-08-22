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
    public partial class Ejercicio1 : Form
    {

        //funcion para calcular los respectivos descuentos
        public static Double CalcularDescuento(Double salario, Double descuento)
        {
            Double calculo = 0;
            calculo = (salario * descuento);
            return calculo;
        }        

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //condicional para validar campos vacios
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtSalarioBruto.Text))
            {
                MessageBox.Show("Verifica que todos los campos estén llenos!");
            }
            else
            {
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                //calculos para rol de gerente
                if (rdbGerente.Checked)
                {                    
                    MessageBox.Show("Hola, Gerente " + nombres + " " + apellidos); //saludo

                    //convierto el salario ingresado a double
                    double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);

                    double descuento = 0.20; //descuento respectivo

                    //mando a llamar funcion creada
                    double calculoDescuento = CalcularDescuento(salarioBruto, descuento);

                    double calculoSalario = (salarioBruto - calculoDescuento); //realizo calculo final

                    //----imprimo variables/resultados
                    txtMontoDescuento.Text = "$" + calculoDescuento.ToString();
                    txtSalarioNeto.Text = "$" + calculoSalario.ToString();
                }

                //calculos para rol de Sub gerente
                if (rdbSub.Checked)
                {
                    MessageBox.Show("Hola, Sub-Gerente " + nombres + " " + apellidos); //saludo

                    //convierto el salario ingresado a double
                    double salarioBrutoS = Convert.ToDouble(txtSalarioBruto.Text);

                    double descuentoS = 0.15; //descuento respectivo

                    //mando a llamar funcion creada
                    double calculoDescuentoS = CalcularDescuento(salarioBrutoS, descuentoS);

                    double calculoSalarioS = (salarioBrutoS - calculoDescuentoS); //realizo calculo final

                    //----imprimo variables/resultados
                    txtMontoDescuento.Text = "$" + calculoDescuentoS.ToString();
                    txtSalarioNeto.Text = "$" + calculoSalarioS.ToString();
                }

                //calculos para rol de secretari@
                if (rdbSecre.Checked)
                {
                    MessageBox.Show("Hola, Secretari@ " + nombres + " " + apellidos); //saludo

                    //convierto el salario ingresado a double
                    double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);

                    double descuento = 0.05; //descuento respectivo

                    //mando a llamar funcion creada
                    double calculoDescuento = CalcularDescuento(salarioBruto, descuento);

                    double calculoSalario = (salarioBruto - calculoDescuento); //realizo calculo final

                    //----imprimo variables/resultados
                    txtMontoDescuento.Text = "$" + calculoDescuento.ToString();
                    txtSalarioNeto.Text = "$" + calculoSalario.ToString();
                }
            }//fin if de validacion
        }

        //evento keypress, me ayuda a verificar lo que el user teclea
        //se hace con fines de validar que solo se ingresen numeros  y unicamente un punto decimal
        private void txtSalarioBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }

            //solo permito que se ingrese un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }

        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
