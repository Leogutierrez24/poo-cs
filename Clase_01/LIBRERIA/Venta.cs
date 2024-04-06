using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class Venta
    {
        public List<Articulo> Articulos = new List<Articulo>();

        public float Total { get ; set; }

        public void AgregarArticulo(Articulo articulo)
        {
            Articulos.Add(articulo);
            Total += articulo.Precio;
        }

        public void QuitarArticulo(Articulo articulo)
        {
            Articulos.Remove(articulo);
            Total -= articulo.Precio;
        }

        public override string ToString()
        {
            return $"Total: ${Total}";
        }
    }
}
