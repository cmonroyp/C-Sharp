using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializandoColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elementos = new List<string>
            {
                "Carlos",
                "Cesar",
                "Javier",
                "Pedro"
            };

            foreach (var item in elementos)
            {
                Console.WriteLine(item);
            }

            //diccionario
            Dictionary<int, int> valores = new Dictionary<int, int>
            {
                [0] = 1,
                [1] = 2,
                [2] = 3
            };

            Dictionary<string, string> nombres = new Dictionary<string, string>
            {
                {"Ca","Camisas" },
                {"Bl","Blusa" },
                {"Za","Zapatos" }
            };

            Console.ReadLine();
        }
    }
}
