using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //LinQ();
            //OperadoresDeConsulta();
            MetodosUtiles();

            Console.ReadLine();
        }

        public static void LinQ()
        {
            var estudiantes = new[]
             {
                new
                {
                    EstudianteID =1,
                    Nombre = "Carlos",
                    ApellidoPaterno ="Monroy",
                    Universidad = "Remington"
                },
                 new
                {
                    EstudianteID =2,
                    Nombre = "Angela",
                    ApellidoPaterno ="Camargo",
                    Universidad = "Uni del Valle"
                },
                  new
                {
                    EstudianteID =3,
                    Nombre = "Pedro",
                    ApellidoPaterno ="Rojas",
                    Universidad = "La Sabana"
                }
            };

            var universidades = new[]
            {
                new
                {
                    Universidad ="Remington",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
                new
                {
                    Universidad ="Uni del Valle",
                    Ciudad = "Tijuana",
                    Pais ="Mexico"
                },
                new
                {
                    Universidad ="La Sabana",
                    Ciudad = "Oxford",
                    Pais ="Oxford"
                },
                new
                {
                    Universidad ="Santo Tomas",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
            };

            IEnumerable<string> nombreEstudiantes = estudiantes.Select(e => e.Nombre);
            //IEnumerable<string> nombreApellidos = estudiantes.Select(e => $"{e.Nombre} {e.ApellidoPaterno}");
            foreach (var item in nombreEstudiantes)
            {

                Console.WriteLine(item);
            }

            IEnumerable<Estudiante> nombreApellidos = estudiantes.Select(e => new Estudiante
            {
                Nombre = e.Nombre,
                Apellido = e.ApellidoPaterno
            });

            foreach (var item in nombreApellidos)
            {

                Console.WriteLine(item.Nombre + " " + item.Apellido);
            }

            Console.WriteLine();
            Console.WriteLine("Nombre y apellidos forma anonima");

            //nombres y apellidos de tipo anonimo
            var nombreApellidoAnonimo = estudiantes.Select(e => new
            {
                Nombre = e.Nombre,
                Apellido = e.ApellidoPaterno
            });

            foreach (var item in nombreApellidoAnonimo)
            {

                Console.WriteLine(item.Nombre + " " + item.Apellido);
            }

            Console.WriteLine();
            Console.WriteLine("Filtando Universidades de Colombia");

            var universidadesCol = universidades
                                    .Where(u => u.Pais == "Colombia")
                                    .Select(u => u.Universidad);


            foreach (var item in universidadesCol)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Ordenar datos");
            var universidadesColOrdenadas = universidades
                                    .OrderBy(u => u.Universidad)
                                    .ThenBy(u => u.Pais)
                                    .Select(u => u.Universidad);


            foreach (var item in universidadesColOrdenadas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Agrupando datos");
            var universidadesAgrupadas = universidades
                                    .GroupBy(u => u.Pais);

            foreach (var item in universidadesAgrupadas)
            {
                Console.WriteLine($"{item.Key} \t Cantidad: {item.Count()}");

                foreach (var univeridad in item)
                {
                    Console.WriteLine($"\t {univeridad.Universidad}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Conteo universidades");

            var conteoUniversidad = universidades
                                    .Select(x => x.Universidad)
                                    .Count();

            Console.WriteLine(conteoUniversidad);

            Console.WriteLine();
            Console.WriteLine("Numero de paises");

            var conteoPaises = universidades
                                    .Select(x => x.Pais)
                                    .Distinct()
                                    .Count();

            Console.WriteLine(conteoPaises);

            Console.WriteLine();
            Console.WriteLine("Uniendo datos");

            var join = estudiantes
                       .Select(e => new
                       {
                           e.Nombre,
                           e.ApellidoPaterno,
                           e.Universidad
                       })
                       .Join(universidades,
                              e => e.Universidad,
                              u => u.Universidad,
                              (e, u) => new
                              {
                                  e.Nombre,
                                  e.ApellidoPaterno,
                                  u.Pais
                              });

            foreach (var item in join)
            {
                Console.WriteLine(item);
            }
        }

        public static void OperadoresDeConsulta()
        {
            var estudiantes = new[]
             {
                new
                {
                    EstudianteID =1,
                    Nombre = "Carlos",
                    ApellidoPaterno ="Monroy",
                    Universidad = "Remington"
                },
                 new
                {
                    EstudianteID =2,
                    Nombre = "Angela",
                    ApellidoPaterno ="Camargo",
                    Universidad = "Uni del Valle"
                },
                  new
                {
                    EstudianteID =3,
                    Nombre = "Pedro",
                    ApellidoPaterno ="Rojas",
                    Universidad = "La Sabana"
                }
            };

            var universidades = new[]
            {
                new
                {
                    Universidad ="Remington",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
                new
                {
                    Universidad ="Uni del Valle",
                    Ciudad = "Tijuana",
                    Pais ="Mexico"
                },
                new
                {
                    Universidad ="La Sabana",
                    Ciudad = "Oxford",
                    Pais ="Oxford"
                },
                new
                {
                    Universidad ="Santo Tomas",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
            };

            Console.WriteLine("Muestra Nombre");
            var nombreEstudiantes = from nombres in estudiantes
                                    select nombres.Nombre;

            foreach (var item in nombreEstudiantes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("concatena Nombre y apellido");
            var nombreApellido = from nombres in estudiantes
                                 select new
                                 {
                                     nombres.Nombre,
                                     nombres.ApellidoPaterno
                                 };

            foreach (var item in nombreApellido)
            {
                Console.WriteLine($"{item.Nombre} \t {item.ApellidoPaterno}");
            }

            Console.WriteLine();
            Console.WriteLine("filtrando informacion Universidades de colombia");
            var universidadesPais = from uniPais in universidades
                                    where string.Equals(uniPais.Pais, "Colombia")
                                    select uniPais.Universidad;

            foreach (var item in universidadesPais)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("ordenando universidades");
            var orderUniversidades = from u in universidades
                                     orderby u.Universidad
                                     select u.Universidad;

            foreach (var item in orderUniversidades)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("agrupando universidades por pais");
            var univPais = from u in universidades
                           group u by u.Pais;

            foreach (var item in univPais)
            {
                Console.WriteLine($"{item.Key}\t {item.Count()}");

                foreach (var univ in item)
                {
                    Console.WriteLine($"\t {univ.Universidad}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("cantidad universidades");
            var cantidadUniversidades = (from u in universidades
                                         select u.Universidad)
                                        .Count();

            Console.WriteLine(cantidadUniversidades);

            Console.WriteLine();
            Console.WriteLine("usando distin paises");
            var conteoPais = (from u in universidades
                              select u.Pais)
                                        .Distinct()
                                        .Count();

            Console.WriteLine(conteoPais);

            Console.WriteLine();
            Console.WriteLine("Uniendo datos");
            var join = from u in universidades
                       join e in estudiantes
                       on u.Universidad equals e.Universidad
                       select new
                       {
                           e.Nombre,
                           e.ApellidoPaterno,
                           u.Pais
                       };

            foreach (var item in join)
            {
                Console.WriteLine(item);
            }

        }

        public static void MetodosUtiles()
        {
            var estudiantes = new[]
             {
                new
                {
                    EstudianteID =1,
                    Nombre = "Carlos",
                    ApellidoPaterno ="Monroy",
                    Universidad = "Remington"
                },
                 new
                {
                    EstudianteID =2,
                    Nombre = "Angela",
                    ApellidoPaterno ="Camargo",
                    Universidad = "Uni del Valle"
                },
                  new
                {
                    EstudianteID =3,
                    Nombre = "Pedro",
                    ApellidoPaterno ="Rojas",
                    Universidad = "La Sabana"
                }
            };

            var universidades = new[]
            {
                new
                {
                    Universidad ="Remington",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
                new
                {
                    Universidad ="Uni del Valle",
                    Ciudad = "Tijuana",
                    Pais ="Mexico"
                },
                new
                {
                    Universidad ="La Sabana",
                    Ciudad = "Oxford",
                    Pais ="Oxford"
                },
                new
                {
                    Universidad ="Santo Tomas",
                    Ciudad = "Bogota",
                    Pais ="Colombia"
                },
            };

            Console.WriteLine();
            Console.WriteLine("mostrando solo los 2 primeros estudiantes");
            var parte = estudiantes.Take(2);

            foreach (var item in parte)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.WriteLine();
            Console.WriteLine("saltando el primer registro y tomando los siguientes 2");
            var parteNext = estudiantes.Skip(1).Take(2);

            foreach (var item in parteNext)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.WriteLine();
            Console.WriteLine("Buscando alguna coincidencia ne la consulta");
            var cualquiera = estudiantes.Any(
                             x => x.Nombre.StartsWith("C"));

            Console.WriteLine(cualquiera);

            Console.WriteLine();
            Console.WriteLine("todas las propiedades nombre no sean null o vacia");
            var todos = estudiantes.All(x => x.Nombre != "");
            Console.WriteLine(todos);

            Console.WriteLine();
            Console.WriteLine("primer coincidencia");
            var primero = estudiantes.First(x => x.Nombre.StartsWith("P"));
            Console.WriteLine(primero);

            Console.WriteLine();
            Console.WriteLine("en caso de tener coincidencia");
            var notCoincidencia = estudiantes.FirstOrDefault(x => x.Nombre.StartsWith("z"));
            Console.WriteLine(notCoincidencia);

            Console.WriteLine();
            Console.WriteLine("evaluacion diferida");
            var nombres = estudiantes
                           .Select(e => e.Nombre);
            //.ToList() perimite hacer una copia de la lista

            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            estudiantes[0] = new
            {
                EstudianteID = 1,
                Nombre = "Susana",
                ApellidoPaterno = "Guillo",
                Universidad = "Remington"
            };

            foreach (var item in nombres)
            {
                Console.WriteLine("nombre diferido:" + item);
            }

        }
    }
}
