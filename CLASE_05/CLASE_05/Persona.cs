using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_05
{
    public class Persona
    {
		private DateTime fechaNacimiento;
		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public Persona()
		{
			fechaNacimiento = DateTime.Now;
		}

		public Persona(DateTime f)
		{
			fechaNacimiento = f;
		}

		public Persona(string nombre, string apellido) : this()
		{
			this.nombre = nombre;
			this.apellido = apellido;
		}

        public override string ToString()
        {
            return $"{nombre} {apellido} {fechaNacimiento.ToShortDateString()}";
        }
    }
}
