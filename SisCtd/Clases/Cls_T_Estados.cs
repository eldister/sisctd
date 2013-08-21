using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Estados
    {
        #region Variables
        string sSql = "";
        #endregion

        #region Listado
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	IdEstado as Id,Descripcion as Descripción, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       IdEstado+' - '+Descripcion as des ";
            sSql += "from 	T_Estado ";
            sSql += "where  IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "IdEstado" : "Descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado=1 ";
            if (nEreg == 1) sSql += "and Estado=0 ";
            sSql += "order by " + (sFiltro == "C" ? "IdEstado" : "Descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Derivados(string sIdEstadoRaiz, int nEreg)
        {
            sSql = "select 	IdEstado as Id,Descripcion as Descripción, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       IdEstado+' - '+Descripcion as des ";
            sSql += "from 	T_Estado ";
            sSql += "where  IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' ";
            switch (sIdEstadoRaiz)
            { 
                case "ACT":
                    sSql += " and IdEstado in ('ACT','CES') ";
                    break;
                case "CES":
                    sSql += " and IdEstado in ('CES','REI') ";
                    break;
                case "REI":
                    sSql += " and IdEstado in ('REI','CES') ";
                    break;
            }
            if (nEreg == 0) sSql += "and Estado=1 ";
            if (nEreg == 1) sSql += "and Estado=0 ";
            sSql += "order by IdEstado ";
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdestado)
        {
            return Helper.fDatatable("select * from T_Estado where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEstado='" + sIdestado + "'");
        }
        public Boolean Existe(string sIdestado)
        {
            return Get_Registro(sIdestado).Rows.Count > 0 ? true : false;
        }
        public string Get_Descrip(string sIdestado)
        {
            sSql = "select Descripcion from T_Estado where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEstado='" + sIdestado + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdestado, string sDescrip, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Estado values( '" + Helper.oBE_Sis_Cliente.IdCliente + "', ";
                sSql += "'" + sIdestado + "','" + sDescrip + "','" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update T_Estado set ";
                sSql += "       Descripcion ='" + sDescrip + "', ";
                sSql += "       Estado ='" + (bEreg == true ? "1" : "0") + "' ";
                sSql += "where 	IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEstado='" + sIdestado + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdestado)
        {
            Helper.fEscalar("delete from T_Estado where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEstado='" + sIdestado + "' ");
        }
        #endregion

    }
}