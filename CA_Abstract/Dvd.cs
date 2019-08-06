using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstract
{
    public class Dvd : Producto
    {
        public int NroPistas { get; set; }

        public Dvd(string nombreProducto, double precioVenta, double costoFabrica, int nroPistas) : base(nombreProducto, precioVenta, costoFabrica)
        {
            NroPistas = nroPistas;
        }

        public override string ImprimirDatos()
        {
            return $"Dvd: {NroPistas} Pistas, Precio: {_precioVenta}, Pistas: {NroPistas}";
        }
    }
}
