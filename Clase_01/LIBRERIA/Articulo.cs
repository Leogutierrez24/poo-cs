using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class Articulo
    {
        public string Nombre { get; set; }

        public string Codigo { get; set; }

        public float Precio { get; set; }

        public Articulo(string nombre, string codigo, float precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Nombre} | {Codigo} | ${Precio}";
        }
    }
}
