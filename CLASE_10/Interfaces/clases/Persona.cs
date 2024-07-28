using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.clases
{
    public class Persona : IComparable<Persona>, ICloneable
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int edad;
		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		private Pasaporte pasaporte;
		public Pasaporte Pasaporte
		{
			get { return pasaporte; }
			set { pasaporte = value; }
		}

		public override string ToString()
        {
			return $"{nombre} {edad}";
        }

        public int CompareTo(Persona other)
        {
            if (other == null)
			{
				return 1;
			} else
			{
				return edad.CompareTo(other.edad);
			}
        }

        public object Clone()
        {
			Persona p = this.MemberwiseClone() as Persona;
			p.Pasaporte = p.Pasaporte.Clone() as Pasaporte;

			return p;
        }
    }
}
