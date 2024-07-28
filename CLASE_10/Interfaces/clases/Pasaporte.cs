using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.clases
{
    public class Pasaporte : ICloneable
    {
		private string numero;
		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
