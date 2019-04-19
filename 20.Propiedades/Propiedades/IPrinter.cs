using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    //Declatando propiedades en una interface
    interface IPrinter
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
