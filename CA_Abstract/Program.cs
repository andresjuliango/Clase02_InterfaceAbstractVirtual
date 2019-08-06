using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("El principito",25000,25000,"Norma");

            Dvd dvd = new Dvd("El Secreto",5000,4500,1);
            

            Console.WriteLine("Productos");
            Console.WriteLine(libro.ImprimirDatos());
            Console.WriteLine(dvd.ImprimirDatos());
            Console.ReadLine();
        }

    
    }
}
