using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(23, 31);

            double resultadoArea = rectangulo.CalcularArea();
            double resultadoPerimetro = rectangulo.CalcularPerimetro();

            //tupla
            (var brect, var aRect) = rectangulo;

            //llamado metodo estatico
           Console.WriteLine(Rectangulo.calculaPerimetroRectangulo(18, 29));
           //Console.ReadLine();

            //contar cuantas veces se ha instanciado la clase circulo
            Circulo circulo1 = new Circulo(10);
            Circulo circulo2 = new Circulo(10);
            Circulo circulo3 = new Circulo(10);

            Console.WriteLine(Circulo.numeroCirculos);
            //Console.ReadLine();

            Console.WriteLine(ClaseStatica.Sumar(10, 15));

            //objeto anonimo
            var objetoAnonimo = new { area = 3, campo1 = 4, campo2 = 5 };
            

            Console.ReadLine();
        }
    }
}
