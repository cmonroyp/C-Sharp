using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class StaticFile: MultimediaFile
    {
        public StaticFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
            : base(_fechaCreacion,_fechaModificacion,_nombre, _tipoElemento)
        {

        }
        public void Editar()
        {
            Console.WriteLine("Editando!..");
        }
    }
}
