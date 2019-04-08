using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("digite un nombre:");
            //string nombre = Console.ReadLine();
            //saludo(nombre);
            //saludo();

            Console.WriteLine("retorno del metodo suma");
            int resultado = suma(10, 15);
            Console.WriteLine(resultado);

            Console.WriteLine("resultado metodo cuerpo de expresion");
            int resultado2 = suma2(8, 5);
            Console.WriteLine(resultado2);

            Console.ReadLine();
        }

        //tipo de dato a retornar + nombre del metodo + parametros
        static void saludo(string msg)
        {
            Console.WriteLine("Hola " + msg);
            Console.ReadLine();
        }

        //metodo que retorna una suma
        static int suma(int num1, int num2)
        {
            return num1 + num2;
        }

        //metodos con cuerpo de expresion
        static void saludo() => Console.WriteLine("Carlos Mario Monroy");
        static int suma2(int num1, int num2) => num1 + num2;

    }
}
