using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_TipoDocumento
    {
        DL_T_TipoDocumento oDL_T_TipoDocumento = new DL_T_TipoDocumento();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_TipoDocumento.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_TipoDocumento.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_TipoDocumento Get_TipoDocumento(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Get_TipoDocumento(sIdTipoDocumento);
        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Existe(sIdTipoDocumento);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            oDL_T_TipoDocumento.Insertar(oBE_T_TipoDocumento);
        }
        public void Modificar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            oDL_T_TipoDocumento.Modificar(oBE_T_TipoDocumento);
        }
        public void Eliminar(string sIdTipoDocumento)
        {
            oDL_T_TipoDocumento.Eliminar(sIdTipoDocumento);
        }

        #endregion
    }
}
