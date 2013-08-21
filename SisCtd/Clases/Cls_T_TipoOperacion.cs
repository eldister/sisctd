using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_TipoOperacion
    {
        string sSql = "";
        #region Listados
        public DataTable Listar(string sFiltro, string sValor, int nEreg, int nCri)
        {
            sSql = "select  a.Idproducto+a.IdTipoOperacion as Id, ";
            sSql += "       a.Idproducto as Producto, ";
            sSql += "       b.descripcion as [Descripción Producto], ";
            sSql += "       a.IdTipoOperacion as [Id.Transac],a.descripcion as Descripción,Naturaleza, ";
            sSql += "       case when a.Critico=1 then 'Si' else '' end as Critico, ";
            sSql += "       case when a.Digitalizable=1 then 'Si' else '' end as Digita, ";
            sSql += "       case when a.Estado=0 then 'I' else '' end as Est, ";
            sSql += "       a.Fecharegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoOperacion a ";
            sSql += "       left join T_Producto b on a.Idcliente=b.Idcliente and a.Idproducto=b.Idproducto  ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "IdTipoOperacion" : "a.descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and a.Estado=1 ";
            if (nEreg == 1) sSql += "and a.Estado=0 ";
            sSql += "order by a.Idproducto," + (sFiltro == "C" ? "IdTipoOperacion" : "a.descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Por_Producto(string sFiltro, string sIdproducto, string sValor)
        {
            sSql = "select  a.IdTipoOperacion as [Tipo Doc], ";
            sSql += "       a.descripcion as [Descripción] ";
            sSql += "from 	T_TipoOperacion a ";
            sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.Idproducto = '" + sIdproducto + "' and a.Estado=1 ";
            sSql += "       and " + (sFiltro == "C" ? "a.IdTipoOperacion" : "a.descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "a.IdTipoOperacion" : "a.descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_TipoOperacionTipoDocumentos(string sFiltro, string sIdproducto, string sIdTipoOperacion, string sValor)
        {
            sSql = "select  a.IdTipoDocumento as [Id], ";
            sSql += "       b.descripcion as Descripción, ";
            sSql += "       case when a.critico=1 then 'Si' else '' end as Critico, ";
            sSql += "       case when a.Digitalizable=1 then 'Si' else '' end as Digita, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       a.Fecharegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoOperacionTipoDocumento a ";
            sSql += "       inner join T_TipoDocumento b on a.Idcliente=b.Idcliente and a.IdTipoDocumento=b.IdTipoDocumento ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and ";
            sSql += "       " + (sFiltro == "C" ? "IdTipoDocumento" : "descripcion") + " like '%" + sValor + "%'";
            sSql += "order by a.orden ";
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdproducto, string sIdTipoOperacion)
        {
            return Helper.fDatatable("select * from T_TipoOperacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'");
        }
        public string Get_Descrip(string sIdproducto, string sIdTipoOperacion)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_TipoOperacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'"));
        }
        public string Get_Descrip(string sIdTipoOperacion)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_TipoOperacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoOperacion='" + sIdTipoOperacion + "'"));
        }
        public Boolean Existe(string sIdproducto,string sIdTipoOperacion)
        {
            return Get_Registro(sIdproducto, sIdTipoOperacion).Rows.Count > 0 ? true : false;
        }

        //Validadon para eliminar
        public Boolean Existe_Operaciones(string sIdproducto, string sIdTipoOperacion)
        {
            sSql = "select top 1 Idproducto from Reg_Operacion ";
            sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "' order by Idproducto,IdTipoOperacion";
            return Convert.ToString(Helper.fEscalar(sSql)) == "" ? false : true;
        }
        public Boolean Es_Index(string sIdproducto, string sIdTipoOperacion)
        {
            sSql = "select top 1 Idproducto from T_TipoOperacion ";
            sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "' and Naturaleza='index'";
            return Convert.ToString(Helper.fEscalar(sSql)) == "" ? false : true;
        }
        public Boolean Existe_Documento(string sIdproducto, string sIdTipoOperacion,string sIddocu)
        {
            sSql = "select count(*) from T_TipoOperacionTipoDocumento ";
            sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdproducto, string sIdTipoOperacion, string sDescrip, string sNatura, Boolean bCritico, Boolean bDigitalizable, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_TipoOperacion values( ";
                sSql += "'" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + sIdTipoOperacion + "','" + sDescrip + "','" + sNatura + "' ";
                sSql += ",'" + (bCritico ? "1" : "0") + "','" + (bDigitalizable ? "1" : "0") + "','" + (bEreg ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_TipoOperacion set ";
                sSql += "       descripcion='" + sDescrip + "', ";
                sSql += "       Naturaleza='" + sNatura + "', ";
                sSql += "       critico='" + (bCritico ? "1" : "0") + "', ";
                sSql += "       Digitalizable='" + (bDigitalizable ? "1" : "0") + "', ";
                sSql += "       Estado='" + (bEreg ? "1" : "0") + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'";

            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdproducto, string sIdTipoOperacion)
        {
            Helper.fEscalar("delete from T_TipoOperacion where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'");
        }
        public void Agregar_TipoDocumento(string sIdproducto, string sIdTipoOperacion, string sIddocu)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select isnull(max(orden)+1,1) from T_TipoOperacionTipoDocumento ";
                    sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "' ";
                    string sOrden = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "insert into T_TipoOperacionTipoDocumento values('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdproducto + "','" + sIdTipoOperacion + "','" + sIddocu + "',1,0,'" + sOrden + "', ";
                    sSql += "      convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_TipoDocumento(string sIdproducto, string sIdTipoOperacion, string sIddocu)
        {
            DataTable Dt = new DataTable();
            sSql = "delete from T_TipoOperacionTipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
            Helper.fExecute(sSql);

            int nIni = 1;
            Dt = Listar_TipoOperacionTipoDocumentos("D", sIdproducto, sIdTipoOperacion, "");
            foreach (DataRow Fila in Dt.Rows)
            {
                sIddocu = Fila["id"].ToString();
                sSql = "update  T_TipoOperacionTipoDocumento set orden='" + nIni.ToString() + "' ";
                sSql = "where   Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
                Helper.fExecute(sSql);
                nIni += 1;
            }
            Dt.Dispose(); Dt = null;
        }
        public void Upd_Critico(string sIdproducto, string sIdTipoOperacion, Boolean bCritico)
        {
            sSql = "update  T_TipoOperacion set ";
            sSql += "       critico='" + (bCritico ? "1" : "0") + "' ";
            sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'";
            Helper.fEscalar(sSql);
        }
        public void Upd_Critico_TipoDocumento(string sIdproducto, string sIdTipoOperacion, string sIddocu,Boolean bCritico)
        {
            sSql = "update T_TipoOperacionTipoDocumento set critico='" + (bCritico ? "1" : "0") + "' ";
            sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
            Helper.fExecute(sSql);
        }
        public void Upd_Digitalizable(string sIdproducto, string sIdTipoOperacion, Boolean bDigitalizable)
        {
            sSql = "update  T_TipoOperacion set ";
            sSql += "       Digitalizable='" + (bDigitalizable ? "1" : "0") + "' ";
            sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion='" + sIdTipoOperacion + "'";
            Helper.fEscalar(sSql);
        }
        public void Upd_Digitalizable_TipoDocumento(string sIdproducto, string sIdTipoOperacion, string sIddocu, Boolean bDigita)
        {
            sSql = "update T_TipoOperacionTipoDocumento set Digitalizable='" + (bDigita ? "1" : "0") + "' ";
            sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
            Helper.fExecute(sSql);
        }
        public void Orden_Subir(string sIdproducto, string sIdTipoOperacion, string sIddocu)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select orden from T_TipoOperacionTipoDocumento ";
                    sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
                    int nOrden = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    if (nOrden != 1)
                    {
                        sSql = "select IdTipoDocumento from T_TipoOperacionTipoDocumento ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and orden='" + Convert.ToString(nOrden - 1) + "'";
                        string sIddocu2 = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                        sSql = "update T_TipoOperacionTipoDocumento set orden ='" + Convert.ToString(nOrden - 1) + "' ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                        sSql = "update T_TipoOperacionTipoDocumento set orden ='" + nOrden.ToString() + "' ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu2 + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sTrans.Commit();
                    }
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Orden_Bajar(string sIdproducto, string sIdTipoOperacion, string sIddocu)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select max(orden) from T_TipoOperacionTipoDocumento ";
                    sSql +="where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "'";
                    int nCant = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "select orden from T_TipoOperacionTipoDocumento ";
                    sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
                    int nOrden = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    if (nOrden != nCant)
                    {
                        sSql = "select IdTipoDocumento from T_TipoOperacionTipoDocumento ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and orden='" + Convert.ToString(nOrden + 1) + "'";
                        string sIddocu2 = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                        sSql = "update T_TipoOperacionTipoDocumento set orden ='" + Convert.ToString(nOrden + 1) + "' ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                        sSql = "update T_TipoOperacionTipoDocumento set orden ='" + nOrden.ToString() + "' ";
                        sSql += "where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idproducto='" + sIdproducto + "' and IdTipoOperacion = '" + sIdTipoOperacion + "' and IdTipoDocumento='" + sIddocu2 + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sTrans.Commit();
                    }
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        #endregion
    }
}