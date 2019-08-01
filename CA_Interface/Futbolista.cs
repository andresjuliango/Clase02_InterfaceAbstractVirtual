using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public class Futbolista : SeleccionFutbol
    {
        public int NumeroDorsal { get; set; }

        public void Entrevistar()
        {
            Console.WriteLine("Realizar Entrevista");
        } 
    }
}
