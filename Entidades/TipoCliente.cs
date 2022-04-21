using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoCliente
    {
        //[IdTipoCliente], [Nombre], [Adicionales]
        public int IdTipoCliente { get; set; }
        public string Nombre { get; set; }
        public string Adicionales { get; set; }
    }
}
