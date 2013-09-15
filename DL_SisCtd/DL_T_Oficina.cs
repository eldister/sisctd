using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Oficina
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sNombre, string sEstado)
        {
            sSql = "select 	a.IdOficina, a.Descripcion, ";
            sSql += "       b.Descripcion as [Ubicacion Geografica], ";
            sSql += "       a.Direccion, ";
            sSql += "       case when a.Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Oficina a ";
            sSql += "       left join v_Ubigeo b on a.Idubigeo=b.Idubigeo ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Descripcion like '%" + sNombre + "%'";
            if (sEstado == "A") sSql += "and a.Estado=1 ";
            if (sEstado == "I") sSql += "and a.Estado=0 ";
            sSql += "order by a.Descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select 	T_Oficina as Codigo, Descripcion ";
            sSql += "from 	T_Oficina ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "where  Estado=1 ";
            sSql += "order by Nombre";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Oficina Get_Oficina(string sIdOficina)
        {
            sSql = "select  * from T_Oficina ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficina = '" + sIdOficina + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdOficina)
        {
            return (Get_Oficina(sIdOficina)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Oficina Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Oficina oBE_T_Oficina = new BE_T_Oficina();
            oBE_T_Oficina.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Oficina.Idoficina = dt.Rows[0]["Idoficina"].ToString().Trim();
            oBE_T_Oficina.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_T_Oficina.Idubigeo = dt.Rows[0]["Idubigeo"].ToString().Trim();
            oBE_T_Oficina.Direccion = dt.Rows[0]["Direccion"].ToString().Trim();
            oBE_T_Oficina.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Oficina.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Oficina.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Oficina.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Oficina;
        }
        public void Insertar(BE_T_Oficina oBE_T_Oficina)
        {
            sSql = "insert into T_Oficina values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Oficina.Idoficina + "',";
            sSql += "'" + oBE_T_Oficina.Descripcion + "', ";
            sSql += "'" + oBE_T_Oficina.Idubigeo + "', ";
            sSql += "'" + oBE_T_Oficina.Direccion + "', ";
            sSql += "'" + (oBE_T_Oficina.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Oficina oBE_T_Oficina)
        {
            sSql = "update  T_Oficina set ";
            sSql += "       Descripcion='" + oBE_T_Oficina.Descripcion + "', ";
            sSql += "       Idubigeo='" + oBE_T_Oficina.Idubigeo + "', ";
            sSql += "       Direccion='" + oBE_T_Oficina.Direccion + "', ";
            sSql += "       Estado='" + (oBE_T_Oficina.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficina='" + oBE_T_Oficina.Idoficina + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdOficina)
        {
            sSql = "delete  from T_Oficina ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficina = '" + sIdOficina + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}