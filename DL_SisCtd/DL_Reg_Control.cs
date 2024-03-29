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
        //public DataTable Listar(string sIdControl, string sNroDocumento, string sRazonSocial,string sEstado)
        //{
        //    if (sEstado == "Todos") sEstado = "";
        //    return ConexionDAO.fDatatable("List_Reg_Control", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl, sNroDocumento, sRazonSocial, sEstado);
        //}
        public DataTable Listar(string sIdControl, string sNroDocumento, string sRazonSocial, string sEstado, string sOficina, string sArea, string sRuta, DateTime sDFecRec, DateTime sHFecRec, DateTime sDFecDoc, DateTime sHFecDoc)
        {
            if (sEstado == "Todos") sEstado = "";
            return ConexionDAO.fDatatable("List_Reg_Control", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl, sNroDocumento, sRazonSocial, sOficina,sArea,sRuta,sDFecRec,sHFecRec,sDFecDoc,sHFecDoc, sEstado);
        }

        public DataTable Listar_Doc(string sIdControl, string sNroDocumento, string sRazonSocial, string sArea, string sEstado)
        {
            if (sEstado == "Todos") sEstado = "";
            return ConexionDAO.fDatatable("List_Reg_ControlDoc", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl, sNroDocumento, sRazonSocial, sArea, sEstado);
        }

        public DataTable Listar_Detalle(string sIdControl, string sEstado)
        {
            return ConexionDAO.fDatatable("List_Reg_ControlDetalleN", BE_Helper.oBE_Sis_Cliente.IdCliente, sIdControl, sEstado);
        }

        public DataTable  Get_ControlImp(string sIdControl)
        {
            sSql = "select  * from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'";

            return ConexionDAO.fDatatable(sSql);

        }

        public DataTable Listar_DocumentosAnexos(string sIdControl, string sNroSecuencia)
        {
            sSql = "select b.Idimagen, b.Nombre,b.ExtensionImagen,b.PesoArchivo   from Reg_ControlDetalleAnexos a ";
            sSql += " left join Reg_ControlImagenes b on a.IdCliente = b.IdCliente and a.IdImagen  = b.Idimagen ";
            sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdControl = '" + sIdControl + "' and a.NroSecuencia = '" + sNroSecuencia + "' ";
            return ConexionDAO.fDatatable(sSql);

        }

        #endregion

        #region Obtener Valores
        public BE_Reg_Control Get_Control(string sIdControl)
        {
            sSql = "select  * from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'";

            return Make(ConexionDAO.fDatatable(sSql));

        }
        public BE_Reg_ControlDetalle Get_ControlDetalleRecepcion(string sIdControl)
        {
            sSql = "select	* ";
            sSql += "from	Reg_ControlDetalle a ";
            sSql += "       left join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "' and ISNULL(FechaDestinatario,'')='' ";
            sSql += "order by Orden ";

            BE_Reg_ControlDetalle _ControlDetalle = new BE_Reg_ControlDetalle();
            SqlDataReader reader = ConexionDAO.fSqlDataReader(sSql);
            if (reader.HasRows)
            {
                reader.Read();
                _ControlDetalle.IdControl = reader.GetString(reader.GetOrdinal("IdControl"));
                _ControlDetalle.IdActividad = reader.GetString(reader.GetOrdinal("IdActividad"));
                _ControlDetalle.NroSecuencia = reader.GetString(reader.GetOrdinal("NroSecuencia"));
                if (!reader.IsDBNull(reader.GetOrdinal("FechaRecepcion")))
                {
                    _ControlDetalle.FechaRecepcion = reader.GetDateTime(reader.GetOrdinal("FechaRecepcion"));

                    _ControlDetalle.IdOficinaRecepcion = reader.GetString(reader.GetOrdinal("IdOficinaRecepcion"));
                }
                if (!reader.IsDBNull(reader.GetOrdinal("IdOficinaRecepcion")))
                    _ControlDetalle.IdOficinaRecepcion = reader.GetString(reader.GetOrdinal("IdOficinaRecepcion"));
                _ControlDetalle.Observacion = reader.GetString(reader.GetOrdinal("Observacion"));
                _ControlDetalle.Orden = reader.GetInt32(reader.GetOrdinal("Orden"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdAreaDestinatario")))
                   _ControlDetalle.IdAreaDestinatario = reader.GetString(reader.GetOrdinal("IdAreaDestinatario"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdOficinaDestinatario")))
                   _ControlDetalle.IdOficinaDestinatario  = reader.GetString(reader.GetOrdinal("IdOficinaDestinatario"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdEmpleadoDestinatario")))
                   _ControlDetalle.IdEmpleadoDestinatario  = reader.GetString(reader.GetOrdinal("IdEmpleadoDestinatario"));

            }

            else
            {
                _ControlDetalle = null;
            }
            reader.Dispose(); reader = null;
            return _ControlDetalle;

        }
        public Boolean Existe(string sIdControl)
        {
            return (Get_Control(sIdControl) != null ? true : false);
        }

        public Boolean Empleado_Valido_Recepcion(string sIdEmpleado, string sIdActividad)
        {
            sSql = "select  count(*) from T_EmpleadoActividad ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdEmpleado = '" + sIdEmpleado + "' and ";
            sSql += "       IdActividad = '" + sIdActividad + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }

        public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            sSql = "select  count(*) from T_TipoDocumentoRuta ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdTipoDocumento = '" + oBE_T_TipoDocumentoRuta.IdTipoDocumento + "' and ";
            sSql += "       IdRuta = '" + oBE_T_TipoDocumentoRuta.IdRuta + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }
        public string Get_Imagen(string sIdControl)
        {
            sSql = "select  IdImagen from Reg_Control ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + sIdControl.ToString() + "'  ";

            return Convert.ToString(ConexionDAO.fEscalar(sSql));
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
        public Boolean Existe_Actividad(string sIdControl,string sIdActividad)
        {
            sSql = "select  count(*) from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + sIdControl + "' and ";
            sSql += "       IdActividad = '" + sIdActividad + "' ";

            return (Convert.ToInt16(ConexionDAO.fEscalar(sSql)) > 0 ? true : false);
        }
        public string Max_NroSecuencia(string sIdControl)
        {
            sSql = "select  right('0'+convert(varchar(2),max(convert(int,NroSecuencia))+1),2) from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + sIdControl + "'";

            return Convert.ToString(ConexionDAO.fEscalar(sSql));
        }
        public int Max_Orden(string sIdControl)
        {
            sSql = "select  max(orden)+1 from Reg_ControlDetalle ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
            sSql += "       IdControl = '" + sIdControl + "'";

            return Convert.ToInt16(ConexionDAO.fEscalar(sSql));
        }

        public string ActividadPendiente(string sIdControl)
        {
            sSql = "select	b.Descripcion ";
            sSql += "from	Reg_ControlDetalle a ";
            sSql += "		left join T_Actividad b on a.IdCliente=b.IdCliente and a.IdActividad=b.IdActividad ";
            sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "' and isnull(FechaRecepcion,'')<>'' and ISNULL(FechaDestinatario,'')='' ";

            return Convert.ToString(ConexionDAO.fEscalar(sSql));
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

                    sSql = "select  right('00000'+convert(varchar(5),Correlativo+1),5) ";
                    sSql += "from   T_Numeracion ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and A�o='" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "'";
                    sCorrelativo = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));
                    if (sCorrelativo == "")
                    {
                        sCorrelativo = "00001";
                        sSql = "insert  into T_Numeracion values (";
                        sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "','" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "','" + oBE_Reg_Control.IdOficinaRecepcion + "','" + sCorrelativo + "') ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }
                    else
                    {
                        sSql = "update  T_Numeracion set ";
                        sSql += "       correlativo = '" + sCorrelativo + "' ";
                        sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and A�o = '" + oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + "' and IdOficina='" + oBE_Reg_Control.IdOficinaRecepcion + "' ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    }


                    //sIdControl = oBE_Reg_Control.FechaRecepcion.ToString("yyyy") + oBE_Reg_Control.IdOficinaRecepcion.Trim() + sCorrelativo;
                    sIdControl = oBE_Reg_Control.FechaRecepcion.ToString("yy") + oBE_Reg_Control.IdOficinaRecepcion.Trim().Substring(0,1) + sCorrelativo;
                    sSql = "INSERT	INTO Reg_Control VALUES( ";
                    sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "', ";
                    sSql += "       '" + sIdControl + "', ";
                    //sSql += "       '" + oBE_Reg_Control.FechaRecepcion.ToString("yyyyMMdd HH':'mm':'s")  + "',  ";
                    sSql += " convert(varchar,getdate(),112)+' '+convert(varchar,getdate(),108), ";
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
                    sSql += "       '" + oBE_Reg_Control.CodBarra + "', ";
                    sSql += "       'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    //sSql = "insert into Reg_ControlDetalle ";
                    //sSql += "select	a.IdCliente,'" + sIdControl + "',right(0+convert(varchar(2),Orden),2),Orden, ";
                    //sSql += "       IdActividad, ";
                    //sSql += "       null,null,null,null, ";
                    //sSql += "       null,null,null,null, ";
                    //sSql += "       '',a.DuracionEnDias,'Pendiente', ";
                    //sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "' ";
                    //sSql += "from	T_RutaActividad a  ";
                    //sSql += "where	a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdRuta='" + oBE_Reg_Control.IdRuta + "' ";
                    //SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "insert into Reg_ControlDetalle ";
                    sSql += "select	a.IdCliente,'" + sIdControl + "',right(0+convert(varchar(2),Orden),2),Orden, ";
                    sSql += "       a.IdActividad, ";
                    sSql += "       a.IdOficina,b.IdEmpleadoResponsable,a.IdArea,null, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       '',a.DuracionEnDias,'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "' ";
                    sSql += "from	T_RutaActividad a  ";
                    sSql += "       left join T_Area b on a.IdArea = b.IdArea  ";
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
                    sSql += "       FechaRecepcion = convert(varchar,getdate(),112)+' '+convert(varchar,getdate(),108) ";
                    //sSql += "       FechaRecepcion='" + oBE_Reg_Control.FechaRecepcion.ToString("yyyyMMdd HH':'mm':'s") + "'  ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "' and NroSecuencia=1 ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    
                    sTrans.Commit();
                    return sIdControl;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public string Actualizar(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    string sIdControl = "";

                    sSql = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tmp009]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [dbo].[tmp009] ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "select  a.IdControl,a.NroSecuencia,b.IdAreaRecepcion,b.IdOficinaRecepcion,b.IdEmpleadoRecepcion into tmp009 ";
                    sSql += "from   Reg_ControlDetalle a";
                    sSql += "       inner join Reg_ControlDetalle b on a.IdControl = b.IdControl  and b.NroSecuencia = a.NroSecuencia + 1  ";
                    sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdControl='" + oBE_Reg_Control.IdControl + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sSql = "Update  Reg_ControlDetalle set ";
                    sSql += "       IdOficinaDestinatario=b.IdOficinaRecepcion, ";
                    sSql += "       IdEmpleadoDestinatario=b.IdEmpleadoRecepcion, ";
                    sSql += "       IdAreaDestinatario=b.IdAreaRecepcion ";
                    sSql += "from	Reg_ControlDetalle a ";
                    sSql += "        left join tmp009 b on a.IdControl = b.IdControl and a.NroSecuencia = b.NroSecuencia  ";
                    sSql += "where  a.IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and a.IdControl='" + oBE_Reg_Control.IdControl + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                    return sIdControl;
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void ActualizarCodBarra(BE_Reg_Control oBE_Reg_Control)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "update Reg_Control set ";
                    sSql += "       codbarra = '" + oBE_Reg_Control.CodBarra  + "' ";
                    sSql += "where  IdCliente = '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + oBE_Reg_Control.IdControl + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public DataTable Reporte()
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try 
                {

                    sSql = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tmp098]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [dbo].[tmp098] ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);


                    sSql = "select IdControl, min(NroSecuencia) as nrosecuencia into tmp098 ";
                    sSql += "from   Reg_ControlDetalle ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and Estado = 'Pendiente' group by idcontrol ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    sTrans.Commit();

                    sSql = "select a.*,b.NumeroDoi,b.RazonSocial,c.Descripcion as dOficina,y.IdAreaRecepcion, d.Descripcion as dArea, y.FechaRecepcion, ";
                    sSql += "       case when ISNULL(y.FechaRecepcion,'')='' then 'Recepcion' else 'Envio' end as EstadoRuta ";
                    sSql += "from reg_control a ";
                    sSql += "   left join tmp098 x on a.IdControl = x.IdControl ";
                    sSql += "   left join Reg_ControlDetalle y on a.IdCliente = y.IdCliente and a.IdControl = y.IdControl and y.NroSecuencia = x.NroSecuencia ";
                    sSql += "   left join T_MaestroCliente b on a.IdCliente = b.IdCliente  and a.IdMaestroCliente = b.IdMaestroCliente ";
                    sSql += "   left join T_Oficina c on a.IdCliente = c.IdCliente  and a.IdOficinaRecepcion  = c.Idoficina  ";
                    sSql += "   left join T_Area d on a.IdCliente = d.IdCliente and y.IdAreaRecepcion =d.IdArea  ";
                    //SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    return ConexionDAO.fDatatable(sSql);

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
        public void Eliminar(string sIdControl)
        {
            //sSql = "delete  from Reg_ControlDetalle  ";
            //sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'  ";
            //ConexionDAO.fExecute(sSql);
            //sSql = "delete  from Reg_Control  ";
            //sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'  ";
            //ConexionDAO.fExecute(sSql);

            sSql = "update Reg_ControlDetalle set estado = 'Anulado'  ";
            sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl = '" + sIdControl + "'  ";
            ConexionDAO.fExecute(sSql);
            sSql = "update Reg_Control set estado = 'Anulado'   ";
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

                    sSql = "update Reg_Control set IdImagen='" + sIdImagen + "' where IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + sIdControl + "'";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

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

        public void Agregar_Actividad(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "insert into Reg_ControlDetalle values(";
                    sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' ,'" + oBE_Reg_ControlDetalle.IdControl + "','" + oBE_Reg_ControlDetalle.NroSecuencia + "', " + oBE_Reg_ControlDetalle.Orden.ToString() + ", ";
                    sSql += "       '" + oBE_Reg_ControlDetalle.IdActividad + "', ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       null,null,null,null, ";
                    sSql += "       ''," + oBE_Reg_ControlDetalle.DuracionEnDias + ",'Pendiente', ";
                    sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                   
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }
        public void Quitar_Actividad(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "update Reg_ControlDetalle set estado = 'Anulado' ";
                    sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
                    sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
                    sSql += "       NroSecuencia = '" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";

                    //sSql = "delete  from Reg_ControlDetalle ";
                    //sSql += "where  IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and ";
                    //sSql += "       IdControl = '" + oBE_Reg_ControlDetalle.IdControl + "' and ";
                    //sSql += "       NroSecuencia = '" + oBE_Reg_ControlDetalle.NroSecuencia + "' ";

                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }
        }

        public void Recepcionar(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {
                    sSql = "Update  Reg_ControlDetalle set ";
                    sSql += "       IdOficinaRecepcion='" + oBE_Reg_ControlDetalle.IdOficinaRecepcion + "', ";
                    sSql += "       IdEmpleadoRecepcion='" + oBE_Reg_ControlDetalle.IdEmpleadoRecepcion + "', ";
                    sSql += "       IdAreaRecepcion='" + oBE_Reg_ControlDetalle.IdAreaRecepcion + "', ";
                    sSql += "       Observacion='" + oBE_Reg_ControlDetalle.Observacion + "', ";
                    sSql += "       FechaRecepcion=convert(varchar,getdate(),112)+' '+convert(varchar,getdate(),108) ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "' and NroSecuencia='" + oBE_Reg_ControlDetalle.NroSecuencia.ToString() +"' ";

                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }

        }
        public void Enviar(BE_Reg_ControlDetalle oBE_Reg_ControlDetalle, List<BE_Reg_ControlImagenes> ListaImagenes)
        {
            using (SqlConnection sCn = new SqlConnection(ConexionDAO.sConexion))
            {
                sCn.Open();
                SqlTransaction sTrans = sCn.BeginTransaction();
                try
                {

                    string sOrdent = ""; 

                    sSql = "select  count(*)  ";
                    sSql += "from   Reg_ControlDetalle ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "' ";
                    sOrdent = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, CommandType.Text, sSql));

                    if (sOrdent == oBE_Reg_ControlDetalle.NroSecuencia.ToString().Trim())
                         {
                             sSql = "Update  Reg_Control set ";
                             sSql += "       Estado='Terminado' ";
                             sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "' ";
                             SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);
                         }

                    sSql = "Update  Reg_ControlDetalle set ";
                    sSql += "       IdOficinaDestinatario='" + oBE_Reg_ControlDetalle.IdOficinaDestinatario + "', ";
                    sSql += "       IdEmpleadoDestinatario='" + oBE_Reg_ControlDetalle.IdEmpleadoDestinatario + "', ";
                    sSql += "       IdAreaDestinatario='" + oBE_Reg_ControlDetalle.IdAreaDestinatario + "', ";
                    sSql += "       Estado='Terminado', ";
                    sSql += "       FechaDestinatario=convert(varchar,getdate(),112)+' '+convert(varchar,getdate(),108) ";
                    sSql += "where	IdCliente='" + BE_Helper.oBE_Sis_Cliente.IdCliente + "' and IdControl='" + oBE_Reg_ControlDetalle.IdControl + "' and NroSecuencia='" + oBE_Reg_ControlDetalle.NroSecuencia.ToString() + "' ";
                    SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                    int nFila = 1;
                    foreach (BE_Reg_ControlImagenes Imagen in ListaImagenes)
                    {
                        string sIdImagen = Convert.ToString(SqlHelper.ExecuteScalar(sTrans, "Insert_Reg_ControlImagenes",
                        BE_Helper.oBE_Sis_Cliente.IdCliente,
                        Imagen.Nombre,
                        Imagen.Archivo,
                        Imagen.PesoArchivo,
                        Imagen.ExtensionImagen,
                        BE_Helper.oBE_Sis_Usuario.IdUsuario,
                        oBE_Reg_ControlDetalle.IdControl));

                        string sIdAnexo = nFila.ToString();
                        sSql = "INSERT	INTO Reg_ControlDetalleAnexos VALUES( ";
                        sSql += "       '" + BE_Helper.oBE_Sis_Cliente.IdCliente + "', ";
                        sSql += "       '" + oBE_Reg_ControlDetalle.IdControl + "', ";
                        sSql += "       '" + oBE_Reg_ControlDetalle.NroSecuencia.ToString() + "', ";
                        sSql += "       right('" +  sIdAnexo + "',2),  ";
                        sSql += "       '" + sIdImagen + "',  ";
                        sSql += "       convert(varchar,getdate(),112),convert(varchar,getdate(),108),'" + BE_Helper.oBE_Sis_Usuario.IdUsuario + "') ";
                        SqlHelper.ExecuteNonQuery(sTrans, CommandType.Text, sSql);

                        nFila += 1;
                    }


                    
                    sTrans.Commit();
                }
                catch (Exception ex) { sTrans.Rollback(); throw ex; }
            }

        }

        #endregion

    }
}