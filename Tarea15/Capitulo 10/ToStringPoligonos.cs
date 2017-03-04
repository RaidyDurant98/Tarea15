using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_10
{
    public class ToStringPoligonos
    {
        public float Perimetro { get; set; }
        public float Apotema { get; set; }

        public ToStringPoligonos(float perimetro, float apotema)
        {
            this.Perimetro = perimetro;
            this.Apotema = apotema;
        }

        public ToStringPoligonos()
        {

        }

        public double AreaPoligono
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 25; Apotema = 4.6f; }
        }

        public static void main()
        {          
            Console.WriteLine(new ToStringPoligonos().ToString());
        }
    }
}
