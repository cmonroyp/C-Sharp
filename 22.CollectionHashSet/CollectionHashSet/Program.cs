using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> materias = new HashSet<string>();

            materias.Add("Matematicas");
            materias.Add("Sociales");
            materias.Add("Español");
            materias.Add("Ciencias");


            Console.WriteLine("**********Lista 1****************");
            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********Comunes entre las 2 listas****************");
            HashSet<string> materias2 = new HashSet<string>(
                new string[] { "Ciencias", "Matematicas", "Biologia" }
                );

            //comparando las 2 colleciones
            materias.IntersectWith(materias2);

            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("**********No Comunes***********");
            NoComunes();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("**********Union de las 2 listas***********");
            UnionLista();

            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();

        }

        public static void NoComunes()
        {
            HashSet<string> materias = new HashSet<string>();

            materias.Add("Matematicas");
            materias.Add("Sociales");
            materias.Add("Español");
            materias.Add("Ciencias");



            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********Comparacion lista con lista 2****************");
            HashSet<string> materias2 = new HashSet<string>(
                new string[] { "Ciencias", "Matematicas" }
                );

            //comparando las 2 colleciones
            materias.ExceptWith(materias2);

            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }
        }

        public static void UnionLista()
        {
            HashSet<string> materias = new HashSet<string>();

            materias.Add("Matematicas");
            materias.Add("Sociales");
            materias.Add("Español");
            materias.Add("Ciencias");


            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********Comparacion lista con lista 2****************");
            HashSet<string> materias2 = new HashSet<string>(
                new string[] { "Biologia", "Fisica" }
                );

            //comparando las 2 colleciones
            materias.UnionWith(materias2);

            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }
        }
    }
}
