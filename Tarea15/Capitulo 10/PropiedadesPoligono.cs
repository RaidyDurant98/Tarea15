using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_10
{
    public class PropiedadesPoligono
    {
        public float Perimetro { get; set; }
        public float Apotema { get; set; }

        public PropiedadesPoligono(float Perimetro, float Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public PropiedadesPoligono()
        {

        }

        public float AreaPoligono
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 25; Apotema = 4.6f; }
        }
    }
}
