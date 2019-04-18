using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Printer
    {
        public int Z { get; set; }
        public int PropiedadSoloLectura
        {

            get
            {
                return 50;
            }
        }

        public int PropiedadSoloEscritura
        {

            set
            {
                int valor = value;
            }
        }

        public int PropiedadGetValue
        {
            get
            {
                return 50;
            }
            private set
            {
                int valor = value;
            }
        }



        /****************************************************************************/

        int _x;
        int _y;

        //codigo mas limpio en una propiedad
        public int X
        {
            get => _x;
            set => _x = VerificarX(value);
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = VerificarY(value);
            }
        }

        public Printer(int _x, int _y)
        {
            this._x = VerificarX(_x);
            this._y = VerificarY(_y);
        }

        public void Print()
        {
            Console.SetCursorPosition(this._x, this._y);
            Console.WriteLine("X");
        }

        private int VerificarX(int _x)
        {
            if (_x < 0 || _x > 60)
            {
                throw new ArgumentOutOfRangeException("Error en X");
            }
            return _x;
        }

        private int VerificarY(int _y)
        {
            if (_y < 0 || _y > 50)
            {
                throw new ArgumentOutOfRangeException("Error en Y");
            }
            return _y;
        }

    }
}
