using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_Sis_Usuario
    {
        DL_Sis_Usuario oDL_Sis_Usuario = new DL_Sis_Usuario();

        #region Listados
        public DataTable Listar(string sIdPerfil, Boolean bTodos)
        {
            return oDL_Sis_Usuario.Listar(sIdPerfil, bTodos);
        }
        public DataTable Buscar(string sFiltro, string sValor)
        {
            return oDL_Sis_Usuario.Buscar(sFiltro, sValor);
        }

        #endregion

        #region Obtener Valores
        public BE_Sis_Usuario Get_Usuario(string sIdUsuario)
        {
            return oDL_Sis_Usuario.Get_Usuario(sIdUsuario);
        }
        public Boolean Existe(string sIdusuario)
        {
            return oDL_Sis_Usuario.Existe(sIdusuario);
        }
        public Boolean Existe_Perfil(string sIdperfil)
        {
            return oDL_Sis_Usuario.Existe_Perfil(sIdperfil);
        }

        #endregion

        #region Operaciones
        public void Grabar(string sIdUsuario, string sIdPerfil)
        {
            oDL_Sis_Usuario.Grabar(sIdUsuario, sIdPerfil);
        }
        public void Modificar_Contraseña(string sIdusuario, string sContraseña)
        {
            oDL_Sis_Usuario.Modificar_Contraseña(sIdusuario, sContraseña);
        }
        public void Eliminar(string sIdUsuario)
        {
            oDL_Sis_Usuario.Eliminar(sIdUsuario);
        }

        #endregion

    }
}
