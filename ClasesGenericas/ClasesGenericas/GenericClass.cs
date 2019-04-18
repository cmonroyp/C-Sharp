using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class GenericClass<T>
    {
        T dato;

        public GenericClass(T _dato)
        {
            dato = _dato;
        }

        //metodos como clases genericas
        public T HacerAlgo(T parametro)
        {
            T datos = parametro;
            return datos;
        }
    }
}
