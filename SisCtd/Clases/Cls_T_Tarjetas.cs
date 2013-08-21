using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Tarjetas
    {
        #region Variable

        string sSql = "";

        #endregion

        #region Listado
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	idtarjeta as Id,descripcion as Descripción, Digitos,";
            sSql += "       case when estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       Idtarjeta+' - '+descripcion as des ";
            sSql += "from 	T_Tarjeta ";
            sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "idtarjeta" : "descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado = 1 ";
            if (nEreg == 1) sSql += "and Estado = 0 ";
            sSql += "order by " + (sFiltro == "C" ? "idtarjeta" : "descripcion");
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdtarjeta)
        {
            return Helper.fDatatable("select * from T_Tarjeta where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idtarjeta='" + sIdtarjeta + "'");
        }
        public Boolean Existe(string sIdtarjeta)
        {
            return Get_Registro(sIdtarjeta).Rows.Count > 0 ? true : false;
        }
        public string Get_Descrip(string sIdtarjeta)
        {
            sSql = "select descripcion from T_Tarjeta where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idtarjeta='" + sIdtarjeta + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        public int Get_Digitos(string sIdtarjeta)
        {
            sSql = "select digitos from T_Tarjeta where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idtarjeta='" + sIdtarjeta + "'";
            return Convert.ToInt16(Helper.fEscalar(sSql));
        }
        //Validaciones para eliminar
        public Boolean Existe_Operaciones(string sIdtarjeta)
        {
            sSql = "select count(*) from Reg_Operacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTarjeta='" + sIdtarjeta + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdtarjeta, string sDescrip,string sDigitos, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Tarjeta values('" + Helper.oBE_Sis_Cliente.IdCliente + "', ";
                sSql += "'" + sIdtarjeta + "','" + sDescrip + "','" + sDigitos + "','" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_Tarjeta set ";
                sSql += "       descripcion='" + sDescrip + "', ";
                sSql += "       Estado='" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "       Digitos='" + sDigitos + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTarjeta='" + sIdtarjeta + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdtarjeta)
        {
            Helper.fEscalar("delete from T_Tarjeta where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idtarjeta='" + sIdtarjeta + "' ");
        }
        #endregion



    }
}