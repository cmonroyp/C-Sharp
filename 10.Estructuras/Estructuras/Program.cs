using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            StructPoint s1 = new StructPoint();
            StructPoint s2 = s1;

            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);

            s1.X++;

            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);

            //classpoint
            Console.WriteLine();
            ClassPoint s3 = new ClassPoint();
            ClassPoint s4 = s3;

            Console.WriteLine(s3.X);
            Console.WriteLine(s4.X);

            s3.X++;

            Console.WriteLine(s3.X);
            Console.WriteLine(s4.X);

            Console.ReadLine();
        }

    }
}
