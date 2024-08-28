using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Program
    {
        static void Main(String[] args)
        {
            Client client = new Client();
            client.FirtsName = "Brando";
            client.LastName = "Avila";
            client.Age = 20;
            client.Id = 1;

           Console.WriteLine(client.GetFullName());
        }
    }

    public class Client()
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public String GetFullName()
        {
            //Utilizando varibles  de instancia de metodos  de la clase.
            return FirtsName + " " + LastName;
        }
    }
}
