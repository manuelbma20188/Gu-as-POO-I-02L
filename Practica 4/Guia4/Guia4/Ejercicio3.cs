using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }       

        private void btnCalculaCuadrado_Click(object sender, EventArgs e)
        {            
                double lado = Convert.ToDouble(txtLado.Text);
                double area = 0;                
                Cuadrado cc = new Cuadrado(area, lado);
            //funcion de clase
                cc.CalcularArea(label1);                       
        }

        private void btnCalculaCirculo_Click(object sender, EventArgs e)
        {            
                double radio = Convert.ToDouble(txtRadio.Text);
                double area = 0;                
                Circulo c = new Circulo(area, radio);
                c.CalcularArea(label2);                     
        }

        private void btnCalculaRombo_Click(object sender, EventArgs e)
        {                            
                double diagonalMas = Convert.ToDouble(txtMayor.Text);
                double diagonalMenos = Convert.ToDouble(txtMenor.Text);
                double area = 0;                
                Rombo r = new Rombo(area, diagonalMas, diagonalMenos);
                r.CalcularArea(label5);
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
