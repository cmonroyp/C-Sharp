using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApimodulo4.Services
{
    public class ClaseB : IClaseB
    {
        public void HacerAlgo()
        {
            Console.WriteLine("Clase B invocada");
        }

        public class ClaseB2 : IClaseB
        {
            public void HacerAlgo()
            {

            }
        }
    }
}
