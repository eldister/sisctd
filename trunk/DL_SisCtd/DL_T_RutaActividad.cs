using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_RutaActividad
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sIdRuta)
        {
            sSql = "select 	a.Orden, a.IdActividad, ";
            sSql += "       b.Descripcion as Actividad, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_RutaActividad a ";
            sSql += "       inner join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdRuta = '" + sIdRuta + "' ";
            sSql += "order by a.orden,a.IdActividad ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_Actividad(string sIdRuta)
        {
            sSql = "select 	a.Orden, a.IdActividad, ";
            sSql += "       b.Descripcion as Actividad, DuracionEnDias ";
            sSql += "from 	T_RutaActividad a ";
            sSql += "       inner join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdRuta = '" + sIdRuta + "' ";
            sSql += "order by a.orden,a.IdActividad ";
            return ConexionDAO.fDatatable(sSql);
        }

        ////public DataTable Buscar()
        ////{
        ////    sSql = "select 	T_Ruta as Codigo, Nombre ";
        ////    sSql += "from 	T_RutaActividad ";
        ////    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
        ////    sSql += "where  Estado=1 ";
        ////    sSql += "order by Nombre";
        ////    return ConexionDAO.fDatatable(sSql);
        ////}

        #endregion

        #region Obtener Valores
        public BE_T_RutaActividad Get_RutaActividad(string sIdRuta, string sIdActividad)
        {
            sSql = "select  * from T_RutaActividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdRuta = '" + sIdRuta + "' and IdActividad = '" + sIdActividad + "'  ";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdRuta, string sIdActividad)
        {
            return (Get_RutaActividad(sIdRuta, sIdActividad)!= null ? true : false);
        }
        #endregion

        public Boolean Existe_Actividad(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            sSql = "select  count(*) from T_RutaActividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdRuta = '" + oBE_T_RutaActividad.IdRuta + "' and ";
            sSql += "       IdActividad = '" + oBE_T_RutaActividad.IdActividad  + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }


        #region Operaciones
        protected virtual BE_T_RutaActividad Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
            oBE_T_RutaActividad.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_RutaActividad.IdRuta = dt.Rows[0]["IdRuta"].ToString().Trim();
            oBE_T_RutaActividad.IdActividad = dt.Rows[0]["IdActividad"].ToString().Trim();
            oBE_T_RutaActividad.Orden = (int)dt.Rows[0]["Orden"];
            oBE_T_RutaActividad.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_RutaActividad.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_RutaActividad.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_RutaActividad;
        }
        public void Insertar(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            sSql = "insert into T_RutaActividad values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_RutaActividad.IdRuta + "',";
            sSql += "'" + oBE_T_RutaActividad.IdActividad + "',";
            sSql += "'" + oBE_T_RutaActividad.Orden + "',";
            sSql += "'" + oBE_T_RutaActividad.DuracionenDia + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            sSql = "delete  from T_RutaActividad ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdRuta='" + oBE_T_RutaActividad.IdRuta + "'  and IdActividad='" + oBE_T_RutaActividad.IdActividad + "' ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}