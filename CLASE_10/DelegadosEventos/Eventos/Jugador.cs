using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegadosEventos.ManejoExcepciones;

namespace DelegadosEventos.Eventos
{
    public class Jugador
    {
        Random random = new Random();

        public event delFestejar Festejar;

        private int edad;
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0 && value < 100)
                {
                    edad = value;
                } else
                {
                    throw new EdadException();
                }
            }
        }

        public void Patear()
        {
            if (random.Next(0,2) == 1)
            {
                this.Festejar("GOOOL");
            }
        }
    }
}
