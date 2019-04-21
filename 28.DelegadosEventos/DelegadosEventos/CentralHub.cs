using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    class CentralHub
    {
        public delegate void iniciarProtocoloDelegate();
        iniciarProtocoloDelegate iniciarProtocolo;

        public void IniciarProtocoloCierre()
        {
            iniciarProtocolo();
        }

        public void Add(iniciarProtocoloDelegate metodoProtocolo) =>
                iniciarProtocolo += metodoProtocolo;

        public void Remove(iniciarProtocoloDelegate metodoProtocolo) =>
                iniciarProtocolo -= metodoProtocolo;
    }
}
