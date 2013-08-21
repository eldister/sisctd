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
        public DataTable Listar(string sNombre, string sEstado)
        {
            sSql = "select 	a.IdUsuario, a.Nombre,b.Descripcion as Perfil,Correo,";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	sis_usuario a ";
            sSql += "       left join sis_Perfil b on a.IdPerfil=b.Idperfil ";
            sSql += "where  a.Nombre like '%" + sNombre + "%'";
            if (sEstado == "A") sSql += "and Estado=1 ";
            if (sEstado == "I") sSql += "and Estado=0 ";
            sSql += "order by a.Nombre ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_Accesos(string sIdPerfil, Boolean bTodos)
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

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdusuario)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from sis_usuario where idusuario ='" + sIdusuario + "' "));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_Perfil(string sIdperfil)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from sis_usuario where idperfil ='" + sIdperfil + "' "));
            return (nCant > 0 ? true : false);
        }
        #endregion

        #region Operaciones
        protected virtual BE_Sis_Usuario Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Usuario oBE_Sis_Usuario = new BE_Sis_Usuario();

            oBE_Sis_Usuario.IdUsuario = dt.Rows[0]["IdUsuario"].ToString().Trim();
            oBE_Sis_Usuario.Nombre = dt.Rows[0]["Nombre"].ToString().Trim();
            oBE_Sis_Usuario.IdPerfil = dt.Rows[0]["IdPerfil"].ToString().Trim();
            oBE_Sis_Usuario.Correo = dt.Rows[0]["Correo"].ToString().Trim();
            oBE_Sis_Usuario.Contraseña = dt.Rows[0]["Contraseña"].ToString().Trim();

            oBE_Sis_Usuario.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_Sis_Usuario.FechaRegistro =(DateTime) dt.Rows[0]["FechaRegistro"];
            oBE_Sis_Usuario.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_Sis_Usuario.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_Sis_Usuario;
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
