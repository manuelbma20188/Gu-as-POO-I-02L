using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class FrmRecibe : Form
    {
        public List<Person> PersonaRecibe = null; //creación de una lista que reciba
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que

        public FrmRecibe()
        {
            InitializeComponent();
        }

        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dgvRecibe.DataSource = null;
            dgvRecibe.DataSource = PersonaRecibe;
        }

        private void FrmRecibe_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado

            {
                PersonaRecibe.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1                
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }

        private void dgvRecibe_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvRecibe.SelectedRows[0];

            int pos = dgvRecibe.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado
            Person per = PersonaRecibe[pos];
        }
    }
}
