using System;

namespace _12._3_Herencia_Polimorfismo
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

            Chinpance chinpance = new Chinpance("Loquillo");


            //polimorfismo
            Console.WriteLine("Polimorfimos");
            Mamiferos[] varios = new Mamiferos[3];
            varios[0] = hombre;
            varios[1] = chinpance;
            varios[2] = perro;

            for (int i = 0; i < varios.Length; i++)
            {
                varios[i].Pensar();
            }


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

            public virtual void Pensar()
            {
                Console.WriteLine("Pensamiento basico instintivo!.");
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

            public override void Pensar()
            {
                Console.WriteLine("Son capaces de pensar los humanos");
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

        public class Chinpance : Mamiferos
        {
            public Chinpance(string nombreChinpance) : base(nombreChinpance)
            {

            }
            public override void Pensar()
            {
                Console.WriteLine("Son capaces de pensar los Chinpances");
            }
        }
    }
}
