using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_10
{
    public class Inventario
    {       
        public double CostoUnidad { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }      
        public double Ganancia { get; set; }
        public string Productos { get; set; }

        public Inventario(double costoUnidad, double precioCompra, double precioVenta, double ganancia, string productos)
        {
            this.CostoUnidad = costoUnidad;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.Ganancia = ganancia;
            this.Productos = productos;
        }
    }
}
