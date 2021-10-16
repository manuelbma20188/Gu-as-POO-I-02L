using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public class clsUniversitario : clsEstudiante
    {
        //atributos
        private string nombreUniversidad;        
        private string carrera;       
        private int materiasInscritas;
        private double notas;
        private double cum;
        public clsUniversitario()
        {
            this.nombreUniversidad = "";
            this.carrera = "";
            this.materiasInscritas = 0;
            this.notas = 0;
            this.cum = 0;
        }

        public string NombreUniversidad { get => nombreUniversidad; set => nombreUniversidad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public int MateriasInscritas { get => materiasInscritas; set => materiasInscritas = value; }
        public double Notas { get => notas; set => notas = value; }
        public double Cum { get => cum; set => cum = value; }
    }
}
