using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Ejecutivos
    {
        #region Variables
        string sSql = "";
        #endregion

        #region Listado
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	idejecutivo as Id,Nombre, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       IdEjecutivo+' - '+Nombre as des ";
            sSql += "from 	T_Ejecutivo ";
            sSql += "where  IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "idejecutivo" : "Nombre") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado = 1 ";
            if (nEreg == 1) sSql += "and Estado = 0 ";
            sSql += "order by " + (sFiltro == "C" ? "IdEjecutivo" : "Nombre");
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdejecutivo)
        {
            return Helper.fDatatable("select * from T_Ejecutivo where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEjecutivo='" + sIdejecutivo + "'");
        }
        public Boolean Existe(string sIdejecutivo)
        {
            return Get_Registro(sIdejecutivo).Rows.Count > 0 ? true : false;
        }
        public Boolean Existe_Registro(string sIdejecutivo)
        {
            sSql = "select count(*) from ingreman where IdEjecutivo='" + sIdejecutivo + "'";
            int nCant = Convert.ToInt32(Helper.fEscalar(sSql));
            return (nCant > 0 ? true : false);
        }
        public string Get_Nombre(string sIdejecutivo)
        {
            return Convert.ToString(Helper.fEscalar("select Nombre from T_Ejecutivo where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEjecutivo ='" + sIdejecutivo + "'"));
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdejecutivo, string sNombre, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Ejecutivo values( '" + Helper.oBE_Sis_Cliente.IdCliente + "',";
                sSql += "'" + sIdejecutivo + "','" + sNombre + "','" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update T_Ejecutivo set ";
                sSql += "       nombre='" + sNombre + "', ";
                sSql += "       Estado ='" + (bEreg == true ? "1" : "0") + "' ";
                sSql += "where 	IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEjecutivo ='" + sIdejecutivo + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdejecutivo)
        {
            Helper.fEscalar("delete from T_Ejecutivo where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdEjecutivo ='" + sIdejecutivo + "' ");
        }
        #endregion


    }
}