using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesPedidos
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public string Direccion { get; set; }

        public int Telefono { get; set; }
        public string Modo_Pago { get; set; }

        public string Estado { get; set; }

        //public bool Modo_Pago { get; set;}
        public ClientesPedidos()

        {
            Identificacion = 0;
            Nombre = string.Empty;
            Producto = string.Empty;
            Direccion = string.Empty;
            Telefono = 0;
            Modo_Pago = string.Empty;
            Estado = string.Empty;

            //Modo_Pago = false;
        }
    }
}
