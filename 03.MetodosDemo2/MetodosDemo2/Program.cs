using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = RegresarDatos();
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("resultado division metodos devuelven 2 paramatros");
            int cociente = 0;
            int residuo = 0;
            (cociente, residuo) = Dividir(50, 25);
            Console.WriteLine("cociente: " + cociente);
            Console.WriteLine("residio: " + residuo);
            Console.WriteLine();

            Console.WriteLine("segunda forma metodos devuelven 2 paramatros");
            (int cociente, int residuo) data = Dividir(100, 50);
            Console.WriteLine(data.cociente);
            Console.WriteLine(data.residuo);
            Console.WriteLine("----------------------------");

            Console.WriteLine("sobre carga de operadores");
            Console.WriteLine("sin estacionamiento: " + CalcularCuenta(100, 10, 30));
            Console.WriteLine("con estacionamiento: " + CalcularCuenta(100, 10, 30, 15));
            Console.WriteLine("----------------------------");

            Console.WriteLine("metodos anidados");
            EscribirTexto("Hola Como vas!.");
            Console.WriteLine("----------------------------");
            Console.WriteLine("parametros opcionales");
            Console.WriteLine(Inventario(15, 63, 12));
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("argumentos con nombre");
            Console.WriteLine(Inventario2(15, 63, 12, iva: 19));

            Console.ReadLine();
        }

        static (string, int) RegresarDatos() {
            return ("resultado: ", 10);
        }

        static (int, int) Dividir(int num1, int num2)
        {
            int cociente = num1 / num2;
            int residio = num1 % num2;
            return (cociente, residio);
        }

        //la sobre carga de operadores consiste en Reutilizar el mismo nombre del metodo, cambiando un tipo de dato diferente la segunda vez.
        static double CalcularCuenta(double totalCuenta, double propina, double clientes)
        {
            return (totalCuenta + propina) / clientes;
        }

        static double CalcularCuenta(double totalCuenta, double propina, double clientes, double estacionamiento)
        {
            return (totalCuenta + propina + estacionamiento) / clientes;
        }

        //metodos aninados

        static void EscribirTexto(string texto)
        {
            Console.WriteLine(texto);
            limpiar();

            void limpiar()
            {
                Console.ReadLine();
                Console.Clear();
                Console.Beep();
            }
        }

        //parametros opcionales, tener encuenta que se dejan despues de los parametros obligatorios
        static int Inventario(int zapatos, int correas, int patalones, int blusas = 0)
        {
            return (zapatos + correas + patalones + blusas);
        }

        //argumentos con nombre
        static int Inventario2(int zapatos, int correas, int patalones, int blusas = 0, int iva = 15)
        {
            return (zapatos + correas + patalones + blusas + iva);
        }

    }
}
