using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fManager = new FileManager(@"E:\Cursos\C-Sharp\AdministracionRecursos\prueba.txt");
            FileManager fManager2 = new FileManager(@"E:\Cursos\C-Sharp\AdministracionRecursos\prueba.txt");

            //MetodoIdisposable();

            Console.ReadLine();
        }

        //IDisposable
        static void MetodoIdisposable()
        {
            string path = @"E:\Cursos\C-Sharp\AdministracionRecursos\prueba.txt";
            FileManagerIDispose fmID = new FileManagerIDispose(path);
            using (fmID)
            {

            }

            string path2 = @"E:\Cursos\C-Sharp\AdministracionRecursos\prueba.txt";
            FileManagerIDispose fmID2 = new FileManagerIDispose(path2);
            using (fmID2)
            {

            }

        }

    }
}
