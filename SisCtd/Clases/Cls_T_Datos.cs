using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_T_Datos
    {
        #region Vaiables
        string sSql = "";
        #endregion

        #region Listado

        public DataTable Listar(string sFiltro, string sValor, int nEreg)
        {
            sSql = "select 	Iddato as Id,Descripcion, ";
            sSql += "       case when estado=0 then 'I' else '' end as Est, ";
            sSql += "       FechaRegistro as [Fecha Registro], ";
            sSql += "       Horaregistro as [Hora Registro], ";
            sSql += "       rtrim(UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       Iddato+' - '+descripcion as Des ";
            sSql += "from 	T_Datos ";
            sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "Iddato" : "descripcion") + " like '%" + sValor + "%' ";
            if (nEreg == 0) sSql += "and estado=1 ";
            if (nEreg == 1) sSql += "and estado=0 ";
            sSql += "order by " + (sFiltro == "C" ? "Iddato" : "descripcion");
            return Helper.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores

        public DataTable Get_Registro(string sIddato)
        {
            return Helper.fDatatable("select * from T_datos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente +"' and Iddato='" + sIddato + "'");
        }
        public Boolean Existe(string sIddato)
        {
            return Get_Registro(sIddato).Rows.Count > 0 ? true : false;
        }
        public string Get_Descripcion(string sIddato)
        {
            sSql = "select descripcion from T_datos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Iddato='" + sIddato + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }
        //Validaciones para Eliminacion
        public Boolean Existe_Productos(string sIddato)
        {
            sSql = "select count(*) from prodocd where iddato='" + sIddato + "'";
            int nCant = Convert.ToInt32(Helper.fEscalar(sSql));
            return (nCant > 0 ? true : false);
        }
        public Boolean Existe_TipoDoc(string sIddato)
        {
            sSql = "select count(*) from documd where iddato='" + sIddato + "'";
            int nCant = Convert.ToInt32(Helper.fEscalar(sSql));
            return (nCant > 0 ? true : false);
        }

        #endregion

        #region Operaciones
                
        public void Grabar(int nOpc, string sIddato, string sDescripcion, Boolean bEstado)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_datos values( ";
                sSql += "'" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIddato + "','" + sDescripcion + "','" + (bEstado == true ? "1" : "0") + "', ";
                sSql += "convert(varchar(10),getdate(),112),convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_datos set ";
                sSql += "       descripcion='" + sDescripcion + "', ";
                sSql += "       estado='" + (bEstado == true ? "1" : "0") + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and iddato='" + sIddato + "' ";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIddato)
        {
            Helper.fEscalar("delete from T_datos where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and iddato='" + sIddato + "' ");
        }

        #endregion



       
    }
}