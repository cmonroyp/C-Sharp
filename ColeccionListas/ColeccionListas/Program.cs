using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ColeccionListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //diferencia entre arreglo y lista
            //arreglo se tiene que espeificar su dimension
            int[] numerosArreglo = new int[10];

            //listas no se debe especificar su dimension
            ListarNumeros();
            Console.WriteLine("*******Agrega Numero*********");
            InsertaNumero();
            Console.WriteLine("*******Borra Numero*********");
            DeleteNumero();
            Console.WriteLine("*******Iterando lista for*********");
            IterandoLista();

            Console.ReadLine();
        }

        public static void ListarNumeros()
        {
            List<int> listNumeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                listNumeros.Add(i);
            }

            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void InsertaNumero()
        {
            List<int> listNumeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                listNumeros.Add(i);
            }

            //inserta numero en la penultima posicion
            listNumeros.Insert(listNumeros.Count - 1, 15);

            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }

        }

        public static void DeleteNumero()
        {
            List<int> listNumeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                listNumeros.Add(i);
            }

            //borra el penultimo numero
            listNumeros.Remove(listNumeros.Count - 1);

            //borra un numero especifico de cierta posicion
            listNumeros.RemoveAt(3);

            //borra un rango de numeros de la lista
            listNumeros.RemoveRange(0, 2);

            //si deseo limpiar toda la lista
            //listNumeros.Clear();

            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }

        }

        //iterando lista generica
        public static void IterandoLista()
        {
            List<int> listNumeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                listNumeros.Add(i);
            }

            for (int i = 0; i < listNumeros.Count; i++)
            {
                int item = listNumeros[i];
                Console.WriteLine(item);
            }

        }
    }
}
