using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    class OperacionTernaria
    {
        public void Suma()
        {
            List<int> numeros = new List<int>
            {
                100,
                150,
                80,
                213,
                610
            };

            var suma = numeros.Sum(x => x % 2 == 0 ? x : 0);

            Console.WriteLine("Operacion ternaria:" + suma);
        }
    }
}
