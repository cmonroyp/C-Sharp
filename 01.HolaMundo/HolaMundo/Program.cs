using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo {
    class Program {
        static void Main () {

            tipodatoPrimitivos();
        }

    static  public void  tipodatoPrimitivos()
        {
            int numero = 32;
            Console.WriteLine("Numero entero");
            Console.WriteLine(numero);

            Console.WriteLine();
            long lng = 21474836488923;
            Console.WriteLine("Numero long");
            Console.WriteLine(lng);

            Console.WriteLine();
            float flt = 3.1416F;
            Console.WriteLine("Numero float");
            Console.WriteLine(flt);

            Console.WriteLine();
            float flt2 = 213.14165566889215F;
            Console.WriteLine("Numero float redondeado");
            Console.WriteLine(flt2);

            Console.WriteLine();
            double doub = 213.14165566889215;
            Console.WriteLine("Numero double");
            Console.WriteLine(doub);

            Console.WriteLine();
            decimal dmc = 213.14165566889215M;
            Console.WriteLine("Numero decimal");
            Console.WriteLine(dmc);

            Console.WriteLine();
            bool b = true;
            Console.WriteLine("dato booleano");
            Console.WriteLine(b);

            Console.WriteLine();
            string st = "Hello world!.";
            Console.WriteLine("dato string");
            Console.WriteLine(st);

            Console.WriteLine();
            char ch = 'X';
            Console.WriteLine("dato char");
            Console.WriteLine(ch);

            Console.WriteLine();
            Console.WriteLine("Formas de incrementar");
            int conteo = 1;
            Console.WriteLine(conteo);
            //conteo = conteo + 1;
            //conteo += conteo;
            conteo++;
            Console.WriteLine(conteo);

            Console.WriteLine();
            int post = 10;            
            Console.WriteLine("resultado postfija");
            Console.WriteLine(post++);

            Console.WriteLine();
            int pref = 10;
            Console.WriteLine("resultado prefija");
            Console.WriteLine(++pref);

            Console.ReadLine();
        }
    }

    //nombrando variables

    //tipo de dato + nombre de la variable + ;
    //int variable;

    //tipo de dato + nombre de la variable  = + valor +;
    //int variable = 10;

    //variables inferidas visual detecta el tipo de datos de entrada.
    //var dato = 10;
    //var dato2 = "carlos";
    //var datos3 = 10.3;

}