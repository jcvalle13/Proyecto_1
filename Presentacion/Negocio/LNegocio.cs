using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class LNegocio
    {
        #region Usuarios

        public static int AgregarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Usuarioss VALUES ('" + P_Usuario.Usuario + "','" + P_Usuario.Contraseña + "','" + P_Usuario.Estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static int ModificarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Usuarioss SET Contraseña = '" + P_Usuario.Contraseña + "', Estado = '" + P_Usuario.Estado + "' WHERE Usuario = '" + P_Usuario.Usuario + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<Usuarios> Consultar_Usuarios()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarioss";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Usuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool VerificarUsuario(Usuarios P_usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarioss ";
                objpeticion.Peticion += @"WHERE Usuario = '" + P_usuario.Usuario + "' AND ";
                objpeticion.Peticion += @"Contraseña = '" + P_usuario.Contraseña + "' AND ";
                objpeticion.Peticion += @"Estado = '" + P_usuario.Estado + "'";

                Acceso objacceso = new Acceso();
                List<Usuarios> lstresultados = objacceso.Consultar_Usuarios(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Usuarios> Consultar_Permisos_Usuarios(Usuarios P_usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarioss";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Permisos_Usuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //revisar codigo, no elimina, solo sale msj
         public static int EliminarUsuario(Usuarios P_usuario)
         {

             try
             {
                 SQLParametros objpeticion = new SQLParametros();
                 objpeticion.Peticion = @"DELETE FROM Usuarioss WHERE Usuario = '" + P_usuario.Usuario + "'";

                 Acceso objacceso = new Acceso();
                 return objacceso.Ejecutar_Peticiones(objpeticion);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
            #endregion


        #region Perfiles
        public static int AgregarPerfil(Perfiles P_Perfil)
        {


           try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Perfiles VALUES ('" + P_Perfil.cod_perfil + "','" + P_Perfil.descripcion + "','" + P_Perfil.estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            //SE UTILIZA CON PARAMETROS
           /* SQLParametros objpeticion = new SQLParametros();


            //Ajustar peticion para utilización con parametros
            objpeticion.Peticion = @"EXEC PA_AgregarPerfil @codigoperfil, @descripcion, @estado";

            //Crear los parametros
            SqlParameter parametroCodigo = new SqlParameter();
            parametroCodigo.ParameterName = "@codigoperfil";
            parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
            parametroCodigo.Value = P_Perfil.cod_perfil;

            SqlParameter parametroDescripcion = new SqlParameter();
            parametroDescripcion.ParameterName = "@descripcion";
            parametroDescripcion.Size = 50;
            parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroDescripcion.Value = P_Perfil.descripcion;

            SqlParameter parametroEstado = new SqlParameter();
            parametroEstado.ParameterName = "@estado";
            parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
            parametroEstado.Value = P_Perfil.estado;

            //Agrega a la lista de parametros los parametros creados
            objpeticion.LstParametros.Add(parametroCodigo);
            objpeticion.LstParametros.Add(parametroDescripcion);
            objpeticion.LstParametros.Add(parametroEstado);

            Acceso objacceso = new Acceso();
            return objacceso.Ejecutar_Peticiones(objpeticion);*/




        }

        public static int ModificarPerfil(Perfiles P_Perfil)
        {
          try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Perfiles SET descripcion = '" + P_Perfil.cod_perfil + "', estado = '" + P_Perfil.estado + "' WHERE codigoperfil = '" + P_Perfil.cod_perfil + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }




            /* try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ModificarPerfil @codigoperfil, @descripcion, @estado";

                //Crear los parametros
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@codigoperfil";
                parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                parametroCodigo.Value = P_Perfil.cod_perfil;

                SqlParameter parametroDescripcion = new SqlParameter();
                parametroDescripcion.ParameterName = "@descripcion";
                parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDescripcion.Value = P_Perfil.descripcion;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Perfil.estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCodigo);
                objpeticion.LstParametros.Add(parametroDescripcion);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
        }

        public static int EliminarPerfil(Perfiles P_Perfil)
        {

            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"DELETE FROM Perfiles WHERE codigoperfil = '" + P_Perfil.cod_perfil + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            /* try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_EliminarPerfil @codigoperfil";

                //Crear los parametros
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@codigoperfil";
                parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                parametroCodigo.Value = P_Perfil.cod_perfil;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCodigo);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
        }

        public static List<Perfiles> ConsultarPerfiles(Perfiles P_Perfil)
        {
            try
            {
                try
                {
                    SQLParametros objpeticion = new SQLParametros();
                    objpeticion.Peticion = @"EXEC PA_ConsultarPerfiles @codigoperfil";

                    //Crear los parametros
                    SqlParameter parametroCodigo = new SqlParameter();
                    parametroCodigo.ParameterName = "@codigoperfil";
                    parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                    parametroCodigo.Value = P_Perfil.cod_perfil;

                    //Agrega a la lista de parametros los parametros creados
                    objpeticion.LstParametros.Add(parametroCodigo);

                    Acceso objacceso = new Acceso();
                    return objacceso.Consultar_Perfiles(objpeticion);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Clientes Pedidos

        public static int AgregarPedidos(ClientesPedidos P_Pedidos)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Pedidos VALUES ('" + P_Pedidos.Identificacion + "','" + P_Pedidos.Nombre + "','" + P_Pedidos.Producto + "','" + P_Pedidos.Direccion + "','" + P_Pedidos.Telefono + "','" + P_Pedidos.Modo_Pago  + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ModificarPedidos(ClientesPedidos m_Pedidos)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Pedidos SET Nombre = '" + m_Pedidos.Nombre + "', Producto = '" + m_Pedidos.Producto + "', Direccion = '" + m_Pedidos.Direccion + "', Telefono = '" + m_Pedidos.Telefono + "', Modo_Pago = '" + m_Pedidos.Modo_Pago + "' WHERE Identificacion = '" + m_Pedidos.Identificacion + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public static List<ClientesPedidos> Consultar_Pedidos()
        {

            /*try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ConsultaPedidos @Identificacion";

                //Crear los parametros
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@Identificacion";
                parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                parametroCodigo.Value = C_Pedidos.Identificacion;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCodigo);

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Pedidos(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/



             try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Nombre, Producto, Direccion, Telefono, Modo_Pago, Estado FROM Pedidos";

                Acceso objacceso = new Acceso();
               
                return objacceso.Consultar_Pedidos(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool VerificarPedidos(ClientesPedidos P_Pedidos)
        {
              try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Nombre, Producto, Direccion, Modo_Pago FROM Pedidos ";
                objpeticion.Peticion += @"WHERE Identificacion = '" + P_Pedidos.Identificacion + "' AND ";
                objpeticion.Peticion += @"Nombre = '" + P_Pedidos.Nombre + "' AND ";
                objpeticion.Peticion += @"Producto = '" + P_Pedidos.Producto + "'";
                objpeticion.Peticion += @"Direccion = '" + P_Pedidos.Direccion + "'";
                objpeticion.Peticion += @"Telefono = '" + P_Pedidos.Telefono + "'";
                objpeticion.Peticion += @"Modo_Pago = '" + P_Pedidos.Modo_Pago + "'";
               // objpeticion.Peticion += @"Estado = '" + P_Pedidos.Estado + "'";

                Acceso objacceso = new Acceso();
                List<ClientesPedidos> lstresultados = objacceso.Consultar_Pedidos(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Mensajeros

        public static int AgregarMensajero(Mensajero m_Mensajero)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Mensajero VALUES ('" + m_Mensajero.Identificacion + "','" + m_Mensajero.Nombre + "','" + m_Mensajero.Placa + "','" + m_Mensajero.Telefono + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ModificarMensajero(Mensajero m_Mensajero)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE mensajero SET Nombre = '" + m_Mensajero.Nombre + "', Placa = '" + m_Mensajero.Placa + "', Telefono = '" + m_Mensajero.Telefono + "' WHERE Identificacion = '" + m_Mensajero.Identificacion + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Mensajero> Consultar_Mensajeros()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Nombre, Placa, Telefono FROM Mensajero";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Mensajeros(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool VerificarMensajero(Mensajero m_Mensajero)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Nombre, Placa, Telefono FROM Mensajero ";
                objpeticion.Peticion += @"WHERE Identificacion = '" + m_Mensajero.Identificacion + "' AND ";
                objpeticion.Peticion += @"Nombre = '" + m_Mensajero.Nombre + "' AND ";
                objpeticion.Peticion += @"Placa = '" + m_Mensajero.Placa + "'";
                objpeticion.Peticion += @"Telefono = '" + m_Mensajero.Telefono + "'";
                

                Acceso objacceso = new Acceso();
                List<Mensajero> lstresultados = objacceso.Consultar_Mensajeros(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Estado

        public static int AgregarEstado(EstadoPedido e_Estado)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Estado VALUES ('" + e_Estado.Identificacion + "','" + e_Estado.Estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ModificarEstado(EstadoPedido e_Estado)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Estado SET Estado = '" + e_Estado.Estado + "' WHERE Identificacion = '" + e_Estado.Identificacion + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EstadoPedido> Consultar_Estado()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Estado FROM Estado";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Estado(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool VerificarEstado(EstadoPedido e_Estado)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Identificacion, Estado FROM Estado ";
                objpeticion.Peticion += @"WHERE Identificacion = '" + e_Estado.Identificacion + "' AND ";
                objpeticion.Peticion += @"Estado = '" + e_Estado.Estado + "'";
               


                Acceso objacceso = new Acceso();
                List<EstadoPedido> lstresultados = objacceso.Consultar_Estado(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
