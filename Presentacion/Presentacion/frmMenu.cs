using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmMenu : Form
    {

        public string Usuario { get; set; }

        /*public void CargarOpcionesUsuario()
        {
          
            Usuarios u = new Usuarios();
            u.NombreUsuario = Usuario;

            List<Usuarios> lstusuarios = LNegocio.Consultar_Permisos_Usuarios(u);
            //botones
            mantenimientoToolStripMenuItem.Visible = false;
            consultasToolStripMenuItem.Visible = false;
            procesosToolStripMenuItem.Visible = false;

            foreach (Usuarios item in lstusuarios)
            {
                switch (item.Perfiles.cod_perfil)
                {
                    case 1: { consultasToolStripMenuItem.Visible = true; } break;
                    case 2: { mantenimientoToolStripMenuItem.Visible = true; } break;
                    case 3: { procesosToolStripMenuItem.Visible = true; } break;
                    case 4: { } break;
                    case 5: { } break;
                }
            }
        }*/
        public frmMenu()
        {
            InitializeComponent();
        }

        private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
