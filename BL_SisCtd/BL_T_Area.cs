using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Area
    {
        DL_T_Area oDL_T_Area = new DL_T_Area();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Area.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Area.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Area Get_Area(string sIdArea)
        {
            return oDL_T_Area.Get_Area(sIdArea);
        }
        public string Get_Descripcion(string sIdArea)
        {
            return oDL_T_Area.Get_Descripcion(sIdArea);
        }
        public string Get_IdEmpleadoResponsable(string sIdArea)
        {
            return oDL_T_Area.Get_IdEmpleadoResponsable(sIdArea);
        }
        public Boolean Existe(string sIdArea)
        {
            return oDL_T_Area.Existe(sIdArea);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Area oBE_T_Area)
        {
            oDL_T_Area.Insertar(oBE_T_Area);
        }
        public void Modificar(BE_T_Area oBE_T_Area)
        {
            oDL_T_Area.Modificar(oBE_T_Area);
        }
        public void Eliminar(string sIdArea)
        {
            oDL_T_Area.Eliminar(sIdArea);
        }

        #endregion
    }
}
