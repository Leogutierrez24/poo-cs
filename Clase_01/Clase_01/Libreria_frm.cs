using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIA;

namespace Clase_01
{
    public partial class Libreria_frm : Form
    {
        public Libreria Libreria;

        public Venta Venta;

        public Libreria_frm()
        {
            InitializeComponent();
            Libreria = new Libreria();
            Venta = new Venta();
            ActualizarTotal();
        }

        private void button1_Click(object sender, EventArgs e) // Agregar articulo
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                Articulo articuloSeleccionado = listBox1.SelectedItem as Articulo;
                Venta.AgregarArticulo(articuloSeleccionado);
                ActualizarTotal();
                ActualizarListBox(listBox2, Venta.Articulos);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Eliminar articulo
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                Articulo articuloSeleccionado = listBox2.SelectedItem as Articulo;
                Venta.QuitarArticulo(articuloSeleccionado);
                ActualizarTotal();
                ActualizarListBox(listBox2, Venta.Articulos);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Cerrar venta
        {
            if (Venta.Articulos.Count > 0)
            {
                Libreria.AgregarVenta(Venta);
                Venta = new Venta();
                ActualizarTotal();
                ActualizarRecaudacion();
                ActualizarListBox(listBox3, Libreria.Ventas);
                ActualizarListBox(listBox2, Venta.Articulos);
            }         
        }

        private void ActualizarTotal()
        {
            label5.Text = $"${Venta.Total}";
        }

        private void ActualizarRecaudacion()
        {
            label7.Text = $"{Libreria.Recaudacion}";
        }

        private void ActualizarListBox<T>(ListBox listBox, List<T> lista)
        {
            listBox.Items.Clear();
            lista.ForEach(item => listBox.Items.Add(item));
        }

        private void Libreria_frm_Load(object sender, EventArgs e)
        {
            ActualizarListBox(listBox1, Libreria.Articulos);
            ActualizarListBox(listBox2, Venta.Articulos);
            ActualizarListBox(listBox3, Libreria.Ventas);
        }
    }
}
