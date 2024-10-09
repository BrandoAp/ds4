using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionString =
            @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI";
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");
            connection.Close();
            MessageBox.Show("Se cerro la conexion");
            LoadProductName();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void LoadProductName()
        {
            String sql = "Select ProductName from Products";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }

            } catch (SqlException e)
            {
                MessageBox.Show("Error al cargar los productos: ", e.Message);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }
       
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = (listBox1.SelectedIndex + 1) % listBox1.Items.Count;
            }
            
        }
    }
}