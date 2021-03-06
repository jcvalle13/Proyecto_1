﻿using System;
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
      //private string strconexion = Properties.Settings.Default.Proyecto1_Globo;
        
        //Configuracion string de conexion a base de datos Steph Glovo
        private string strconexion = Properties.Settings.Default.Glovo;
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

        public List<Usuarios> Consultar_Permisos_Usuarios(SQLParametros P_Peticion)
        {
            //Variable temporal que conservara respuesta de BD
            List<Usuarios> lstresultados = new List<Usuarios>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        u.Perfiles = new Perfiles
                        {
                            cod_perfil = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            descripcion = fila.ItemArray[1].ToString()
                        };

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

        public List<Perfiles> Consultar_Perfiles(SQLParametros P_Peticion)
        {
            List<Perfiles> lstresultados = new List<Perfiles>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultaperfil = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultaperfil.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Perfiles p = new Perfiles();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        p.cod_perfil = Convert.ToInt32(fila.ItemArray[0].ToString());
                        p.descripcion = fila.ItemArray[1].ToString();
                        p.estado = Convert.ToBoolean(fila.ItemArray[2].ToString());

                        lstresultados.Add(p);
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

        public List<ClientesPedidos> Consultar_Pedidos(SQLParametros P_Peticion)
        {
            List<ClientesPedidos> lstresultados = new List<ClientesPedidos>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultapedido = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultapedido.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        ClientesPedidos p = new ClientesPedidos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        p.Identificacion = Convert.ToInt32(fila.ItemArray[0].ToString());
                        p.Nombre = fila.ItemArray[1].ToString();
                        p.Producto = fila.ItemArray[2].ToString();
                        p.Direccion = fila.ItemArray[3].ToString();
                        p.Telefono = Convert.ToInt32(fila.ItemArray[4].ToString());
                        p.Modo_Pago = fila.ItemArray[5].ToString();
                      

                        lstresultados.Add(p);
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

        public List<Mensajero> Consultar_Mensajeros(SQLParametros P_Peticion)
        {
            List<Mensajero> lstresultados = new List<Mensajero>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultapedido = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultapedido.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Mensajero m = new Mensajero();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        m.Identificacion = fila.ItemArray[0].ToString();
                        m.Nombre = fila.ItemArray[1].ToString();
                        m.Placa = fila.ItemArray[2].ToString();
                        m.Telefono = Convert.ToInt32(fila.ItemArray[3].ToString());
                       

                        lstresultados.Add(m);
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

        public List<EstadoPedido> Consultar_Estado(SQLParametros P_Peticion)
        {
            List<EstadoPedido> lstresultados = new List<EstadoPedido>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultapedido = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultapedido.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        EstadoPedido e = new EstadoPedido();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        e.Identificacion = Convert.ToInt32(fila.ItemArray[0].ToString());
                        e.Estado = fila.ItemArray[1].ToString();
                       


                        lstresultados.Add(e);
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
