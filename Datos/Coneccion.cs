using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Coneccion
    {
        private readonly static string Cadena = "Data Source=.;Initial Catalog=Examen;Integrated Security=True";

        public static string GetConeccion()
        {
            return Cadena;
        }
    }
}
