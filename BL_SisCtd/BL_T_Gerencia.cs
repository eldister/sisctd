using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Gerencia
    {
        DL_T_Gerencia oDL_T_Gerencia = new DL_T_Gerencia();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Gerencia.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Gerencia.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Gerencia Get_Gerencia(string sIdGerencia)
        {
            return oDL_T_Gerencia.Get_Gerencia(sIdGerencia);
        }
        public Boolean Existe(string sIdGerencia)
        {
            return oDL_T_Gerencia.Existe(sIdGerencia);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Gerencia oBE_T_Gerencia)
        {
            oDL_T_Gerencia.Insertar(oBE_T_Gerencia);
        }
        public void Modificar(BE_T_Gerencia oBE_T_Gerencia)
        {
            oDL_T_Gerencia.Modificar(oBE_T_Gerencia);
        }
        public void Eliminar(string sIdGerencia)
        {
            oDL_T_Gerencia.Eliminar(sIdGerencia);
        }

        #endregion
    }
}
