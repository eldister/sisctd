using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_Reg_Control
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sNroDocumento, string sRazonSocial,string sEstado)
        {
            if (sEstado == "Total") sEstado = "";
            return ConexionDAO.fDatatable("List_Reg_Control", sNroDocumento, sRazonSocial, sEstado);
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
            sSql = "select 	a.Orden,a.IdActividad,b.Descripcion, ";
            sSql += "       case when b.Estado = 1 then '' else 'I' end as Estado ";
            sSql += "from	T_RutaActividad a ";
            sSql += "       left join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.IdRuta = '" + sIdRuta + "'";
            sSql += "order by a.orden ";
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
        public BE_Reg_Control Get_Control(string sIdControl)
        {
            sSql = "select  * from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdControl + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return (Get_Control(sIdTipoDocumento)!= null ? true : false);
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
        protected virtual BE_Reg_Control Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();
            oBE_Reg_Control.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_Reg_Control.IdControl = (Int32)dt.Rows[0]["IdControl"];
            oBE_Reg_Control.IdTipoDocumento = dt.Rows[0]["IdTipoDocumento"].ToString().Trim();
            oBE_Reg_Control.IdMaestroCliente = dt.Rows[0]["IdMaestroCliente"].ToString().Trim();
            oBE_Reg_Control.NroDocumento = dt.Rows[0]["NroDocumento"].ToString().Trim();
            oBE_Reg_Control.FechaDocumento = (DateTime)dt.Rows[0]["FechaDocumento"];
            oBE_Reg_Control.CodigoBarra = dt.Rows[0]["CodigoBarra"].ToString().Trim();
            oBE_Reg_Control.Observacion = dt.Rows[0]["Observacion"].ToString().Trim();
            oBE_Reg_Control.FechaInicio = (DateTime)dt.Rows[0]["FechaInicio"];
            oBE_Reg_Control.FechaTermino = (DateTime)dt.Rows[0]["FechaTermino"];
            oBE_Reg_Control.Estado = dt.Rows[0]["Estado"].ToString().Trim();
            oBE_Reg_Control.IdRuta = dt.Rows[0]["IdRuta"].ToString().Trim();
            oBE_Reg_Control.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_Reg_Control.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_Reg_Control.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_Reg_Control;
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