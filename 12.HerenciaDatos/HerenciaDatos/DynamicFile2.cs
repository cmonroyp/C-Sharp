using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class DynamicFile2:MultimediaFile2
    {
        //declarando metodos virtuales para poderlos sobreEscribir
        public virtual void Reproducir()
        {
            Console.WriteLine("Reproduciendo");
        }

        public virtual void Pausar()
        {
            Console.WriteLine("Pausar");
        }

        public virtual void Detener()
        {
            Console.WriteLine("Detener");
        }

        public override void DesplegarInformacion()
        {
            Console.WriteLine("Soy un archivo dinamico!.");
        }
    }
}
