using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_Sis_Sistema
    {
        DL_Sis_Sistema oDL_Sis_Sistema = new DL_Sis_Sistema();
        #region Listados

        public DataTable Listar_Ubigeo(string sFiltro, string sValor)
        {
            return oDL_Sis_Sistema.Listar_Ubigeo(sFiltro, sValor);
        }
        public DataTable Listar_Historial(string sNomtablas, string sIdCliente)
        {
            return oDL_Sis_Sistema.Listar_Historial(sNomtablas, sIdCliente);
        }
        public DataTable Listar_Menu(string sIdPerfil, string sMenu)
        {
            return oDL_Sis_Sistema.Listar_Menu(sIdPerfil, sMenu);
        }
        #endregion

        #region Obtener Valores
        public string Get_Acceso(string sIdperfil, string sIdmenu)
        {
            return oDL_Sis_Sistema.Get_Acceso(sIdperfil, sIdmenu);
        }
        public Boolean Get_Agrupador(string sIdMenu)
        {
            return oDL_Sis_Sistema.Get_Agrupador(sIdMenu);
        }
        public string Get_Parametro(string sIdParametro)
        {
            return oDL_Sis_Sistema.Get_Parametro(sIdParametro);
        }
        public string Get_Descrip_Ubigeo(string sIdubigeo)
        {
            return oDL_Sis_Sistema.Get_Descrip_Ubigeo(sIdubigeo);
        }

        #endregion

        #region Operaciones
        public void Grabar_Historial(string sNomtabla, string sNcampo, string sIdregistro, string sAccion, 
            string sValant, string sValact, string sObse)
        {
            oDL_Sis_Sistema.Grabar_Historial(sNomtabla, sNcampo, sIdregistro, sAccion, sValant, sValact, sObse);
        }

        #endregion
    }
}
