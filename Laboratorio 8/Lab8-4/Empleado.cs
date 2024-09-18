using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    public class Empleado
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;  }
        }
    }

    public class CuentaBancaria
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
                else
                    throw new ArgumentException("El saldo no pude ser negativo");
            }
        }
    }
    public class Cobertura
    {
        private double radio;

        public Cobertura(double radio)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
        }
    }
}
