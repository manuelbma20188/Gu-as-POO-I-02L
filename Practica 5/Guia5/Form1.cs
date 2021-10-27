using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {            
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {            
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closing app
            Application.Exit();
        }
    }
}
