using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace SisCtd
{
    public class Cls_T_Oficinas
    {
        string sSql = "";


        #region Listados
        public DataTable Listar(string sFiltro, string sValor)
        {
            sSql = "select 	a.Idoficina as Id, ";
            sSql += "       a.descripcion as Descripción, ";
            sSql += "       a.Idterritorio as [Id. Terri.], ";
            sSql += "       b.descripcion as [Descripción Territorio], ";
            sSql += "       a.Idubigeo, ";
            sSql += "       c.descripcion as [Ubicación Geográfica], ";
            sSql += "       a.Direccion as Dirección, ";
            sSql += "       case when recojo=0 then '' else 'SI' end as Recojo, ";
            sSql += "       case when cierre=0 then '' else 'SI' end as Cierre, ";
            sSql += "       a.Fecharegistro as [Fecha Registro], ";
            sSql += "       a.HoraRegistro as [Hora Registro], ";
            sSql += "       rtrim(a.UsuarioRegistro) as [Usuario Registro], ";
            sSql += "       convert(char(10),a.Idoficina)+' '+a.descripcion as des ";
            sSql += "from 	T_Oficina a ";
            sSql += "       left join T_Territorio b on a.Idcliente=b.Idcliente and a.Idterritorio=b.Idterritorio ";
            sSql += "       left join v_Ubigeo c on a.Idubigeo=c.Idubigeo ";
            sSql += "where 	a.Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and " + (sFiltro == "C" ? "a.Idoficina" : "a.descripcion") + " like '%" + sValor + "%' ";
            sSql += "order by " + (sFiltro == "C" ? "a.Idoficina" : "a.descripcion");
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Recogidos()
        {
            sSql = "select 	Idoficina,rtrim(Idoficina)+' - '+descripcion as descripcion ";
            sSql += "from 	T_Oficina ";
            sSql += "where  Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and recojo=1 ";
            sSql += "union all ";
            sSql += "select '' as Idoficina,'(Todas las Oficinas)' as descripcion ";
            sSql += "order by Idoficina ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Procesados(string sIdoficina, int nEstadoProc)
        {
            sSql = "select	case tiprec ";
            sSql += "           when 'S' then 'Stock' ";
            sSql += "           when 'A' then 'Acumulado sin Stock' else ";
            sSql += "           dbo.FNombreMes(convert(int, mesrec)) + '/'+ añorec  ";
            sSql += "       end as Nombre, ";
            sSql += "       CONVERT(varchar(12),fecrec,103) as [Fec.Recojo], ";
            sSql += "       totfiles as [Cant. Files], ";
            sSql += "       totcont as [Cant. Contratos], ";
            sSql += "       porcontcomp as [% Contratos Completos], ";
            sSql += "       pordoccomp as [% Datos Completos],case when web=1 then 'X' else '' end as Web, ";
            sSql += "       case tiprec  ";
            sSql += "           when 'S' then '1' ";
            sSql += "           when 'A' then '2' ";
            sSql += "           when 'D' then '3' end as ord,Idoficina,tiprec,mesrec,añorec ";
            sSql += "from	t_repoficina ";
            sSql += "where	Idoficina ='" + sIdoficina + "' ";
            if (nEstadoProc == 0) sSql += " and web=0  ";
            if (nEstadoProc == 1) sSql += " and web=1  ";
            sSql += "order by 8,añorec desc,mesrec desc ";

            return Helper.fDatatable(sSql);
        }

        #endregion

        #region Obtener Valores
        public DataTable Get_Registro(string sIdoficina)
        {
            return Helper.fDatatable("select * from T_Oficina where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina='" + sIdoficina + "'");
        }
        public Boolean Existe(string sIdoficina)
        {
            return Get_Registro(sIdoficina).Rows.Count > 0 ? true : false;
        }        
        public string Get_Descripcion(string sIdoficina)
        {
            sSql = "select descripcion from T_Oficina where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina ='" + sIdoficina + "'";
            return Convert.ToString(Helper.fEscalar(sSql));
        }

        //Validaciones Para eliminar
        //Para Web
        public Boolean Existe_UsuariosWeb(string sIdoficina)
        {
            sSql = "select count(*) from Sis_UsuarioWeb where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina='" + sIdoficina + "'";
            return Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false;
        }
        public Boolean Existe_UsuWebOficinas(string sIdoficina)
        {
            sSql = "select count(*) from Sis_UsuarioWebOficina where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina='" + sIdoficina + "'";
            return Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false;
        }
        public Boolean Existe_Recojos(string sIdoficina)
        {
            sSql = "select count(*) from Reg_Recojo where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficina='" + sIdoficina + "'";
            return Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false;
        }
        public Boolean Existe_Legajos_Procedencia(string sIdoficina)
        {
            sSql = "select count(*) from Reg_Legajo where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficinaProcedencia='" + sIdoficina + "'";
            return Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false;
        }
        public Boolean Existe_Legajos_Gestora(string sIdoficina)
        {
            sSql = "select count(*) from Reg_Legajo where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and IdOficinaGestora='" + sIdoficina + "'";
            return Convert.ToInt32(Helper.fEscalar(sSql)) > 0 ? true : false;
        }
        #endregion

        #region Operaciones
        public void Grabar(int nOpc, string sIdoficina, string sDescripcion, string sIdterritorio, string sIdubigeo, string sDireccion, Boolean bRecojo, Boolean bCierre)
        {
            if (nOpc == 3)
            {
                sSql = "insert into T_Oficina ";
                sSql += "       values('" + Helper.oBE_Sis_Cliente.IdCliente + "','" + sIdoficina + "','" + sDescripcion + "','" + sIdterritorio + "', ";
                sSql += "       '" + sIdubigeo + "','" + sDireccion + "','" + (bRecojo == true ? "1" : "0") + "','" + (bCierre == true ? "1" : "0") + "', ";
                sSql += "       convert(varchar(10),getdate(),112), convert(varchar(8),getdate(),108),'" + Helper.oBE_Sis_Usuario.IdUsuario + "') ";
            }
            else
            {
                sSql = "update  T_Oficina set ";
                sSql += "       descripcion='" + sDescripcion + "',  ";
                sSql += "       Idterritorio='" + sIdterritorio + "', ";
                sSql += "       idubigeo='" + sIdubigeo + "', ";
                sSql += "       Direccion='" + sDireccion + "', ";
                sSql += "       recojo='" + (bRecojo == true ? "1" : "0") + "', ";
                sSql += "       cierre='" + (bCierre == true ? "1" : "0") + "' ";
                sSql += "where 	Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina='" + sIdoficina + "'";
            }
            Helper.fEscalar(sSql);
        }
        public void Eliminar(string sIdoficina)
        {
            Helper.fEscalar("delete from T_Oficina where Idcliente='" + Helper.oBE_Sis_Cliente.IdCliente + "' and Idoficina='" + sIdoficina + "' ");
        }

        #endregion










    }
}