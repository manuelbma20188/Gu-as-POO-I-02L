using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia4
{
    public class Vehiculo 
    {
        //Patron de validación para números con expresión regular
        Regex regexNumero = new Regex(@"^[0.0-9.9]+$");

        //cadena de expresiones regulares donde solo se aceptan letras
        Regex regexLetra = new Regex(@"^[a-zA-Z]+$");

        //atributos
        protected int cantPasajeros;
        protected double capacidadGas;

        protected int CantPasajeros { get => cantPasajeros; set => cantPasajeros = value; }
        protected double CapacidadGas { get => capacidadGas; set => capacidadGas = value; }
        
        public Vehiculo()
        {
            this.cantPasajeros = 0;
            this.capacidadGas = 0;
        }

        public virtual double ConsumoGas(double capacidad)
        {           
            return 0;
        }

        public virtual string Registrar()
        {            
            return "";
        }        
    }
}
