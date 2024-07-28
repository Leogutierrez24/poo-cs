using Interfaces.clases;
using Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITocable rallador = new Rallador();
            rallador.Nombre = "Rallador";

            Instrumento p = new Piano();
            p.Nombre = "Piano";

            listBox1.Items.Add(p);
            listBox1.Items.Add(rallador);

            CrearPersonas();
            EnlazarPersonas();
        }

        void EnlazarPersonas()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = personas;
        }

        List<Persona> personas = new List<Persona>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                label2.Text = ((ITocable)listBox1.SelectedItem).Tocar();
            }
        }

        Random random = new Random();

        void CrearPersonas()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Cristian");
            nombres.Add("Leonel");
            nombres.Add("Martin");
            nombres.Add("El intrepido");

            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(0, nombres.Count);
                Persona p = new Persona();
                p.Nombre = nombres[x];
                p.Edad = random.Next(20, 60);
                p.Pasaporte = new Pasaporte();
                p.Pasaporte.Numero = i.ToString();
                personas.Add(p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personas.Sort();
            EnlazarPersonas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Persona p = listBox2.SelectedItem as Persona;
            listBox3.Items.Add(p.Clone());
            listBox3.Items.Add(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{listBox2.SelectedItem == listBox3.SelectedItem}");
        }
    }
}
