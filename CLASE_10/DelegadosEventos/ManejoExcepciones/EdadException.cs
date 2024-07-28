using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos.ManejoExcepciones
{
    public class EdadException : Exception
    {
        public override string Message => "La edad es inválida.";
    }
}
