using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BESisCtd;
using System.Data.SqlClient;
namespace DLSisCtd
{
    public class DL_Reg_Control
    {
        string sSql;

        #region Listados
        public DataTable Listar(string sNroDocumento, string sRazonSocial,string sEstado)
        {
            if (sEstado == "Total") sEstado = "";
            return ConexionDAO.fDatatable("List_Reg_Control", BE_Helper.oBE_Sis_Cliente.IdCliente, sNroDocumento, sRazonSocial, sEstado);
        }

        public DataTable Listar_Detalle(Int32 nIdControl )
        {
            return ConexionDAO.fDatatable("List_Reg_ControlDetalle", BE_Helper.oBE_Sis_Cliente.IdCliente, nIdControl);
        }


        #endregion

        #region Obtener Valores
        public BE_Reg_Control Get_Control(Int32 nIdControl)
        {
            sSql = "select  * from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + nIdControl.ToString() + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(Int32 nIdControl)
        {
            return (Get_Control(nIdControl) != null ? true : false);
        }

        public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "select  count(*) from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
            sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }
        public Boolean Existe_Imagen(Int32 nIdControl)
        {
            sSql = "select  count(*) from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + nIdControl.ToString() + "' and ";
            sSql += "       IdImagen <> '' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }
        public BE_Reg_ControlImagenes Get_Reg_ControlImagenes(string sIdCliente, string sIdImagen)
        {
            BE_Reg_ControlImagenes oBE_Reg_ControlImagenes  = new BE_Reg_ControlImagenes();
            sSql = "select * from Reg_ControlImagenes where IdCliente='" + sIdCliente + "' and IdImagen='" + sIdImagen + "' ";
            SqlDataReader reader = ConexionDAO.fSqlDataReader(sSql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    oBE_Reg_ControlImagenes.IdCliente = reader.GetString(reader.GetOrdinal("IdCliente"));
                    oBE_Reg_ControlImagenes.Idimagen = reader.GetString(reader.GetOrdinal("Idimagen"));
                    oBE_Reg_ControlImagenes.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    oBE_Reg_ControlImagenes.Archivo = (byte[])reader["Archivo"];
                    oBE_Reg_ControlImagenes.PesoArchivo = reader.GetInt32(reader.GetOrdinal("PesoArchivo"));
                    oBE_Reg_ControlImagenes.ExtensionImagen = reader.GetString(reader.GetOrdinal("ExtensionImagen"));
                    oBE_Reg_ControlImagenes.Estado = reader.GetBoolean(reader.GetOrdinal("Estado"));
                }
            }
            reader.Dispose(); reader = null;
            return oBE_Reg_ControlImagenes;
        }
        #endregion

        #region Operaciones
        protected virtual BE_Reg_Control Make(DataTable dt)
        {
            if (dt.Rows.Count <= 0) return null;

            BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();
            oBE_Reg_Control.IdCliente = dt.Rows[0]["IdCliente"].ToString().Trim();
            oBE_Reg_Control.IdControl = (Int32)dt.Rows[0]["IdControl"];
            oBE_Reg_Control.IdTipoDocumento = dt.Rows[0]["IdTipoDocumento"].ToString().Trim();
            oBE_Reg_Control.IdMaestroCliente = dt.Rows[0]["IdMaestroCliente"].ToString().Trim();
            oBE_Reg_Control.NroDocumento = dt.Rows[0]["NroDocumento"].ToString().Trim();
            oBE_Reg_Control.FechaDocumento = (DateTime)dt.Rows[0]["FechaDocumento"];
            oBE_Reg_Control.Observacion = dt.Rows[0]["Observacion"].ToString().Trim();
            if (dt.Rows[0]["FechaInicio"].ToString() != "") oBE_Reg_Control.FechaInicio = (DateTime)dt.Rows[0]["FechaInicio"];
            if (dt.Rows[0]["FechaTermino"].ToString() != "") oBE_Reg_Control.FechaTermino = (DateTime)dt.Rows[0]["FechaTermino"];
            oBE_Reg_Control.Estado = dt.Rows[0]["Estado"].ToString().Trim();
            oBE_Reg_Control.IdRuta = dt.Rows[0]["IdRuta"].ToString().Trim();
            oBE_Reg_Control.FechaRegistro = (DateTime)dt.Rows[0]["FechaRegistro"];
            oBE_Reg_Control.HoraRegistro = dt.Rows[0]["HoraRegistro"].ToString().Trim();
            oBE_Reg_Control.UsuarioRegistro = dt.Rows[0]["UsuarioRegistro"].ToString().Trim();
            return oBE_Reg_Control;
        }
        public Int32 Insertar(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    Int32 nIdControl= Convert.ToInt32(ConexionDAO.fEscalar("Insert_Reg_Control",
                        BE_Helper.oBE_Sis_Cliente.IdCliente,
                        oBE_Reg_Control.IdTipoDocumento,
                        oBE_Reg_Control.IdRuta,
                        oBE_Reg_Control.IdMaestroCliente,
                        oBE_Reg_Control.NroDocumento,
                        oBE_Reg_Control.FechaDocumento,
                        oBE_Reg_Control.Observacion,
                        oBE_Reg_Control.Estado,
                        BE_Helper.oBE_Sis_Usuario.IdUsuario));
                    sTrans.Commit();
                    return nIdControl;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Modificar(BE_Reg_Control oBE_Reg_Control)
        {
            ConexionDAO.fExecute("Update_Reg_Control",
                BE_Helper.oBE_Sis_Cliente.IdCliente,
                oBE_Reg_Control.IdControl,
                oBE_Reg_Control.IdTipoDocumento,
                oBE_Reg_Control.IdMaestroCliente,
                oBE_Reg_Control.NroDocumento,
                oBE_Reg_Control.FechaDocumento,
                oBE_Reg_Control.Observacion,
                oBE_Reg_Control.Estado,
                oBE_Reg_Control.IdRuta,
                BE_Helper.oBE_Sis_Usuario.IdUsuario);
        }


        public void Eliminar(string sIdTipoDocumento)
        {
            sSql = "delete  from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'  ";
            ConexionDAO.fExecute(sSql);
            sSql = "delete  from T_TipoDocumento ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdTipoDocumento = '" + sIdTipoDocumento + "'  ";
            ConexionDAO.fExecute(sSql);
        }

        public string Insertar_Archivo(BE_Reg_ControlImagenes oBE_Reg_ControlImagenes, int nIdControl)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    string sIdImagen = Convert.ToString(SqlHelper.ExecuteScalar(sTrans,"Insert_Reg_ControlImagenes",
                        BE_Helper.oBE_Sis_Cliente.IdCliente,
                        oBE_Reg_ControlImagenes.Nombre,
                        oBE_Reg_ControlImagenes.Archivo,
                        oBE_Reg_ControlImagenes.PesoArchivo,
                        oBE_Reg_ControlImagenes.ExtensionImagen,
                        BE_Helper.oBE_Sis_Usuario.IdUsuario,
                        nIdControl));
                    sTrans.Commit();
                    return sIdImagen;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_Archivo(int nIdControl)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select IdImagen from Reg_Control where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + nIdControl.ToString() + "'";
                    string sIdImagen = Convert.ToString(ConexionDAO.fEscalar(sSql));

                    sSql = "Update Reg_Control set IdImagen=null where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + nIdControl.ToString() + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "delete from Reg_ControlImagenes ";
                    sSql += "where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdImagen='" + sIdImagen + "'";
                    SqlHelper.ExecuteNonQuery(sTrans,CommandType.Text,sSql);



                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        //public void AgregarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    sSql = "insert into T_TipoDocumentoRuta values ";
        //    sSql += "(";
        //    sSql += "'" + BE_Helper.oBE_Sis_Cliente.IdCliente + "',";
        //    sSql += "'" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "',";
        //    sSql += "'" + oBE_T_TipoDocumentoRuta.IdRuta + "', ";
        //    sSql += "convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
        //    ConexionDAO.fExecute(sSql);
        //}

        //public void QuitarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    sSql = "delete from T_TipoDocumentoRuta ";
        //    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
        //    sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
        //    sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' "; 
        //    ConexionDAO.fExecute(sSql);
        //}
        #endregion

    }
}