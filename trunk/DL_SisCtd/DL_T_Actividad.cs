using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Actividad
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdActividad, a.Descripcion, ";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Actividad a ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sDescripcion + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	IdActividad as Codigo, Descripcion ";
            sSql += "from 	T_Actividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Actividad Get_Actividad(string sIdActividad)
        {
            sSql = "select  * from T_Actividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdActividad = '" + sIdActividad + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public string Get_Descripcion(string sIdActividad)
        {
            BE_T_Actividad oBE_T_Actividad = Get_Actividad(sIdActividad);
            if (oBE_T_Actividad == null)
                return "";
            else
                return oBE_T_Actividad.Descripcion;
        }

        public Boolean Existe(string sIdActividad)
        {
            return (Get_Actividad(sIdActividad) != null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Actividad Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Actividad oBE_T_Actividad = new BE_T_Actividad();
            oBE_T_Actividad.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Actividad.IdActividad = dt.Rows[0]["IdActividad"].ToString().Trim();
            oBE_T_Actividad.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Actividad.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Actividad.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Actividad.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Actividad.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Actividad;
        }
        public void Insertar(BE_T_Actividad oBE_T_Actividad)
        {
            sSql = "insert into T_Actividad values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Actividad.IdActividad + "',";
            sSql += "'" + oBE_T_Actividad.Descripcion + "', ";
            sSql += "'" + (oBE_T_Actividad.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Actividad oBE_T_Actividad)
        {
            sSql = "update  T_Actividad set ";
            sSql += "       Descripcion='" + oBE_T_Actividad.Descripcion + "', ";
            sSql += "       Estado='" + (oBE_T_Actividad.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdActividad='" + oBE_T_Actividad.IdActividad + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdActividad)
        {
            sSql = "delete  from T_Actividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdActividad = '" + sIdActividad + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}