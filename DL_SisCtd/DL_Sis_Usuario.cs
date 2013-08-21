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
        public DataTable Listar()
        {
            sSql = "select 	* ";
            sSql += "from 	Sis_Usuario ";
            sSql += "order by Nombre ";
            return ConexionDAO.fDatatable(sSql);
        }
        //public DataTable BuscarUsuarioIron(string sFiltro, string sValor)
        //{
        //    sSql = "select 	idusuario as Id_Usuario,Nombre ";
        //    sSql += "from 	sis_usuarios ";
        //    sSql += "where  descrip like '%DMS%' and ";
        //    sSql += (sFiltro == "C" ? "idusuario" : "Nombre") + " like '%" + sValor + "%' ";
        //    sSql += "order by " + (sFiltro == "C" ? "idusuario" : "Nombre");
        //    return Helper.fDatatable_Cn(Helper.sCnSisIron, sSql);
        //}


        #endregion

        #region Obtener Valores

        public BE_Sis_Usuario Get_Usuario(string sIdUsuario)
        {
            sSql = "select * from Sis_Usuario where IdUsuario = '" + sIdUsuario + "'";

            return MakeUsuario(ConexionDAO.fDatatable(sSql));

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

        public void Modificar_Contraseña(string sIdusuario, string sContraseña)
        {
            sSql = "update	Sis_Usuario ";
            sSql += "set	Contraseña ='" + sContraseña + "' ";
            sSql += "where	idusuario = '" + sIdusuario + "' ";
            ConexionDAO.fExecute(sSql);
        }
        

        #endregion
    }
}
