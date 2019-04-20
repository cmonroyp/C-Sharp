using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> lista = new SortedList<string, string>();

            lista.Add("Ca", "Camisas");
            lista.Add("Bl", "Blusas");
            lista.Add("Zp", "Zapatos");

            foreach (var item in lista)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}
