using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_10
{
    public class Estudiantes
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumCel { get; set; }

        public Estudiantes(string nombre, string apellidos, string direccion, string nombrePadre, string nombreMadre, DateTime fechaNacimiento, int numCel)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.NombrePadre = nombrePadre;
            this.NombreMadre = nombreMadre;
            this.FechaNacimiento = fechaNacimiento;
            this.NumCel = numCel;
        }
    }
}
