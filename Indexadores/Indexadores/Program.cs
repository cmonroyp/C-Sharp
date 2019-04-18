using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //datos binarios
            uint binData = 0b0_1111;
            Console.WriteLine(binData);
            Console.WriteLine("valor binario:" + Convert.ToString(binData, 2));

            //datos hexadecimales
            uint hexData = 0x0_f;
            Console.WriteLine(hexData);
            Console.WriteLine("valor hexadecimal:" + Convert.ToString(hexData, 16));


            //negando valores binarios
            uint binDataNeg = 0b0_00000000_00000000_00000000_00001111;
            uint result = ~binDataNeg;
            Console.WriteLine("resultado negacion:" + Convert.ToString(result, 2));

            //desplazando valor 
            //izquierda
            uint valorIzq = binDataNeg << 2;
            Console.WriteLine("desplazando valores izq:" + Convert.ToString(valorIzq, 2));

            //desplazando valor 
            //derecha
            uint valorDer = binDataNeg >> 2;
            Console.WriteLine("desplazando valores Der:" + Convert.ToString(valorDer, 2));

            //operador or
            uint binDataOr = 0b0_00000000_00000000_00000000_10001111;
            uint binDataOr2 = 0b0_00000000_00000000_00000000_00001111;
            uint resultOr = binDataOr | binDataOr2;
            Console.WriteLine("resultado Or:" + Convert.ToString(resultOr, 2));

            //operador and
            uint binDataAnd = 0b0_00000000_0000000_00000000_10001111;
            uint binDataAnd2 = 0b0_00000000_00000000_00000000_00001111;
            uint resultAnd = binDataAnd & binDataAnd2;
            Console.WriteLine("resultado and:" + Convert.ToString(resultAnd, 2));

            //operador xor
            uint xorData = binDataOr ^ binDataOr2;
            Console.WriteLine("resultado xor:" + Convert.ToString(xorData, 2));

            Console.ReadLine();
        }
    }
}
