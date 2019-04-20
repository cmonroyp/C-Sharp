using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesManager cm = new ClientesManager();

            foreach (Cliente item in cm)
            {
                Console.WriteLine(item.Nombre);
            }

            //enumerator implementado
            Console.WriteLine("*************Forma dos**************");
            var enumerator = cm.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(((Cliente)enumerator.Current).Nombre);
            }

            Console.ReadLine();
        }
    }
}
