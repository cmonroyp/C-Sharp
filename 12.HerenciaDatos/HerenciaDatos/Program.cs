using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            MultimediaFile mFile = new MultimediaFile("04/09/2019","04/10/2019","nuevo archivo Multimedia","video");
            //mFile.DesplegarInformacion();

            DynamicFile dFile = new DynamicFile("04/09/2019", "04/10/2019", "nuevo archivo dinamico", "video");
            
            StaticFile sFile = new StaticFile("04/09/2019", "04/10/2019", "nuevo archivo estatico", "video");
            //sFile.Editar();

            mFile.DesplegarInformacion();
            dFile.DesplegarInformacion();
            sFile.DesplegarInformacion();


            //asignacion de clases
            AsignandoClases();

            //declarando metodos virtuales para poderlos sobreEscribir
            Console.WriteLine(mFile.ToString());

            Console.ReadLine();
        }

        public static void AsignandoClases()
        {
            DynamicFile2 dFile2 = new DynamicFile2();

            dFile2.DesplegarInformacion();
            //MultimediaFile2 mFile2 = new MultimediaFile2();
            StaticFile2 sFile2 = new StaticFile2();

            sFile2.DesplegarInformacion();

            MultimediaFile2 mFile2 = sFile2;

            StaticFile2 sFile3 = sFile2 as StaticFile2;

            if(mFile2 != null)
            {
                sFile2.DesplegarInformacion();
            }
           
        }
    }
}
