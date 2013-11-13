using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Posicion
    {
        DL_T_Posicion oDL_T_Posicion = new DL_T_Posicion();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Posicion.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Posicion.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Posicion Get_Posicion(string sIdPosicion)
        {
            return oDL_T_Posicion.Get_Posicion(sIdPosicion);
        }
        public string Get_Descripcion(string sIdPosicion)
        {
            return oDL_T_Posicion.Get_Descripcion(sIdPosicion);
        }
        public Boolean Existe(string sIdPosicion)
        {
            return oDL_T_Posicion.Existe(sIdPosicion);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Posicion oBE_T_Posicion)
        {
            oDL_T_Posicion.Insertar(oBE_T_Posicion);
        }
        public void Modificar(BE_T_Posicion oBE_T_Posicion)
        {
            oDL_T_Posicion.Modificar(oBE_T_Posicion);
        }
        public void Eliminar(string sIdPosicion)
        {
            oDL_T_Posicion.Eliminar(sIdPosicion);
        }

        #endregion
    }
}
