using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
namespace DLSisCtd
{
    public class DL_Sis_Sistema
    {
        string sSql;
        #region Listados

        public DataTable Listar_Ubigeo(string sFiltro, string sValor)
        {
            sSql = "select 	idUbigeo,descripcion, ";
            sSql += "       idubigeo+' - '+descripcion as des ";
            sSql += "from 	v_ubigeo ";
            sSql += "where  " + (sFiltro == "C" ? "idubigeo" : "descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "idubigeo" : "descripcion");
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_Historial(string sNomtablas,string sIdCliente)
        {
            sSql = "select	Idhistoria,NombreTabla,NombreCampo as Campo,IdRegistro,Accion,ValorAnterior as [Valor Anterior],ValorActual as [Valor Actual], ";
            sSql += "       Observacion as Observación,FechaRegistro,HoraRegistro,UsuarioRegistro ";
            sSql += "from	Sis_Historial ";
            sSql += "where	NombreTabla in (" + sNomtablas + ")  and Idcliente='" + sIdCliente + "' ";
            sSql += "order by Idhistoria ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_Menu(string sIdperfil, string sMenu)
        {

            if (sIdperfil == "00")
                sSql = "select *,isnull(IdMenuPadre,'') as sIdMenuPadre from Sis_Menu where Estado=1 order by Orden";
            else
            {
                if (sMenu == "Menu")
                {
                    sSql = "select *,isnull(IdMenuPadre,'') as sIdMenuPadre from Sis_Menu where Idmenu not in ";
                    sSql += "(select a.idmenu from 	Sis_MenuPerfil a left join Sis_Menu b on a.Idmenu = b.Idmenu ";
                    sSql += "where	a.Idperfil = '" + sIdperfil + "' and Agrupador=0 ) and Estado=1  ";
                    sSql += "order by orden ";
                }
                else
                {
                    sSql = "select  b.*,isnull(b.IdMenuPadre,'') as sIdMenuPadre ";
                    sSql += "from   Sis_MenuPerfil a ";
                    sSql += "       left join Sis_Menu b on a.idmenu = b.idmenu ";
                    sSql += "where	a.IdPerfil = '" + sIdperfil + "' and b.Estado=1 order by orden";
                }
            }
            return ConexionDAO.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public string Get_Acceso(string sIdperfil, string sIdmenu)
        {
            if (sIdperfil == "00")
                sSql = "select accesos from sis_menu where idmenu='" + sIdmenu + "' ";
            else
                sSql = "select accesos from Sis_menuPerfil where idmenu='" + sIdmenu + "' and idperfil='" + sIdperfil + "'";
            return Convert.ToString(ConexionDAO.fEscalar(sSql));
        }
        public Boolean Get_Agrupador(string sIdMenu)
        {
            return Convert.ToBoolean(ConexionDAO.fEscalar("select agrupador from Sis_Menu where idMenu='" + sIdMenu + "'"));
        }
        public string Get_Parametro(string sIdparam,string sIdCliente)
        {
            return Convert.ToString(ConexionDAO.fEscalar("select Valor from Sis_Parametro where IdCliente = '" + sIdCliente + "' and IdParametro='" + sIdparam + "'"));
        }
        public string Get_Descrip_Ubigeo(string sIdubigeo)
        {
            sSql = "select descripcion from v_ubigeo where idubigeo ='" + sIdubigeo + "'";
            return Convert.ToString(ConexionDAO.fEscalar(sSql));
        }

        #endregion

        #region Operaciones
        public void Grabar_Historial(string sIdCliente, string sNomtabla, string sNcampo, string sIdregistro, string sAccion, string sValant, string sValact, string sObse, string sIdusuario)
        {
            sSql = "insert into Sis_Historial values( ";
            sSql += "'" + sIdCliente + "','" + sNomtabla + "','" + sNcampo + "','" + sIdregistro + "','" + sAccion + "','" + sValant + "','" + sValact + "','" + sObse + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + sIdusuario + "')";
            ConexionDAO.fExecute(sSql);
        }

        #endregion
    }
}
