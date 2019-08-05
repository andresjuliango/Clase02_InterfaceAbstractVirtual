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
            Entrenador entrenador = new Entrenador();
            entrenador.Nombre = "Carlos";
            entrenador.Apellidos = "Queiroz";
            entrenador.Nacionalidad = "Portugal";
            entrenador.Edad = 50;
            entrenador.FechaNacimiento = DateTime.Parse("21/01/1986");

            Futbolista jugador = new Futbolista()
            {
                Nombre = "Radamel",
                Apellidos = "Falcao",
                FechaNacimiento = DateTime.Parse("21/01/1986"),
                NumeroDorsal = 9,
            };

            //Imprimir(entrenador);
            Console.WriteLine("***************");
            Imprimir(jugador);
            Console.WriteLine("***************");
            Console.ReadLine();



        }

        static void Imprimir(SeleccionFutbol seleccionFutbol)
        {
            Console.WriteLine($"{seleccionFutbol.Nombre}{seleccionFutbol.Apellidos}");

            Futbolista futbolista = seleccionFutbol as Futbolista;
            Console.WriteLine(futbolista.NumeroDorsal);

            seleccionFutbol.JugarPartido();
        }
    }
}
