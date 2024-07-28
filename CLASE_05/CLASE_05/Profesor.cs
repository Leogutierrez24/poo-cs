using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_05
{
    public class Profesor : Persona
    {
		private string legajo;
		public string Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		public Profesor(string legajo) : base()
		{
			this.legajo = legajo;
		}

        ~Profesor()
		{
			MessageBox.Show("Me estoy muriendo " + Nombre);
		}

        public override string ToString()
        {
            return base.ToString() + " " + legajo;
        }

    }
}
