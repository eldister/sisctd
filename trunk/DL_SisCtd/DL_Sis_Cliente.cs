using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
namespace DLSisCtd
{
    public class DL_Sis_Cliente
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sIdperfil,string sIdusuario, string sEstado)
        {
            sSql = "select 	a.* ";
            sSql += "from 	Sis_Cliente a ";
            if (sIdperfil != "00") sSql += " inner join Sis_UsuarioCliente b on a.Idcliente=b.Idcliente and b.Idusuario='" + sIdusuario + "'";
            if (sEstado == "A") sSql += "where a.estado=1";
            if (sEstado == "I") sSql += "where a.estado=0";
            sSql += "order by a.descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable BuscarCliente(string sFiltro, string sValor)
        {
            sSql = "select 	IdCliente,Descripcion ";
            sSql += "from 	Sis_Cliente ";
            sSql += "where  estado=1 and ";
            sSql += (sFiltro == "C" ? "idcliente" : "Descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "idcliente" : "Descripcion");
            return ConexionDAO.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores

        public BE_Sis_Cliente Get_Cliente(string sIdCliente)
        {
            sSql = "select * from Sis_Cliente where Idcliente = '" + sIdCliente + "'";

            return MakeUsuario(ConexionDAO.fDatatable(sSql));

        }

        #endregion

        #region Operaciones
        protected virtual BE_Sis_Cliente MakeUsuario(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Cliente usuario = new BE_Sis_Cliente();

            usuario.IdCliente = dt.Rows[0]["Idcliente"].ToString().Trim();
            usuario.Descripcion = dt.Rows[0]["descripcion"].ToString().Trim();
            usuario.Estado= (Boolean)dt.Rows[0]["Estado"];

            return usuario;
        }
        #endregion
    }
}
