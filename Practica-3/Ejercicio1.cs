using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private List<Customer> Customers = new List<Customer>(); //instace of my class Customers
        private int edit_index = -1;

        //function to validate empty txt's
        bool validarTxtVacio(GroupBox ejercicio1) //instace, type GroupBox
        {            
            bool empty=false;
            foreach (Control c in ejercicio1.Controls) // I check the elements of the groupbox
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

        //fuction to validate entrances

        //---validating amount
        private bool ValidateAmount(double amount)
        {
            bool var = false;
            if(amount ==0)
            {
                MessageBox.Show("Ingresa un valor diferente de cero!");
                txtMonto.Focus();
                txtMonto.Text = "";
                var = true;
            }
            return var;
        }

        //validating dui
        private bool ValidateDui(string duiTxt)
        {
            bool var = false;
            //regular expression to validate DUI entrance
            //format: ########-#
            Regex dui = new Regex("^[0-9]{8}-[0-9]{1}$");
            if (!dui.IsMatch(duiTxt))
            {
                MessageBox.Show("Formato de DUI incorrecto");
                txtDui.Focus();
                var = true;
            }
            return var;
        }

        //validating nit                
        private bool ValidateNit(string nitTxt)
        {
            bool var = false;
            //regular expression for NIT entrante
            //format: ####-######-###-#
            Regex nit = new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}");
            if (!nit.IsMatch(nitTxt))
            {
                MessageBox.Show("Formato de NIT incorrecto");
                txtNit.Focus();
                var = true;
            }
            return var;                
        }

        //validating account number's
        private bool ValidateAccount(string type, string number)
        {
            bool var = false;
            switch (type)
            {
                case "Corriente":
                    //regular expression 
                    //format: CA-00001
                    Regex corriente = new Regex("[(CC)]{2}-[0-9]{5}");
                    if (!corriente.IsMatch(number))
                    {
                        MessageBox.Show("Formato de numero de cuenta incorrecto");
                        txtNumeroCuenta.Focus();
                        var = true;
                    }
                    break;

                case "Ahorros":
                    //regular expression 
                    //format: CA-00001
                    Regex ahorros = new Regex("[(CA)]{2}-[0-9]{5}");
                    if (!ahorros.IsMatch(number))
                    {
                        MessageBox.Show("Formato de numero de cuenta incorrecto");
                        txtNumeroCuenta.Focus();
                        var = true;
                    }
                    break;

                case "Plazos":
                    //regular expression 
                    //format: CA-00001
                    Regex plazos = new Regex("[(CP)]{2}-[0-9]{5}");
                    if (!plazos.IsMatch(number))
                    {
                        MessageBox.Show("Formato de numero de cuenta incorrecto");
                        txtNumeroCuenta.Focus();
                        var = true;
                    }
                    break;
            }
            return var;
        }

        private void updateGrid()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Customers; 
        }

        private void delete(GroupBox groupBox)
        {            
            foreach (Control c in groupBox.Controls) // I check the elements of the groupbox
            {
                // if control c is a textbox and it is empty, vacio is gonna be true
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");            //welcome message :)
            //with this property, the user cant edit the options in cbo
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoCuenta.Items.Clear();
            cboSucursal.Items.Clear();

            //options for cbo's
            cboTipoCuenta.Items.Add("Corriente");
            cboTipoCuenta.Items.Add("Ahorros");
            cboTipoCuenta.Items.Add("Plazos");
            cboTipoCuenta.SelectedIndex = 0; //select option 1 by default

            cboSucursal.Items.Add("Sucursal Miguel VCO");
            cboSucursal.Items.Add("Sucursal Apex SV");
            cboSucursal.Items.Add("Sucursal Rodríguez SV");
            cboSucursal.Items.Add("Sucursal Toronto SV");
            cboSucursal.Items.Add("Sucursal DUX-306 SV");
            cboSucursal.SelectedIndex = 0; //select option 1 by default

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            if (!validarTxtVacio(groupBox1)) //if the function return false, we're gonna make all the proccess
            {                
                Customer customer = new Customer(); //instance of Customer's class
                //set value to attributes
                customer.Dui = txtDui.Text.ToString();
                customer.Names = txtNombres.Text.ToString();
                customer.Lastname = txtApellido.Text.ToString();
                customer.TypeAccount = cboTipoCuenta.Text.ToString();
                customer.Nit = txtNit.Text.ToString();
                customer.AccountNumb = txtNumeroCuenta.Text.ToString();
                customer.Amount = Convert.ToDouble(txtMonto.Text);
                customer.Place = cboSucursal.Text.ToString();

                //same logic, if the functions returns false, we're gonna make all the proccess
                if (!ValidateAmount(customer.Amount) && !ValidateDui(customer.Dui) && !ValidateNit(customer.Nit) && !ValidateAccount(customer.TypeAccount, customer.AccountNumb))
                {                    
                    MessageBox.Show("Cliente registrado satisfactoriamente");
                   // delete(groupBox1);

                    if(edit_index > -1)
                    {
                        Customers[edit_index] = customer;
                        edit_index = -1;
                    }
                    else
                    {
                        Customers.Add(customer);
                    }
                    updateGrid();
                }                                                                          
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //keypress event, validate txt 'only numbers' acepted
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (edit_index > -1) //verifica si hay un índice seleccionado

            {
                Customers.RemoveAt(edit_index);
                edit_index = -1; //resetea variable a -1                
                updateGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvDatos.SelectedRows[0];
            int posicion = dgvDatos.Rows.IndexOf(selected); //indicates the current row
            edit_index = posicion; 

            Customer customer = Customers[posicion]; 
            //attributes
            double amount = Convert.ToDouble(txtMonto.Text);
            string dui = txtDui.Text.ToString();
            string nit = txtNit.Text.ToString();
            string type = cboTipoCuenta.SelectedItem.ToString();
            string numer = txtNumeroCuenta.Text.ToString();
        }
    }
}
