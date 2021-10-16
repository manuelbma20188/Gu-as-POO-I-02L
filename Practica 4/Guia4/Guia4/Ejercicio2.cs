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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
            //tabpage solicitado por la guia
            MenuControl.SelectedTab = tabPage1;

            nombrarCols();
        }

        //lista de tipo clase estudiante
        private List<clsEstudiante> Estudiantes = new List<clsEstudiante>();
        
        private void nombrarCols()
        {            
            dgvEstudiante.DataSource = null;
            dgvEstudiante.ColumnCount = 10;
            //establecemos nombres para columnas
            dgvEstudiante.Columns[0].Name = "Nombre";
            dgvEstudiante.Columns[1].Name = "Carnet";
            dgvEstudiante.Columns[2].Name = "Lvl Estudio";
            dgvEstudiante.Columns[3].Name = "Universidad";
            dgvEstudiante.Columns[4].Name = "Carrera";
            dgvEstudiante.Columns[5].Name = "N materias Inscritas";
            dgvEstudiante.Columns[6].Name = "Promedio de Notas";
            dgvEstudiante.Columns[7].Name = "cum";
            dgvEstudiante.Columns[8].Name = "Nombre proyecto";
            dgvEstudiante.Columns[9].Name = "Total Horas Pasantías";
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            txtCarnet.Text = "";
            txtNivelEstudio.Text = "";
            txtNombreUniversidad.Text = "";
            txtCarrera.Text = "";
            nudMateriasInscritas.Value = 1;
            nudNota1.Value = 1;
            nudNota2.Value = 1;
            nudNota3.Value = 1;
            txtNombreProyecto.Text = "";
            nudTotalHorasPasantias.Value = 1;
        }
        
        public int contadora = 0;
        private void guardarAlumnos()
        {            
            clsIngenieria estudiaIng = new clsIngenieria();
            estudiaIng.getDatos(txtNombre.Text, txtCarnet.Text, txtNivelEstudio.Text, txtNombreUniversidad.Text, txtCarrera.Text, nudMateriasInscritas.Value.ToString(), nudNota1.Value.ToString(), nudNota2.Value.ToString(), nudNota3.Value.ToString(), txtNombreProyecto.Text, nudTotalHorasPasantias.Value.ToString());            
            Estudiantes.Add(estudiaIng);
            limpiarForm();
            do
            {
                dgvEstudiante.Rows.Add(1);//Agrega una fila porque se presentarán nuevos datos
                dgvEstudiante.Rows[contadora].Cells[0].Value = estudiaIng.Nombre;
                dgvEstudiante.Rows[contadora].Cells[1].Value = estudiaIng.Carnet;
                dgvEstudiante.Rows[contadora].Cells[2].Value = estudiaIng.NivelEstudio;
                dgvEstudiante.Rows[contadora].Cells[3].Value = estudiaIng.NombreUniversidad;
                dgvEstudiante.Rows[contadora].Cells[4].Value = estudiaIng.Carrera;
                dgvEstudiante.Rows[contadora].Cells[5].Value = estudiaIng.MateriasInscritas;
                dgvEstudiante.Rows[contadora].Cells[6].Value = estudiaIng.Notas;
                dgvEstudiante.Rows[contadora].Cells[7].Value = estudiaIng.Cum;
                dgvEstudiante.Rows[contadora].Cells[8].Value = estudiaIng.NombreProyecto;
                dgvEstudiante.Rows[contadora].Cells[9].Value = estudiaIng.TotalHorasPasantias;

                contadora++;
            } while (contadora < 1);            
            MenuControl.SelectedTab = tabPage2;
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {            
            guardarAlumnos();
        }

        private void btnRegresarEstudiante_Click(object sender, EventArgs e)
        {            
            MenuControl.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
