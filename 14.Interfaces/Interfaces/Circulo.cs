using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   sealed class Circulo: FiguraBase, IFigura, IRenderizador 
    {
        int radio;

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override void ObtenerTop()
        {
            throw new NotImplementedException();
        }

        int IFigura.Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IFigura.Dibujar()
        {
            throw new NotImplementedException();
        }

        void IRenderizador.Dibujar()
        {
            throw new NotImplementedException();
        }

        void IRenderizador.Renderizar()
        {
            throw new NotImplementedException();
        }
    }
}
