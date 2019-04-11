using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class MultimediaFile2
    {
        public string fechaCreacion;
        string fechaModificacion, nombre, tipoElemento;

        public virtual void DesplegarInformacion()
        {
            string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
            Console.WriteLine(informacion);
        }

        
    }
}
