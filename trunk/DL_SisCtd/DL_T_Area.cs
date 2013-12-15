using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Area
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sNombre, string sEstado)
        {
            sSql = "select 	a.IdArea, a.Descripcion, ";
            sSql += "       b.Descripcion as Gerencia, ";
            sSql += "       case when a.Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Area a ";
            sSql += "       inner join T_Gerencia b on a.IdCliente=b.IdCliente and a.IdGerencia=b.IdGerencia ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sNombre + "%'";
            if (sEstado == "A") sSql += "and a.Estado=1 ";
            if (sEstado == "I") sSql += "and a.Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select  IdArea as Codigo, Descripcion ";
            sSql += "from  T_Area ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Area Get_Area(string sIdArea)
        {
            sSql = "select  * from T_Area ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea = '" + sIdArea + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public string Get_Descripcion(string sIdArea)
        {
            BE_T_Area oBE_T_Area = Get_Area(sIdArea);
            if (oBE_T_Area == null)
                return "";
            else
                return oBE_T_Area.Descripcion;
        }
        public string Get_IdEmpleadoResponsable(string sIdArea)
        {
            BE_T_Area oBE_T_Area = Get_Area(sIdArea);
            if (oBE_T_Area == null)
                return "";
            else
                return oBE_T_Area.IdEmpleadoResponsable;
        }
        public Boolean Existe(string sIdArea)
        {
            return (Get_Area(sIdArea)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Area Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Area oBE_T_Area = new BE_T_Area();
            oBE_T_Area.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Area.IdArea = dt.Rows[0]["IdArea"].ToString().Trim();
            oBE_T_Area.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Area.IdGerencia = dt.Rows[0]["IdGerencia"].ToString().Trim();
            oBE_T_Area.IdEmpleadoResponsable = dt.Rows[0]["IdEmpleadoResponsable"].ToString().Trim();
            oBE_T_Area.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Area.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Area.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Area.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Area;
        }
        public void Insertar(BE_T_Area oBE_T_Area)
        {
            sSql = "insert into T_Area values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Area.IdArea + "',";
            sSql += "'" + oBE_T_Area.IdGerencia + "', ";
            sSql += "'" + oBE_T_Area.Descripcion + "', ";
            sSql += "'" + (oBE_T_Area.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Area oBE_T_Area)
        {
            sSql = "update  T_Area set ";
            sSql += "       Descripcion='" + oBE_T_Area.Descripcion + "', ";
            sSql += "       IdGerencia='" + oBE_T_Area.IdGerencia + "', ";
            sSql += "       Estado='" + (oBE_T_Area.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + oBE_T_Area.IdArea + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdArea)
        {
            sSql = "delete  from T_Area ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea = '" + sIdArea + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}