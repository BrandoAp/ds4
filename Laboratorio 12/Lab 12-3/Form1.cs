using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcularSemiperimetro_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = Convert.ToDouble(textBox1.Text);
                double lado2 = Convert.ToDouble(textBox2.Text); 
                double lado3 = Convert.ToDouble(textBox3.Text);

                calcularSemiperimetro semiperimetro = new calcularSemiperimetro(lado1, lado2, lado3);

                double semiP = semiperimetro.calcularSemip();

                textBox4.Text = semiP.ToString();

            }
            catch (FormatException) 
            {
                MessageBox.Show("Por favor ingrese valores validos");
            }

        }

        private void calcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = Convert.ToDouble(textBox1.Text);
                double lado2 = Convert.ToDouble(textBox2.Text);
                double lado3 = Convert.ToDouble(textBox3.Text);

                calcularArea trianguloArea = new calcularArea(lado1, lado2, lado3);

                double area = trianguloArea.calcularA();

                textBox5.Text = area.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores validos");
            }

        }

        private void resetearVentana_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
        }
    }
}
