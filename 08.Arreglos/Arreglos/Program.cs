using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //si queremos recibir datos desde la consola
            if (args.Length > 0)
            {
                foreach (var parametro in args)
                {
                    Console.WriteLine(parametro);
                }
            }


            /*****************************************/
            int[] numeros = { 210, 11, 15, 20 };
            Circulo[] circulos = { new Circulo(20), new Circulo(15) };

            var arr = numeros.GetType();
            //arreglos implicitos
            var personas = new[] {
                    new{nombre="Carlos"},
                    new {nombre="Hector"}
                };

            // Arrays();
            // Inicializador();
            GenerarReporte();
            GenerarReporteClone();
            MostarArrays();

            Console.ReadLine();
        }

        //iterando arreglos
        static void Arrays()
        {
            int[] numeros = { 51, 23, 25, 58 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("****************");
            Console.WriteLine();

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }

        static int[] Inicializador()
        {
            Console.WriteLine("Numero de elementos");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Valor para el elemento");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i] = dato;
            }

            return numeros;
        }

        //copiando arreglos
        static void GenerarReporte()
        {
            int[] array1 = { 12, 15, 63 };
            int[] array2 = new int[array1.Length];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array2[i] = array1[i];
            //}
            Array.Copy(array1, array2, array1.Length);
        }

        //clonando arreglos
        static void GenerarReporteClone()
        {
            int[] array1 = { 12, 15, 63 };
            int[] array2 = (int[])array1.Clone();
        }

        //arreglos multidimensionales
        static void MostarArrays()
        {
            int[,] bidimensional = new int[5, 5];
            bidimensional[0, 0] = 3;
            bidimensional[3, 3] = 15;
        }
    }
}
