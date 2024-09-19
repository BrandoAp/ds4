using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_6
{
    public class ClaseBase
    {
        public void test()
        {

        }
        public virtual void masTest() //Se cambia la palabra sealed por virtual
        {

        }
    }

    class ClaseHijo : ClaseBase 
    { 
        public override void masTest()
        {

        }    
    }
}
