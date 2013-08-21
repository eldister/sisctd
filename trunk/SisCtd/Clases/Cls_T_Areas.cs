using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Areas
    {
        #region Variables
        string sSql = "";
        #endregion

        #region Listado
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	IdArea as Id,Descripcion as Descripción, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       IdArea+' - '+Descripcion as des ";
            sSql += "from 	T_Area ";
            sSql += "where  IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "IdArea" : "Descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado=1 ";
            if (nEreg == 1) sSql += "and Estado=0 ";
            sSql += "order by " + (sFiltro == "C" ? "IdArea" : "Descripcion");
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdarea)
        {
            return Helper.fDatatable("select * from T_Area where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "'");
        }
        public Boolean Existe(string sIdarea)
        {
            return Get_Registro(sIdarea).Rows.Count > 0 ? true : false;
        }
        public string Get_Descrip(string sIdarea)
        {
            sSql = "select Descripcion from T_Area where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        public Boolean Existe_Productos(string sIdarea)
        {
            sSql = "select count(*) from T_Producto where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "'";
            int nCant = Convert.ToInt32(Helper.fEscalar(sSql));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_Ingresos(string sIdarea)
        {
            sSql = "select top 1 IdArea from Reg_Legajo where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "' order by IdArea";
            return Convert.ToString(Helper.fEscalar(sSql)) == "" ? false : true;
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdarea, string sDescrip, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Area values( '" + Helper.oBE_Sis_Cliente.IdCliente + "', ";
                sSql += "'" + sIdarea + "','" + sDescrip + "','" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update T_Area set ";
                sSql += "       Descripcion ='" + sDescrip + "', ";
                sSql += "       Estado ='" + (bEreg == true ? "1" : "0") + "' ";
                sSql += "where 	IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdarea)
        {
            Helper.fEscalar("delete from T_Area where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdArea='" + sIdarea + "' ");
        }
        #endregion


    }
}