using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_Oficina
    {
        DL_T_Oficina oDL_T_Oficina = new DL_T_Oficina();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_Oficina.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_Oficina.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_Oficina Get_Oficina(string sIdoficina)
        {
            return oDL_T_Oficina.Get_Oficina(sIdoficina);
        }
        public string Get_Descripcion(string sIdOficina)
        {
            return oDL_T_Oficina.Get_Descripcion(sIdOficina);
        }
        public Boolean Existe(string sIdoficina)
        {
            return oDL_T_Oficina.Existe(sIdoficina);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_Oficina oBE_T_Oficina)
        {
            oDL_T_Oficina.Insertar(oBE_T_Oficina);
        }
        public void Modificar(BE_T_Oficina oBE_T_Oficina)
        {
            oDL_T_Oficina.Modificar(oBE_T_Oficina);
        }
        public void Eliminar(string sIdoficina)
        {
            oDL_T_Oficina.Eliminar(sIdoficina);
        }

        #endregion
    }
}
