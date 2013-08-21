using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Separadoras
    {
        #region Declaracion de Variables
        string sSql = "";
        #endregion

        #region Listados
        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	idseparadora as Id,descripcion as Descripción,";
            sSql += "       case when Estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_Separadora ";
            sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "Idseparadora" : "descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and Estado=1 ";
            if (nEreg == 1) sSql += "and Estado=0 ";
            sSql += "order by idseparadora ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_TiposDocumento(string sIdSeparadora)
        {
            //sSql = "select 	b.idseparadora as [Id],b.IdTipoDocumento as [IdTipoDoc], ";
            sSql = "select 	b.IdTipoDocumento as [Id], ";
            sSql += "     	b.Descripcion as Descripción, ";
            sSql += "       case when b.critico=1 then 'Si' else '' end as Critico, ";
            //sSql += "       case when b.Digitalizable=1 then 'Si' else '' end as Digita, ";
            sSql += "       case when b.Estado=0 then 'I' else '' end as Est, ";
            sSql += "       b.Fecharegistro as [Fecha Registro], ";
            sSql += "       b.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(b.UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoDocumento b ";
            sSql += "where  b.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and b.IdSeparadora = '" + sIdSeparadora + "' ";
            sSql += "order by b.IdTipoDocumento ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_TiposDocumento_NoAgregados()
        {
            sSql = "select 	a.IdTipoDocumento as [Id], ";
            sSql += "     	a.Descripcion as Descripción, ";
            sSql += "       case when a.critico=1 then 'Si' else '' end as Critico, ";
            //sSql += "       case when b.Digitalizable=1 then 'Si' else '' end as Digita, ";
            sSql += "       case when a.Estado=0 then 'I' else '' end as Est, ";
            sSql += "       a.Fecharegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro] ";
            sSql += "from 	T_TipoDocumento a ";
            sSql += "where  a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and  isnull(a.IdSeparadora,'')=''  ";
            sSql += "order by a.IdTipoDocumento ";
            return Helper.fDatatable(sSql);
        } 

        #endregion

        #region Obtener Valores

        public DataTable Get_Registro(string sIdSeparadora)
        {
            sSql = "select 	* from T_Separadora where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdSeparadora = '" + sIdSeparadora + "'";
            return Helper.fDatatable(sSql);
        }
        public string Get_Descripcion(string sIdSeparadora)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_Separadora where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdSeparadora='" + sIdSeparadora + "'"));
        }
        public string Get_Critico(string sIdSeparadora)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_Separadora where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "'  and IdSeparadora='" + sIdSeparadora + "'"));
        }
        public Boolean Existe(string sIdSeparadora)
        {
            return Get_Registro(sIdSeparadora).Rows.Count > 0 ? true : false;
        }
        public Boolean Existe_TiposDocumento(string sIdSeparadora)
        {
            return Listar_TiposDocumento(sIdSeparadora).Rows.Count > 0 ? true : false;
        }

        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdSeparadora, string sDescrip, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Separadora values( ";
                sSql += "'" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdSeparadora + "','" + sDescrip + "'," + (bEreg ? "1" : "0") + " , ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_Separadora set ";
                sSql += "       descripcion='" + sDescrip + "', ";
                sSql += "       Estado='" + (bEreg ? "1" : "0") + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdSeparadora ='" + sIdSeparadora + "' ";

            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar( string sIdSeparadora)
        {
            Helper.fEscalar("delete from T_Separadora where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdSeparadora ='" + sIdSeparadora + "' ");
        }
        public void Agregar_TipoDocumento(string sIdSeparadora, string sIdTipoDocumento)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql  = " update T_TipoDocumento ";
                    sSql += " set IdSeparadora = '"+sIdSeparadora+"' ";
                    sSql += " where IdCliente = '"+ Helper.oBE_Sis_Cliente.IdCliente+"' and IdTipoDocumento = '"+sIdTipoDocumento+"' ";

                    //sSql = "insert into T_SeparadoraDocumentos values('" + Helper.oCliente.IdCliente + "','" + sIdSeparadora + "','" + sIdTipoDocumento + "', ";
                    //sSql += "      convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_TipoDocumento(string sIdTipoDocumento)
        {
            //sSql = "delete from T_SeparadoraDocumentos where Idcliente='" + Helper.oCliente.IdCliente + "' and IdSeparadora='" + sIdSeparadora + "' and IdTipoDocumento = '" + sIdTipoDocumento + "' ";
            sSql  = " update T_TipoDocumento ";
            sSql += " set IdSeparadora = null ";
            sSql += " where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "' ";
            Helper.fExecute(sSql);
        }
        #endregion

    }
}
