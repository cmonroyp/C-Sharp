using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    static class MetodoExtension
    {
        public static int ContarPalabras(this string cadena)
        {
            var palabras = cadena.Split(' ');
            return palabras.Length;
        }

        public static int ContarPalabrasParametro(this string cadena, char separador)
        {
            var palabras = cadena.Split('@');
            return palabras.Length;
        }
    }
}
