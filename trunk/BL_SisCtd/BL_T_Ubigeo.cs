using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Ubigeo
    {
        DL_T_Ubigeo oDL_T_Ubigeo = new DL_T_Ubigeo();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Ubigeo.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Ubigeo.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Ubigeo Get_Ubigeo(string sIdUbigeo)
        {
            return oDL_T_Ubigeo.Get_Ubigeo(sIdUbigeo);
        }
        public string Get_DesUbigeo(string sIdUbigeo)
        {
            return oDL_T_Ubigeo.Get_DesUbigeo(sIdUbigeo);
        }


        public Boolean Existe(string sIdUbigeo)
        {
            return oDL_T_Ubigeo.Existe(sIdUbigeo);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Ubigeo oBE_T_Ubigeo)
        {
            oDL_T_Ubigeo.Insertar(oBE_T_Ubigeo);
        }
        public void Modificar(BE_T_Ubigeo oBE_T_Ubigeo)
        {
            oDL_T_Ubigeo.Modificar(oBE_T_Ubigeo);
        }
        public void Eliminar(string sIdUbigeo)
        {
            oDL_T_Ubigeo.Eliminar(sIdUbigeo);
        }

        #endregion
    }
}
