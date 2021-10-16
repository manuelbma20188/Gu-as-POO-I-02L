using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    class Persona
    {
        protected string nombre;
        protected string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
    class Empleado : Persona
    {

    }

    class Estudiante : Persona
    {
        protected string carnet;
        protected string nivelEstudio;

        protected string Carnet { get => carnet; set => carnet = value; }
        protected string NivelEstudio { get => nivelEstudio; set => nivelEstudio = value; }
    }
    class Universitario : Estudiante
    {
        protected string nombreUni;
        protected string carrera;
        protected string materiasInscritas;
        protected string notas;
        protected string cum;

        protected string NombreUni { get => nombreUni; set => nombreUni = value; }
        protected string Carrera { get => carrera; set => carrera = value; }
        protected string MateriasInscritas { get => materiasInscritas; set => materiasInscritas = value; }
        protected string Notas { get => notas; set => notas = value; }
        protected string Cum { get => cum; set => cum = value; }
    }
    class Ingenieria : Universitario
    {
        protected string nombreProyecto;
        protected string totalHoras;
        protected string horasCompletas;

        protected string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        protected string TotalHoras { get => totalHoras; set => totalHoras = value; }
        protected string HorasCompletas { get => horasCompletas; set => horasCompletas = value; }
    }
}
