using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_MaestroCliente
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            sSql = "select  a.IdMaestroCliente, a.TipoPersona, ";
            sSql += "       a.TipoDoi,a.NumeroDoi,rtrim(a.RazonSocial) as RazonSocial,rtrim(a.Direccion) as Direccion, a.Telefono1,  ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from   T_MaestroCliente a ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.RazonSocial like '%" + sDescripcion + "%' ";
            sSql += "order by a.RazonSocial ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	IdMaestroCliente as codigo, RazonSocial as Descripcion ";
            sSql += "from 	T_MaestroCliente ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_MaestroCliente Get_MaestroCliente(string sIdMaestroCliente)
        {
            sSql = "select  * from T_MaestroCliente ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdMaestroCliente = '" + sIdMaestroCliente + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public string Get_RazonSocial(string sIdMaestroCliente)
        {
            BE_T_MaestroCliente oBE_T_MaestroCliente = Get_MaestroCliente(sIdMaestroCliente);
            if (oBE_T_MaestroCliente == null)
                return "";
            else
                return oBE_T_MaestroCliente.RazonSocial;
        }
        public Boolean Existe(string sIdRuta)
        {
            return (Get_MaestroCliente(sIdRuta)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_MaestroCliente Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_MaestroCliente oBE_T_MaestroCliente = new BE_T_MaestroCliente();
            oBE_T_MaestroCliente.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_MaestroCliente.IdMaestroCliente = dt.Rows[0]["IdMaestroCliente"].ToString().Trim();
            oBE_T_MaestroCliente.RazonSocial = dt.Rows[0]["RazonSocial"].ToString().Trim();
            oBE_T_MaestroCliente.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_MaestroCliente.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_MaestroCliente.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_MaestroCliente;
        }
        public void Insertar(BE_T_MaestroCliente oBE_T_MaestroCliente)
        {
            //sSql = "insert into T_MaestroCliente values ";
            //sSql += "(";
            //sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            //sSql += "'" + oBE_T_MaestroCliente.IdRuta + "',";
            //sSql += "'" + oBE_T_MaestroCliente.Descripcion + "', ";
            //sSql += "'" + (oBE_T_MaestroCliente.Estado ? "1" : "0") + "',";
            //sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            //ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_MaestroCliente oBE_T_MaestroCliente)
        {
            //sSql = "update  T_MaestroCliente set ";
            //sSql += "       Descripcion='" + oBE_T_MaestroCliente.Descripcion + "', ";
            //sSql += "       Estado='" + (oBE_T_MaestroCliente.Estado ? "1" : "0") + "' ";
            //sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdPosicion='" + oBE_T_MaestroCliente.IdRuta + "' ";
            //ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdRuta)
        {
            //sSql = "delete  from T_MaestroCliente ";
            //sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdRuta = '" + sIdRuta + "'  ";
            //ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}