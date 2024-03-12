using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_CategoriaP
    {
        public int C_IdCategoria { get; set; }
        public string C_StrDescripcion { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaCategoria()
        {
            string sentencia;
            try
            {
                sentencia = "Select * from TBLCATEGORIA_PROD";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable Consulta_Categoria(int IdCategoria)
        {
            string sentencia = "";
            try
            {
                sentencia = $"Select * from TBLCATEGORIA_PROD where IdCategoria={IdCategoria}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Filtrar_Categoria(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"Select * from TBLCATEGORIA_PROD where StrDescripcion like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string EliminaCategoria()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_CategoriaProducto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado de empleado" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarCategoria()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));


                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_CategoriaProducto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion" + ex.Message;
            }
            return mensaje;
        }
    }
}
