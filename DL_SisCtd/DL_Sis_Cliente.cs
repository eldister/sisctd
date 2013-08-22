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
        public DataTable Listar(string sEstado)
        {
            sSql = "select 	a.* ";
            sSql += "from 	Sis_Cliente a ";
            if (BE_Helper.oBE_Sis_Usuario.IdPerfil != "00") sSql += " inner join Sis_UsuarioCliente b on a.Idcliente=b.Idcliente and b.Idusuario='" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "'";
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
        public DataTable Buscar()
        {
            sSql = "select 	IdCliente as Codigo, Descripcion ";
            sSql += "from 	Sis_Cliente ";
            sSql += "where  Estado=1 ";
            sSql += "order by Descripcion";
            return ConexionDAO.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public BE_Sis_Cliente Get_Cliente(string sIdCliente)
        {
            sSql = "select * from Sis_Cliente where Idcliente = '" + sIdCliente + "'";

            return Make(ConexionDAO.fDatatable(sSql));

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
        protected virtual BE_Sis_Cliente Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Cliente oBE_Sis_Cliente = new BE_Sis_Cliente();

            oBE_Sis_Cliente.IdCliente = dt.Rows[0]["Idcliente"].ToString().Trim();
            oBE_Sis_Cliente.Descripcion = dt.Rows[0]["descripcion"].ToString().Trim();
            oBE_Sis_Cliente.Estado= (Boolean)dt.Rows[0]["Estado"];

            return oBE_Sis_Cliente;
        }
        public void AgregarUsuarioCliente(string sIdUsuario, string sIdcliente)
        {
            sSql = "insert into Sis_UsuarioCliente values ";
            sSql += "('" + sIdUsuario + "','" + sIdcliente + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
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
