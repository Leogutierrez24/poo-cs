using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    public class Operacion
    {
        public delegate void delOperar(int numero1, int numero2);

        public delOperar Operar;
    }
}
