using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public class Entrenador : SeleccionFutbol
    {
        public string Nacionalidad { get; set; }

        public void PlanificarEntrenamiento()
        {
            Console.WriteLine("Planificar Entrenamiento");
        }
    }
}
