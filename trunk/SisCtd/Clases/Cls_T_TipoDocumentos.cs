using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_TipoDocumentos
    {
        string sSql = "";
        public DataTable Listar(string sFiltro, string sValor, int nEstado, int nCri)
        {
            sSql = "select 	IdTipoDocumento as Id, Descripcion,DescripcionLarga as [Descripcion Larga], ";
            sSql += "       case when Verificable=1 then 'Si' else '' end as Verificable , ";
            sSql += "       case when Critico=1 then 'Si' else '' end as Critico , ";
            sSql += "       case when Digitalizable=1 then 'Si' else '' end as Digitable , ";
            sSql += "       Nivel as [Clasif.], ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       case when orden=0 then '' else CONVERT(varchar(4),orden) end as Ord, ";
            sSql += "       isnull(IdSeparadora,'') as Separadora, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoDocumento  ";
            sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and " + (sFiltro == "C" ? "IdTipoDocumento" : "descripcion") + " like '%" + sValor + "%' ";
            if (nCri == 0) sSql += "and critico=1 ";
            if (nCri == 1) sSql += "and critico=0 ";
            if (nEstado == 0) sSql += "and Estado=1 ";
            if (nEstado == 1) sSql += "and Estado=0 ";
            sSql += "order by " + (sFiltro == "C" ? "IdTipoDocumento" : "descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Get_Registro(string sIdTipoDocumento)
        {
            return Helper.fDatatable("select *,case when critico=1 then 'Si' else '' end as scritico from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'");
        }
        public string Get_Descrip(string sIdTipoDocumento)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'"));
        }

        public string Get_IdSeperadora(string sIdTipoDocumento)
        {
            return Convert.ToString(Helper.fEscalar("select IdSeparadora from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'"));
        }
        public Boolean Get_Verificable(string sIdTipoDocumento)
        {
            return Convert.ToBoolean(Helper.fEscalar("select Verificable from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'"));
        }
        public Boolean Get_Critico(string sIdTipoDocumento)
        {
            return Convert.ToBoolean(Helper.fEscalar("select Critico from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'"));
        }
        public Boolean Get_Digitalizable(string sIdTipoDocumento)
        {
            return Convert.ToBoolean(Helper.fEscalar("select Digitalizable from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdTipoDocumento='" + sIdTipoDocumento + "'"));
        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return Get_Registro(sIdTipoDocumento).Rows.Count > 0 ? true : false;
        }

        public void Grabar(int nOpc, string sIdTipoDocumento, string sDescrip,string sDescripcionLarga, Boolean bVerificable,Boolean bCritico,Boolean bDigitalizable,string sNivel, Boolean bEstado, int nOrden, string sSeparadora)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_TipoDocumento values( ";
                sSql += "'" + Helper.oBE_Sis_Cliente.IdCliente + "', '" + sIdTipoDocumento + "','" + sDescrip + "','" + sDescripcionLarga + "','" + (bVerificable == true ? "1" : "0") + "','" + (bCritico == true ? "1" : "0") + "','" + (bDigitalizable == true ? "1" : "0") + "','" + sNivel + "','" + (bEstado == true ? "1" : "0") + "','" + nOrden + "', ";
                sSql += sSeparadora == "" ? "null," : "'"+sSeparadora+"', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_TipoDocumento set ";
                sSql += "       descripcion='" + sDescrip + "', ";
                sSql += "       DescripcionLarga='" + sDescripcionLarga + "', ";
                sSql += "       verificable='" + (bVerificable == true ? "1" : "0") + "', ";
                sSql += "       critico='" + (bCritico == true ? "1" : "0") + "', ";
                sSql += "       digitalizable='" + (bDigitalizable == true ? "1" : "0") + "', ";
                sSql += "       nivel='" + sNivel + "', ";
                sSql += "       Estado='" + (bEstado == true ? "1" : "0") + "', ";
                sSql += "       orden='" + nOrden + "' ,";
                sSql += sSeparadora == "" ? "IdSeparadora = null " : " IdSeparadora = '" + sSeparadora + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' ";

            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdTipoDocumento)
        {
            Helper.fEscalar("delete from T_TipoDocumento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "'");
        }


        public Boolean Existe_Productos(string sIdTipoDocumento)
        {
            sSql = "select count(*) from T_ProductoTipoDocumento  where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + " and rtrim(IdTipoDocumento)='" + sIdTipoDocumento + "' ";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }

        public Boolean Existe_Documentos(string sIdTipoDocumento)
        {
            sSql = "select top 1 IdTipoDocumento from Reg_Documento where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + " and rtrim(IdTipoDocumento)='" + sIdTipoDocumento + "' order by IdTipoDocumento";
            return Convert.ToString(Helper.fEscalar(sSql)) == "" ? false : true;
        }

        public DataTable Listar_Datos(string sFiltro, string sIdTipoDocumento, string sValor)
        {
            sSql = "select  a.iddato as [Id], ";
            sSql += "       b.descripcion as Descripción, ";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       a.FechaRegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoDocumentoDatos a ";
            sSql += "       inner join T_datos b on a.Idcliente=b.Idcliente and a.iddato=b.iddato ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "' and ";
            sSql += "       " + (sFiltro == "C" ? "IdTipoDocumento" : "descripcion") + " like '%" + sValor + "%'";
            sSql += "order by orden ";
            return Helper.fDatatable(sSql);
        }

        public Boolean Existe_Dato(string sIdTipoDocumento, string sIddato)
        {
            sSql = "select count(*) from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
            return (Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false);
        }

        public void Grabar_Dato(string sIdTipoDocumento, string sIddato)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select isnull(max(orden)+1,1) from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' ";
                    string sOrden = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "insert into T_TipoDocumentoDatos values('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdTipoDocumento + "','" + sIddato + "','" + sOrden + "', ";
                    sSql += "      convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void Eliminar_Dato(string sIdTipoDocumento, string sIddato)
        {
            DataTable Dt = new DataTable();
            sSql = "delete from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
            Helper.fExecute(sSql);

            int nIni = 1;
            Dt = Listar_Datos("D", sIdTipoDocumento, "");
            foreach (DataRow Fila in Dt.Rows)
            {
                sIddato = Fila["id"].ToString();
                sSql = "update T_TipoDocumentoDatos set orden='" + nIni.ToString() + "' where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
                Helper.fExecute(sSql);
                nIni += 1;
            }
            Dt.Dispose(); Dt = null;
        }

        public void Orden_SubirDato(string sIdTipoDocumento, string sIddato)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select orden from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "' ";
                    int nOrden = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    if (nOrden != 1)
                    {
                        sSql = "select iddato from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and orden='" + Convert.ToString(nOrden - 1) + "'";
                        string sIddato2 = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                        sSql = "update T_TipoDocumentoDatos set orden ='" + Convert.ToString(nOrden - 1) + "' where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sSql = "update T_TipoDocumentoDatos set orden ='" + nOrden.ToString() + "' where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato2 + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sTrans.Commit();
                    }
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void Orden_BajarDato(string sIdTipoDocumento, string sIddato)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select max(orden) from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "'";
                    int nCant = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));
                    sSql = "select orden from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
                    int nOrden = Convert.ToInt16(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    if (nOrden != nCant)
                    {
                        sSql = "select iddato from T_TipoDocumentoDatos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and orden='" + Convert.ToString(nOrden + 1) + "'";
                        string sIddato2 = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                        sSql = "update T_TipoDocumentoDatos set orden ='" + Convert.ToString(nOrden + 1) + "' where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sSql = "update T_TipoDocumentoDatos set orden ='" + nOrden.ToString() + "' where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento='" + sIdTipoDocumento + "' and iddato='" + sIddato2 + "'";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        sTrans.Commit();
                    }
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

    }
}