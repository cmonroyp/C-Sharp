using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //cola el primer elemento que entra es el primero que sale

            AgregarNumeros();
            Console.WriteLine("****Desencolando*******");
            DesencolarNumeros();

            //Stack
            Console.WriteLine("****Collection Stack*******");
            CollecrtionStack cS = new CollecrtionStack();
            cS.AgregarNumeros();


            Console.ReadLine();
        }

        //encolar
        public static void AgregarNumeros()
        {
            Queue<int> num = new Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                num.Enqueue(i);
            }

            foreach (var item in num)
            {

                Console.WriteLine(item);
            }
        }

        //desencolar
        public static void DesencolarNumeros()
        {
            Queue<int> num = new Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                num.Enqueue(i);
            }

            var element = num.Dequeue();

            while (num.Count > 0)
            {
                element = num.Dequeue();
                Console.WriteLine(element);
            }
        }
    }
}
