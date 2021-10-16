using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public class clsEstudiante : ClasePersona
    {
        //atributos
        private string carnet;
        private string nivelEstudio;

        public string Carnet { get => carnet; set => carnet = value; }
        public string NivelEstudio { get => nivelEstudio; set => nivelEstudio = value; }
        
        public clsEstudiante()
        {
            this.carnet = "";
            this.nivelEstudio = "";
        }        
    }
}
