using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    class Individuo
    {
        protected string nombre;
        protected string usuario;
        protected string codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }

    class Docente : Individuo 
    {
        protected string materia;

        public string Materia { get => materia; set => materia = value; }
    }
}
