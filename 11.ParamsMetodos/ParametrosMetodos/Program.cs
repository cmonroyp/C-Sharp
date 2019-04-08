using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2 , 4};
            Sumar(num);

            int resultado = Sumar2(2, 4, 6);

            int resultado2 = Sumar3(2, 4, 6, "100");
        }

        static int Sumar(int[] numeros)
        {
            if(numeros.Length < 2 || numeros == null)
            {
                throw new ArgumentException("Debe agregar 2 parametros como minimo!.");
            }
            else
            {
                int suma = 0;
                foreach (var numero in numeros)
                {
                    suma += numero;
                }
                return suma;
            }

        }

        //metodo con Params, no se puede usar con arreglos multidimensionales
        static int Sumar2(params int[] numeros)
        {
            if (numeros.Length < 2 || numeros == null)
            {
                throw new ArgumentException("Debe agregar 2 parametros como minimo!.");
            }
            else
            {
                int suma = 0;
                foreach (var numero in numeros)
                {
                    suma += numero;
                }
                return suma;
            }

        }

        //params como object
        static int Sumar3(params object[] numeros)
        {
            int suma = 0;
            foreach (var numero in numeros)
            {
                if(numero is int)
                {
                    suma += (int)numero; 
                }
                else if(numero is string)
                {
                    bool convertido = int.TryParse((string)numero,out int temporal);

                    if (convertido)
                    {
                        suma += temporal;
                    }else
                    {
                        throw new Exception("Valor no numerico");
                    }
                }
                else
                {
                    throw new Exception("Valor no numerico");
                }
            }
            return suma;
        }
    }
}
