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

namespace Guia5
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }       
        
        double gradesP1;
        double gradesP2;
        double gradesP3;
        double avg;        

        private void btnSiguienteP1_Click(object sender, EventArgs e)
        {            
            gradesP1 = Convert.ToDouble((nudNota1P1.Value + nudNota2P1.Value + nudNota3P1.Value)/3);
            MessageBox.Show("Promedio de periodo 1: " + gradesP1);
            if (gradesP1 <= 5.99)
            {
                MessageBox.Show("Ánimo estudiante, aún puedes mejorar tu promedio");
            }
            else
            {
                MessageBox.Show("Felicidades, vas arriba del promedio requerido");
            }
            MenuControl.SelectedTab = tabPage2;
        }

        private void btnSiguienteP2_Click(object sender, EventArgs e)
        {            
            gradesP2 = Convert.ToDouble((nudNota1P2.Value + nudNota2P2.Value + nudNota3P2.Value)/3);
            MessageBox.Show("Promedio de periodo 1: " + gradesP2);
            if (gradesP2 <= 5.99)
            {
                MessageBox.Show("Ánimo estudiante, aún puedes mejorar tu promedio");
            }
            else
            {
                MessageBox.Show("Felicidades, vas arriba del promedio requerido");
            }
            MenuControl.SelectedTab = tabPage3;
        }

        private void btnSiguienteP3_Click(object sender, EventArgs e)
        {            
            gradesP3 = Convert.ToDouble((nudNota1P3.Value + nudNota2P3.Value + nudNota3P3.Value)/3);
            MessageBox.Show("Promedio de periodo 1: " + gradesP3);
            if (gradesP3 <= 5.99)
            {
                MessageBox.Show("Ánimo estudiante, aún puedes mejorar tu promedio");
            }
            else
            {
                MessageBox.Show("Felicidades, vas arriba del promedio requerido");
            }
            avg =((gradesP1 + gradesP2 + gradesP3)/3);
            if (avg >= 6)
            {
                label10.Visible = true;
                label10.Text = ("Promedio final: " + avg.ToString() + ", haz aprobado!");
            }
            else
            {
                label10.Visible = true;
                label10.Text = ("Promedio final: " + avg.ToString() + ", haz reprobado!");

            }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
