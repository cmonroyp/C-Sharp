using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(10, 15);
            p.Print();

            //si desearamos modificar un parametro
            p.X += 25;

            //p.PropiedadGetValue

            p.Print();

            p.Y = 13;

            p.Print();


            //ejemplo de como inicializar de objetos utilizando propiedades
            Triangulo t = new Triangulo
            {
                Lado1 = 15,
                Lado3 = 55
            };

            Triangulo color = new Triangulo("Rojo")
            {
                Lado2 = 13,
                Lado1 = 26
            };

            Console.ReadLine();
        }
    }
}
