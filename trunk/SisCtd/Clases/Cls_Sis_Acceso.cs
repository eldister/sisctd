using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BESisCtd;
using BLSisCtd;
namespace SisCtd
{
    public class Cls_Sis_Acceso
    {
        string sSql = "";
        BL_Sis_Sistema oBL_Sis_Sistema = new BL_Sis_Sistema();

        #region Listados

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


        public DataTable Get_Registro_Perfil(string sIdPerfil)
        {
            return Helper.fDatatable("select * from Sis_Perfil where idPerfil = '" + sIdPerfil + "'");
        }
        public Boolean Existe_Perfil_Usuarios(string sIdperfil)
        {
            int nCant = Convert.ToInt32(Helper.fEscalar("select count(*) from sis_usuario where idperfil ='" + sIdperfil + "' "));
            return (nCant > 0 ? true : false);
        }

        public string Get_IdPerfilUsuario(string sIdusuario)
        {
            sSql = "select a.idPerfil+' '+b.Descripcion from Sis_Usuario a inner join Sis_Perfil b on a.IdPerfil=b.IdPerfil where a.idUsuario='" + sIdusuario + "' ";
            return Convert.ToString(Helper.fEscalar(sSql));
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
                    
                    if (oBL_Sis_Sistema.Get_Agrupador(sIdMenu))
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



        #endregion
    }
}