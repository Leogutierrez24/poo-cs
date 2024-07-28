using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.clases
{
    public class Piano : Instrumento
    {
        public override string Tocar()
        {
            return $"Claro de luna";
        }
    }
}
