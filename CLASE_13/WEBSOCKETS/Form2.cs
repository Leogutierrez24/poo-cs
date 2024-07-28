using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WEBSOCKETS
{
    public partial class Form2 : Form
    {
        TcpListener listener;  // Se encarga de escuchar.

        List<TcpClient> clientes = new List<TcpClient>(); // Se encarga de conectarse y mantener la conexión.

        TcpClient clienteLocal; 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);
            listener = new TcpListener(endPoint);
            listener.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listener.Pending())
            {
                TcpClient cliente = listener.AcceptTcpClient();
                clientes.Add(cliente);
            }

            if (clientes.Count > 0)
            {
                foreach (TcpClient cliente in clientes)
                {
                    if (cliente.Connected)
                    {
                        if (cliente.Available > 0)
                        {
                            EndPoint origen = new IPEndPoint(IPAddress.Any, 0);
                            byte[] bytes = new byte[cliente.Available];
                            cliente.Client.ReceiveFrom(bytes, ref origen);

                            string mensaje = Encoding.UTF8.GetString(bytes);

                            listBox1.Items.Insert(0, mensaje);
                            listBox1.Items.Insert(0, $"{cliente.Client.RemoteEndPoint} dice: ");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint myPoint = new IPEndPoint(IPAddress.Any, 0);
            clienteLocal = new TcpClient(myPoint);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_textBox.Text), int.Parse(Puerto_textBox.Text));
            clienteLocal.Connect(endPoint);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clienteLocal != null && clienteLocal.Connected)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Mensaje_textBox.Text);
                clienteLocal.Client.Send(bytes);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clienteLocal.Client.Close();
            clienteLocal.Close();
            clienteLocal = null;
            GC.Collect();
        }
    }
}
