using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Entidades;

namespace AccesoDatos
{
    public class Acceso
    {
        #region Atributos
        //Configuracion string de conexion Joiner Proyecto1_Globo
        private string strconexion = Properties.Settings.Default.Proyecto1_Globo;
        
        //Configuracion string de conexion a base de datos Steph Glovo
        //private string strconexion = Properties.Settings.Default.Glovo;
        private SqlConnection objconexion;
        #endregion

        #region Constructor

        public Acceso()
        {
            try
            {
                //Inicializa la conexion con la cadena 
                objconexion = new SqlConnection(strconexion);
                this.ABRIRCONEXION();  //se abre conexión
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION(); //Cierre de conexión
            }
        }
        #endregion

        #region Metodos privados

        private void ABRIRCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRARCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }

        #endregion

        #region Métodos públicos

        public int Ejecutar_Peticiones(SQLParametros P_Peticion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;

                this.ABRIRCONEXION();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
        }

        public List<Usuarios> Consultar_Usuarios(SQLParametros P_Peticion)
        {

            List<Usuarios> lstresultados = new List<Usuarios>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;


                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();


                        u.Usuario = fila.ItemArray[0].ToString();
                        u.Contraseña = fila.ItemArray[1].ToString();
                        u.Estado = Convert.ToBoolean(fila.ItemArray[2].ToString());

                        lstresultados.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }

        #endregion

    }
}
