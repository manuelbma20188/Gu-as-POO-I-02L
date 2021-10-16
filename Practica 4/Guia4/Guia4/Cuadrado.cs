using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public class Cuadrado:Figura 
    {
        private double lado;//atributo
        public double Lado { get => lado; set => lado = value; }
        public Cuadrado(double area, double lado1) : base(area)
        {
            lado = lado1;
        }    
        
        public override void CalcularArea(Label res)
        {
            Area = (Lado * Lado);
            res.Text = "Valor del area: " + Area;
        }
    }
}
