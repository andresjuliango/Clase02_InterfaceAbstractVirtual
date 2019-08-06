using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstract
{
    public class Libro : Producto
    {
        public string Editorial { get; set; }

        public Libro(string nombreProducto, double precioVenta, double costoFabrica, string editorial) : base(nombreProducto, precioVenta, costoFabrica)
        {
            Editorial = editorial;
        }

        public override string ImprimirDatos()
        {
            return $"Libro: {_nombreProducto}, Precio: {_precioVenta}, de la editorial {Editorial}";
        }
    }
}
