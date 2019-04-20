using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerables
{
    class ClientesManager : IEnumerable
    {
        List<Cliente> clientes;

        public ClientesManager()
        {
            clientes = new List<Cliente>
            {
                new Cliente
                {
                    ID = 1,
                    Nombre ="Hector"
                },
                new Cliente
                {
                    ID = 2,
                    Nombre = "Maria"
                },
                new Cliente
                {
                    ID = 3,
                    Nombre = "Amanda"
                }
            };
        }

        public IEnumerator GetEnumerator()
        {
            // return clientes.GetEnumerator();
            //return new ClientesEnumerator(clientes);
            foreach (var item in clientes)
            {
                yield return item;
            }
        }
    }
}
