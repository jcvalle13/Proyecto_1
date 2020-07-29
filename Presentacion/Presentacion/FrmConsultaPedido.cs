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
    public partial class FrmConsultaPedido : Form
    {
        //public List<ClientesPedidos> lstresultado { get; set; }
        public FrmConsultaPedido()
        {
            //lstresultado = new List<ClientesPedidos>();
            InitializeComponent();
           // CargarConsultaPedido();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void CargarConsultaPedido()
        {
            try
            {
                lstresultado = new List<ClientesPedidos>();

                if (txtcedula.Text.Length == 0 || txtcedula.Text.Equals("0"))
                    lstresultado = LNegocio.Consultar_Pedidos(new ClientesPedidos { Identificacion = 0 });
                else
                    lstresultado = LNegocio.Consultar_Pedidos(new ClientesPedidos { Identificacion = Convert.ToInt32(txtcedula.Text) });

                dgvpedidos.DataSource = null;
                dgvpedidos.Refresh();

                dgvpedidos.DataSource = lstresultado;
                dgvpedidos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }*/


        /*private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarConsultaPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}
