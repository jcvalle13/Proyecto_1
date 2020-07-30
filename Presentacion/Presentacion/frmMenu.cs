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

            //*************************************************
            //pedidos tiene q quitarlo xq esta afuera
            pedidosToolStripMenuItem.Visible = false;
            //***************************************************

            mensajeroToolStripMenuItem.Visible = false;

            foreach (Usuarios item in lstusuarios)
            {
                switch (item.Perfiles.cod_perfil)
                {
                    case 1: { mantenimientosToolStripMenuItem.Visible = true; } break;
                    case 2: { consultasToolStripMenuItem.Visible = true; } break;

                        //**************************************************************
                        //igual aca, quitarlo
                    case 3: { pedidosToolStripMenuItem.Visible = true; } break;
                        //***************************************************************

                    case 4: { mensajeroToolStripMenuItem.Visible = true; } break;
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
            MessageBox.Show("Conexion Finalizada");
            Application.Exit();
            
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

   
        private void mensajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMensajero frm = new FrmMensajero();
            frm.MdiParent = this;
            frm.Show();
        }

      

       

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuarios frm = new FrmConsultaUsuarios();
            frm.Show();
            this.Hide();
        }

        private void listadoDePaquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMensajeros frm = new FrmConsultaMensajeros();
            frm.Show();
            this.Hide();
        }

        private void listadoCantidadDePaquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frm = new FrmConsultaClientes();
            frm.Show();
            this.Hide();
        }

        private void estadoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoPedido frm = new FrmEstadoPedido();
            frm.Show();
            this.Hide();
        }
    }
}
