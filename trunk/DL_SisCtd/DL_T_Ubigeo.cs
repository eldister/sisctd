using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Ubigeo
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select 	a.IdUbigeo, a.Descripcion, ";
            sSql += "from 	Sis_Ubigeo a ";
            sSql += "where a.Descripcion like '%" + sDescripcion + "%' ";
            sSql += " order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	Idubigeo as Codigo, Descripcion ";
            sSql += "from 	Sis_Ubigeo ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Ubigeo Get_Ubigeo(string sIdUbigeo)
        {
            sSql = "select a.*,b.descripcion as DesUbigeo from Sis_Ubigeo a ";
            sSql += " left join v_Ubigeo b on a.Idubigeo=b.Idubigeo ";
            sSql += "where  a.  IdUbigeo = '" + sIdUbigeo + "' ";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public BE_T_Ubigeo Get_DesUbigeoo(string sIdUbigeo)
        {
            sSql = "select * from v_ubigeo ";
            sSql += "where  IdUbigeo = '" + sIdUbigeo + "' ";

            return Make(ConexionDAO.fDatatable(sSql));

        }

        public string Get_DesUbigeo(string sIdUbigeo)
        {
            BE_T_Ubigeo oBE_T_Ubigeo = Get_DesUbigeoo(sIdUbigeo);
            if (oBE_T_Ubigeo == null)
                return "";
            else
                return oBE_T_Ubigeo.Descripcion;
        }


        public Boolean Existe(string sIdUbigeo)
        {
            return (Get_Ubigeo(sIdUbigeo) != null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Ubigeo Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Ubigeo oBE_T_Ubigeo = new BE_T_Ubigeo();
            oBE_T_Ubigeo.IdUbigeo = dt.Rows[0]["IdUbigeo"].ToString().Trim();
            oBE_T_Ubigeo.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            return oBE_T_Ubigeo;
        }
        public void Insertar(BE_T_Ubigeo oBE_T_Ubigeo)
        {
            sSql = "insert into Sis_Ubigeo values ";
            sSql += "(";
            sSql += "'" + oBE_T_Ubigeo.IdUbigeo + "',";
            sSql += "'" + oBE_T_Ubigeo.Descripcion + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Ubigeo oBE_T_Ubigeo)
        {
            sSql = "update  Sis_Ubigeo set ";
            sSql += "       Descripcion='" + oBE_T_Ubigeo.Descripcion + "' ";
            sSql += "where   IdUbigeo='" + oBE_T_Ubigeo.IdUbigeo + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdUbigeo)
        {
            sSql = "delete  from Sis_Ubigeo ";
            sSql += "where   IdUbigeo = '" + sIdUbigeo + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion

              
    }
}