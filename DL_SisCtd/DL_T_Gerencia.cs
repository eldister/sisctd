using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Gerencia
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdGerencia, a.Descripcion, ";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Gerencia a ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sDescripcion + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	IdGerencia as Codigo, Descripcion ";
            sSql += "from 	T_Gerencia ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Gerencia Get_Gerencia(string sIdGerencia)
        {
            sSql = "select  * from T_Gerencia ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdGerencia = '" + sIdGerencia + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public string Get_Descripcion(string sIdGerencia)
        {
            BE_T_Gerencia oBE_T_Gerencia = Get_Gerencia(sIdGerencia);
            if (oBE_T_Gerencia == null)
                return "";
            else
                return oBE_T_Gerencia.Descripcion;
        }

        public Boolean Existe(string sIdGerencia)
        {
            return (Get_Gerencia(sIdGerencia) != null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Gerencia Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Gerencia oBE_T_Gerencia = new BE_T_Gerencia();
            oBE_T_Gerencia.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Gerencia.IdGerencia = dt.Rows[0]["IdGerencia"].ToString().Trim();
            oBE_T_Gerencia.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Gerencia.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Gerencia.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Gerencia.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Gerencia.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Gerencia;
        }
        public void Insertar(BE_T_Gerencia oBE_T_Gerencia)
        {
            sSql = "insert into T_Gerencia values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Gerencia.IdGerencia + "',";
            sSql += "'" + oBE_T_Gerencia.Descripcion + "', ";
            sSql += "'" + (oBE_T_Gerencia.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Gerencia oBE_T_Gerencia)
        {
            sSql = "update  T_Gerencia set ";
            sSql += "       Descripcion='" + oBE_T_Gerencia.Descripcion + "', ";
            sSql += "       Estado='" + (oBE_T_Gerencia.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdGerencia='" + oBE_T_Gerencia.IdGerencia + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdGerencia)
        {
            sSql = "delete  from T_Gerencia ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdGerencia = '" + sIdGerencia + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}