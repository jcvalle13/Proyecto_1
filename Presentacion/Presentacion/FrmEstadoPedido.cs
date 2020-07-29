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
    public partial class FrmEstadoPedido : Form
    {
        public List<ClientesPedidos> lstresultado { get; set; }
        public bool EsError { get; set; }
        public FrmEstadoPedido()
        {
            InitializeComponent();
            lstresultado = new List<ClientesPedidos>();
        }

        private bool VerificarExistenciaCodigo()
        {
            bool L_resultado = false;

            try
            {
                foreach (ClientesPedidos item in lstresultado)
                {
                    if (item.Identificacion == Convert.ToInt32(txtidentificacion.Text.Trim()))
                    {
                        L_resultado = true; // Es igual a encontro el codigo
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return L_resultado;
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
            try
            {
                if (!EsError)
                {
                    ClientesPedidos m = new ClientesPedidos();

                    m.Identificacion = Convert.ToInt32(txtidentificacion.Text.Trim());
                   /* m.Nombre = txtnombre.Text.Trim();
                    m.Producto = txtproducto.Text.Trim();
                    m.Direccion = txtdireccion.Text.Trim();
                    m.Telefono = Convert.ToInt32(txttelefono.Text.Trim());
                    m.Modo_Pago = cbomodopago.Text.Trim();*/
                    m.Estado = cboestado.Text.Trim();


                    Negocio.LNegocio.ModificarPedidos(m);
                    MessageBox.Show("Iniciando pedido", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btndecamino_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    ClientesPedidos m = new ClientesPedidos();

                    m.Identificacion = Convert.ToInt32(txtidentificacion.Text.Trim());
                    m.Estado = cboestado.Text.Trim();


                    Negocio.LNegocio.ModificarPedidos(m);
                    MessageBox.Show("Camino a la Entrega", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer1.Start();
          //  MessageBox.Show("Camino a la Entrega", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnentregado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    ClientesPedidos m = new ClientesPedidos();

                    m.Identificacion = Convert.ToInt32(txtidentificacion.Text.Trim());
                    m.Estado = cboestado.Text.Trim();


                    Negocio.LNegocio.ModificarPedidos(m);
                    MessageBox.Show("Pedido Entregado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer2.Start();
           // MessageBox.Show("Pedido Entregado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbcarga2.Increment(10);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClientesPedidos> lstresultado = LNegocio.Consultar_Pedidos();

                this.dgvestado.DataSource = lstresultado;
                this.dgvestado.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
