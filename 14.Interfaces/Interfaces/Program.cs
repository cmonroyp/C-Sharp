using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circulo c = new Circulo();
            IFigura f1 = c;
            f1.Dibujar();

            IRenderizador r = c;
            r.Dibujar();

            Linea l = new Linea();

            IFigura f = c;
            f = l;

            FiguraBase fBase; 
   
        }
        static void CalcualrArea(IFigura figura) {
            if(figura is Circulo)
            {
                figura.Dibujar();
            }
            else if(figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}
