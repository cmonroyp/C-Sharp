using System;

namespace _12._2_Herencia_PrincipioSustitucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo("Trueno");
            caballo.getNombre();

            Hombre hombre = new Hombre("Juan");
            hombre.getNombre();

            Perros perro = new Perros("Sultan");
            perro.getNombre();

            //principio de sustitucion
            Mamiferos m = new Perros("sss");
            m.TomanLeche();

            Mamiferos ma = new Mamiferos("Relampago");
            Caballo ca = new Caballo("Terciepelo");
            ma = ca;
            ma.getNombre();

            Object miCaballo = new Caballo("Alazan");

            Mamiferos[] mamif = new Mamiferos[3];
            mamif[0] = caballo;
            mamif[1] = perro;
            mamif[2] = hombre;

            //mamif[1].getNombre();

            Console.ReadLine();

        }

        public class Mamiferos
        {
            private string nombreMamifero;

            public Mamiferos(string nombre)
            {
                this.nombreMamifero = nombre;
            }
            public void TomanLeche()
            {
                Console.WriteLine("Los mamiferos toman leche");
            }

            public void SonVertebrados()
            {
                Console.WriteLine("Los mamifereos son vertebrados");
            }

            public void getNombre()
            {
                Console.WriteLine("El nombre del ser vivo es: " + nombreMamifero);
            }
        }

        public class Caballo : Mamiferos
        {
            public Caballo(string nombreCaballo) : base(nombreCaballo)
            {

            }
            public void Cabalgan()
            {
                Console.WriteLine("Los caballos cabalgan");
            }
        }

        public class Hombre : Mamiferos
        {
            public Hombre(string nombreHumano) : base(nombreHumano) { }
            public void Hablar()
            {
                Console.WriteLine("Los seres humanos Hablan");
            }
        }

        public class Perros : Mamiferos
        {
            public Perros(string nombrePerro) : base(nombrePerro) { }
            public void Ladrar()
            {
                Console.WriteLine("Los perros ladran");
            }
        }
    }
}
