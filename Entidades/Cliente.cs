using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //[IdCliente], [Nombres], [Apellidos], [DNI], [EMail], [IdTipoCliente]
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string EMail { get; set; }
        public int IdTipoCliente { get; set; }

    }

}
