using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerables
{
    class ClientesEnumerator : IEnumerator
    {
        int position = -1;
        List<Cliente> clientes = null;

        public ClientesEnumerator(List<Cliente> _cliente)
        {
            clientes = _cliente;
        }
        public object Current
        {
            get
            {
                try
                {
                    return clientes[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < clientes.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
