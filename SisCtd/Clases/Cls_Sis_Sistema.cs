using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BESisCtd;
namespace SisCtd
{
    public class Cls_Sis_Sistema
    {
        string sSql = "";
        #region Listados
        
        public DataTable BuscarCliente(string sFiltro, string sValor)
        {
            sSql = "select 	IdCliente,Descripcion ";
            sSql += "from 	Sis_Cliente ";
            sSql += "where  estado=1 and ";
            sSql += (sFiltro == "C" ? "idcliente" : "Descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "idcliente" : "Descripcion");
            return Helper.fDatatable(sSql);
        }

        public DataTable Listar_Ubigeo(string sFiltro, string sValor)
        {
            sSql = "select 	idUbigeo,descripcion, ";
            sSql += "       idubigeo+' - '+descripcion as des ";
            sSql += "from 	v_ubigeo ";
            sSql += "where  " + (sFiltro == "C" ? "idubigeo" : "descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "idubigeo" : "descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Historial(string sNomtablas)
        {
            sSql = "select	Idhistoria,NombreTabla,NombreCampo as Campo,IdRegistro,Accion,ValorAnterior as [Valor Anterior],ValorActual as [Valor Actual], ";
            sSql += "       Observacion as Observación,FechaRegistro,HoraRegistro,UsuarioRegistro ";
            sSql += "from	Sis_Historial ";
            sSql += "where	NombreTabla in (" + sNomtablas + ")  and Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' ";
            sSql += "order by Idhistoria ";
            return Helper.fDatatable(sSql);
        }
        
        #endregion

        #region Obtener Valores
        
        public string Get_Parametro(string sIdparam)
        {
            return Convert.ToString(Helper.fEscalar("select Valor from Sis_Parametro where IdCliente = '"+Helper.oBE_Sis_Cliente.IdCliente+"' and IdParametro='" + sIdparam + "'"));
        }
        public string Get_Descrip_Ubigeo(string sIdubigeo)
        {
            sSql = "select descripcion from v_ubigeo where idubigeo ='" + sIdubigeo + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        
        #endregion

        #region Operaciones
        public void Grabar_Historial(string sNomtabla, string sNcampo, string sIdregistro, string sAccion, string sValant, string sValact, string sObse)
        {
            sSql = "insert into Sis_Historial values( ";
            sSql += "'"+Helper.oBE_Sis_Cliente.IdCliente+"','" + sNomtabla + "','" + sNcampo + "','" + sIdregistro + "','" + sAccion + "','" + sValant + "','" + sValact + "','" + sObse + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "')";
            Helper.fExecute(sSql);
        }
        
        #endregion
    }
}