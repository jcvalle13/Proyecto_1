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

        public void CargarOpcionesUsuario()
        {
          
            Usuarios u = new Usuarios();
            u.Usuario = Usuario;

            List<Usuarios> lstusuarios = LNegocio.Consultar_Permisos_Usuarios(u);
            //botones
            mantenimientosToolStripMenuItem.Visible = false;
            consultasToolStripMenuItem.Visible = false;
            pedidosToolStripMenuItem.Visible = false;

            foreach (Usuarios item in lstusuarios)
            {
                switch (item.Perfiles.cod_perfil)
                {
                    case 1: { consultasToolStripMenuItem.Visible = true; } break;
                    case 2: { mantenimientosToolStripMenuItem.Visible = true; } break;
                    case 3: { pedidosToolStripMenuItem.Visible = true; } break;
                    case 4: { } break;
                    case 5: { } break;
                }
            }
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Console.WriteLine("Conexion Finalizada");
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManPerfiles frm = new FrmManPerfiles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManUsuarios frm = new FrmManUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estadoPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPedidosAdm frm = new FrmConsultaPedidosAdm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mensajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMensajero frm = new FrmMensajero();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estadoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoPedido frm = new FrmEstadoPedido();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
