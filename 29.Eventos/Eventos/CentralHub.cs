using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class CentralHub
    {

        ControlEmpleados control = new ControlEmpleados();

        public void Add(Action metodoProtocolo) =>
          control.EmpleadosCero += metodoProtocolo;

        public void Remove(Action metodoProtocolo) =>
                control.EmpleadosCero -= metodoProtocolo;

        public void RevisarSalida()
        {
            control.RevisarSalida();
        }
    }
}
