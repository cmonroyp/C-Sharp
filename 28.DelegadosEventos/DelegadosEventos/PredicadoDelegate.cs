using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    class PredicadoDelegate
    {
        List<string> nombres = new List<string>
         {
             "Carlos",
             "Mauro",
             "Pedro"
         };


        static Predicate<string> predicado = new Predicate<string>(Contiene);

        public PredicadoDelegate()
        {

            var resultado = nombres.Find(predicado);

            //si inicia nombre con Palabra
            nombres.Exists(x =>
            {
                Console.WriteLine("Resultado Inicia Nombre:" + x.StartsWith("M"));
                return x.StartsWith("S");
            });


            if (resultado != null)
            {

                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Nombre no encontrado");
            }
        }

        static bool Contiene(string palabra)
        {
            return palabra.Contains("M");
        }

    }
}
