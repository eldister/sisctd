using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Ruta
    {
        DL_T_Ruta oDL_T_Ruta = new DL_T_Ruta();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Ruta.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Ruta.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Ruta Get_Ruta(string sIdRuta)
        {
            return oDL_T_Ruta.Get_Ruta(sIdRuta);
        }
        public string Get_Descripcion(string sIdRuta)
        {
            return oDL_T_Ruta.Get_Descripcion(sIdRuta);
        }
        public Boolean Existe(string sIdRuta)
        {
            return oDL_T_Ruta.Existe(sIdRuta);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Ruta oBE_T_Ruta)
        {
            oDL_T_Ruta.Insertar(oBE_T_Ruta);
        }
        public void Modificar(BE_T_Ruta oBE_T_Ruta)
        {
            oDL_T_Ruta.Modificar(oBE_T_Ruta);
        }
        public void Eliminar(string sIdRuta)
        {
            oDL_T_Ruta.Eliminar(sIdRuta);
        }

        #endregion
    }
}
