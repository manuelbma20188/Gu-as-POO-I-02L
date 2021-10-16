using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public class Circulo:Figura
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo(double a, double b):base(a)//constructor con parámetros
        {
            radio = b;
        }                
        public override void CalcularArea(Label l)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            l.Text = "Valor del area: " + Area;
        }
    }
}
