using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public float C_NumPrecioCompra { get; set; }
        public float C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_strFoto { get; set; }
        public int C_NumStock { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaProducto()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLPRODUCTO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable Consulta_Producto(int IdProducto)
        {
            string sentencia = "";
            try
            {
                sentencia = $"Select * from TBLPRODUCTO where IdProducto={IdProducto}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Filtrar_Producto(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLPRODUCTO where StrNombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ConsultarCategoria()
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLCATEGORIA_PROD";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string EliminaProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado de producto" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_parametros("@strFoto", C_strFoto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", StrUsuarioModifica));

                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion" + ex.Message;
            }
            return mensaje;
        }
    }
}
