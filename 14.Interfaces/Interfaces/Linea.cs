using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Linea: IFigura
    {
        double puntoXInicial;
        double puntoYInicial;
        double puntoXFinal;
        double puntoYFinal;

        int IFigura.Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }
        void IFigura.Dibujar()
        {
            throw new NotImplementedException();
        }

        double ICalculador.CalcularArea()
        {
            throw new NotImplementedException();
        }

    }
}
