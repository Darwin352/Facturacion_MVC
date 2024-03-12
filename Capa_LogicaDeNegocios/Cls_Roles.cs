using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Roles
    {
        public int C_IdRolEmpleado { get; set; }
        public string C_StrDescripcion { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaRol()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLROLES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable Consulta_Rol(int IdRolEmpleado)
        {
            string sentencia = "";
            try
            {
                sentencia = $"Select * from TBLROLES where IdRolEmpleado={IdRolEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Filtrar_Rol(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLROLES where StrDescripcion like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminaRol()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Rol", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado de empleado" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarRol()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));


                mensaje = Acceso_Datos.Ejecutar_procedimiento("Actualizar_Rol", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion" + ex.Message;
            }
            return mensaje;
        }

    }
}
