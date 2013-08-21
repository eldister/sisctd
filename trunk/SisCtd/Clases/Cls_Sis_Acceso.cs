using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BESisCtd;
namespace SisCtd
{
    public class Cls_Sis_Acceso
    {
        string sSql = "";
        #region Listados
        public DataTable Listar_Usuarios(string sIdPerfil,Boolean bTodos)
        {
            sSql = "select 	a.IdUsuario, a.Nombre,a.idPerfil+' '+b.Descripcion as Perfil ";
            sSql += "from 	sis_usuario a ";
            sSql += "       left join sis_Perfil b on a.IdPerfil=b.Idperfil ";
            if (!bTodos) sSql += "where  a.idperfil='" + sIdPerfil + "'";
            sSql += "order by a.Nombre ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_UsuarioCliente(string sIdusuario)
        {
            sSql = "select	a.IdCliente,b.Descripcion ";
            sSql += "from	sis_usuariocliente a left join Sis_Cliente b on a.IdCliente=b.IdCliente ";
            sSql += "where	a.IdUsuario='" + sIdusuario + "' ";
            sSql += "order by b.Descripcion ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Menu(string sIdperfil, string sMenu)
        {
            
            if (sIdperfil == "00")
                sSql = "select *,isnull(IdMenuPadre,'') as sIdMenuPadre from Sis_Menu where Estado=1 order by Orden";
            else
            {
                if (sMenu == "Menu")
                {
                    sSql = "select *,isnull(IdMenuPadre,'') as sIdMenuPadre from Sis_Menu where Idmenu not in ";
                    sSql += "(select a.idmenu from 	Sis_MenuPerfil a left join Sis_Menu b on a.Idmenu = b.Idmenu ";
                    sSql += "where	a.Idperfil = '" + sIdperfil + "' and Agrupador=0 ) and Estado=1  ";
                    sSql += "order by orden ";
                }
                else
                {
                    sSql = "select  b.*,isnull(b.IdMenuPadre,'') as sIdMenuPadre ";
                    sSql += "from   Sis_MenuPerfil a ";
                    sSql += "       left join Sis_Menu b on a.idmenu = b.idmenu ";
                    sSql += "where	a.IdPerfil = '" + sIdperfil + "' and b.Estado=1 order by orden";
                }
            }
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Perfiles()
        {
            sSql = "select  idPerfil,";
            sSql += "       Descripcion,idPerfil+' '+Descripcion as Des ";
            sSql += "from 	Sis_Perfil ";
            sSql += "where  Idperfil<>'00' ";
            sSql += " order by descripcion ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Perfiles_Exportar()
        {
            sSql = "select  idPerfil,";
            sSql += "       Descripcion,FechaRegistro,HoraRegistro,UsuarioRegistro ";
            sSql += "from 	Sis_Perfil ";
            sSql += "where  Idperfil<>'00' ";
            sSql += " order by descripcion ";
            return Helper.fDatatable(sSql);
        }
        
        #endregion

        #region Obtener Valores
        public string Get_Acceso(string sIdperfil, string sIdmenu)
        {
            if (sIdperfil == "00")
                sSql = "select accesos from sis_menu where idmenu='" + sIdmenu + "' ";
            else
                sSql = "select accesos from Sis_menuPerfil where idmenu='" + sIdmenu + "' and idperfil='" + sIdperfil + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        public Boolean Get_Agrupador(string sIdMenu)
        {
            return Convert.ToBoolean(Helper.fEscalar("select agrupador from Sis_Menu where idMenu='" + sIdMenu + "'"));
        }
        public DataTable Get_Registro_Perfil(string sIdPerfil)
        {
            return Helper.fDatatable("select * from Sis_Perfil where idPerfil = '" + sIdPerfil + "'");
        }
        public Boolean Existe_Perfil_Usuarios(string sIdperfil)
        {
            int nCant = Convert.ToInt32(Helper.fEscalar("select count(*) from sis_usuario where idperfil ='" + sIdperfil + "' "));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_Usuario(string sIdusuario)
        {
            int nCant = Convert.ToInt32(Helper.fEscalar("select count(*) from sis_usuario where idusuario ='" + sIdusuario + "' "));
            return (nCant > 0 ? true : false);
        }
        public string Get_IdPerfilUsuario(string sIdusuario)
        {
            sSql = "select a.idPerfil+' '+b.Descripcion from Sis_Usuario a inner join Sis_Perfil b on a.IdPerfil=b.IdPerfil where a.idUsuario='" + sIdusuario + "' ";
            return Convert.ToString(Helper.fEscalar(sSql));
        }

        public Boolean Existe_UsuarioClientes(string sIdusuario)
        {
            int nCant = Convert.ToInt32(Helper.fEscalar("select count(*) from Sis_UsuarioCliente where IdUsuario ='" + sIdusuario + "' "));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_UsuarioCliente(string sIdusuario,string sIdcliente)
        {
            int nCant = Convert.ToInt32(Helper.fEscalar("select count(*) from Sis_UsuarioCliente where IdUsuario ='" + sIdusuario + "' and Idcliente='" + sIdcliente + "' "));
            return (nCant > 0 ? true : false);
        }

        public DataTable Get_Registro_Usuario(string sIdusuario)
        {
            return Helper.fDatatable("select * from Sis_Usuario where idusuario = '" + sIdusuario + "'");
        }
        #endregion

        #region Operaciones

        public string Grabar_Perfil(Helper.eOpcion qOpcion, string sIdperfil, string sDescripcion)
        {
            if (qOpcion == Helper.eOpcion.Nuevo)
            {

                sSql = "select right('00'+convert(varchar(2),max(convert(int,idperfil))+1),2) from sis_perfil ";

                sIdperfil = Convert.ToString(Helper.fEscalar(sSql));
                sSql = "insert into sis_perfil ";
                sSql += "values('" + sIdperfil + "','" + sDescripcion + "',convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }

            if (qOpcion == Helper.eOpcion.Modificar)
            {

                sSql = "update  sis_perfil	set ";
                sSql += "       descripcion='" + sDescripcion + "' ";
                sSql += "where idperfil='" + sIdperfil + "' ";

            }

            Helper.fExecute(sSql);
            return sIdperfil;
        }
        public void EliminarPerfil(string sIdperfil)
        {
            sSql = "delete from sis_menuPerfil where idperfil='" + sIdperfil + "' ";
            Helper.fExecute(sSql);
            sSql = "delete from sis_perfil where idperfil='" + sIdperfil + "' ";
            Helper.fExecute(sSql);
        }
        public void Asignar_Acceso(string sIdPerfil, string sIdMenu)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "insert into Sis_MenuPerfil ";
                    sSql += "select '" + sIdPerfil + "',IdMenu,'00000' from sis_menu where IdMenu='" + sIdMenu + "' and Estado=1 ";
                    sSql += "and IdMenu not in (select IdMenu from Sis_MenuPerfil where IdPerfil='" + sIdPerfil + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert into Sis_MenuPerfil ";
                    sSql += "select '" + sIdPerfil + "',IdMenu,'00000' from sis_menu where IdMenuPadre='" + sIdMenu + "' and Estado=1 ";
                    sSql += "and IdMenu not in (select IdMenu from Sis_MenuPerfil where IdPerfil='" + sIdPerfil + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert into Sis_MenuPerfil ";
                    sSql += "select '" + sIdPerfil + "',IdMenu,'00000' from sis_menu where IdMenu=(select isnull(IdMenuPadre,'') from sis_menu where IdMenu='" + sIdMenu + "') and Estado=1 ";
                    sSql += "and IdMenu not in (select IdMenu from Sis_MenuPerfil where IdPerfil='" + sIdPerfil + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_Acceso(string sIdPerfil, string sIdMenu)
        {
            using (SqlConnection sCn = new SqlConnection(Helper.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {

                    if (Get_Agrupador(sIdMenu))
                    {
                        sSql = "delete from sis_menuperfil ";
                        sSql += "where idperfil='" + sIdPerfil + "' and idmenu in ";
                        sSql += "(select idmenu from sis_menu ";
                        sSql += "where idmenupadre='" + sIdMenu + "') ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }
                    else
                    {
                        sSql = "select count(*) from sis_menuperfil a inner join Sis_Menu b on a.IdMenu=b.IdMenu ";
                        sSql += "where idperfil='" + sIdPerfil + "' and Estado=1 and idmenupadre=(Select IdMenuPadre from Sis_Menu where IdMenu='" + sIdMenu + "')";
                        int nItems = Convert.ToInt16(Helper.fEscalar(sSql));

                        if (nItems <= 1)
                        {
                            sSql = "delete from Sis_MenuPerfil ";
                            sSql += "where IdPerfil = '" + sIdPerfil + "' and IdMenu =(Select IdMenuPadre from Sis_Menu where IdMenu='" + sIdMenu + "') ";
                            SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                        }
                    }

                    sSql = "delete from Sis_MenuPerfil ";
                    sSql += "where IdPerfil = '" + sIdPerfil + "' and IdMenu ='" + sIdMenu + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void ModificarAcceso(string sIdperfil, string sIdMenu,string sAcceso)
        {
            sSql = "update	Sis_MenuPerfil ";
            sSql += "set 	accesos = '" + sAcceso + "' ";
            sSql += "where	idperfil = '" + sIdperfil + "' and idmenu = '" + sIdMenu + "' ";
            Helper.fExecute(sSql);
        }
        //public void AgregarUsuario(string sIdUsuario, string sIdPerfil)
        //{
        //    Cls_Sis_Sistema oSistema = new Cls_Sis_Sistema();
        //    sSql = "insert into Sis_Usuario values ";
        //    sSql += "('" + sIdUsuario + "','" + oSistema.Get_Nombre_Usuario(sIdUsuario) + "','" + sIdPerfil + "', ";
        //    sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
        //    Helper.fExecute(sSql);
        //}

        public void Modificar_Perfil_Usuario(string sIdUsuario, string sIdPerfil)
        {
            sSql = "update Sis_Usuario set ";
            sSql += "IdPerfil= '" + sIdPerfil + "' ";
            sSql += "where Idusuario='" + sIdUsuario + "' ";
            Helper.fExecute(sSql);
        }

        public void EliminarUsuario(string sIdUsuario)
        {
            sSql = "delete from Sis_Usuario ";
            sSql += "where	IdUsuario = '" + sIdUsuario + "'  ";
            Helper.fExecute(sSql);
        }

        //ClienteUsuario
        public void AgregarUsuarioCliente(string sIdUsuario, string sIdcliente)
        {
            sSql = "insert into Sis_UsuarioCliente values ";
            sSql += "('" + sIdUsuario + "','" + sIdcliente + "', ";
            sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            Helper.fExecute(sSql);
        }
        public void QuitarUsuarioCliente(string sIdUsuario,string sIdCliente)
        {
            sSql = "delete from Sis_UsuarioCliente ";
            sSql += "where	IdUsuario = '" + sIdUsuario + "' and Idcliente='" + sIdCliente + "' ";
            Helper.fExecute(sSql);
        }
        #endregion
    }
}