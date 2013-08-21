using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Productos
    {
        string sSql = "";

        #region Listados
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	idproducto as Id,descripcion as Descripción,idarea as Area,Tipo, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       Idproducto+' - '+descripcion as des ";
            sSql += "from 	T_Producto ";
            sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "Idproducto" : "descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado=1 ";
            if (nEreg == 1) sSql += "and Estado=0 ";
            sSql += "order by Idproducto ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_ProductoTipoDocumentos(string sIdproducto)
        {
            sSql = "select 	a.IdTipoDocumento as Id, ";
            sSql += "       b.descripcion as Descripción, ";
            sSql += "       case when b.Estado=0 then 'I' else '' end as Est ";
            sSql += "from 	T_ProductoTipoDocumento a  ";
            sSql += "       inner join T_TipoDocumento b on a.Idcliente=b.Idcliente and a.IdTipoDocumento=b.IdTipoDocumento ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.Idproducto='" + sIdproducto + "' ";
            sSql += "order by a.IdTipoDocumento ";
            return Helper.fDatatable(sSql);
        }


        public DataTable Listar_ProductoTipoDocumentoDatos(string sIdproducto, string IdTipoDocumento)
        {
            sSql = "select  a.iddato as Id, ";
            sSql += "       b.descripcion as Descripción, ";
            sSql += "       case when b.Estado=0 then 'I' else '' end as Est ";
            sSql += "from 	T_ProductoTipoDocumentoDatos a  ";
            sSql += "       inner join T_Datos b on a.Idcliente=b.Idcliente and a.iddato=b.iddato ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.Idproducto='" + sIdproducto + "' and a.IdTipoDocumento='" + IdTipoDocumento + "' ";
            sSql += "order by a.iddato ";
            return Helper.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdproducto)
        {
            return Helper.fDatatable("select * from T_Producto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'");
        }
        public string Get_Descrip(string sIdproducto)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_Producto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'"));
        }
        public Boolean Existe(string sIdproducto)
        {
            return Get_Registro(sIdproducto).Rows.Count > 0 ? true : false;
        }
        public Boolean Existe_ProductoTipoDocumento(string sIdproducto, string IdTipoDocumento)
        {
            sSql = "select count(*) from T_ProductoTipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoDocumento='" + IdTipoDocumento + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }
        public Boolean Existe_ProductoTipoDocumentoDato(string sIdproducto, string IdTipoDocumento, string sIddato)
        {
            sSql = "select count(*) from T_ProductoTipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoDocumento='" + IdTipoDocumento + "' and iddato='" + sIddato + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }



        //validaciones para eliminar
        public Boolean Existe_Subproductos(string sIdproducto)
        {
            sSql = "select count(*) from T_SubProducto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }

        public Boolean Existe_ProductoTipoDocumentos(string sIdproducto)
        {
            sSql = "select count(*) from T_ProductoTipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }
        public Boolean Existe_Operaciones(string sIdproducto)
        {
            sSql = "select top 1 Idproducto from Reg_Operacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and rtrim(Idproducto)='" + sIdproducto + "' order by Idproducto";
            return Convert.ToString(Helper.fEscalar(sSql)) == "" ? false : true;
        }

        
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdproducto, string sDescripcion, string sIdArea, string sTipo, Boolean bEstado)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Producto values( ";
                sSql += "'" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + sDescripcion + "','" + sIdArea + "','" + sTipo + "','" + (bEstado == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_Producto set ";
                sSql += "       descripcion='" + sDescripcion + "', ";
                sSql += "       idarea='" + sIdArea + "', ";
                sSql += "       tipo   ='" + sTipo + "', ";
                sSql += "       Estado='" + (bEstado == true ? "1" : "0") + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' ";
            }
            Helper.fEscalar(sSql);
        }

        public void Eliminar(string sIdproducto)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "delete from T_ProductoTipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sSql = "delete from T_ProductoTipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sSql = "delete from T_Producto where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void Grabar_ProductoTipoDocumento(string sIdproducto, string IdTipoDocumento)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "insert  into T_ProductoTipoDocumento ";
                    sSql += "       values('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + IdTipoDocumento + "', ";
                    sSql += "       convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert  into T_ProductoTipoDocumentoDatos ";
                    sSql += "select '" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + IdTipoDocumento + "',iddato, ";
                    sSql += "       convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "'";
                    sSql += "from   T_TipoDocumentoDatos where IdCliente = '"+Helper.oBE_Sis_Cliente.IdCliente+"' and IdTipoDocumento='" + IdTipoDocumento + "'  ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Eliminar_ProductoTipoDocumentoDato(string sIdproducto, string IdTipoDocumento)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "delete from T_ProductoTipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoDocumento='" + IdTipoDocumento + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sSql = "delete from T_ProductoTipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoDocumento='" + IdTipoDocumento + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void Grabar_Dato(string sIdproducto, string IdTipoDocumento, string sIddato)
        {
            sSql = "insert  into T_ProductoTipoDocumentoDatos values ";
            sSql += "       ('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + IdTipoDocumento + "','" + sIddato + "', ";
            sSql += "       convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            Helper.fExecute(sSql);
        }

        public void Eliminar_ProductoTipoDocumentoDato(string sIdproducto, string IdTipoDocumento, string sIddato)
        {
            sSql = "delete from T_ProductoTipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoDocumento='" + IdTipoDocumento + "' and iddato='" + sIddato + "'";
            Helper.fExecute(sSql);
        }
        #endregion

    }
}