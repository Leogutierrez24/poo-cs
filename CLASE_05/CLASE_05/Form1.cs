using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            listBox1.Items.Add(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(dateTimePicker1.Value);
            listBox1.Items.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(textBox1.Text, textBox2.Text);
            listBox1.Items.Add(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor("24");

            listBox1.Items.Add(p);

            GC.Collect();
        }
    }
}
