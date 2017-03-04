using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_10
{
    public class SobrecargaPoligono
    {
        public float Apotema { get; set; }
        public float Perimetro { get; set; }

        public SobrecargaPoligono(float apotema, float perimetro)
        {
            this.Apotema = apotema;
            this.Perimetro = perimetro;
        }

        public SobrecargaPoligono()
        {

        }
    }
}
