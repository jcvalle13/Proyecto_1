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
using Presentacion.GlovoDataSetTableAdapters;


namespace Presentacion
{
    public partial class FrmConsultaPedido : Form
    {
        public FrmConsultaPedido()
        {
            
            InitializeComponent();
   
        }

        private void limpiar()
        {
            identificacionTextBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Gracias por preferirnos!", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void estadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.estadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glovoDataSet);
            
        }

        private void FrmConsultaPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glovoDataSet.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.glovoDataSet.Estado);
            limpiar();
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            this.estadoTableAdapter.BuscarPedido(this.glovoDataSet.Estado, Convert.ToInt32(identificacionTextBox.Text));
            estadoDataGridView.Rows[0].Selected = false;
        }

        
    }
}
