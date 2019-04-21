using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralHub hub = new CentralHub();
            SistemaLuces luces = new SistemaLuces();

            hub.Add(() => luces.ApagarLuces(5));



            for (int i = 0; i < 5; i++)
            {
                hub.RevisarSalida();
            }

            Console.ReadLine();
        }


    }
}
