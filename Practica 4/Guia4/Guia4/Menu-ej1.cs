using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Guia4
{
    public partial class Menu : Guia4.Ejemplo2
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiante estudiante = new FrmEstudiante();
            this.Hide();
            estudiante.Show();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            FrmDocente docente = new FrmDocente();
            this.Hide();
            docente.Show();
        }

        
    }
}
