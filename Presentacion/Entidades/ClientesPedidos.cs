using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesPedidos
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public string Direccion { get; set; }
        public bool Modo_Pago { get; set; }

        public ClientesPedidos()

        {
            Identificacion = string.Empty;
            Nombre = string.Empty;
            Producto = string.Empty;
            Direccion = string.Empty;
            Modo_Pago = false;
        }
    }
}
