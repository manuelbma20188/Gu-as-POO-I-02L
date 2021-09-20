using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Product> Productos = new List<Product>();
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.

        private void actualizarGrid()
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = Productos; /*los nombres de columna que veremos son los de las propiedades*/
        }

        //metodo que recorre a todos los txt del groupbox y verifica si están vacios
        bool validarTxtVacio(GroupBox groupBox) //instace, type GroupBox
        {
            bool empty = false;
            foreach (Control c in groupBox.Controls) // I check the elements of the groupbox
            {
                // if control c is a textbox and it is empty, vacio is gonna be true
                if (c.GetType() == typeof(TextBox) && c.Text == String.Empty)
                {
                    empty = true;
                }
            }

            //print a message
            if (empty == true)
            {
                MessageBox.Show("Llena los campos que estén vacios!");
            }

            return empty;
        }

        private void reseteo()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtRuta.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvListado.SelectedRows[0];
            int posicion = dgvListado.Rows.IndexOf(selected); //almacena en cual fila estoy
            edit_indice = posicion; //copio esa variable en índice editado

            Product product = Productos[posicion]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            //lo que tiene el atributo se lo doy al textbox

            txtNombre.Text = product.Nombre;
            txtDescripcion.Text = product.Descripcion;
            txtMarca.Text = product.Marca;
            txtPrecio.Text = Convert.ToString(product.Precio);
            txtStock.Text = Convert.ToString(product.Stock);
            pictureBox1.Image = Image.FromFile(product.Ruta); //paso al picture box la ruta de la img guardada
            txtRuta.Text = product.Ruta;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validarTxtVacio(groupBox1))
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades
                Product product = new Product();
                product.Nombre = txtNombre.Text;
                product.Descripcion = txtDescripcion.Text;
                product.Marca = txtMarca.Text;
                product.Precio = float.Parse(txtPrecio.Text);
                product.Stock = int.Parse(txtStock.Text);
                product.Ruta = txtRuta.Text; //se añadió un nuevo atributo a la clase para guardar ruta de img subida
                if (edit_indice > -1) //verifica si hay un índice seleccionado
                {
                    Productos[edit_indice] = product;
                    edit_indice = -1;
                }
                else
                {

                    Productos.Add(product); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/
                }
                actualizarGrid();//llamamos al procedimiento que guarda en datagrid
                reseteo(); //llamamos al método que resetea
            }
                
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado

            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                //limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.txtRuta.Text = this.openFileDialog1.FileName;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //user can write only one . 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //user can write only one . 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
