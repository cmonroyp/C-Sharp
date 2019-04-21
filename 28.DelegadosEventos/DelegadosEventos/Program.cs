using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralHub hub = new CentralHub();

            //aqui se invocarian todos los nuevos metodos
            SistemaAlarmas alarmas = new SistemaAlarmas();
            SistemaElectrodomesticos electrodomestico = new SistemaElectrodomesticos();
            SistemaLuces luces = new SistemaLuces();

            hub.Add(alarmas.EncenderAlarmas);
            hub.Add(electrodomestico.ApagarElectrodomesticos);
            hub.Add(luces.ApagarLuces);

            hub.IniciarProtocoloCierre();

            //metodo Predicado
            PredicadoDelegate pDeleg = new PredicadoDelegate();


            //Operacion ternaria
            OperacionTernaria resultado = new OperacionTernaria();
            resultado.Suma();

            Console.ReadLine();
        }
    }
}
