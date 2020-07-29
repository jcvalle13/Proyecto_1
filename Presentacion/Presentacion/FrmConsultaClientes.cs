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
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {

                List<ClientesPedidos> lstresultado = LNegocio.Consultar_Pedidos();

                this.dgvclientes.DataSource = null;
                this.dgvclientes.Refresh();


                dgvclientes.DataSource = lstresultado;
                dgvclientes.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
