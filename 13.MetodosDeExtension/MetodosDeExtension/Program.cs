using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Esto es una cadena de metodo de extension";
            Console.WriteLine(frase.ContarPalabras());

            string fraseSep = "Esto@es@una@cadena@de@metodo@de@extesnion";
            Console.WriteLine(fraseSep.ContarPalabrasParametro('@'));

            Console.ReadLine();
        }
    }
}
