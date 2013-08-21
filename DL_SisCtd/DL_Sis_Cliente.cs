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
        public DataTable Listar_UsuarioCliente(string sIdusuario)
        {
            sSql = "select	a.IdCliente,b.Descripcion ";
            sSql += "from	sis_usuariocliente a left join Sis_Cliente b on a.IdCliente=b.IdCliente ";
            sSql += "where	a.IdUsuario='" + sIdusuario + "' ";
            sSql += "order by b.Descripcion ";
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
        public Boolean Existe_UsuarioClientes(string sIdusuario)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from Sis_UsuarioCliente where IdUsuario ='" + sIdusuario + "' "));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_UsuarioCliente(string sIdusuario, string sIdcliente)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from Sis_UsuarioCliente where IdUsuario ='" + sIdusuario + "' and Idcliente='" + sIdcliente + "' "));
            return (nCant > 0 ? true : false);
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
        public void AgregarUsuarioCliente(string sIdUsuario, string sIdcliente, string sIdusuarioTra)
        {
            sSql = "insert into Sis_UsuarioCliente values ";
            sSql += "('" + sIdUsuario + "','" + sIdcliente + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + sIdusuarioTra + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void QuitarUsuarioCliente(string sIdUsuario, string sIdCliente)
        {
            sSql = "delete from Sis_UsuarioCliente ";
            sSql += "where	IdUsuario = '" + sIdUsuario + "' and Idcliente='" + sIdCliente + "' ";
            ConexionDAO.fExecute(sSql);
        }
        #endregion
    }
}
