using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    public class Factura
    {
        public string Numero;

        public string Letra;

        public string Importe;

        public string Imprimir()
        {
            return $"{Numero} {Letra} - Total a pagar $ {Importe}";
        }
    }
}
