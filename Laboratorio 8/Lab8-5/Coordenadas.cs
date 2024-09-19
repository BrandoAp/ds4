using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_5
{
    public partial class Coordenadas
    {
        private int x;
        private int y; 

        public Coordenadas(int x, int y) {
            this.x = x; 
            this.y = y;
        }
    }

    public partial class Coordenadas 
    { 
        public void Vercoordenadas()
        {
            Console.WriteLine("Coordenadas: {0}, {1}", x, y);
        }
    
    }
}
