using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Guia4
{
    public partial class FrmEstudiante : Guia4.FrmRegistro
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        //listado de class individuo
        private List<Individuo> Estudiantes = new List<Individuo>();        
        private int edit_indice = -1; //var para dgv

        private void FrmEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        

        private void actualizarGrid()
        {
            dataGridView1.DataSource = null;            
            dataGridView1.DataSource = Estudiantes;
        }
        private void limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCodigo.Clear();
        }

        private void guardar()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtCodigo.Text))
            {                    
                    Individuo estudiante = new Individuo();
                    estudiante.Nombre = txtNombre.Text;
                    estudiante.Usuario = txtUsuario.Text;
                    estudiante.Codigo = txtCodigo.Text;

                    if (edit_indice > -1) 
                    {
                        Estudiantes[edit_indice] = estudiante;
                        edit_indice = -1;
                    }
                    else
                    {                        
                        Estudiantes.Add(estudiante);
                    }                    
                    actualizarGrid();
                    limpiar();               
            }
            else
            {
                MessageBox.Show("Campos vacios dentro del form");
            }
        }

        private void update()
        {
            DataGridViewRow selected = dataGridView1.SelectedRows[0];
            int posicion = dataGridView1.Rows.IndexOf(selected);//fila <<actual>>
            edit_indice = posicion;             
            Individuo estudiante = Estudiantes[posicion];
            
            txtNombre.Text = estudiante.Nombre;
            txtUsuario.Text = estudiante.Usuario;
            txtCodigo.Text = estudiante.Codigo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            guardar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {            
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            update();
        }
    }
}
