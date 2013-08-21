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
        public DataTable Listar()
        {
            return oDL_Sis_Usuario.Listar();
        }

        #endregion

        #region Obtener Valores

        public BE_Sis_Usuario Get_Usuario(string sIdUsuario)
        {
            return oDL_Sis_Usuario.Get_Usuario(sIdUsuario);
        }
        #endregion

        #region Operaciones

        public void Modificar_Contraseña(string sIdusuario, string sContraseña)
        {
            oDL_Sis_Usuario.Modificar_Contraseña(sIdusuario,sContraseña);
        }

        #endregion

    }
}
