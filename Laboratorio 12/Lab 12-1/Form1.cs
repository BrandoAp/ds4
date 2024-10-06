using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo, distancia;

            if (double.TryParse(textBox1.Text, out velocidad) && double.TryParse(textBox2.Text, out tiempo))
            {
                distancia = velocidad * tiempo;
                textBox3.Text = distancia.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores numericos validos");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
