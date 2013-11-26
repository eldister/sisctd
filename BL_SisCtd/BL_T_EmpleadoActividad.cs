using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_EmpleadoActividad
    {
        DL_T_EmpleadoActividad oDL_T_EmpleadoActividad = new DL_T_EmpleadoActividad();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_EmpleadoActividad.Listar(sDescripcion, sEstado);
        }
        public DataTable Listar_Empleado(string sIdActividad)
        {
            return oDL_T_EmpleadoActividad.Listar_Empleado(sIdActividad);
        }

        //public DataTable Buscar()
        //{
        //    return oDL_T_EmpleadoActividad.Buscar();
        //}

        #endregion

        #region Obtener Valores
        //public BE_T_EmpleadoActividad Get_EmpleadoActividad(string sIdActividad)
        //{
        //    return oDL_T_EmpleadoActividad.Get_Actividad(sIdActividad);
        //}
        //public string Get_Descripcion(string sIdActividad)
        //{
        //    return oDL_T_Actividad.Get_Descripcion(sIdActividad);
        //}

        //public Boolean Existe(string sIdActividad)
        //{
        //    return oDL_T_Actividad.Existe(sIdActividad);
        //}
        public Boolean Existe_EmpleadoActividad(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            return oDL_T_EmpleadoActividad.Existe_EmpleadoActividad(oBE_T_EmpleadoActividad);
        }


        #endregion

        #region Operaciones
        public void Insertar(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            oDL_T_EmpleadoActividad.Insertar(oBE_T_EmpleadoActividad);
        }
        public void Eliminar(BE_T_EmpleadoActividad oBE_T_EmpleadoActividad)
        {
            oDL_T_EmpleadoActividad.Eliminar(oBE_T_EmpleadoActividad);
        }

        #endregion
    }
}
