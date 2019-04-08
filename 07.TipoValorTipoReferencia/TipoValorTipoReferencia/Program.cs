using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoValorTipoReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables tipo valor
            int valor1 = 50;
            int valor2 = valor1;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            valor1++;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            //tipos de refrencia
            Console.WriteLine("Tipos de referencia");
            Circulo circ1 = new Circulo();
            circ1.radio = 50;

            Circulo circ2 = circ1;//asigna referencia de circ1 a circ2

            Console.WriteLine(circ1.radio);
            Console.WriteLine(circ2.radio);

            circ1.radio = 20;
            Console.WriteLine(circ1.radio);
            Console.WriteLine(circ2.radio);



            Circulo circulo = new Circulo();
            circulo.radio = 10;
            AgregarUno(circulo);

            //? compara si una variable ha sido inicializada a la izquierda o no.
            Circulo circulo2 = null;
            Console.WriteLine("operador ? : " + circulo2?.radio);

            Console.ReadLine();
        }
            public static void AgregarUno (Circulo param)
            {
                param = new Circulo();
                param.radio = 50;
                //param.radio++;
            }
    }
}
