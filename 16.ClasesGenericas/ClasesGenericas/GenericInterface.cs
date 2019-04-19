using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public interface IHacerAlgo<T>
    {
        void HacerAlgo(T _dato);
        T GetDato();
    }

    class Dato<T> : IHacerAlgo<T>
    {
        T dato;
        T IHacerAlgo<T>.GetDato()
        {
            return dato;
        }

        void IHacerAlgo<T>.HacerAlgo(T _dato)
        {
            dato = _dato;
        }
    }
}
