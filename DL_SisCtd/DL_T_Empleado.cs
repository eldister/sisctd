using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
namespace DLSisCtd
{
    public class DL_T_Empleado
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sNombre, string sEstado)
        {
            sSql = "select 	a.IdEmpleado, a.Nombre, ";
            sSql += "       b.Descripcion as Area, ";
            sSql += "       c.Descripcion as Posicion, ";
            sSql += "       case when a.Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	T_Empleado a ";
            sSql += "       inner join T_Area b on a.IdCliente=b.IdCliente and a.IdArea=b.IdArea ";
            sSql += "       inner join T_Posicion c on a.IdCliente=c.IdCliente and a.IdPosicion=c.IdPosicion ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       a.Nombre like '%" + sNombre + "%'";
            if (sEstado == "A") sSql += "and a.Estado=1 ";
            if (sEstado == "I") sSql += "and a.Estado=0 ";
            sSql += "order by a.Nombre ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar()
        {
            sSql = "select IdEmpleado as Codigo, Nombre as Descripcion ";
            sSql += "from  T_Empleado ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "    Estado=1 ";
            sSql += "order by Nombre";
            return ConexionDAO.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_T_Empleado Get_Empleado(string sIdEmpleado)
        {
            sSql = "select  * from T_Empleado ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdEmpleado = '" + sIdEmpleado + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public string Get_Nombre(string sIdEmpleado)
        {
            BE_T_Empleado oBE_T_Empleado = Get_Empleado(sIdEmpleado);
            if (oBE_T_Empleado == null)
                return "";
            else
                return oBE_T_Empleado.Nombre;
        }

        public Boolean Existe(string sIdEmpleado)
        {
            return (Get_Empleado(sIdEmpleado)!= null ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_T_Empleado Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_T_Empleado oBE_T_Empleado = new BE_T_Empleado();
            oBE_T_Empleado.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_T_Empleado.IdEmpleado = dt.Rows[0]["IdEmpleado"].ToString().Trim();
            oBE_T_Empleado.Nombre = dt.Rows[0]["Nombre"].ToString().Trim();
            oBE_T_Empleado.IdArea = dt.Rows[0]["IdArea"].ToString().Trim();
            oBE_T_Empleado.IdPosicion = dt.Rows[0]["IdPosicion"].ToString().Trim();
            oBE_T_Empleado.IdOficina = dt.Rows[0]["IdOficina"].ToString().Trim();
            oBE_T_Empleado.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_T_Empleado.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_T_Empleado.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_T_Empleado.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_T_Empleado;
        }
        public void Insertar(BE_T_Empleado oBE_T_Empleado)
        {
            sSql = "insert into T_Empleado values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_T_Empleado.IdEmpleado + "',";
            sSql += "'" + oBE_T_Empleado.IdArea + "', ";
            sSql += "'" + oBE_T_Empleado.IdPosicion + "', ";
            sSql += "'" + oBE_T_Empleado.IdOficina + "', ";
            sSql += "'" + oBE_T_Empleado.Nombre + "', ";
            sSql += "'" + (oBE_T_Empleado.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_T_Empleado oBE_T_Empleado)
        {
            sSql = "update  T_Empleado set ";
            sSql += "       Nombre='" + oBE_T_Empleado.Nombre + "', ";
            sSql += "       IdArea='" + oBE_T_Empleado.IdArea + "', ";
            sSql += "       IdPosicion='" + oBE_T_Empleado.IdPosicion + "', ";
            sSql += "       IdOficina='" + oBE_T_Empleado.IdOficina + "', ";
            sSql += "       Estado='" + (oBE_T_Empleado.Estado ? "1" : "0") + "' ";
            sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdEmpleado='" + oBE_T_Empleado.IdEmpleado + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdEmpleado)
        {
            sSql = "delete  from T_Empleado ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdEmpleado = '" + sIdEmpleado + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion



       
    }
}