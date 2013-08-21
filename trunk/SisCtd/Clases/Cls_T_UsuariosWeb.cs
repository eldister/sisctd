using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace SisCtd
{
    public class Cls_T_UsuariosWeb
    {
        string sSql = "";

        public string Get_Oficina(string sIdusuWeb)
        {
            sSql = "select idoficina from usuariosweb where idusuweb='" + sIdusuWeb + "' ";
            return Convert.ToString(Helper.fEscalar(sSql));

        }


    }
}