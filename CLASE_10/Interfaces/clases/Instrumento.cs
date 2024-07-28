using Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.clases
{
    public abstract class Instrumento : ITocable
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public abstract string Tocar();

        public override string ToString()
        {
            return nombre;
        }
    }
}
