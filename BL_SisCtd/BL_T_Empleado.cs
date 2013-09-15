using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Empleado
    {
        DL_T_Empleado oDL_T_Empleado = new DL_T_Empleado();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Empleado.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Empleado.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Empleado Get_Empleado(string sIdEmpleado)
        {
            return oDL_T_Empleado.Get_Empleado(sIdEmpleado);
        }
        public Boolean Existe(string sIdEmpleado)
        {
            return oDL_T_Empleado.Existe(sIdEmpleado);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Empleado oBE_T_Empleado)
        {
            oDL_T_Empleado.Insertar(oBE_T_Empleado);
        }
        public void Modificar(BE_T_Empleado oBE_T_Empleado)
        {
            oDL_T_Empleado.Modificar(oBE_T_Empleado);
        }
        public void Eliminar(string sIdEmpleado)
        {
            oDL_T_Empleado.Eliminar(sIdEmpleado);
        }

        #endregion
    }
}
