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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Person> Personas = new List<Person>();
        //creo un listado para que guarde los valores de filas que se van seleccionando
        private List<Person> Selected = new List<Person>(); 

        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que
        //no hay ninguno seleccionado, esto servirá para el DataGridView.

        private void actualizarGrid()
        {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = Personas; /*los nombres de columna que veremos son los de las propiedades*/
        }       

        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtBuscar.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Person per = new Person();
            per.Nombre = txtNombre.Text;
            per.Apellido = txtApellido.Text;
            per.Telefono = txtTelefono.Text;
            per.Correo = txtCorreo.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {

                Personas.Add(per); /*al arreglo de Personas le agrego el objeto creado con todos los datos que recolecté*/

            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            limpiar();//mandamos a llamar la función que limpia
            dgvContactos.ClearSelection(); //limpio el dgv para que no haya ninguna fila seleccionada            
        }

        

        private void dgvContactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvContactos.SelectedRows[0];            

            int pos = dgvContactos.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado                                                                                                      
            Person per = Personas[pos]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/            
            txtNombre.Text = per.Nombre; //lo que tiene el atributo se lo doy al textbox
            txtApellido.Text = per.Apellido;
            txtTelefono.Text = per.Telefono;
            txtCorreo.Text = per.Correo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado

            {
                Personas.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRecibe formulario = new FrmRecibe(); //instancia de otro formulario            
            if (dgvContactos.Rows.Count != 0) { //valido en caso de no haber ningún registro
            formulario.Show(); //mostar el segundo formulario            
            Person per = new Person(); //instancia de la clase person
            //acá obtengo los valores que se van seleccionando acorde a la posicion
            string nombre = (dgvContactos.SelectedCells[0].Value.ToString()); //pos 0 para nombre
            string apellido = (dgvContactos.SelectedCells[1].Value.ToString());
            string tel = (dgvContactos.SelectedCells[2].Value.ToString());
            string correo = (dgvContactos.SelectedCells[3].Value.ToString());
            //asigno valores
            per.Nombre = nombre;
            per.Apellido = apellido;
            per.Telefono = tel;
            per.Correo = correo;
            //y guardo los valores asignados (o seleccionados) en mi nueva variable Selected
            Selected.Add(per);
            //mando los valores nuevos a la otra clase
            formulario.PersonaRecibe = Selected;
            }
            else
            {
                MessageBox.Show("Aún no se han ingresado valores");                
            }
        }

        //el evento textchanged me ayuda a verificar lo escrito en el txt
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {            
            //hago un buscador con base a la columna de Nombre
            foreach (DataGridViewRow Row in dgvContactos.Rows) //recorro las filas del dgv
            {                
                //convierto en string a la row nombre
                string Valor = Convert.ToString(Row.Cells["Nombre"].Value);

                //si dicho valor convertido coincide con lo que se ha escrito en el txt, eureka! palabra encontrada
                if (Valor == this.txtBuscar.Text)
                {
                    MessageBox.Show("Eureka, valor encontrado");
                    Row.Selected = true; //LINEA IMPORTANTE, me selecciona a la fila esperada                    
                }
            }
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {            
            MessageBox.Show("Dicho ejercicio funciona de dos maneras: \n\n1) Seleccionas la fila que deseaas para mandar los valores al otro formulario" +
                "\n\n2) Buscas por <<Nombre>> por medio del txt y automáticamente se selecciona la fila.");
        }
    }
}
