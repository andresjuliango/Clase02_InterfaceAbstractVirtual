using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstract
{
    public abstract class Producto
    {
        protected string _nombreProducto;
        protected double _precioVenta;
        protected double _costoFabrica;
     

        public Producto(string nombreProducto, double precioVenta, double costoFabrica)
        {
            _nombreProducto = nombreProducto;
            _precioVenta = precioVenta;
            _costoFabrica = costoFabrica;
        }

        public abstract string ImprimirDatos();

    }
}
