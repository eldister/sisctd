using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using  System.Data.SqlClient;

namespace DLSisCtd
{
    public class ConexionDAO
    {

        // ----- PRODUCCION -----------------------------------------------------------------------------------------
        public static string sDBservidor = "MIGUEL-PC\\SQL2008";
        public static string sDBusuario = "sa";
        public static string sDBPassword = "123456";
        public static string sDBnombre = "bddoc";

        // ---- DESARROLLO SQL 2000---------------------------------------------------------------------------------
        //public static string sDBservidor = "10.50.93.203";
        //public static string sDBusuario = "sa";
        //public static string sDBPassword = "123456";
        //public static string sDBnombre = "BdGpd";

        public static string sConexion;

        public static void ConfigServidor()
        {
            try
            {
                sConexion = "Server=" + sDBservidor + ";Uid=" + sDBusuario + ";Pwd=" + sDBPassword + ";Database=" + sDBnombre;
            }
            catch (Exception ex) { throw ex; }
        }

        //conexiones y transacciones a base de datos
        public static DataTable fDatatable(string sSql)
        {
            DataTable Dt = new DataTable();
            ConfigServidor();
            try
            {
                SqlDataReader Dr = SqlHelper.ExecuteReader(sConexion, CommandType.Text, sSql);
                Dt.Load(Dr); Dr.Close(); Dr.Dispose();
                return Dt;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (Dt != null)
                {
                    Dt.Dispose(); Dt = null;
                }
            }
        }

        public static DataTable fDatatable(string sStore, params object[] pValores)
        {
            DataTable Dt = new DataTable();
            ConfigServidor();
            try
            {
                SqlDataReader Dr = SqlHelper.ExecuteReader(sConexion, sStore, pValores);
                Dt.Load(Dr); Dr.Close(); Dr.Dispose();
                return Dt;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (Dt != null)
                { Dt.Dispose(); Dt = null; }
            }
        }

        public static object fEscalar(string sStore, params object[] pValores)
        {
            try
            {
                return SqlHelper.ExecuteScalar(sConexion, sStore, pValores);
            }
            catch (Exception ex) { throw ex; }
        }

        public static object fEscalar(string sSql)
        {
            try
            {
                return SqlHelper.ExecuteScalar(sConexion, CommandType.Text, sSql);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void fExecute(string sStore, params object[] pValores)
        {
            try
            {
                ConfigServidor();
                SqlHelper.ExecuteNonQuery(sConexion, sStore, pValores);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void fExecute(string sSql)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(sConexion, CommandType.Text, sSql);
            }
            catch (Exception ex) { throw ex; }
        }

        public static DataTable fDatatable_Cn(string sCn, string sSql)
        {
            DataTable Dt = new DataTable();
            try
            {
                SqlDataReader Dr = SqlHelper.ExecuteReader(sCn, CommandType.Text, sSql);
                Dt.Load(Dr); Dr.Close(); Dr.Dispose();
                return Dt;
            }
            catch (Exception ex) { throw ex; }
            finally { if (Dt != null) { Dt.Dispose(); Dt = null; } }
        }
    }

}
