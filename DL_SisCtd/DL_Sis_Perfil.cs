using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using System.Data.SqlClient;

namespace DLSisCtd
{
    public class DL_Sis_Perfil
    {
        string sSql;
        DL_Sis_Sistema oDL_Sis_Sistema = new DL_Sis_Sistema();
        #region Listados
        public DataTable Listar()
        {
            sSql = "select  idPerfil,";
            sSql += "       Descripcion,FechaRegistro,HoraRegistro,UsuarioRegistro ";
            sSql += "from 	Sis_Perfil ";
            sSql += "where  Idperfil<>'00' ";
            sSql += " order by descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        public DataTable Listar_Combo()
        {
            sSql = "select  idPerfil,";
            sSql += "       Descripcion,idPerfil+' '+Descripcion as Des ";
            sSql += "from 	Sis_Perfil ";
            sSql += "where  Idperfil<>'00' ";
            sSql += " order by descripcion ";
            return ConexionDAO.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores

        public BE_Sis_Perfil Get_Perfil(string sIdPerfil)
        {
            sSql = "select * from Sis_Perfil where IdPerfil = '" + sIdPerfil + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        #endregion

        #region Operaciones
        protected virtual BE_Sis_Perfil Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Sis_Perfil oBE_Sis_Perfil = new BE_Sis_Perfil();

            oBE_Sis_Perfil.IdPerfil = dt.Rows[0]["IdPerfil"].ToString().Trim();
            oBE_Sis_Perfil.Descripcion = dt.Rows[0]["Descripcion"].ToString().Trim();
            oBE_Sis_Perfil.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_Sis_Perfil.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_Sis_Perfil.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_Sis_Perfil;
        }
        public string Insertar(BE_Sis_Perfil oBE_Sis_Perfil, string sIdUsuarioTra)
        {
            sSql = "select right('00'+convert(varchar(2),max(convert(int,idperfil))+1),2) from sis_perfil ";
            string sIdperfil = Convert.ToString(ConexionDAO.fEscalar(sSql));
            sSql = "insert into sis_perfil ";
            sSql += "values('" + sIdperfil + "','" + oBE_Sis_Perfil.Descripcion + "',convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + sIdUsuarioTra + "') ";
            ConexionDAO.fExecute(sSql);
            return sIdperfil;
        }
        public void Modificar(BE_Sis_Perfil oBE_Sis_Perfil)
        {
            sSql = "update  sis_perfil	set ";
            sSql += "       descripcion='" + oBE_Sis_Perfil.Descripcion + "' ";
            sSql += "where idperfil='" + oBE_Sis_Perfil.IdPerfil + "' ";
            ConexionDAO.fExecute(sSql);
        }
        public void Eliminar(string sIdperfil)
        {
            sSql = "delete from sis_menuPerfil where idperfil='" + sIdperfil + "' ";
            ConexionDAO.fExecute(sSql);
            sSql = "delete from sis_perfil where idperfil='" + sIdperfil + "' ";
            ConexionDAO.fExecute(sSql);
        }

        public void Asignar_Acceso(string sIdPerfil, string sIdMenu)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
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
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {

                    if (oDL_Sis_Sistema.Get_Agrupador(sIdMenu))
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
                        int nItems = Convert.ToInt16(ConexionDAO.fEscalar(sSql));

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
        public void ModificarAcceso(string sIdperfil, string sIdMenu, string sAcceso)
        {
            sSql = "update	Sis_MenuPerfil ";
            sSql += "set 	accesos = '" + sAcceso + "' ";
            sSql += "where	idperfil = '" + sIdperfil + "' and idmenu = '" + sIdMenu + "' ";
            ConexionDAO.fExecute(sSql);
        }

        #endregion
    }
}
