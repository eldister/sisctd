using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_SubProductos
    {
        #region Variables

        string sSql = "";

        #endregion

        #region Listado
        public DataTable Listar(string sDescrip, int nEreg)
        {
            sSql = "select  a.idproducto +a.idsubproducto as Id, ";
            sSql += "       a.idproducto as Producto, ";
            sSql += "       b.descripcion as [Descripción Producto], ";
            sSql += "       a.idsubproducto as SubProducto, ";
            sSql += "       a.descripcion as [Descripción Sub-Producto], ";
            sSql += "       case when a.Estado=0 then 'I' else '' end as Est, ";
            sSql += "       a.FechaRegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       a.idsubproducto+' - '+a.descripcion as des ";
            sSql += "from 	T_subproducto a ";
            sSql += "       left join T_producto b on a.IdCliente = b.IdCliente and a.idproducto = b.idproducto ";
            sSql += "where  a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'";
            sSql += "       and a.descripcion like '%" + sDescrip + "%' ";
            if (nEreg == 0) sSql += "and a.Estado = 1 ";
            if (nEreg == 1) sSql += "and a.Estado = 0 ";
            sSql += "order by a.idproducto,a.idsubproducto ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Por_Producto(string sFiltro, string sIdprod, string sValor)
        {
            sSql = "select  a.idsubproducto as SubProducto, ";
            sSql += "       a.descripcion as [Descripción] ";
            sSql += "from 	T_subproducto a ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.idproducto ='" + sIdprod + "' and a.Estado= 1 ";
            sSql += "       and " + (sFiltro == "C" ? "a.idsubproducto" : "a.descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "a.idsubproducto" : "a.descripcion");
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdprod, string sIdsubprod)
        {
            return Helper.fDatatable("select * from T_subproducto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idproducto='" + sIdprod + "' and idsubproducto='" + sIdsubprod + "'");
        }
        public string Get_Descrip(string sIdprod, string sIdsubprod)
        {
            sSql = "select descripcion from T_subproducto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idproducto='" + sIdprod + "' and idsubproducto='" + sIdsubprod + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        public Boolean Existe(string sIdprod, string sIdsubprod)
        {
            return Get_Registro(sIdprod, sIdsubprod).Rows.Count > 0 ? true : false;
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdprod, string sIdsubprod, string sDescrip, Boolean sEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert  into T_subproducto ";
                sSql += "        values('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdprod + "','" + sIdsubprod + "','" + sDescrip + "','" + (sEreg == true ? "1" : "0")  +"', ";
                sSql += "        convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_subproducto set ";
                sSql += "       descripcion='" + sDescrip + "', ";
                sSql += "       Estado='" + (sEreg == true ? "1" : "0") + "'  ";
                sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idproducto='" + sIdprod + "' and idsubproducto='" + sIdsubprod + "'";
            }
            Helper.fExecute(sSql);
        }
        public void Elminar(string sIdprod, string sIdsubprod)
        {
            sSql = "delete from T_Subproducto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and idproducto='" + sIdprod + "' and idsubproducto='" + sIdsubprod + "'";
            Helper.fExecute(sSql);
        }
        #endregion

      
       
    }
}