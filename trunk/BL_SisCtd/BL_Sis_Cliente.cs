using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_Sis_Cliente
    {

        DL_Sis_Cliente oCliente = new DL_Sis_Cliente();
        #region Listados
        public DataTable Listar(string sIdperfil, string sIdusuario, string sEstado)
        {
            return oCliente.Listar(sIdperfil, sIdusuario, sEstado);
        }
        public DataTable BuscarCliente(string sFiltro, string sValor)
        {
            return oCliente.BuscarCliente(sFiltro, sValor);
        }
        #endregion

        #region Obtener Valores

        public BE_Sis_Cliente Get_Cliente(string sIdCliente)
        {
            return oCliente.Get_Cliente(sIdCliente);
        }

        #endregion
    }
}
