using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
namespace DLSisCtd
{
    public class DL_Sis_Usuario
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sIdPerfil, Boolean bTodos)
        {
            sSql = "select 	a.IdUsuario, a.Nombre,a.idPerfil+' '+b.Descripcion as Perfil ";
            sSql += "from 	sis_usuario a ";
            sSql += "       left join sis_Perfil b on a.IdPerfil=b.Idperfil ";
            if (!bTodos) sSql += "where  a.idperfil='" + sIdPerfil + "'";
            sSql += "order by a.Nombre ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Buscar(string sFiltro, string sValor)
        {
            sSql = "select 	idusuario as Id_Usuario,Nombre ";
            sSql += "from 	sis_usuarios ";
            sSql += "where  descrip like '%DMS%' and ";
            sSql += (sFiltro == "C" ? "idusuario" : "Nombre") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "idusuario" : "Nombre");
            return ConexionDAO.fDatatable_Cn(ConexionDAO.sCnSisIron, sSql);
        }

        #endregion

        #region Obtener Valores
        public BE_Sis_Usuario Get_Usuario(string sIdUsuario)
        {
            sSql = "select * from Sis_Usuario where IdUsuario = '" + sIdUsuario + "'";

            return MakeUsuario(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdusuario)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from sis_usuario where idusuario ='" + sIdusuario + "' "));
            return (nCant > 0 ? true : false);
        }

        #endregion

        #region Operaciones
        protected virtual BE_Sis_Usuario MakeUsuario(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Usuario usuario = new BE_Sis_Usuario();

            usuario.IdUsuario = dt.Rows[0]["IdUsuario"].ToString().Trim();
            usuario.Nombre = dt.Rows[0]["Nombre"].ToString().Trim();
            usuario.IdPerfil = dt.Rows[0]["IdPerfil"].ToString().Trim();
            usuario.Correo = dt.Rows[0]["Correo"].ToString().Trim();
            usuario.Contraseña = dt.Rows[0]["Contraseña"].ToString().Trim();

            usuario.Estado = (Boolean)dt.Rows[0]["Estado"];
            usuario.FechaRegistro =(DateTime) dt.Rows[0]["FechaRegistro"];
            usuario.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            usuario.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return usuario;
        }
        public void Grabar(string sIdUsuario, string sIdPerfil)
        {
            sSql = "insert into Sis_Usuario values ";
            sSql += "('" + sIdUsuario + "','" + sIdUsuario + "','" + sIdPerfil + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + sIdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar_Contraseña(string sIdusuario, string sContraseña)
        {
            sSql = "update	Sis_Usuario ";
            sSql += "set	Contraseña ='" + sContraseña + "' ";
            sSql += "where	idusuario = '" + sIdusuario + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdUsuario)
        {
            sSql = "delete from Sis_Usuario where IdUsuario = '" + sIdUsuario + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion
    }
}
