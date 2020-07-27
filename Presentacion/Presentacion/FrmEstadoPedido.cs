using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEstadoPedido : Form
    {
        public FrmEstadoPedido()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbcarga.Increment(10);
        }

        private void btnenrestaurante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando pedido", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btndecamino_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("Camino a la Entrega", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnentregado_Click(object sender, EventArgs e)
        {
            timer2.Start();
            MessageBox.Show("Pedido Entregado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbcarga2.Increment(10);
        }
    }
}
