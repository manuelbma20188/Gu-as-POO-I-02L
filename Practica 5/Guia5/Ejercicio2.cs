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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //instance of my class Student
            Student student = new Student();

            DateTime bornDate = dtpFechaNac.Value;
            //vars to compare actual year
            int month = System.DateTime.Now.Month - bornDate.Month;
            int day = System.DateTime.Now.Day - bornDate.Day;
            int year = System.DateTime.Now.Year - bornDate.Year;            
            
            if (month == 0 && day <= 0 && year <= 0)
            {
                MessageBox.Show("Fecha no valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    //setting values 
                    student.Id = txtCarnet.Text;
                    student.Name = txtNombre.Text;
                    student.BorDate = dtpFechaNac.Value;
                    student.Email = txtCorreo.Text;
                    student.Responsable = txtResponsable.Text;
                }
                catch (Exception x)
                {                    
                    MessageBox.Show(x.Message);                    
                    return;
                }               
            }                      
            MessageBox.Show("Todo en orden");
            FrmNotas Notas = new FrmNotas();
            Notas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
