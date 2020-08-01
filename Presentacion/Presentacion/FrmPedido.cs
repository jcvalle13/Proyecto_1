using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmPedido : Form
    {
        public List<ClientesPedidos> lstresultado { get; set; }
        public bool EsError { get; set; }
        public FrmPedido()
        {
            InitializeComponent();
            lstresultado = new List<ClientesPedidos>();
          
        }

        private void limpiar()
        {

            txtidentificacion.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtproducto.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txttelefono.Text = string.Empty;
            cbomodopago.SelectedIndex = 0;
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

        private void btnpedir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    if (VerificarExistenciaCodigo())
                    {
                        MessageBox.Show("El código digitado ya existe en base de datos, por favor cambiarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ClientesPedidos p = new ClientesPedidos();

                    p.Identificacion = Convert.ToInt32(txtidentificacion.Text.Trim());
                    p.Nombre = txtnombre.Text.Trim();
                    p.Producto = txtproducto.Text.Trim();
                    p.Direccion = txtdireccion.Text.Trim();
                    p.Telefono = Convert.ToInt32(txttelefono.Text.Trim());
                    p.Modo_Pago = cbomodopago.Text.Trim();

                    Negocio.LNegocio.AgregarPedidos(p);
                    MessageBox.Show("Pedido agregado");
                    limpiar();

                    txtidentificacion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
           FrmConsultaPedido frm = new FrmConsultaPedido();
            frm.Show();
            this.Hide();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
            this.Hide();
        }
    }
}
