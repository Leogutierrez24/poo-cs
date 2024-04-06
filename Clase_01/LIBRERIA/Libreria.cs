using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class Libreria
    {
        public List<Articulo> Articulos {  get; set; }

        public List<Venta> Ventas = new List<Venta>();

        public float Recaudacion { get; set; }
        
        public Libreria()
        {            
            Articulos = new List<Articulo> 
            { 
                new Articulo("Lápiz", "AS213", 125),
                new Articulo("Goma", "BD203", 70),
                new Articulo("Lapicera", "ZW125", 199.50f),
            };
        }

        public void AgregarVenta(Venta venta)
        {
            Ventas.Add(venta);
            Recaudacion += venta.Total;
        }

    }
}
