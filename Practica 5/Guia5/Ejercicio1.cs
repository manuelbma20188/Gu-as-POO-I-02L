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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //function to validate each entrance of the form
        private bool ValidateEntrances()
        {
            //verifying if the process is ok, a bool variale
            bool verify = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                //txt empty
                verify = false; 
                //parameters; object txt and msg
                errorProvider1.SetError(txtNombre, "Por favor ingresa un nombre");                 
            }
            
            //same process
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                verify = false;                
                errorProvider1.SetError(txtApellido, "Por favor ingrese un apellido");
            }

            //instance of a datetime            
            DateTime fechaNacimiento = dtpFechaNac.Value;

            //getting year, month and day value
            int year = System.DateTime.Now.Year - fechaNacimiento.Year;
            int month = System.DateTime.Now.Month - fechaNacimiento.Month;
            int day = System.DateTime.Now.Day - fechaNacimiento.Day;

            //validating dtp 
            if  (year <= 0 && month == 0 && day <= 0)
            {
                verify = false;
                //parameters for error provider; datetimepicker, msg
                errorProvider1.SetError(dtpFechaNac, "Fecha no valida");
            }
            else
            {
                //si todo esta bien lo dejo pasar y muestro la edad
                txtEdad.Text = Convert.ToString(year);
            }

            return verify;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
        }
    }
}
