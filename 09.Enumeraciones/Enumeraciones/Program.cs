using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Rol tipoUsuario = Rol.Administrador;

            //convirtiendo en nullable
            Rol? rol = null;

            //casteando un dato
            Rol i = Rol.user;
            Console.WriteLine("valor cast:" + (int)i);

            switch (tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine("Es: " + tipoUsuario);
                    break;
                case Rol.Desarrollador:
                    Console.WriteLine("Es: " + tipoUsuario);
                    break;
                case Rol.UsarioFinal:
                    Console.WriteLine("Es: " + tipoUsuario);
                    break;
                default:
                    break;
            }

            ValidarUsuario(Rol.Desarrollador);

            Console.ReadLine();
        }

        //pasando enumeraciones como variables
       public static void ValidarUsuario(Rol rol)
        {
            Console.WriteLine(rol);
        }
    }
}
