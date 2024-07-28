using DelegadosEventos.Eventos;
using DelegadosEventos.ManejoExcepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadosEventos
{
    public partial class Form1 : Form
    {
        Operacion o;

        Jugador messi = new Jugador();

        public Form1()
        {
            InitializeComponent();
            o = new Operacion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messi.Festejar += Messi_Festejar;         
        }

        // Eventos

        private void Messi_Festejar(string festejo)
        {
            label4.Text = festejo;
        }

        private void Messi_Festejar2(string festejo)
        {
            label4.Text += "SOS DE LA B";
        }

        // Delegados

        void Sumar(int x, int y)
        {
            label3.Text = (x + y).ToString();
        }

        void Restar(int x, int y)
        {
            label3.Text = (x - y).ToString();
        }

        void Multiplicar(int x, int y) 
        {
            label3.Text = (x * y).ToString();
        }  

        void Dividir(int x, int y) 
        {
            label3.Text = (x / y).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (o.Operar == null)
            {
                MessageBox.Show("El método operar no está asignado.");
            }
            else
            {
                try
                {
                    o.Operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    o.Operar = null;
                }
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            o.Operar = Sumar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o.Operar = Restar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            o.Operar = Multiplicar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            o.Operar = Dividir;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            messi.Patear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            messi.Festejar += Messi_Festejar2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            messi.Festejar -= Messi_Festejar2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                messi.Edad = int.Parse(textBox3.Text); 
            } catch (EdadException ex) when (int.Parse(textBox3.Text) >= 50)
            {
                MessageBox.Show("Tas grande pa jugar fulbo");
            } catch (EdadException ex)
            {
                MessageBox.Show(ex.Message);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
