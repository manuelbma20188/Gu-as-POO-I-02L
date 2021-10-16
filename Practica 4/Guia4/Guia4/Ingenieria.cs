using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public class clsIngenieria : clsUniversitario
    {
        //atributos
        private string nombreProyecto;       
        private int totalHorasPasantias;
        
        public clsIngenieria()
        {
            this.nombreProyecto = "";
            this.totalHorasPasantias = 0;
        }

        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public int TotalHorasPasantias { get => totalHorasPasantias; set => totalHorasPasantias = value; }

        public string getDatos(string Nombre, string Carnet, string NivelEstudio, string NombreUniversidad, string Carrera, string ManteriasInscritas, string Nota1, string Nota2, string Nota3, string NombreProyecto, string TotalHorasPasantias)
        {                        
            this.Nombre = Nombre;
            this.Carnet = Carnet;            
            this.NivelEstudio = NivelEstudio;            
            this.NombreUniversidad = NombreUniversidad;            
            this.Carrera = Carrera;            
            this.MateriasInscritas = Convert.ToInt32(ManteriasInscritas);           
            this.Notas = Math.Round((Convert.ToDouble(Nota1) + Convert.ToDouble(Nota2) + Convert.ToDouble(Nota3)) / 3, 2);                            
            this.Cum = Math.Round((Convert.ToDouble(Nota1) + Convert.ToDouble(Nota2) + Convert.ToDouble(Nota3)) / 4, 2);            
            this.NombreProyecto = NombreProyecto;            
            this.TotalHorasPasantias = Convert.ToInt32(TotalHorasPasantias);
            return "";
        }
    }
}
