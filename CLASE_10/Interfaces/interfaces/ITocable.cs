using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.interfaces
{
    public interface ITocable
    {
        string Nombre { get; set; }

        string Tocar();
    }
}
