using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Mensajero
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public int Telefono { get; set; }

        public Mensajero()
        {
            Identificacion = string.Empty;
            Nombre = string.Empty;
            Placa = string.Empty;
            Telefono = 0;
        }
    }
}
