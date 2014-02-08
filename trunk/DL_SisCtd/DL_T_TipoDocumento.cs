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
            //sSql += "       case when Verificable=1 then 'Si' else '' end as Verif, ";
            //sSql += "       case when Critico=1 then 'Si' else '' end as Critico, ";
            //sSql += "       case when Digitalizable=1 then 'Si' else '' end as Digital, ";
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

        public DataTable Listar_Rutas(string sIdTipoDocumento)
        {
            sSql = "select 	a.IdRuta,b.Descripcion, ";
            sSql += "       case when b.Estado = 1 then '' else 'I' end as Estado ";
            sSql += "from	T_TipoDocumentoRuta a ";
            sSql += "       left join T_Ruta b on a.IdCliente=b.IdCliente and a.IdRuta=b.IdRuta ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdTipoDocumento = '" + sIdTipoDocumento + "'";
            sSql += "order by b.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_RutaActividad(string sIdRuta)
        {
            sSql = "select 	a.Orden, a.IdActividad, ";
            sSql += "       b.Descripcion as Actividad, DuracionEnDias as Duracion, left(c.Descripcion,30) as Oficina, left(d.Descripcion,30) as Area ";
            sSql += "from 	T_RutaActividad a ";
            sSql += "       inner join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "       left join T_Oficina c on a.IdCliente=c.IdCliente and a.IdOficina=c.IdOficina ";
            sSql += "       left join T_Area d on a.IdCliente=d.IdCliente and a.IdArea=d.IdArea ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdRuta = '" + sIdRuta + "' ";
            sSql += "order by a.orden,a.IdActividad ";
            return ConexionDAO.fDatatable(sSql);

            //sSql = "select 	a.Orden,a.IdActividad,b.Descripcion, ";
            //sSql += "       case when b.Estado = 1 then '' else 'I' end as Estado ";
            //sSql += "from	T_RutaActividad a ";
            //sSql += "       left join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            //sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            //sSql += "       a.IdRuta = '" + sIdRuta + "'";
            //sSql += "order by a.orden ";
            //return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	IdTipoDocumento as Codigo, Descripcion ";
            sSql += "from 	T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       Estado=1 ";
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
        public string Get_Descripcion(string sIdTipoDocumento)
        {
            BE_T_TipoDocumento oBE_T_TipoDocumento = Get_TipoDocumento(sIdTipoDocumento);
            if (oBE_T_TipoDocumento == null)
                return "";
            else
                return oBE_T_TipoDocumento.Descripcion;
        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return (Get_TipoDocumento(sIdTipoDocumento)!= null ? true : false);
        }

        public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "select  count(*) from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
            sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
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
            oBE_T_TipoDocumento.DescripcionLarga = dt.Rows[0]["DescripcionLarga"].ToString().Trim();
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
            sSql += "       DescripcionLarga='" + oBE_T_TipoDocumento.DescripcionLarga + "', ";
            sSql += "       Estado='" + (oBE_T_TipoDocumento.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + oBE_T_TipoDocumento.IdTipoDocumento + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdTipoDocumento)
        {
            sSql = "delete  from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'  ";
            ConexionDAO.fExecute(sSql);
            sSql = "delete  from T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        public void AgregarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "insert into T_TipoDocumentoRuta values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "',";
            sSql += "'" + oBE_T_TipoDocumentoRuta.IdRuta + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }

        public void QuitarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "delete from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
            sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' "; 
            ConexionDAO.fExecute(sSql);
        }
        #endregion

    }
}