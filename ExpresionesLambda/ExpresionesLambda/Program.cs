using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            LlenadoClientes();

            //ejemplos varios
            Ejemplos ej = new Ejemplos();
            ej.MultiplicacionForma1();

            Console.ReadLine();
        }

        public static void LlenadoClientes()
        {
            List<Clientes> clientes = new List<Clientes>
            {
                new Clientes
                {
                    ID = 1,
                    Nombre = "Carlos"
                },

                new Clientes
                {
                    ID = 2,
                    Nombre = "Julio"
                },
                 new Clientes
                {
                    ID = 3,
                    Nombre = "Ramiro"
                }
            };

            //forma 1 
            var cliente = clientes.Find((Clientes C) =>
             {
                 return C.ID == 3;
             });

            if (cliente != null)
            {
                Console.WriteLine($"{cliente.ID}: {cliente.Nombre}");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado!.");
            }

            //forma 2
            var cliente2 = clientes.Find(c => c.ID == 2);

            if (cliente2 != null)
            {
                Console.WriteLine($"{cliente2.ID}: {cliente2.Nombre}");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado!.");
            }
        }
    }
}
