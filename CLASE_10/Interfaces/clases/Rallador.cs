using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.interfaces;

namespace Interfaces.clases
{
    public class Rallador : ITocable
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tocar()
        {
            return $"Chiqui chin chiqui chin";
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
