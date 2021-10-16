using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia4
{
    public class ClasePersona
    {

        protected string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        
        public ClasePersona()
        {
            this.nombre = "";
        }                     
    }
}
