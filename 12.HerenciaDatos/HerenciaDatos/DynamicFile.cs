using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class DynamicFile: MultimediaFile
    {
        string duracion;

        public DynamicFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
            : base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        {

        }
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausar");
        }

        public void Detener()
        {
            Console.WriteLine("Detener");
        }
    }
}
