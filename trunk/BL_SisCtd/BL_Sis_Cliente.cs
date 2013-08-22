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
        DL_Sis_Cliente oDL_Sis_Cliente = new DL_Sis_Cliente();
        #region Listados
        public DataTable Listar(string sEstado)
        {
            return oDL_Sis_Cliente.Listar(sEstado);
        }
        public DataTable Listar_UsuarioCliente(string sIdusuario)
        {
            return oDL_Sis_Cliente.Listar_UsuarioCliente(sIdusuario);
        }
        public DataTable Buscar()
        {
            return oDL_Sis_Cliente.Buscar();
        }

        #endregion

        #region Obtener Valores
        public BE_Sis_Cliente Get_Cliente(string sIdCliente)
        {
            return oDL_Sis_Cliente.Get_Cliente(sIdCliente);
        }
        public Boolean Existe_UsuarioClientes(string sIdusuario)
        {
            return oDL_Sis_Cliente.Existe_UsuarioClientes(sIdusuario);
        }
        public Boolean Existe_UsuarioCliente(string sIdusuario, string sIdcliente)
        {
            return oDL_Sis_Cliente.Existe_UsuarioCliente(sIdusuario, sIdcliente);
        }

        #endregion

        #region Operaciones
        public void AgregarUsuarioCliente(string sIdUsuario, string sIdcliente)
        {
            oDL_Sis_Cliente.AgregarUsuarioCliente(sIdUsuario, sIdcliente);
        }
        public void QuitarUsuarioCliente(string sIdUsuario, string sIdCliente)
        {
            oDL_Sis_Cliente.QuitarUsuarioCliente(sIdUsuario, sIdCliente);
        }

        #endregion
    }
}
