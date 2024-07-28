using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WEBSOCKETS
{
    public partial class Form1 : Form
    {

        public UdpClient udpClient; // Objeto encargado en enviar y recibir mensajes.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

            udpClient = new UdpClient(endPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_textBox.Text), int.Parse(Puerto_textBox.Text));

            byte[] bytes = Encoding.UTF8.GetBytes(Mensaje_textBox.Text);

            udpClient.Send(bytes, bytes.Length, endPoint);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (udpClient.Available > 0)
            {
                IPEndPoint origin = new IPEndPoint(IPAddress.Any, 0);
                byte[] bytes = udpClient.Receive(ref origin);

                string mensaje = Encoding.UTF8.GetString(bytes);

                listBox1.Items.Insert(0, mensaje);
                listBox1.Items.Insert(0, origin.Address.ToString() + " " + origin.Port.ToString() + " dice: ");
            }
        }
    }
}
