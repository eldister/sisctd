using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_TipoDocumento
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdTipoDocumento, a.Descripcion, ";
            sSql += "       a.DescripcionLarga as [Descripcion Larga], ";
            sSql += "       case when Verificable=1 then 'Si' else '' end as Verif, ";
            sSql += "       case when Critico=1 then 'Si' else '' end as Critico, ";
            sSql += "       case when Digitalizable=1 then 'Si' else '' end as Digital, ";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_TipoDocumento a ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sDescripcion + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	T_TipoDocumento as Codigo, Descripcion ";
            sSql += "from 	T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "where  Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_TipoDocumento Get_TipoDocumento(string sIdTipoDocumento)
        {
            sSql = "select  * from T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return (Get_TipoDocumento(sIdTipoDocumento)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_TipoDocumento Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_TipoDocumento oBE_T_TipoDocumento = new BE_T_TipoDocumento();
            oBE_T_TipoDocumento.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_TipoDocumento.IdTipoDocumento = dt.Rows[0]["IdTipoDocumento"].ToString().Trim();
            oBE_T_TipoDocumento.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_TipoDocumento.DescripcionLarga = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_TipoDocumento.Verificable = (Boolean)dt.Rows[0]["Verificable"];
            oBE_T_TipoDocumento.Critico = (Boolean)dt.Rows[0]["Critico"];
            oBE_T_TipoDocumento.Digitalizable = (Boolean)dt.Rows[0]["Digitalizable"];
            oBE_T_TipoDocumento.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_TipoDocumento.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_TipoDocumento.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_TipoDocumento.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_TipoDocumento;
        }
        public void Insertar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            sSql = "insert into T_TipoDocumento values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_TipoDocumento.IdTipoDocumento + "',";
            sSql += "'" + oBE_T_TipoDocumento.Descripcion + "', ";
            sSql += "'" + oBE_T_TipoDocumento.DescripcionLarga + "', ";
            sSql += "'" + (oBE_T_TipoDocumento.Verificable ? "1" : "0") + "',";
            sSql += "'" + (oBE_T_TipoDocumento.Critico ? "1" : "0") + "',";
            sSql += "'" + (oBE_T_TipoDocumento.Digitalizable ? "1" : "0") + "',";
            sSql += "'" + (oBE_T_TipoDocumento.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            sSql = "update  T_TipoDocumento set ";
            sSql += "       Descripcion='" + oBE_T_TipoDocumento.Descripcion + "', ";
            sSql += "       Estado='" + (oBE_T_TipoDocumento.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + oBE_T_TipoDocumento.IdTipoDocumento + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdTipoDocumento)
        {
            sSql = "delete  from T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}