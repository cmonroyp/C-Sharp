using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerables
{
    class ColeccionIterable<T> : IEnumerable<T>
    {
        List<T> datos = new List<T>();
        public ColeccionIterable(params T[] _datos)
        {
            foreach (var item in _datos)
            {
                datos.Add(item);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in datos)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
