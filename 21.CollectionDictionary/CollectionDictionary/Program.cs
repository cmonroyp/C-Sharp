using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //manejo de diferentes tipos de valores
            AgregarNumeros();
            Console.WriteLine("********Agreando frases********");
            AgregarFrases();
            Console.WriteLine("********diccionario********");
            Dicionario();

            Console.ReadLine();
        }

        public static void AgregarNumeros()
        {
            Dictionary<int, int> numeros = new Dictionary<int, int>();

            for (int i = 1; i < 10; i++)
            {
                numeros.Add(i, i);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
            }
        }

        public static void AgregarFrases()
        {
            Dictionary<int, string> numeros = new Dictionary<int, string>();

            string frase = "Amor!.";
            for (int i = 1; i < 3; i++)
            {
                numeros.Add(i, frase);
                frase += frase;
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Value);
            }
        }

        public static void Dicionario()
        {
            Dictionary<string, string> coleccion = new Dictionary<string, string>();

            coleccion.Add("C", "Camisas");
            coleccion.Add("Z", "Zapatos");
            coleccion.Add("B", "Busos");

            foreach (var item in coleccion)
            {
                string sigla = item.Key;
                string descripcion = item.Value;

                Console.WriteLine($"{sigla}, {descripcion}");
            }

            //si deseo cambiar un valor
            //coleccion["C"] = "corbatas";
        }
    }
}
