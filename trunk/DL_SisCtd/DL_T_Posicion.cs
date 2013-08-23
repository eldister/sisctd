using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Posicion
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdPosicion, a.Descripcion, ";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Posicion a ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sDescripcion + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	T_Posicion as Codigo, Descripcion ";
            sSql += "from 	T_Posicion ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "where  Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Posicion Get_Posicion(string sIdPosicion)
        {
            sSql = "select  * from T_Posicion ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdPosicion = '" + sIdPosicion + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdPosicion)
        {
            return (Get_Posicion(sIdPosicion)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Posicion Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Posicion oBE_T_Posicion = new BE_T_Posicion();
            oBE_T_Posicion.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Posicion.IdPosicion = dt.Rows[0]["IdPosicion"].ToString().Trim();
            oBE_T_Posicion.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Posicion.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Posicion.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Posicion.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Posicion.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Posicion;
        }
        public void Insertar(BE_T_Posicion oBE_T_Posicion)
        {
            sSql = "insert into T_Posicion values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Posicion.IdPosicion + "',";
            sSql += "'" + oBE_T_Posicion.Descripcion + "', ";
            sSql += "'" + (oBE_T_Posicion.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Posicion oBE_T_Posicion)
        {
            sSql = "update  T_Posicion set ";
            sSql += "       Descripcion='" + oBE_T_Posicion.Descripcion + "', ";
            sSql += "       Estado='" + (oBE_T_Posicion.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdPosicion='" + oBE_T_Posicion.IdPosicion + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdPosicion)
        {
            sSql = "delete  from T_Posicion ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdPosicion = '" + sIdPosicion + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}