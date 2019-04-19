using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class GenericException<T, U> where T : Exception
    {
        T dato;
        U dato2;

        public GenericException(T _dato)
        {
            dato = _dato;
        }

        public void HacerAlgo(T parametro)
        {
            Console.WriteLine(parametro.Message);
        }
    }
}
