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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();            
            setCbos();
        }

        private void setCbos()
        {            
            //opciones para los cbo's
            cboCantPasajerosMoto.Items.Add("1");
            cboCantPasajerosMoto.Items.Add("2");
            cboCantPasajerosMoto.Items.Add("4");
            
            cboCantLlantasMoto.Items.Add("2");
            cboCantLlantasMoto.Items.Add("3");
            cboCantLlantasMoto.Items.Add("4");
            
            cboCantPasajerosCarro.Items.Add("1");
            cboCantPasajerosCarro.Items.Add("2");
            cboCantPasajerosCarro.Items.Add("5");
            
            cboCantPuertasCarro.Items.Add("2");
            cboCantPuertasCarro.Items.Add("4");
            
            cboTipoCaja.Items.Add("Manual");
            cboTipoCaja.Items.Add("Automatico");
            
            cboCantPasajerosBus.Items.Add("20");
            cboCantPasajerosBus.Items.Add("30");
            cboCantPasajerosBus.Items.Add("40");
            
            cboPosicionMotor.Items.Add("Atrás");
            cboPosicionMotor.Items.Add("Delante");
        }

        private void limpiarForm()
        {                                    
            txtCapacidadGasMoto.Text = "";
            txtColorMoto.Text = "";            
                        
            txtCapacidadGasCarro.Text = "";            
                        
            txtCapacidadGasBus.Text = "";            
            txtLongitudBus.Text = "";
        }

        private void registroMotos()
        {            
            Moto moto = new Moto();
            moto.setDatos(cboCantPasajerosMoto.Text, txtCapacidadGasMoto.Text, txtColorMoto.Text, cboCantLlantasMoto.Text);            
            limpiarForm();
            setCbos();            
            listBox1.Items.Add(moto.Registrar());
            //mando al tabpage
            MenuControl.SelectedTab = tabPage5;
        }

        private void registroCarros()
        {         
            Carro carro = new Carro();
            carro.setDatos(cboCantPasajerosCarro.Text, txtCapacidadGasCarro.Text, cboCantPuertasCarro.Text, cboTipoCaja.Text);            
            limpiarForm();
            setCbos();            
            listBox1.Items.Add(carro.Registrar());
            MenuControl.SelectedTab = tabPage5;
        }

        private void registroBuses()
        {            
            AutoBus bus = new AutoBus();
            bus.getDatos(cboCantPasajerosBus.Text, txtCapacidadGasBus.Text, cboPosicionMotor.Text, txtLongitudBus.Text);            
            limpiarForm();
            setCbos();            
            listBox1.Items.Add(bus.Registrar());
            MenuControl.SelectedTab = tabPage5;
        }

        private void btnRegistroMotos_Click(object sender, EventArgs e)
        {            
            MenuControl.SelectedTab = tabPage1;
        }

        private void btnRegistroCarros_Click(object sender, EventArgs e)
        {            
            MenuControl.SelectedTab = tabPage2;
        }

        private void btnRegistroBuses_Click(object sender, EventArgs e)
        {            
            MenuControl.SelectedTab = tabPage4;
        }

        private void btnVerRegistro_Click(object sender, EventArgs e)
        {            
            
        }

        private void btnRegistraMoto_Click(object sender, EventArgs e)
        {            
            registroMotos();
        }

        private void btnRegistraCarro_Click(object sender, EventArgs e)
        {            
            registroCarros();
        }

        private void btnRegistraBus_Click(object sender, EventArgs e)
        {            
            registroBuses();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {                        
            limpiarForm();
            setCbos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
