using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_Datos
{
    public class BD_Conexion
    {
        public string ConectarBD()
        {
            var con = ConfigurationManager.ConnectionStrings["ConBD"].ConnectionString;

            return con;
        }
    }
}
