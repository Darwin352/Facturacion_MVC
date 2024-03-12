using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccionparametro { get; set; }

        public Cls_parametros(string Objnombre, Object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            Direccionparametro = ParameterDirection.Input;
        }
        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccionparametro = ParameterDirection.Output;
        }

    }



    public class Cls_Acceso_Datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public String AbrirBd() // método para abrir la base de datos
        {
            string resultado = "";
            try // permite captura de un error en caso que se presente
            {

                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de 
                conexion = new SqlConnection($"Data Source=.;Initial Catalog=DBFACTURAS;Integrated Security=True");
                conexion.Open(); // invocamos método para abrir la base de datos
                //MessageBox.Show("conexion exitosa");
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                resultado = "ERROR: No se establecion la conexion con la base de datos" + ex;
            }
            return resultado;
        }
        public string CerrarrBd() // método para cerrar conexion a la base de datos
        {
            string resultado = "";
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para abrir la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                resultado = "ERROR: Fallo al cerra la conexion" + ex;
            }
            return resultado;
        }
        public string Ejecutar_procedimiento(string procedimiento, List<Cls_parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccionparametro == ParameterDirection.Input)
                        {
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccionparametro == ParameterDirection.Output)
                        {
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }
                retornado = comando.ExecuteNonQuery();
                CerrarrBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: fallo la operacion" + ex;
            }
            return salida;
        }
        public string EjecutarComando(string sentencia)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarrBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: fallo la operacion" + ex;
            }
            return salida;
        }
        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarrBd();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
