using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_MaestroCliente
    {
        DL_T_MaestroCliente oDL_T_MaestroCliente = new DL_T_MaestroCliente();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_MaestroCliente.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_MaestroCliente.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_T_MaestroCliente Get_MaestroCliente(string sIdMaestroCliente)
        {
            return oDL_T_MaestroCliente.Get_MaestroCliente(sIdMaestroCliente);
        }
        public string Get_RazonSocial(string sIdMaestroCliente)
        {
            return oDL_T_MaestroCliente.Get_RazonSocial(sIdMaestroCliente);
        }
        public Boolean Existe(string sIdMaestroCliente)
        {
            return oDL_T_MaestroCliente.Existe(sIdMaestroCliente);
        }

        #endregion

        #region Operaciones
        public void Insertar(BE_T_MaestroCliente oBE_T_MaestroCliente)
        {
            oDL_T_MaestroCliente.Insertar(oBE_T_MaestroCliente);
        }
        public void Modificar(BE_T_MaestroCliente oBE_T_MaestroCliente)
        {
            oDL_T_MaestroCliente.Modificar(oBE_T_MaestroCliente);
        }
        public void Eliminar(string sIdMaestroCliente)
        {
            oDL_T_MaestroCliente.Eliminar(sIdMaestroCliente);
        }

        #endregion
    }
}
