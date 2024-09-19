using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_8
{
    abstract class ClaseAbstracta
    {
        abstract protected string tomaValor();
        abstract protected string prefixValor(string prefix);

        public void printOut() 
        { 
            Console.WriteLine(tomaValor());
        }
    }
}
