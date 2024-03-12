using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Facturas
    {
        public int C_IdFactura { get; set; }
        public string C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public float C_NumDescuento { get; set; }
        public float C_NumImpuesto { get; set; }
        public float C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaFactura()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLFACTURA";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable Consulta_Factura(int IdFactura)
        {
            string sentencia = "";
            try
            {
                sentencia = $"Select * from TBLFACTURA where IdFactura={IdFactura}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Filtrar_Factura(int filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLFACTURA where IdFactura ={filtro}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ConsultaCliente()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLCLIENTES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
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
        public DataTable ConsultaEstado()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLESTADO_FACTURA";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string EliminaFactura()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdFactura", C_IdFactura));
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Factura", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado de la factura" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarFactura()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdFactura", C_IdFactura));
                lst.Add(new Cls_parametros("@DtmFecha", C_DtmFecha));
                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@NumDescuento", C_NumDescuento));
                lst.Add(new Cls_parametros("@NumImpuesto", C_NumImpuesto));
                lst.Add(new Cls_parametros("@NumValorTotal", C_NumValorTotal));
                lst.Add(new Cls_parametros("@IdEstado", C_IdEstado));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));


                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Factura", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion" + ex.Message;
            }
            return mensaje;
        }
    }
}
