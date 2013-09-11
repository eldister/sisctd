using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Ruta
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdRuta, a.Descripcion, ";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Ruta a ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sDescripcion + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	IdRuta as Codigo, Descripcion ";
            sSql += "from 	T_Ruta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "where  Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Ruta Get_Ruta(string sIdRuta)
        {
            sSql = "select  * from T_Ruta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdRuta = '" + sIdRuta + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdRuta)
        {
            return (Get_Ruta(sIdRuta)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Ruta Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Ruta oBE_T_Ruta = new BE_T_Ruta();
            oBE_T_Ruta.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Ruta.IdRuta = dt.Rows[0]["IdRuta"].ToString().Trim();
            oBE_T_Ruta.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Ruta.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Ruta.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Ruta.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Ruta.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Ruta;
        }
        public void Insertar(BE_T_Ruta oBE_T_Ruta)
        {
            sSql = "insert into T_Ruta values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Ruta.IdRuta + "',";
            sSql += "'" + oBE_T_Ruta.Descripcion + "', ";
            sSql += "'" + (oBE_T_Ruta.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Ruta oBE_T_Ruta)
        {
            sSql = "update  T_Ruta set ";
            sSql += "       Descripcion='" + oBE_T_Ruta.Descripcion + "', ";
            sSql += "       Estado='" + (oBE_T_Ruta.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdPosicion='" + oBE_T_Ruta.IdRuta + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdRuta)
        {
            sSql = "delete  from T_Ruta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdRuta = '" + sIdRuta + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}