using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposNullable
{
  public  class Suma
    {
        public double sumar(out int num1, int num2)        {

            num1 = 3;
            int resultado = num1 + num2;
            return resultado;
        }

        public double agreagarUno(ref int number)
        {
            return number++;
        }
    }
}
