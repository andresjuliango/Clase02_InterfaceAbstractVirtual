using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public class SeleccionFutbol : IIntegranteSeleccionFutbol
    {
        #region [Propiedades]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        #endregion

        #region [Constructores]
        public SeleccionFutbol()
        {
        }

        public SeleccionFutbol(int id, string nombre, string apellidos, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        #endregion

        #region [Implementación de métodos de la interface]
        public void Concentrarse()
        {
            Console.WriteLine("Concentrarse");
        }

        public void Viajar()
        {
            Console.WriteLine("Viajar");
        }

        public void JugarPartido()
        {
            Console.WriteLine("Jugar Partido");
        } 
        #endregion
    }
}
