using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class StaticFile2: MultimediaFile2
    {
        //declarando metodos virtuales para poderlos sobreEscribir
        public virtual void Editar()
        {
            Console.WriteLine("Editando!..");
        }

        //la palabra reservada new hace que pueda nombrar con el mismo nombre el metodo, al de la clase padre
        //public new void DesplegarInformacion()
        //{

        //}

        //sobreescribiendo el metodo de la clase padre
        public override void DesplegarInformacion()
        {
            Console.WriteLine("Soy un archivo Statico!.");
        }
    }
}
