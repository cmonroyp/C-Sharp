using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Triangulo
    {
        //inicializador de objetos utilizando propiedades
        int lado1 = 10;
        int lado2 = 10;
        int lado3 = 10;
        string color;

        public int Lado1
        {
            set => lado1 = value;
        }

        public int Lado2
        {
            get => lado2;
            set => lado2 = value;
        }

        public int Lado3
        {
            set => lado3 = value;
        }

        public Triangulo() { }

        public Triangulo(string _color)
        {
            color = _color;
        }
    }
}
