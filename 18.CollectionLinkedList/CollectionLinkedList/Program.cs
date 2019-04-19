using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollectionLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregarNumero();
            Console.WriteLine("******agrega numeros al inicio de la lista");
            AgregarNumero2();

            Console.ReadLine();
        }

        public static void AgregarNumero()
        {
            LinkedList<int> numeros = new LinkedList<int>();

            //numeros.AddLast(3);
            //agrega numeros al final de la lista
            for (int i = 1; i <= 10; i++)
            {
                numeros.AddLast(i);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void AgregarNumero2()
        {
            LinkedList<int> numeros = new LinkedList<int>();

            //agrega un numero despues de un node especifico
            var num = numeros.AddFirst(150);
            numeros.AddAfter(num, 200);

            //agregarlo antes del node especifico
            numeros.AddBefore(num, 140);

            //agrega numeros al inicio de la lista
            for (int i = 1; i <= 10; i++)
            {
                numeros.AddFirst(i);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            //imprime el primer node
            var nodo = numeros.First;
            Console.WriteLine("primer nodo: " + nodo.Value);

            //metodo de elimmincacon
            //numeros.Remove(3);
            //numeros.RemoveFirst();
            //numeros.RemoveLast();

        }
    }
}
