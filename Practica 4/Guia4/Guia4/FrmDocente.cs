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
    public partial class FrmDocente : Guia4.FrmRegistro
    {
        public FrmDocente()
        {
            InitializeComponent();
        }
        //lista de tipo class docente
        private List<Docente> Docentes = new List<Docente>();        
        private int edit_indice = -1; //var para dgv

        private void FrmDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCodigo.Clear();
            txtMateria.Clear();
        }

        private void actualizarGrid()
        {
            dataGridView1.DataSource = null;            
            dataGridView1.DataSource = Docentes;
        }

        private void guardar()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtMateria.Text))
            {                                                   
                    Docente docente = new Docente();
                    docente.Nombre = txtNombre.Text;
                    docente.Usuario = txtUsuario.Text;
                    docente.Codigo = txtCodigo.Text;
                    docente.Materia = txtMateria.Text;

                    if (edit_indice > -1) 
                    {
                        Docentes[edit_indice] = docente;
                        edit_indice = -1;
                    }
                    else
                    {                        
                        Docentes.Add(docente);
                    }                    
                    actualizarGrid();
                    limpiar();               
            }
            else
            {
                MessageBox.Show("Campos vacíos dentro del form");
            }
        }

        private void update()
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {                
                DataGridViewRow selected = dataGridView1.SelectedRows[0];
                int posicion = dataGridView1.Rows.IndexOf(selected);
                edit_indice = posicion;                 
                Docente docente = Docentes[posicion];
                //asignando valores de txt's
                txtNombre.Text = docente.Nombre;
                txtUsuario.Text = docente.Usuario;
                txtCodigo.Text = docente.Codigo;
                txtMateria.Text = docente.Materia;
            }
            else
            {
                MessageBox.Show("Selecciona la celda respectiva");
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            guardar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            update();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {            
            limpiar();
        }
    }
}
