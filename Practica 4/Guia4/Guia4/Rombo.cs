using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public class Rombo:Figura
    {        
        private double diagonalMayor;        
        private double diagonalMenor;

        public Rombo(double a, double may, double men) : base(a)
        {
            diagonalMayor = may;
            diagonalMenor = men;
        }

        public double DiagonalMayor { get => diagonalMayor; set => diagonalMayor = value; }
        public double DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }



        //Método sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (DiagonalMayor * DiagonalMenor)/2;
            LR.Text = "Valor del area: " + Area;
        }
    }
}
