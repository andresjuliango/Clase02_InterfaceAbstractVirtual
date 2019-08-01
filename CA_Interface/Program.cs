using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador queiroz = new Entrenador();
            queiroz.Nombre = "Carlos";
            queiroz.Apellidos = "Queiroz";

            Futbolista jugador = new Futbolista()
            {
                Nombre = "Radamel",
                Apellidos = "Falcao"
            };

            // TODO: Tarea, Imprimir la información y llenar los demás campos

        }
    }
}
