using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable Consulta_Empleado(int IdEmpleado)
        {
            string sentencia = "";
            try
            {
                sentencia = $"Select * from TBLEMPLEADO where IdEmpleado={IdEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Filtrar_Empleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLEMPLEADO where strNombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ConsultarRol()
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLROLES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string EliminaEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                mensaje = Acceso_Datos.Ejecutar_procedimiento("eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado de empleado" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@strNombre", C_strNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_strDatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion" + ex.Message;
            }
            return mensaje;
        }
    } 
}
