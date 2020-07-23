using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmManPerfiles : Form
    {
        #region Propiedades

        public List<Perfiles> lstresultado { get; set; }
        public bool EsError { get; set; }

        #endregion


        public FrmManPerfiles()
        {
            lstresultado = new List<Perfiles>();
            InitializeComponent();
        }

        #region Metodos 

        #region Metodos privados

        private void limpiar()
        {
            txtcodigoperfil.Text = string.Empty;
            txtNombrePerfil.Text = string.Empty;
            cboPerfiles.SelectedIndex = 0;
        }

        private void CargarLista()
        {
            try
            {
                lstresultado = new List<Perfiles>();

                if (txtBuscar.Text.Length == 0 || txtBuscar.Text.Equals("0"))
                    lstresultado = LNegocio.ConsultarPerfiles(new Perfiles { cod_perfil = 0 });
                else
                    lstresultado = Negocio.ConsultarPerfiles(new Perfiles { cod_perfil = Convert.ToInt32(txtBuscar.Text) });

                dgvPerfiles.DataSource = null;
                dgvPerfiles.Refresh();

                dgvPerfiles.DataSource = lstresultado;
                dgvPerfiles.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void CargarCombos()
        {
            try
            {
                //Creando una tabla
                DataTable dt = new DataTable();

                //Creando las columnas a esa tabla
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Descripcion");

                //Insertando información a esa tabla
                dt.Rows.Add("true", "Activo");
                dt.Rows.Add("false", "Inactivo");

                cboPerfiles.DataSource = dt;
                cboPerfiles.DisplayMember = "Descripcion";
                cboPerfiles.ValueMember = "Codigo";
                cboPerfiles.Refresh();
                cboPerfiles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool VerificarExistenciaCodigo()
        {
            bool L_resultado = false;

            try
            {
                foreach (Perfiles item in lstresultado)
                {
                    if (item.cod_perfil == Convert.ToInt32(txtcodigoperfil.Text.Trim()))
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

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
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
                    Perfiles p = new Perfiles();

                    Perfiles perfil_user = new Perfiles();
                    perfil_user.cod_perfil = Convert.ToInt32(txtcodigoperfil.Text.Trim());
                    perfil_user.descripcion = txtdescripcion.Text.Trim();
                    perfil_user.estado = (cboPerfiles.SelectedValue.ToString().Equals("true")) ? true : false;

                    LNegocio.AgregarPerfiles(perfil_user);
                    MessageBox.Show("Perfil agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    CargarLista();
                    txtcodigoperfil.Focus(); //coloca el cursor en el control
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #endregion


    }
}
