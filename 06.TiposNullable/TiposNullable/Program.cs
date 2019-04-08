using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo dato nullable
            int? i = null;
            i = 10;

            //propiedades nullable, entra si i es null
            if (!i.HasValue)
            {
                i = 15;
            }
            Console.WriteLine(i.Value);

            //resultado();
            LlamarAgregarUno();

            LlamaSuma();

            ConversionString();

            int numeroEntero = 50;
            object objeto = numeroEntero;
            Console.WriteLine(objeto);

            Console.WriteLine("cast tipo objeto a numerico");
            int otroNumero = (int)objeto;
            Console.WriteLine(otroNumero);

            ConversionObject();

            Console.ReadLine();
        }

        //parametro ref, sirve para modificar parametros de entrada en un metodo o funcion     
        static void LlamarAgregarUno()
        {
            int num = 10;
            Suma suma = new Suma();
            Console.WriteLine("Resultado Inicial: " + suma.agreagarUno(ref num));
            Console.WriteLine("Resultado Final: " + num);
        }

        //parametro out, puede suceder que una variable sea inicializada desde el mismo metodo.
        static void LlamaSuma()
        {
            int num;
            Suma suma = new Suma();
            Console.WriteLine(suma.sumar(out num, 15));
        }

        //conversion de cadenas de texto int a numerico
        static void ConversionString()
        {
            int.TryParse("50", out int metodorecibe);
            Console.WriteLine(metodorecibe);
        }

        //onversion de objetos
        static void ConversionObject()
        {
            object objeto = "hola";
            object objeto2 = 50;
       
            //int numr = (int)objeto;
            //Console.WriteLine(numr);
            if(objeto is int)
            {
                Console.WriteLine("Es entero");
            }
            else if(objeto is string)
            {
                Console.WriteLine("Es string");
            }

            string result = objeto2 as string;
            if(result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("result es null");
            }
            Console.WriteLine(result);

            
        }
    }
}
