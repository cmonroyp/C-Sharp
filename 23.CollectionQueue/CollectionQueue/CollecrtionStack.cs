using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionQueue
{
    class CollecrtionStack
    {
        //permite apilar los datos estilo pila de platos del ultimo al primero
        public void AgregarNumeros()
        {
            Stack<int> num = new Stack<int>();

            for (int i = 1; i <= 10; i++)
            {
                num.Push(i);
            }

            foreach (var item in num)
            {

                Console.WriteLine(item);
            }

            var elemento = num.Pop();

            while (num.Count > 0)
            {
                elemento = num.Pop();
                Console.WriteLine(elemento);
            }
        }
    }

}
