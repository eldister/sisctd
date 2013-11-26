using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_EmpleadoActividad
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdEmpleado, b.Nombre, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_EmpleadoActividad a ";
            sSql += "       left  join T_Empleado b on a.IdEmpleado = b.IdEmpleado ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       b.Nombre like '%" + sDescripcion + "%'";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }

        public DataTable Listar_Empleado(string sIdActividad)
        {
            sSql = "select 	a.IdEmpleado, b.Nombre ";
            sSql += "from 	T_EmpleadoActividad a ";
            sSql += "       left  join T_Empleado b on a.IdEmpleado = b.IdEmpleado ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdActividad = '" + sIdActividad + "' ";
            sSql += "order by b.Nombre ";
            return ConexionDAO.fDatatable(sSql);
        }


        #endregion

        #region Obtener Valores
        //public BE_T_EmpleadoActividad Get_EmpleadoActividad(string sIdActividad, string sIdEmpleado)
        //{
        //    sSql = "select  * from T_Actividad ";
        //    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdActividad = '" + sIdActividad + "'  and IdEmpleado = '" + sIdEmpleado + "'";

        //    return Make(ConexionDAO.fDatatable(sSql));

        //}
        //public string Get_Descripcion(string sIdActividad)
        //{
        //    BE_T_Actividad oBE_T_Actividad = Get_Actividad(sIdActividad);
        //    if (oBE_T_Actividad == null)
        //        return "";
        //    else
        //        return oBE_T_Actividad.Descripcion;
        //}

        //public Boolean Existe(string sIdActividad)
        //{
        //    return (Get_Actividad(sIdActividad) != null ? true : false);
        //}
        public Boolean Existe_EmpleadoActividad(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            sSql = "select  count(*) from T_EmpleadoActividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdActividad = '" + oBE_T_EmpleadoActividad.IdActividad + "' and ";
            sSql += "       IdEmpleado = '" + oBE_T_EmpleadoActividad.IdEmpleado + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }

        #endregion

        #region Operaciones
        protected virtual BE_T_EmpleadoActividad Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_EmpleadoActividad oBE_T_EmpleadoActividad = new BE_T_EmpleadoActividad();
            oBE_T_EmpleadoActividad.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_EmpleadoActividad.IdActividad = dt.Rows[0]["IdActividad"].ToString().Trim();
            oBE_T_EmpleadoActividad.IdEmpleado = dt.Rows[0]["IdEmpleado"].ToString().Trim();
            oBE_T_EmpleadoActividad.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_EmpleadoActividad.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_EmpleadoActividad.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_EmpleadoActividad;
        }
        public void Insertar(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            sSql = "insert into T_EmpleadoActividad values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_EmpleadoActividad.IdActividad + "',";
            sSql += "'" + oBE_T_EmpleadoActividad.IdEmpleado + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            sSql = "delete  from T_EmpleadoActividad ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdActividad='" + oBE_T_EmpleadoActividad.IdActividad + "' and IdEmpleado='" + oBE_T_EmpleadoActividad.IdEmpleado + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}