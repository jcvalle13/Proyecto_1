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
    public partial class FrmMensajero : Form
    {
        public List<Mensajero> lstresultado { get; set; }
        public bool EsError { get; set; }
        public FrmMensajero()
        {
            InitializeComponent();
            lstresultado = new List<Mensajero>();
        }

        private void limpiar()
        {

            txtidentificacion.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtplaca.Text = string.Empty;
            txttelefono.Text = string.Empty;
           
        }

        private bool VerificarExistenciaCodigo()
        {
            bool L_resultado = false;

            try
            {
                foreach (Mensajero item in lstresultado)
                {
                    if (item.Identificacion == txtidentificacion.Text.Trim())
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

        private void btnagregar_Click(object sender, EventArgs e)
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

                    Mensajero m = new Mensajero();

                    m.Identificacion = txtidentificacion.Text.Trim();
                    m.Nombre = txtnombre.Text.Trim();
                    m.Placa = txtplaca.Text.Trim();
                    m.Telefono = Convert.ToInt32(txttelefono.Text.Trim());
                    

                    Negocio.LNegocio.AgregarMensajero(m);
                    MessageBox.Show("Mensajero agregado");
                    limpiar();

                    txtidentificacion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    Mensajero m = new Mensajero();

                    m.Identificacion = txtidentificacion.Text.Trim();
                    m.Nombre = txtnombre.Text.Trim();
                    m.Placa = txtplaca.Text.Trim();
                    m.Telefono = Convert.ToInt32(txttelefono.Text.Trim());

                    Negocio.LNegocio.ModificarMensajero(m);
                    MessageBox.Show("Mensajero modificado");
                    limpiar();

                    txtidentificacion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Mensajero m = new Mensajero();

                m.Identificacion = txtidentificacion.Text.Trim();

                LNegocio.EliminarMensajero(m);
                MessageBox.Show("Mensajero Eliminado");
                limpiar();

                txtidentificacion.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
