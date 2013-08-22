using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_Sis_Perfil
    {
        DL_Sis_Perfil oDL_Sis_Perfil = new DL_Sis_Perfil();

        #region Listados
        public DataTable Listar()
        {
            return oDL_Sis_Perfil.Listar();
        }
        public DataTable Listar_Combo()
        {
            return oDL_Sis_Perfil.Listar_Combo();
        }

        #endregion

        #region Obtener Valores
        public BE_Sis_Perfil Get_Perfil(string sIdPerfil)
        {
            return oDL_Sis_Perfil.Get_Perfil(sIdPerfil);
        }

        #endregion

        #region Operaciones
        public string Insertar(BE_Sis_Perfil oBE_Sis_Perfil)
        {
            return oDL_Sis_Perfil.Insertar(oBE_Sis_Perfil);
        }
        public void Modificar(BE_Sis_Perfil oBE_Sis_Perfil)
        {
            oDL_Sis_Perfil.Modificar(oBE_Sis_Perfil);
        }
        public void Eliminar(string sIdperfil)
        {
            oDL_Sis_Perfil.Eliminar(sIdperfil);
        }

        public void Asignar_Acceso(string sIdPerfil, string sIdMenu)
        {
            oDL_Sis_Perfil.Asignar_Acceso(sIdPerfil, sIdMenu);
        }
        public void Quitar_Acceso(string sIdPerfil, string sIdMenu)
        {
            oDL_Sis_Perfil.Quitar_Acceso(sIdPerfil, sIdMenu);
        }
        public void ModificarAcceso(string sIdperfil, string sIdMenu, string sAcceso)
        {
            oDL_Sis_Perfil.ModificarAcceso(sIdperfil, sIdMenu, sAcceso);
        }

        #endregion
    }
}
