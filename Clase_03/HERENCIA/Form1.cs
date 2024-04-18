using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrumento instrumento = listBox1.SelectedItem as Instrumento;
            textBox1.Text = instrumento.Tocar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instrumento instrumento = listBox1.SelectedItem as Instrumento;            

            if (instrumento is GuitarraElectrica)
            {
                GuitarraElectrica ge = instrumento as GuitarraElectrica;
                ge.Encender();
                label1.Text = "Conectada: " + ge.Conectado.ToString();
            } else
            {
                label1.Text = "No aplica";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instrumento instrumento;

            if (radioButton1.Checked)
            {
                instrumento = new Guitarra();
                instrumento.Nombre = "Guitarra";
            }
            else if (radioButton2.Checked)
            {
                instrumento = new GuitarraElectrica();
                instrumento.Nombre = "Guitarra Eléctrica";
            }
            else
            {
                instrumento = new Piano();
                instrumento.Nombre = "Piano";
            }

            listBox1.Items.Add(instrumento);
        }
    }
}
