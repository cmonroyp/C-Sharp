using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> num = new GenericClass<int>(2);
            GenericClass<string> cadena = new GenericClass<string>("Hola!.");

            //metodo
            GenericClass<string> metodo = new GenericClass<string>("");
            metodo.HacerAlgo("Hola Mundo!.");

            //GenricException
            GenericException<Exception, string> gexcep = new GenericException<Exception, string>(new Exception(""));
            gexcep.HacerAlgo(new Exception("Aqui esta bien"));

            //Generic Interface         

            Dato<string> dato = new Dato<string>();
            IHacerAlgo<string> frase = dato;
            frase.HacerAlgo("Hello!..");
            Console.WriteLine(frase.GetDato());

            Console.ReadLine();
        }
    }
}
