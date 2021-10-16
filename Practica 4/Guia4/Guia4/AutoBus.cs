using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public class AutoBus : Vehiculo
    {
        //atributos
        private string posicionMotor;
        private double longitud;

        public string PosicionMotor { get => posicionMotor; set => posicionMotor = value; }
        public double Longitud { get => longitud; set => longitud = value; }

        public AutoBus()
        {
            this.posicionMotor = "0 datos";
            this.longitud = 0;
        }

        public override double ConsumoGas(double capacidad)
        {            
            double consumo;
            consumo = (1 / (capacidad * 4.54));
            return consumo;
        }

        public override string Registrar()
        {
            string mensaje;
            mensaje = "Bus -" + " Cantidad de pasajeros: " + this.CantPasajeros
            + "\n"+ ", Consumo de gas: " + this.ConsumoGas(this.CapacidadGas) + " litros/Gal" 
            + "\n" +  ", Posicion del motor: " + this.PosicionMotor + ", Tipo de bus: "
            + this.obtenerClasificacion(); //mando a llamar metodo
            return mensaje;
        }
        public string obtenerClasificacion()
        {
            string tipo = "";

            if (this.CantPasajeros == 20)
            {
                if (this.Longitud >= 7 || this.Longitud <= 10)
                {
                    tipo = "Buseta";
                }
            }
            else if (this.CantPasajeros == 30)
            {
                if (this.Longitud >= 11 || this.Longitud <= 15)
                {
                    tipo = "AutoBus";
                }
            }
            else if (this.CantPasajeros == 40)
            {
                if (this.Longitud >= 16 || this.Longitud <= 19)
                {
                    tipo = "Bus articulado";
                }
            }
            else if (this.CantPasajeros == 0 && this.Longitud == 0)
            {
                tipo = "Sin Datos";
            }
            else
            {
                tipo = "Normal";
            }

            return tipo;
        }
        
        public string getDatos(string capacidadGasolina, string cantidadPasajeros, string posicionMotor, string longitudBus)
        {                        
                this.CantPasajeros = Convert.ToInt32(cantidadPasajeros);                                       
                this.CapacidadGas = Convert.ToDouble(capacidadGasolina);                                        
                this.PosicionMotor = posicionMotor;                        
                this.Longitud = Convert.ToDouble(longitudBus);            
                return "";//retoorna cadena ""
        }
    }
}
