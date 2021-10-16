using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia4
{
    public class Moto : Vehiculo
    {
        //atributos
        private string colorMoto;
        private int cantLlantas;

        public string ColorMoto { get => colorMoto; set => colorMoto = value; }
        public int CantLlantas { get => cantLlantas; set => cantLlantas = value; }

        public Moto()
        {
            this.colorMoto = "0 datos";
            this.cantLlantas = 0;
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
            mensaje = "Moto -" + " Cantidad de pasajeros: " + this.CantPasajeros 
            + ", Consumo de gas: " + this.ConsumoGas(this.CapacidadGas) 
            + " litros/Gal" + ", Color: " + this.ColorMoto + ", Tipo de moto: " 
            + this.obtenerTipo();
            return mensaje;
        }

        public string obtenerTipo()
        {
            string Tipo = "";

            if (this.cantLlantas == 2 && this.cantPasajeros == 1)
            {
                Tipo = "Carreras";
            }
            else if (this.cantLlantas == 3 && this.cantPasajeros == 4)
            {
                Tipo = "Trimodo";
            }
            else if (this.cantLlantas == 4 && this.cantPasajeros == 2)
            {
                Tipo = "Cuadrimoto";
            }
            else if (this.cantLlantas == 0 && this.cantPasajeros == 0)
            {
                Tipo = "Sin Datos";
            }
            else
            {
                Tipo = "Moto normal";
            }

            return Tipo;
        }
        
        public string setDatos(string cantidadPasajeros, string capacidadGasolina, string colorVechiculo, string cantidadLlantas)
        {                        
            this.CantPasajeros = Convert.ToInt32(cantidadPasajeros);            
            this.CapacidadGas = Convert.ToDouble(capacidadGasolina);            
            this.ColorMoto = colorVechiculo;            
            this.CantLlantas = Convert.ToInt32(cantidadLlantas);
            return "";
        }
    }
}
