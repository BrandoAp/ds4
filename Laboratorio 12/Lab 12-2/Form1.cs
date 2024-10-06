using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);

                CalcularPromedio calcularPromedio = new CalcularPromedio(nota1, nota2, nota3);

                double promedio = calcularPromedio.calcularProm();

                textBox4.Text = promedio.ToString("F2");
            } catch (FormatException)
            {
                MessageBox.Show("Ingrese notas validas");
            }

        }

        private void resetearVentana_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }
    }
}
