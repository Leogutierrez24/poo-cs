using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    public class GuitarraElectrica : Guitarra
    {
        private bool conectado;
        public bool Conectado
        {
            get { return conectado; }
            set { conectado = value; }
        }

        public override string Tocar()
        {
            string resultado;

            if (Conectado)
            {
                resultado = "Mujer Amante";
            }
            else resultado = "Sin Corriente";

            return resultado;
        }

        public void Encender()
        {
            this.conectado = !conectado;
        }
    }
}
