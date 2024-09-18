using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2
{
    public class Cuenta
    {
        private String idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            this.idCuenta = prmtIdCuenta;
            System.Console.WriteLine(
                "Constructor Clase Base para cuenta {0}", prmtIdCuenta);
        }

        public virtual void CalcularInteres()
        {
            System.Console.WriteLine(
                "Cuenta.CalcularInteres() efectuado para la cuenta {0}", this.idCuenta);
        }

        public string getIdCunta()
        {
            return this.idCuenta;
        }
    }
    public class CuentaCorriente: Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularInteres()
        {
            System.Console.WriteLine(
                "CuentaCorriente.CalcularInteres() efectuado para " +
                "la cuenta {0}", getIdCunta());
        }
    }
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {

        }
        public override void CalcularInteres()
        {
            System.Console.WriteLine(
                "Cuenta.Ahorro.CalcularIntereses () efectuado para " +
                "la cuenta {0}", getIdCunta());
        }
    }
}
