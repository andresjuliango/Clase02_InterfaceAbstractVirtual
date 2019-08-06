using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Virtual
{
    public abstract class Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public virtual double Area()
        {
            return Base * Altura;
        }
    }
}
