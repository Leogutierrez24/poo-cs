using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Importe = textBox3.Text;
            factura.Letra = comboBox1.SelectedItem.ToString();
            factura.Numero = textBox1.Text;

            listBox1.Items.Add(factura);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                Factura factura = listBox1.SelectedItem as Factura;
                MessageBox.Show($"{factura}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Libreria_frm form = new Libreria_frm();
            form.ShowDialog();
        }
    }
}
