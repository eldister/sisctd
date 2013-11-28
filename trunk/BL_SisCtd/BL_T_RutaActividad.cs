using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_RutaActividad
    {
        DL_T_RutaActividad oDL_T_RutaActividad = new DL_T_RutaActividad();
        #region Listados
        public DataTable Listar(string sIdRuta)
        {
            return oDL_T_RutaActividad.Listar(sIdRuta);
        }
        public DataTable Listar_Actividad(string sIdRuta)
        {
            return oDL_T_RutaActividad.Listar_Actividad(sIdRuta);
        }

        //public DataTable Buscar()
        //{
        //    return oDL_T_RutaActividad.Buscar();
        //}

        #endregion

        #region Obtener Valores
        public BE_T_RutaActividad Get_RutaActividad(string sIdRuta, string sIdActividad)
        {
            return oDL_T_RutaActividad.Get_RutaActividad(sIdRuta, sIdActividad );
        }
        public Boolean Existe(string sIdRuta, string sIdActividad)
        {
            return oDL_T_RutaActividad.Existe(sIdRuta,sIdActividad);
        }
        public Boolean Existe_Actividad(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            return oDL_T_RutaActividad.Existe_Actividad(oBE_T_RutaActividad);
        }
        public int Max_Orden(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            return oDL_T_RutaActividad.Max_Orden(oBE_T_RutaActividad);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            oDL_T_RutaActividad.Insertar(oBE_T_RutaActividad);
        }
        public void Eliminar(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            oDL_T_RutaActividad.Eliminar(oBE_T_RutaActividad);
        }
        public void Subir(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            oDL_T_RutaActividad.Subir(oBE_T_RutaActividad);
        }
        public void Bajar(BE_T_RutaActividad oBE_T_RutaActividad)
        {
            oDL_T_RutaActividad.Bajar(oBE_T_RutaActividad);
        }
   
        #endregion
    }
}
