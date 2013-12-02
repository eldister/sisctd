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
        public DataTable Listar(string sIdControl, string sNroDocumento, string sRazonSocial,string sEstado)
        {
            if (sEstado == "Total") sEstado = "";
            return ConexionDAO.fDatatable("List_Reg_Control", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl, sNroDocumento, sRazonSocial, sEstado);
        }

        public DataTable Listar_Detalle(string sIdControl)
        {
            return ConexionDAO.fDatatable("List_Reg_ControlDetalle", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl);
        }


        #endregion

        #region Obtener Valores
        public BE_Reg_Control Get_Control(string sIdControl)
        {
            sSql = "select  * from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public Boolean Existe(string sIdControl)
        {
            return (Get_Control(sIdControl) != null ? true : false);
        }

        public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "select  count(*) from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
            sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }
        public Boolean Existe_Imagen(string sIdControl)
        {
            sSql = "select  count(*) from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + sIdControl.ToString() + "' and ";
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
            oBE_Reg_Control.IdControl = dt.Rows[0]["IdControl"].ToString().Trim();
            oBE_Reg_Control.FechaRecepcion = (DateTime)dt.Rows[0]["FechaRecepcion"];
            oBE_Reg_Control.IdOficinaRecepcion = dt.Rows[0]["IdOficinaRecepcion"].ToString().Trim();
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

        public string Insertar(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    string sIdControl = ""; string sCorrelativo = "";

                    sSql = "select  '000000'+convert(varchar(7),Correlativo+1) ";
                    sSql += "from   T_Numeracion ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and Año='" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "'";
                    sCorrelativo = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));
                    if (sCorrelativo == "")
                    {
                        sCorrelativo = "0000001";
                        sSql = "insert  into T_Numeracion values (";
                        sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "','" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "','" + oBE_Reg_Control.IdOficinaRecepcion + "','" + sCorrelativo + "') ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }
                    else
                    {
                        sSql = "update  T_Numeracion set ";
                        sSql += "       correlativo = '" + sCorrelativo + "' ";
                        sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and Año = '" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "' ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }
                    

                    sIdControl = oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "_" + oBE_Reg_Control.IdOficinaRecepcion.Trim() + "_" + sCorrelativo;
                    sSql = "INSERT	INTO Reg_Control VALUES( ";
                    sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "', ";
                    sSql += "       '" + sIdControl + "', ";
                    sSql += "       convert(varchar,getdate(),112), ";
                    sSql += "       '" + oBE_Reg_Control.IdOficinaRecepcion + "',  ";
                    sSql += "       '" + oBE_Reg_Control.IdTipoDocumento + "',  ";
                    sSql += "       '" + oBE_Reg_Control.IdRuta + "', ";
                    sSql += "       '" + oBE_Reg_Control.IdMaestroCliente + "', ";
                    sSql += "       '" + oBE_Reg_Control.NroDocumento + "', ";
                    sSql += "       '" + oBE_Reg_Control.FechaDocumento.ToString("yyyyMMdd") + "', ";
                    sSql += "       '" + oBE_Reg_Control.Observacion + "', ";
                    sSql += "       null, ";
                    sSql += "       null, ";
                    sSql += "       null, ";
                    sSql += "       'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert into Reg_ControlDetalle ";
                    sSql += "select	a.IdCliente,'" + sIdControl + "',right(0+convert(varchar(2),Orden),2),Orden, ";
                    sSql += "       IdActividad, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       '',a.DuracionEnDias,'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "' ";
                    sSql += "from	T_RutaActividad a  ";
                    sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdRuta='" + oBE_Reg_Control.IdRuta + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "select  IdEmpleado ";
                    sSql += "from   Sis_Usuario ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdUsuario='" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "'";
                    string sIdEmpleado = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "select  IdArea ";
                    sSql += "from   T_Empleado ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdEmpleado='" + sIdEmpleado + "'";
                    string sIdArea = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "Update  Reg_ControlDetalle set ";
                    sSql += "       IdOficinaRecepcion='" + oBE_Reg_Control.IdOficinaRecepcion + "', ";
                    sSql += "       IdEmpleadoRecepcion='" + sIdEmpleado + "', ";
                    sSql += "       IdAreaRecepcion='" + sIdArea + "', ";
                    sSql += "       FechaRecepcion=convert(varchar,getdate(),112) ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "' and NroSecuencia=1 ";

                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    
                    sTrans.Commit();
                    return sIdControl;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Modificar(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "update	Reg_Control set ";
                    sSql += "       IdTipoDocumento= '" + oBE_Reg_Control.IdTipoDocumento + "',  ";
                    sSql += "       IdMaestroCliente= '" + oBE_Reg_Control.IdMaestroCliente + "', ";
                    sSql += "       NroDocumento= '" + oBE_Reg_Control.NroDocumento + "', ";
                    sSql += "       FechaDocumento= '" + oBE_Reg_Control.FechaDocumento.ToString("yyyy/MM/dd") + "', ";
                    sSql += "       Observacion= '" + oBE_Reg_Control.Observacion + "' ";
                    //sSql += "       IdRuta= @IdRuta ";
                    sSql += "where	IdCliente=@IdCliente and IdControl=@IdControl ";

                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }


        }
        public string Subir(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    string sIdControl = ""; string sCorrelativo = "";

                    sSql = "select  '000000'+convert(varchar(7),Correlativo+1) ";
                    sSql += "from   T_Numeracion ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and Año='" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "'";
                    sCorrelativo = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));
                    if (sCorrelativo == "")
                    {
                        sCorrelativo = "0000001";
                        sSql = "insert  into T_Numeracion values (";
                        sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "','" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "','" + oBE_Reg_Control.IdOficinaRecepcion + "','" + sCorrelativo + "') ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }
                    else
                    {
                        sSql = "update  T_Numeracion set ";
                        sSql += "       correlativo = '" + sCorrelativo + "' ";
                        sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and Año = '" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "' ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }


                    sIdControl = oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "_" + oBE_Reg_Control.IdOficinaRecepcion.Trim() + "_" + sCorrelativo;
                    sSql = "INSERT	INTO Reg_Control VALUES( ";
                    sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "', ";
                    sSql += "       '" + sIdControl + "', ";
                    sSql += "       convert(varchar,getdate(),112), ";
                    sSql += "       '" + oBE_Reg_Control.IdOficinaRecepcion + "',  ";
                    sSql += "       '" + oBE_Reg_Control.IdTipoDocumento + "',  ";
                    sSql += "       '" + oBE_Reg_Control.IdRuta + "', ";
                    sSql += "       '" + oBE_Reg_Control.IdMaestroCliente + "', ";
                    sSql += "       '" + oBE_Reg_Control.NroDocumento + "', ";
                    sSql += "       '" + oBE_Reg_Control.FechaDocumento.ToString("yyyyMMdd") + "', ";
                    sSql += "       '" + oBE_Reg_Control.Observacion + "', ";
                    sSql += "       null, ";
                    sSql += "       null, ";
                    sSql += "       null, ";
                    sSql += "       'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert into Reg_ControlDetalle ";
                    sSql += "select	a.IdCliente,'" + sIdControl + "',right(0+convert(varchar(2),Orden),2),Orden, ";
                    sSql += "       IdActividad, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       '',a.DuracionEnDias,'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "' ";
                    sSql += "from	T_RutaActividad a  ";
                    sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdRuta='" + oBE_Reg_Control.IdRuta + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "select  IdEmpleado ";
                    sSql += "from   Sis_Usuario ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdUsuario='" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "'";
                    string sIdEmpleado = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "select  IdArea ";
                    sSql += "from   T_Empleado ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdEmpleado='" + sIdEmpleado + "'";
                    string sIdArea = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    sSql = "Update  Reg_ControlDetalle set ";
                    sSql += "       IdOficinaRecepcion='" + oBE_Reg_Control.IdOficinaRecepcion + "', ";
                    sSql += "       IdEmpleadoRecepcion='" + sIdEmpleado + "', ";
                    sSql += "       IdAreaRecepcion='" + sIdArea + "', ";
                    sSql += "       FechaRecepcion=convert(varchar,getdate(),112) ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "' and NroSecuencia=1 ";

                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();
                    return sIdControl;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Eliminar(string sIdControl)
        {
            sSql = "delete  from Reg_ControlDetalle  ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'  ";
            ConexionDAO.fExecute(sSql);
            sSql = "delete  from Reg_Control  ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'  ";
            ConexionDAO.fExecute(sSql);
        }



        public string Insertar_Archivo(BE_Reg_ControlImagenes oBE_Reg_ControlImagenes, string sIdControl)
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
                        sIdControl));
                    sTrans.Commit();
                    return sIdImagen;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_Archivo(string sIdControl)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "select IdImagen from Reg_Control where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl.ToString() + "'";
                    string sIdImagen = Convert.ToString(ConexionDAO.fEscalar(sSql));

                    sSql = "Update Reg_Control set IdImagen=null where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl.ToString() + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "delete from Reg_ControlImagenes ";
                    sSql += "where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdImagen='" + sIdImagen + "'";
                    SqlHelper.ExecuteNonQuery(sTrans,CommandType.Text,sSql);



                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Subir(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle)
        {
            sSql = "select orden from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
            sSql += "       NroSecuencia = '" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";
            int nOrden = (Convert.ToInt16(ConexionDAO.fEscalar(sSql)));
            if (nOrden != 1)
            {
                sSql = "select  NroSecuencia from Reg_ControlDetalle ";
                sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
                sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
                sSql += "       orden = " + Convert.ToString(nOrden - 1) + " ";
                string sNroSecuencia = (Convert.ToString(ConexionDAO.fEscalar(sSql)));

                sSql = "update  Reg_ControlDetalle set orden ='" + Convert.ToString(nOrden - 1) + "' ";
                sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "'  and NroSecuencia='" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";
                ConexionDAO.fExecute(sSql);

                sSql = "update  Reg_ControlDetalle set orden ='" + Convert.ToString(nOrden) + "' ";
                sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "'  and NroSecuencia='" + sNroSecuencia + "' ";
                ConexionDAO.fExecute(sSql);
            }
        }

        public void Bajar(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle)
        {
            sSql = "select  max(orden) from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "'";
            int nCantidad = (Convert.ToInt16(ConexionDAO.fEscalar(sSql)));

            sSql = "select  orden from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
            sSql += "       NroSecuencia = '" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";
            int nOrden = (Convert.ToInt16(ConexionDAO.fEscalar(sSql)));
            if (nOrden != nCantidad)
            {
                sSql = "select  NroSecuencia from Reg_ControlDetalle ";
                sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
                sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
                sSql += "       Orden = " + Convert.ToString(nOrden + 1) + " ";
                string sNroSecuencia = (Convert.ToString(ConexionDAO.fEscalar(sSql)));

                sSql = "update Reg_ControlDetalle set orden ='" + Convert.ToString(nOrden + 1) + "' ";
                sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "'  and NroSecuencia='" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";
                ConexionDAO.fExecute(sSql);

                sSql = "update Reg_ControlDetalle set orden ='" + Convert.ToString(nOrden) + "' ";
                sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "'  and NroSecuencia='" + sNroSecuencia + "' ";
                ConexionDAO.fExecute(sSql);
            }

        }

        #endregion

    }
}