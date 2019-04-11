using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class MultimediaFile
    {
        public string fechaCreacion;
            string fechaModificacion, nombre,  tipoElemento;

        public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        {
            this.fechaCreacion = _fechaCreacion;
            this.fechaModificacion = _fechaModificacion;
            this.nombre = _nombre;
            this.tipoElemento = _tipoElemento;
        }

        public void DesplegarInformacion()
        {
            string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
            Console.WriteLine(informacion);
        }

        //la idea es sobreescribir el metodo tostring de la clase System.Object
        public override string ToString()
        {
            return "ToString sobreescrito";
        }
    }
}
