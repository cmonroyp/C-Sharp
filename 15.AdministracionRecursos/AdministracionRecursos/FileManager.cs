using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursos
{
    class FileManager
    {
        public FileManager(string filePath)
        {

            using (FileStream reader = File.Open(filePath, FileMode.Open))
            {

                byte[] b = new byte[1024];
                //permite leer cadenas de texto de un archivo
                UTF8Encoding temp = new UTF8Encoding();

                while (reader.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }

        }

        //Destructor
        ~FileManager()
        {
            System.Diagnostics.Trace.WriteLine("Archivo Cerrado!.");
        }
    }
}
