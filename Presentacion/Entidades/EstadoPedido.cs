using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoPedido
    {
        public int Identificacion { get; set; }
        public string Estado { get; set; }

        public EstadoPedido()
        {
            Identificacion = 0;
            Estado = string.Empty;
        }
    }
}
