using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Territorios
    {
        #region Variables
        string sSql = "";
        #endregion

        #region Listado
        public DataTable Listar(string sDescrip, int nEreg)
        {
            sSql = "select 	idterritorio as Id,descripcion as Descripción, ";
            sSql += "       case when Estado = 0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       idterritorio+' - '+descripcion as des ";
            sSql += "from 	T_Territorio ";
            sSql += "where 	IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and descripcion like '%" + sDescrip + "%' ";
            if (nEreg == 0) sSql += "and Estado = 1 ";
            if (nEreg == 1) sSql += "and Estado = 0 ";
            sSql += "order by idterritorio ";
            return Helper.fDatatable(sSql);
        }
        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdterri)
        {
            return Helper.fDatatable("select * from T_Territorio where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idterritorio ='" + sIdterri + "'");
        }
        public Boolean Existe(string sIdterri)
        {
            return Get_Registro(sIdterri).Rows.Count > 0 ? true : false;
        }
        public Boolean Existe_Oficinas(string sIdterri)
        {
            sSql = "select count(*) from T_Oficina where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idterritorio ='" + sIdterri + "'";
            int nCant = Convert.ToInt32(Helper.fEscalar(sSql));
            return (nCant > 0 ? true : false);
        }
        public string Get_Descrip(string sIdterri)
        {
            return Convert.ToString(Helper.fEscalar("select descripcion from T_Territorio where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idterritorio ='" + sIdterri + "'"));
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdterri, string sDescrip, Boolean bEreg)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Territorio values( '" + Helper.oBE_Sis_Cliente.IdCliente + "', ";
                sSql += "'" + sIdterri + "','" + sDescrip + "','" + (bEreg == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update T_Territorio set ";
                sSql += "       Descripcion='" + sDescrip + "', ";
                sSql += "       Estado='" + (bEreg == true ? "1" : "0") + "' ";
                sSql += "where IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idterritorio = '" + sIdterri + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdterri)
        {
            Helper.fEscalar("delete from T_Territorio where IdCliente  = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and idterritorio='" + sIdterri + "' ");
        }
        #endregion

    
    }
}