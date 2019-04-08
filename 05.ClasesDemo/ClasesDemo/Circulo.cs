using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo
{
   public class Circulo
    {
        int radio;
        //campo compartido
        public static int numeroCirculos;
        //campo compartido constante no permite modificar su valor, si es llamado desde afuera
        public const double PI = 3.1416;
        public Circulo(int radioInicial)
        {
            radio = radioInicial;
            numeroCirculos++;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
