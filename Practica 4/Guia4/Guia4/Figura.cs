using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public abstract class Figura 
    {
        private double area;
        
        public Figura(double areaR)
        {
            area = areaR;
        }
        public double Area { get => area; set => area = value; }
        public virtual void CalcularArea(Label res)
        {

        }
    }
}
