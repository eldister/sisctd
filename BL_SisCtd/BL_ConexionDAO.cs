using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DLSisCtd;

namespace BLSisCtd
{
    public class BL_ConexionDAO
    {
        public static string sDBservidor = ConexionDAO.sDBservidor;
        public static string sDBnombre = ConexionDAO.sDBnombre;
        public static string sDBusuario = ConexionDAO.sDBusuario;
        public static string sDBPassword = ConexionDAO.sDBPassword;

        public static string sConexion = "Server=" + sDBservidor + ";Uid=" + sDBusuario + ";Pwd=" + sDBPassword + ";Database=" + sDBnombre;

        //SISIRON
        public static string sCnSisIron = ConexionDAO.sCnSisIron;
    }
}
