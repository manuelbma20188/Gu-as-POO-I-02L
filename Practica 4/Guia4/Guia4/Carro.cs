using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public class Carro : Vehiculo
    {
        //atributos
        private int cantPuertas;
        private string tipoCaja;
        public int CantPuertas { get => cantPuertas; set => cantPuertas = value; }
        public string TipoCaja { get => tipoCaja; set => tipoCaja = value; }

        //Constructor 
        public Carro()
        {
            this.cantPuertas = 0;
            this.tipoCaja = "0 datos";
        }

        //Métodos y heredados
        public override double ConsumoGas(double capacidad)
        {            
            double consumo;
            consumo = (1 / (capacidad * 4.54));
            return consumo;
        }

        public override string Registrar()
        {
            string mensaje;            
            mensaje = "Carro -" + " Cantidad de pasajeros: " + this.CantPasajeros 
            + "\n" + ", Consumo de gas: " + this.ConsumoGas(this.CapacidadGas) + " litros/Gal"
            + "\n" + ", Puertas: " + this.CantPuertas + ", Caja de cambios: "
            + this.getClasificacion(); //metodo
            return mensaje;
        }
        public string getClasificacion()
        {
            string clasificado = "";

            if (this.cantPasajeros == 1 && this.cantPuertas == 2)
            {
                clasificado = "Carreras";
            }
            else if (this.cantPasajeros == 2 && this.cantPuertas == 2)
            {
                clasificado = "Deportivos";
            }
            else if (this.cantPasajeros == 5 && this.cantPuertas == 4)
            {
                clasificado = "Familiar";
            }
            else if (this.cantPasajeros == 0 && this.cantPuertas == 0)
            {
                clasificado = "Sin Datos";
            }
            else
            {
                clasificado = "Normal";
            }

            return clasificado;
        }
        
        public string setDatos(string cantidadPasajeros, string capacidadGasolina, string cantidadPuertas, string caja)
        {
                this.CantPasajeros = Convert.ToInt32(cantidadPasajeros);            
                this.CapacidadGas = Convert.ToDouble(capacidadGasolina);            
                this.CantPuertas = Convert.ToInt32(cantidadPuertas);            
                this.TipoCaja = caja;
                return "";
        }
    }
}
