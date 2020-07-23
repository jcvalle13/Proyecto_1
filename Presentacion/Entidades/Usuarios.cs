using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }


        public Usuarios()
        {
            Usuario = string.Empty;
            Contraseña = string.Empty;
            Estado = false;



        }
    }
}
