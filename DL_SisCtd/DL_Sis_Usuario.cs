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
            sSql = "select 	a.IdUsuario, a.Nombre,a.IdEmpleado, b.Descripcion as Perfil,Correo,";
            sSql += "       case when Estado=1 then '' else 'I' end as Estado, ";
            sSql += "       a.FechaRegistro,a.HoraRegistro,a.UsuarioRegistro ";
            sSql += "from 	sis_usuario a ";
            sSql += "       left join sis_Perfil b on a.IdPerfil=b.Idperfil ";
            sSql += "where  a.idperfil<>'00' and a.Nombre like '%" + sNombre + "%'";
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
        public DataTable Buscar()
        {
            sSql = "select 	idusuario as Codigo,Nombre as Descripcion ";
            sSql += "from 	sis_usuarios ";
            sSql += "where  Estado=1 ";
            sSql += "order by Nombre ";
            return ConexionDAO.fDatatable(sSql);
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
            return (Get_Usuario(sIdusuario) != null ? true : false);
        }
        public Boolean Existe_Perfil(string sIdperfil)
        {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from sis_usuario where idperfil ='" + sIdperfil + "' "));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_Usuario_Empresa(string sIdUsuario, string sEmpresa)
        {
            if  (sIdUsuario.ToUpper() == "ADMIN")
            {
               return false;
            }
            else
            {
            int nCant = Convert.ToInt32(ConexionDAO.fEscalar("select count(*) from Sis_UsuarioCliente where idUsuario ='" + sIdUsuario + "' and idCliente = '"+ sEmpresa +"' "));
            return (nCant > 0 ? false : true);
            }

            
        }

        public string Get_IdOficina(string sIdUsuario)
        {
            sSql = "select	b.IdOficina ";
            sSql += "from   Sis_Usuario a  ";
            sSql += "       inner join T_Empleado b on a.IdEmpleado=b.IdEmpleado ";
            sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdUsuario='" + sIdUsuario + "' ";

            return Convert.ToString(ConexionDAO.fEscalar(sSql));
        }
        public string Get_IdEmpleado(string sIdUsuario)
        {
            sSql = "select	IdEmpleado ";
            sSql += "from   Sis_Usuario ";
            sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdUsuario='" + sIdUsuario + "' ";

            return Convert.ToString(ConexionDAO.fEscalar(sSql));
        }
        #endregion

        #region Operaciones
        protected virtual BE_Sis_Usuario Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Usuario oBE_Sis_Usuario = new BE_Sis_Usuario();

            oBE_Sis_Usuario.IdUsuario = dt.Rows[0]["IdUsuario"].ToString().Trim();
            oBE_Sis_Usuario.Nombre = dt.Rows[0]["Nombre"].ToString().Trim();
            oBE_Sis_Usuario.IdEmpleado = dt.Rows[0]["IdEmpleado"].ToString().Trim();
            oBE_Sis_Usuario.IdPerfil = dt.Rows[0]["IdPerfil"].ToString().Trim();
            oBE_Sis_Usuario.Correo = dt.Rows[0]["Correo"].ToString().Trim();
            oBE_Sis_Usuario.Contraseña = dt.Rows[0]["Contraseña"].ToString().Trim();

            oBE_Sis_Usuario.Estado = (Boolean)dt.Rows[0]["Estado"];
            oBE_Sis_Usuario.FechaRegistro =(DateTime) dt.Rows[0]["FechaRegistro"];
            oBE_Sis_Usuario.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_Sis_Usuario.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_Sis_Usuario;
        }
        public void Insertar(BE_Sis_Usuario oBE_Sis_Usuario)
        {
            sSql = "insert into Sis_Usuario values ";
            sSql += "(";
            sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
            sSql += "'" + oBE_Sis_Usuario.IdUsuario + "',";
            sSql += "'" + oBE_Sis_Usuario.Nombre + "', ";
            sSql += "'" + oBE_Sis_Usuario.IdEmpleado + "', ";
            sSql += "'" + oBE_Sis_Usuario.IdPerfil + "', ";
            sSql += "'" + oBE_Sis_Usuario.Correo + "', ";
            sSql += "'" + oBE_Sis_Usuario.Contraseña + "', ";
            sSql += "'" + (oBE_Sis_Usuario.Estado ? "1" : "0") + "',";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar(BE_Sis_Usuario oBE_Sis_Usuario)
        {
            sSql = "update  Sis_Usuario set ";
            sSql += "       Nombre='" + oBE_Sis_Usuario.Nombre + "', ";
            sSql += "       IdEmpleado='" + oBE_Sis_Usuario.IdEmpleado + "', ";
            sSql += "       IdPerfil='" + oBE_Sis_Usuario.IdPerfil + "', ";
            sSql += "       Correo='" + oBE_Sis_Usuario.Correo + "', ";
            sSql += "       Estado='" + (oBE_Sis_Usuario.Estado ? "1" : "0") + "' ";
            sSql += "where  IdUsuario='" + oBE_Sis_Usuario.IdUsuario + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdUsuario)
        {
            sSql = "delete from Sis_Usuario where IdUsuario = '" + sIdUsuario + "'  ";
            ConexionDAO.fExecute(sSql);
        }
        public void Modificar_Contraseña(string sContraseña)
        {
            sSql = "update	Sis_Usuario ";
            sSql += "set	Contraseña ='" + sContraseña + "' ";
            sSql += "where	idusuario = '" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "' ";
            ConexionDAO.fExecute(sSql);
            BE_Helper.oBE_Sis_Usuario.Contraseña = sContraseña;
        }
        public void Resetear_Contraseña(string sIdUsuario, string sContraseña)
        {
            sSql = "update	Sis_Usuario ";
            sSql += "set	Contraseña ='" + sContraseña + "' ";
            sSql += "where	idusuario = '" + sIdUsuario + "' ";
            ConexionDAO.fExecute(sSql);
            BE_Helper.oBE_Sis_Usuario.Contraseña = sContraseña;
        }

        #endregion
    }
}
