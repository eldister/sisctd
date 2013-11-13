using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Actividad
    {
        DL_T_Actividad oDL_T_Actividad = new DL_T_Actividad();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Actividad.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Actividad.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Actividad Get_Actividad(string sIdActividad)
        {
            return oDL_T_Actividad.Get_Actividad(sIdActividad);
        }
        public string Get_Descripcion(string sIdActividad)
        {
            return oDL_T_Actividad.Get_Descripcion(sIdActividad);
        }

        public Boolean Existe(string sIdActividad)
        {
            return oDL_T_Actividad.Existe(sIdActividad);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Actividad oBE_T_Actividad)
        {
            oDL_T_Actividad.Insertar(oBE_T_Actividad);
        }
        public void Modificar(BE_T_Actividad oBE_T_Actividad)
        {
            oDL_T_Actividad.Modificar(oBE_T_Actividad);
        }
        public void Eliminar(string sIdActividad)
        {
            oDL_T_Actividad.Eliminar(sIdActividad);
        }

        #endregion
    }
}
