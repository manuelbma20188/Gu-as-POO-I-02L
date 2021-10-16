using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Menu Ejercicio1 = new Menu();
            Ejercicio1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 Ejercicio2 = new Ejercicio2();
            Ejercicio2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ejercicio3 = new Ejercicio3();
            Ejercicio3.Show();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4 Ejercicio4 = new Ejercicio4();
            Ejercicio4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
