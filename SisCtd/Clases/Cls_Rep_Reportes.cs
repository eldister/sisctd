using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SisCtd
{
    public class Cls_Rep_Reportes
    {
        string sSql = ""; string sSp = "";
        //Reportes de Registro
        public DataTable Rep_Registro(int nOpc, string sFiltro, DateTime dFecini, DateTime dFecfin, string sMesrec, string sAñorec, string sIdofiproc, string sTiprec, string sCodbar,string sIdtiptran,string sIdrecojo)
        {
            switch (nOpc)
            {
                case 0:// LEGAJOS NL
                case 4: // INDEX IN
                    sSql = "select	a.TipoLegajo as TF, ";
                    sSql += "       a.CodigoIM as Cod_IM, ";
                    sSql += "       b.Idrecojo, ";
                    sSql += "       IdOficinaProcedencia as [Ofic. Procedencia], ";
                    sSql += "       TipoRecojo as [Tip. Recojo], ";
                    //sSql += "       tipdoc as [Tip. File], ";
                    sSql += "       FechaRecojo as [Fecha Recojo], ";
                    sSql += "       MesRecojo as [Mes Recojo], ";
                    sSql += "       AñoRecojo as [Año Recojo], ";
                    sSql += "       a.CodBarra as Caja, ";
                    sSql += "       a.NroPaquete as Paq, ";
                    //if (nOpc == 4) sSql += "case when tfileref='' then '' else tfileref+'-'+codimref end as IM_Asignado, ";
                    sSql += "       a.IdOficinaGestora as [Ofic. Gestora], ";
                    sSql += "       FechaInventario as [Fecha Invent], ";
                    sSql += "       Inventariador as Inventariador, ";
                    sSql += "       TipoCliente as TC, ";
                    sSql += "       TipoPersona as TP, ";
                    sSql += "       NumeroDoi as [Dni / Ruc], ";
                    sSql += "       ApellidoPaterno as Apepat,ApellidoMaterno as Apemat,Nombres as Nombre,RazonSocial as Razsoc, ";
                    sSql += "       NombreRazon as [Nombre / Razón Social], ";
                    //sSql += "       nomcom as [Nombre Comercial], ";
                    sSql += "       CodigoCliente as Codcli, ";
                    sSql += "       FechaDesde as Fec_Desde, ";
                    sSql += "       FechaHasta as Fec_Hasta, ";
                    sSql += "       NroFolios as Folios, ";
                    sSql += "       NroFoliosIndex as [Folios Index], ";
                    sSql += "       case when isnull(NroArchivos,0)>=1 then 'Si' else '' end as Imagen, ";
                    sSql += "       Estado as Est, ";
                    sSql += "       a.FechaRegistro as [Fecha Registro], ";
                    sSql += "       a.HoraRegistro as [Hora Registro], ";
                    sSql += "       a.UsuarioRegistro as [Usuario Registro] ";
                    /*if (nOpc == 0)*/
                    sSql += "from 	Reg_Legajo a ";
                    //if (nOpc == 4) sSql += "from 	Reg_TransmitalIndex a inner join Reg_Legajo g on a.IdCLiente = g.IdCliente and a.TipoLegajoRef and g.TipoLegajo and a.CodigoIMRef = g.CodigoIM ";
                    sSql += "       left join Reg_Transmital b on a.IdCliente = b.IdCliente and a.CodBarra = b.CodBarra and a.NroSecuencia = b.NroSecuencia ";
                    sSql += "       inner join Reg_Recojo r on b.IdCliente = r.IdCliente and b.IdRecojo = r.IdRecojo ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.TipoLegajo='" + (nOpc == 0 ? "NL" : "IN") + "' and ";
                    if (sFiltro == "F") sSql += " a.FechaRegistro between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " r.MesRecojo = '" + sMesrec + "' and r.AñoRecojo = '" + sAñorec + "' and ";
                    if (sFiltro == "C") sSql += " a.CodBarra = '" + sCodbar + "' and ";
                    sSql += "       a.IdOficinaProcedencia like '" + sIdofiproc + "%' ";
                    if (sTiprec != "") sSql += " and r.TipoRecojo = '" + sTiprec + "' ";
                    //sSql += "order by a.FechaRegistro,a.HoraRegistro";


                    break;
                case 2: // DOCUMENTOS
                    sSql = "select  c.CodBarra as Caja, ";
                    sSql += "       c.NroPaquete as Paq, ";
                    sSql += "       a.TipoLegajo as TF, ";
                    sSql += "       a.CodigoIM as Cod_IM, ";
                    sSql += "       a.NroSecuencia as Sec_Doc, ";
                    sSql += "       c.NumeroDoi as [Dni / Ruc], ";
                    sSql += "       c.NombreRazon as [Nombre / Razón Social], ";
                    sSql += "       a.IdTipoDocumento as [Tip. Doc], ";
                    sSql += "       a.FechaDocumento as [Fec. Doc], ";
                    sSql += "       a.NroDni as [Nro. Dni], ";
                    sSql += "       a.Descripcion as Descripción, ";
                    sSql += "       a.NroDocumento as [Nro. Doc], ";
                    sSql += "       a.Origen, ";
                    sSql += "       a.IdPedido,a.NroLinea, ";
                    sSql += "       a.FechaRegistro as [Fecha Registro], ";
                    sSql += "       a.HoraRegistro as [Hora Registro], ";
                    sSql += "       a.UsuarioRegistro as [Usuario Registro] ";
                    sSql += "from 	Reg_Documento a  ";
                    sSql += "       inner join Reg_Legajo c on a.IdCliente = c.IdCliente and a.TipoLegajo = c.TipoLegajo and a.CodigoIM=c.CodigoIM ";
                    sSql += "       left join Reg_Transmital t on c.IdCliente = t.IdCliente and c.CodBarra = t.CodBarra and t.NroSecuencia = c.NroSecuencia ";
                    sSql += "       inner join Reg_Recojo r on t.IdCliente = r.IdCliente and t.IdRecojo = r.IdRecojo ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and  ";
                    if (sFiltro == "F") sSql += " a.FechaRegistro between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " r.MesRecojo = '" + sMesrec + "' and r.AñoRecojo = '" + sAñorec + "' and ";
                    if (sFiltro == "C") sSql += " c.CodBarra = '" + sCodbar + "' and ";
                    sSql += "       c.IdOficinaProcedencia like '" + sIdofiproc + "%' ";
                    if (sTiprec != "") sSql += " and r.TipoRecojo ='" + sTiprec + "' ";
                    //sSql += "order by a.FechaRegistro,a.HoraRegistro";  

                    sSql += "order by a.FechaRegistro,a.HoraRegistro";
                    break;
                case 3: //DATOS
                    sSql = "select  d.CodBarra as Caja, ";
                    sSql += "       d.NroPaquete as Paq, ";
                    sSql += "       a.TipoLegajo as TF, ";
                    sSql += "       a.CodigoIM as Cod_IM, ";
                    sSql += "       a.NroSecuencia as Sec_Doc, ";
                    sSql += "       a.NroSecuenciaDato as [Sec. Dato], ";
                    sSql += "       b.IdTipoDocumento as [Tip. Doc], ";
                    sSql += "       b.FechaDocumento as [Fec. Doc], ";
                    sSql += "       a.Numero as [Nro. Dato], ";
                    sSql += "       a.NroDni as [Nro. Dni], ";
                    sSql += "       a.Descripcion as Descripción, ";
                    sSql += "       a.FechaRegistro as [Fecha Registro], ";
                    sSql += "       a.HoraRegistro as [Hora Registro], ";
                    sSql += "       a.UsuarioRegistro as [Usuario Registro] ";
                    sSql += "from 	Reg_DocumentoDato a  ";
                    sSql += "       inner join Reg_Documento b on a.IdCliente = b.IdCliente and a.TipoLegajo=b.TipoLegajo and a.CodigoIM=b.CodigoIM and a.NroSecuencia=b.NroSecuencia ";
                    sSql += "       inner join Reg_Legajo d on b.IdCliente = d.IdCliente and b.TipoLegajo=d.TipoLegajo and b.CodigoIM=d.CodigoIM ";
                    sSql += "       left join Reg_Transmital t on d.IdCliente = t.IdCliente and d.CodBarra = t.CodBarra and t.NroSecuencia = d.NroSecuencia ";
                    sSql += "       inner join Reg_Recojo r on t.IdCliente = r.IdCliente and t.IdRecojo = r.IdRecojo ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and  ";
                    if (sFiltro == "F") sSql += " a.FechaRegistro between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " r.MesRecojo = '" + sMesrec + "' and r.AñoRecojo = '" + sAñorec + "' and ";
                    if (sFiltro == "C") sSql += " d.CodBarra = '" + sCodbar + "' and ";
                    sSql += "       d.IdOficinaProcedencia like '" + sIdofiproc + "%' ";
                    if (sTiprec != "") sSql += " and r.TipoRecojo ='" + sTiprec + "' ";
                    sSql += "order by a.FechaRegistro,a.HoraRegistro";
                    break;
                case 5: // CONSOLIDADO
                    sSql += "       left join Reg_Transmital t on a.IdCliente = t.IdCliente and a.CodBarra = t.CodBarra and a.NroSecuencia = t.NroSecuencia ";
                    sSql += "       inner join Reg_Recojo r on t.IdCliente = r.IdCliente and t.IdRecojo = r.IdRecojo ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and  ";
                    if (sFiltro == "F") sSql += " a.FechaRegistro between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " r.MesRecojo = '" + sMesrec + "' and r.AñoRecojo = '" + sAñorec + "' and ";
                    if (sFiltro == "R") sSql += " r.Idrecojo='" + sIdrecojo + "' and ";
                    if (sFiltro == "C") sSql += " a.CodBarra = '" + sCodbar + "' and ";
                    sSql += "       a.IdOficinaProcedencia like '" + sIdofiproc + "%' ";
                    if (sTiprec != "") sSql += " and r.TipoRecojo = '" + sTiprec + "' ";
                    //sSql += "order by a.FechaRegistro,a.HoraRegistro";


                    sSql += "order by a.FechaRegistro,a.HoraRegistro";
                    break;
            }
            return Helper.fDatatable(sSql);
        }

        public void Gen_Datos()
        {
            Helper.fExecute("Gen_Datos");
        }

        //Reportes de Digitadores
        public DataTable Rep_Digitadores(int nOpc, int nTipo, DateTime dFecini, DateTime dFecfin, string sIdoficina, string sUreg, int nAño, string sIdtiptran)
        {
            switch (nOpc)
            {
                case 0: sSp = "Rep_Dig_Legajos"; break;
                case 1: sSp = "Rep_Dig_Operaciones"; break;
                case 2: sSp = "Rep_Dig_Documentos"; break;
            }
            DataTable Dt = new DataTable();
            if (nOpc == 1)
                Dt = Helper.fDatatable(sSp, Helper.oBE_Sis_Cliente.IdCliente,nTipo, dFecini, dFecfin, sIdoficina, sUreg, nAño, sIdtiptran);
            else
                Dt = Helper.fDatatable(sSp, Helper.oBE_Sis_Cliente.IdCliente, nTipo, dFecini, dFecfin, sIdoficina, sUreg, nAño);
            return Dt;
        }

        //Reportes de Categorizacion
        public DataTable Rep_Categorizacion(string sTipoReporte, Boolean bIndex, int nTipofile, string sMesrec, string sAñorec, Boolean bTodos, string sIdoficina)
        {
            sSql = ""; string sFil = "";

            {
                if (!bTodos) sFil += "and a.mesrec='" + sMesrec + "' and a.añorec='" + sAñorec + "'";
            }

            string sTipoFile = "";
            if (nTipofile == 0) sTipoFile = "tfile='NC' and tfileref='' ";
            if (nTipofile == 1) sTipoFile = "tfile='IN' and tfileref='' ";
            if (nTipofile == 2) sTipoFile = "tfile='IN' and tfileref<>'' ";

            switch (sTipoReporte)
            {
                case "Todos": //totales
                    sSql = "select	'Tipo I   : De 1   a 100' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a ";
                    sSql += "where	convert(int,case nfolio when '' then 1 else nfolio end) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       between 1 and 100 and  ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    sSql += " union all ";
                    sSql += "select	'Tipo II  : De 101 a 300' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a ";
                    sSql += "where	convert(int,nfolio) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       between 101 and 300 and nfolio<>'' and ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    sSql += " union all ";
                    sSql += "select	'Tipo III : De 301 a más' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a ";
                    sSql += "where	convert(int,nfolio) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       >=301 and nfolio<>'' and  ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    sSql += "       order by 1";
                    break;
                case "Oficina":
                    sSql = "select	a.idoficina,min(b.descrip) as Nombre_Oficina,'Tipo I   : De 1   a 100' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a inner join oficinas b on a.idoficina=b.idoficina ";
                    sSql += "where	convert(int,case nfolio when '' then 1 else nfolio end) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       between 1 and 100 and  ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    if (!bTodos) sSql += "and a.mesrec='" + sMesrec + "' and a.añorec='" + sAñorec + "' ";
                    sSql += " group by a.idoficina";
                    sSql += " union all ";

                    sSql += "select	a.idoficina,min(b.descrip) as Nombre_Oficina,'Tipo II  : De 101 a 300' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a inner join oficinas b on a.idoficina=b.idoficina ";
                    sSql += "where	convert(int,nfolio) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       between 101 and 300 and nfolio<>'' and ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    if (!bTodos) sSql += "and a.mesrec='" + sMesrec + "' and a.añorec='" + sAñorec + "' ";
                    sSql += " group by a.idoficina";
                    sSql += " union all ";

                    sSql += "select	a.idoficina,min(b.descrip) as Nombre_Oficina,'Tipo III : De 301 a más' as Tipo, ";
                    sSql += "       sum(case when tiprec='S' then 1 else 0 end) as Stock, ";
                    sSql += "       sum(case when tiprec='D' then 1 else 0 end) as [Dia Dia], ";
                    sSql += "       COUNT(*) as Total ";
                    sSql += "from	ingrec a inner join oficinas b on a.idoficina=b.idoficina ";
                    sSql += "where	convert(int,nfolio) ";
                    if (bIndex) sSql += "+convert(int,case nfolioindex when '' then 0 else nfolioindex end)  ";
                    sSql += "       >=301 and nfolio<>'' and  ";
                    if (sIdoficina != "") sSql += "a.idoficina = '" + sIdoficina + "' and ";
                    sSql += sTipoFile;
                    if (!bTodos) sSql += "and a.mesrec='" + sMesrec + "' and a.añorec='" + sAñorec + "' ";
                    sSql += " group by a.idoficina";
                    sSql += "       order by 1,3";

                    break;
            }
            return Helper.fDatatable(sSql);
        }

        //Reportes de Correlatividad
        public DataTable Rep_Correlativo(Int64 nIni, Int64 nFin, string sTfile)
        {
            sSql = "select	convert(numeric(10,0),a.codim) as codim ,'' as dif, ";
            sSql += "	    a.codbar, ";
            sSql += "	    a.npaque,CONVERT(varchar(10),a.freg,103) as freg,b.nombre as ureg ";
            sSql += "from	ingrec a  ";
            sSql += "	    inner join sis_usuarios b on a.ureg=b.idusuario  ";
            sSql += "where	convert(numeric(10,0),a.codim) between " + nIni.ToString() + " and " + nFin.ToString() + " and ";
            sSql += "	    tfile='" + sTfile + "' ";
            sSql += "order by 1 ";
            return Helper.fDatatable(sSql);
        }
        public void Mant_Tnume(string sCodim, string sCodimref, string sCodbar, string sNpaque, string sFreg, string sUreg)
        {
            sSql = "INSERT INTO tnume VALUES ('" + sCodim + "','" + sCodimref + "','" + sCodbar + "','" + sNpaque + "','" + sFreg + "','" + sUreg + "')";
            Helper.fExecute(sSql);
        }
        public void Del_Tnume()
        {
            Helper.fExecute("truncate table tnume");
        }
        public DataTable Rep_Tnume()
        {
            return Helper.fDatatable("select * from tnume");
        }

        //Reportes de Pedidos
        public DataTable Rep_Pedidos(string sOpcion, int nDetOpc, string sTatencion, string sTipreing, string sTpedido, string sEstado, string sFecha, DateTime dFecini, DateTime dFecfin)
        {
            string sCampos = "", sFiltro = "", sCampos2 = "", sFiltro2 = "";

            sFiltro += (sFecha == "E" ? "fpedido" : "b.fproc") + " between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
            if (sTpedido != "T") sFiltro += "and a.masivo=" + (sTpedido == "N" ? "0" : "1") + " ";
            if (sEstado != "T") sFiltro += "and b.ereg='" + sEstado + "' ";

            if (sTatencion != "T")
            {
                switch (sTatencion)
                {
                    case "S": sFiltro += "and b.tatencion='' "; break;
                    default: sFiltro += "and b.tatencion='" + sTatencion + "' "; break;
                }
            }
            sFiltro2 += (sFecha == "E" ? "bb.fpedido" : "aa.fproc") + " between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
            if (sTpedido != "T") sFiltro2 += "and bb.masivo=" + (sTpedido == "N" ? "0" : "1") + " ";

            switch (sOpcion)
            {
                case "Detallado":
                    sCampos += "select  a.Idpedido,b.Idinst,case when a.masivo=0 then 'Normal' else 'Masivo' end as Tped, ";
                    sCampos += "        a.fpedido as Fec_Pedido,a.hreg as Hora_Pedido,a.idusuario as Usuario,a.Nombre,a.idoficina as Oficina, ";
                    sCampos += "        a.obse as Obse_Cliente, ";
                    sCampos += "        b.tfile as TF,b.codim as Cod_IM, ";

                    if (nDetOpc == 4)
                    {
                        sCampos += "	    rtrim(c.idofiproc) as [Proced], ";
                        sCampos += "	    rtrim(c.idoficina) as [Gestor], ";
                    }

                    if (nDetOpc != 4)
                    {
                        sCampos += "	    rtrim(o.idofiproc) as [Proced], ";
                        sCampos += "	    rtrim(o.idoficina) as [Gestor], ";
                    }

                    // SE AGREGA ESTA COLUMNA PARA VISUALIZAR EL TIPO DE PRODUCTO
                    sCampos += "        m.idtiptran as [Producto], ";
                    // ----------------------------------------------------------

                    sCampos += "        b.numero as [Dni / Ruc], ";
                    sCampos += "        b.Nombre as [Nombre / Razón Social], ";
                    sCampos += "        case b.tpedido   when 'I' then 'Imagen' ";
                    sCampos += "                         when 'O' then 'Fisico' else ' ' end as [T.Pedido], ";
                    sCampos += "        b.ereg, ";
                    sCampos += "        b.fproc as FecProceso,b.hproc as Hora_Proceso,b.uproc as Usuario_Proceso, ";
                    if (nDetOpc != 4) sCampos += "case when b.ereg='A' then isnull(c.cant,0) else 0 end as [Qty.Imag], ";
                    sCampos += "        case b.tatencion when 'I' then 'Imagen' ";
                    sCampos += "	    		         when 'O' then 'Fisico' else ' ' end as [T.Atención], ";
                    sCampos += "        case when b.ereg='A' then isnull(b.nrofot,0) else 0 end as [Qty.Fotoc], ";
                    sCampos2 = "        b.obse as Detalle_Atención, ";
                    sCampos2 += "       a.fcierre as Fec_Cierre,a.hcierre as Hora_Cierre,a.ucierre as Usuario_Cierre, ";
                    sCampos2 += "       a.fcierrem as F_Termino_Masivo,a.hcierrem as H_Termino_Masivo,a.ucierrem as U_Termino_Masivo, ";
                    sCampos2 += "       a.Contacto,a.Area,a.Email,a.lentrega as [Lugar Entrega] ";

                    switch (nDetOpc)
                    {
                            // OPCION :: FILE
                        case 0:
                            sSql = sCampos + sCampos2;
                            sSql += "from	pedic a  ";
                            sSql += "       inner join pedid b on a.idpedido=b.idpedido  ";
                            sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim =c.codim and b.idpedido=c.idpedido and c.nrosec='' ";
                            // SE AGREGA ESTE CRUCE POR SOLICITUD DEL USUARIO --------------------------------------------
                            sSql += "       LEFT JOIN ingrec o ON o.tfile = c.tfile AND o.codim = c.codim ";
                            sSql += "       LEFT JOIN ingreman m ON m.codim = c.codim AND m.tfile = c.tfile ";
                            // -------------------------------------------------------------------------------------------
                            sSql += "where  b.tipo='F' and ";
                            sSql += sFiltro;
                            sSql += "order by a.idpedido,b.idinst ";
                            break;

                            // OPCION :: DOCUMENTOS
                        case 1:
                            sSql = sCampos;
                            sSql += "       d.nrosec as [Sec.Doc],d.ncontrato as Contrato,d.iddocu as [Tipo Doc], ";
                            sSql += "       case when d.ncontrato='' then d.descrip else e.descrip end as Descripción, ";
                            sSql += "       d.fecdoc as Fec_Doc, ";
                            sSql += sCampos2;
                            sSql += "from	pedic a ";
                            sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                            sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim=c.codim and b.nrosec=c.nrosec and b.idpedido=c.idpedido ";
                            sSql += "       left join ingredoc d on b.tfile=d.tfile and b.codim=d.codim and b.nrosec=d.nrosec ";
                            sSql += "       left join documc e on d.iddocu=e.iddocu ";

                            // SE AGREGA ESTE CRUCE POR SOLICITUD DEL USUARIO --------------------------------------------
                            sSql += "       LEFT JOIN ingrec o ON o.tfile = c.tfile AND o.codim = c.codim ";
                            sSql += "       LEFT JOIN ingreman m ON m.codim = c.codim AND m.tfile = c.tfile ";
                            // -------------------------------------------------------------------------------------------

                            sSql += "where  b.tipo='D' and ";
                            sSql += sFiltro;
                            sSql += "order by a.idpedido,b.idinst ";
                            break;
                        case 2:
                        // OPCION :: INSTRUCCION
                        case 3:
                            sSql = sCampos;
                            sSql += "		b.instruc as Instruccion, ";
                            sSql += "       d.nrosec as [Sec.Doc],d.iddocu as [Tipo Doc],d.descrip as Descripción, ";
                            sSql += "       d.fecdoc as Fec_Doc, ";
                            sSql += sCampos2;
                            sSql += "from	pedic a ";
                            sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                            sSql += "       left join ingredoc d on b.idpedido=d.idpedido and b.idinst=d.idinst ";
                            sSql += "       left join vingrecima c on d.tfile=c.tfile and d.codim =c.codim and d.nrosec=c.nrosec and d.idpedido=c.idpedido ";

                            // SE AGREGA ESTE CRUCE POR SOLICITUD DEL USUARIO --------------------------------------------
                            sSql += "       LEFT JOIN ingrec o ON o.tfile = c.tfile AND o.codim = c.codim ";
                            sSql += "       LEFT JOIN ingreman m ON m.codim = c.codim AND m.tfile = c.tfile ";
                            // -------------------------------------------------------------------------------------------

                            sSql += "where  b.tipo='" + (nDetOpc == 2 ? "I" : "E") + "' and ";
                            sSql += sFiltro;
                            sSql += "order by a.idpedido,b.idinst ";
                            break;
                        case 4:
                            sSql = sCampos;
                            sSql += "       case b.tipo when 'F' then 'File' ";
                            sSql += "                    when 'D' then 'Documento' ";
                            sSql += "                    when 'I' then 'Instrucción' ";
                            sSql += "                    when 'E' then 'Especial' end as Tipo, ";
                            sSql += "       b.instruc as Instruccion, ";
                            sSql += "       isnull(c.nfolio,'') as Folios, ";
                            sSql += "       isnull(c.nfolioindex,'') as [Folios Index], ";
                            sSql += "       case when b.tipo='D' then e.nrosec    when b.tipo='I' then g.nrosec    when b.tipo='E' then i.nrosec    end as [Sec.Doc], ";
                            sSql += "       case when b.tipo='D' then e.ncontrato when b.tipo='I' then g.ncontrato when b.tipo='E' then i.ncontrato end as [Contrato], ";
                            sSql += "       case when b.tipo='D' then e.iddocu    when b.tipo='I' then g.iddocu    when b.tipo='E' then i.iddocu    end as [Tipo Doc], ";
                            sSql += "       case when b.tipo='D' then e.descrip   when b.tipo='I' then g.descrip   when b.tipo='E' then i.descrip   end as [Descripcion], ";
                            sSql += "       case when b.ereg='A' then ";
                            sSql += "           case b.tipo when 'F' then isnull(d.cant,0) ";
                            sSql += "                       when 'D' then isnull(f.cant,0) ";
                            sSql += "                       when 'I' then isnull(h.cant,0) ";
                            sSql += "                       when 'E' then isnull(j.cant,0) end end as [Qty.Imag], ";
                            sSql += "       case when b.ereg='A' then isnull(b.nrofot,0) else 0 end as [Qty.Fotoc], ";
                            sSql += sCampos2;
                            sSql += "from	pedic a ";
                            sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                            sSql += "       left join ingrec c on b.tfile=c.tfile and b.codim=c.codim and b.tipo='F' ";
                            sSql += "       left join vingrecima d on b.tfile=d.tfile and b.codim =d.codim and b.idpedido=d.idpedido and d.nrosec='' ";
                            sSql += "       left join ingredoc e on b.tfile=e.tfile and b.codim =e.codim and b.nrosec=e.nrosec and b.tipo='D' ";
                            sSql += "       left join vingrecima f on b.tfile=f.tfile and b.codim =f.codim and b.nrosec=f.nrosec and b.idpedido=f.idpedido ";
                            sSql += "       left join ingredoc g on b.idpedido=g.idpedido and b.idinst=g.idinst and b.tipo='I' ";
                            sSql += "       left join vingrecima h on g.tfile=h.tfile and g.codim =h.codim and g.nrosec=h.nrosec ";
                            sSql += "       left join ingredoc i on b.idpedido=i.idpedido and b.idinst=i.idinst and b.tipo='E' ";
                            sSql += "       left join vingrecima j on i.tfile=j.tfile and i.codim =j.codim and i.nrosec=j.nrosec ";

                            // SE AGREGA ESTE CRUCE PARA VISUALIZAR LOS PRODUCTOS ------------------------------
                            sSql += "       left join ingreman m on m.codim = c.codim and m.tfile = c.tfile ";
                            // ---------------------------------------------------------------------------------

                            sSql += "where  b.tipo=b.tipo and ";
                            sSql += sFiltro;
                            sSql += "order by a.idpedido,b.idinst ";
                            break;
                    } break;
                case "Oficina":
                    sCampos = "         sum(case when b.ereg='A' then 1 else 0 end ) as atend, ";
                    sCampos += "        sum(case when b.ereg='N' then 1 else 0 end ) as [no atend], ";
                    sCampos += "        sum(case when b.ereg='C' then 1 else 0 end ) as [cancel], ";
                    sCampos += "        sum(case when b.ereg='L' then 1 else 0 end ) as [errado], ";
                    sCampos += "        sum(case when b.tatencion ='I' then 1 else 0 end ) as [Como Imag], ";
                    sCampos += "        sum(case when b.ereg='A' then isnull(c.cant,0) else 0 end) as [Qty.Imag], ";
                    sCampos += "        sum(case when b.tatencion ='O' then 1 else 0 end ) as [Como Orig], ";


                    sSql = "select	a.idoficina,min(d.descrip) as desofi,'Files     ' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       sum(case when b.ereg='A' then isnull(b.nrofot,0) else 0 end) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim =c.codim and b.idpedido=c.idpedido and c.nrosec='' ";
                    sSql += "       left join oficinas d on a.idoficina=d.idoficina ";
                    sSql += "where  b.tipo='F' and ";
                    sSql += sFiltro;
                    sSql += "group by a.idoficina ";
                    sSql += "union all ";
                    sSql += "select	a.idoficina,min(d.descrip) as desofi,'Documentos' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       sum(case when b.ereg='A' then isnull(b.nrofot,0) else 0 end) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim =c.codim and b.nrosec=c.nrosec and b.idpedido=c.idpedido ";
                    sSql += "       left join oficinas d on a.idoficina=d.idoficina ";
                    sSql += "where  b.tipo='D' and ";
                    sSql += sFiltro;
                    sSql += "group by a.idoficina ";
                    sSql += "union all ";
                    sSql += "select	a.idoficina,min(e.descrip) as desofi,'Instrucción' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       (select	sum(nrofot) ";
                    sSql += "       from 	pedid aa ";
                    sSql += "               inner join pedic bb on aa.idpedido=bb.idpedido ";
                    sSql += "       where 	aa.tipo='I' and ";
                    sSql += "               bb.idoficina=a.idoficina and ";
                    sSql += sFiltro2;
                    sSql += "       ) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join ingredoc d on b.idpedido=d.idpedido and b.idinst=d.idinst ";
                    sSql += "       left join vingrecima c on d.tfile=c.tfile and d.codim=c.codim and d.nrosec=c.nrosec ";
                    sSql += "       left join oficinas e on a.idoficina=e.idoficina ";
                    sSql += "where	b.tipo='I' and ";
                    sSql += sFiltro;
                    sSql += "group by a.idoficina ";
                    sSql += "union all ";
                    sSql += "select	a.idoficina,min(e.descrip) as desofi,'Especiales' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       (select	sum(nrofot) ";
                    sSql += "       from 	pedid aa ";
                    sSql += "               inner join pedic bb on aa.idpedido=bb.idpedido ";
                    sSql += "       where 	aa.tipo='E' and ";
                    sSql += "               bb.idoficina=a.idoficina and ";
                    sSql += sFiltro2;
                    sSql += "       ) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join ingredoc d on b.idpedido=d.idpedido and b.idinst=d.idinst ";
                    sSql += "       left join vingrecima c on d.tfile=c.tfile and d.codim=c.codim and d.nrosec=c.nrosec ";
                    sSql += "       left join oficinas e on a.idoficina=e.idoficina ";
                    sSql += "where	b.tipo='E' and ";
                    sSql += sFiltro;
                    sSql += "group by a.idoficina ";
                    sSql += "order by a.idoficina,3";
                    break;
                case "Total":
                    sCampos = "         sum(case when b.ereg='A' then 1 else 0 end ) as atend, ";
                    sCampos += "        sum(case when b.ereg='N' then 1 else 0 end ) as [no atend], ";
                    sCampos += "        sum(case when b.ereg='C' then 1 else 0 end ) as [cancel], ";
                    sCampos += "        sum(case when b.ereg='L' then 1 else 0 end ) as [errado], ";
                    sCampos += "        sum(case when b.tatencion ='I' then 1 else 0 end ) as [Como Imag], ";
                    sCampos += "        sum(case when b.ereg='A' then isnull(c.cant,0) else 0 end) as [Qty.Imag], ";
                    sCampos += "        sum(case when b.tatencion ='O' then 1 else 0 end ) as [Como Orig], ";

                    sSql = "select	'Files     ' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       sum(case when b.ereg='A' then isnull(b.nrofot,0) else 0 end) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim =c.codim and b.idpedido=c.idpedido and c.nrosec='' ";
                    sSql += "where  b.tipo='F' and ";
                    sSql += sFiltro;
                    sSql += "union all ";
                    sSql += "select	'Documentos' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       sum(case when b.ereg='A' then isnull(b.nrofot,0) else 0 end) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join vingrecima c on b.tfile=c.tfile and b.codim =c.codim and b.nrosec=c.nrosec and b.idpedido=c.idpedido ";
                    sSql += "where  b.tipo='D' and ";
                    sSql += sFiltro;
                    sSql += "union all ";
                    sSql += "select	'Instrucción' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       (select	sum(nrofot) ";
                    sSql += "       from 	pedid aa ";
                    sSql += "               inner join pedic bb on aa.idpedido=bb.idpedido ";
                    sSql += "       where 	aa.tipo='I' and ";
                    sSql += sFiltro2;
                    sSql += "       ) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join ingredoc d on b.idpedido=d.idpedido and b.idinst=d.idinst ";
                    sSql += "       left join vingrecima c on d.tfile=c.tfile and d.codim=c.codim and d.nrosec=c.nrosec ";
                    sSql += "where	b.tipo='I' and ";
                    sSql += sFiltro;
                    sSql += "union all ";
                    sSql += "select	'Especiales' as Tipo,count(*) as sol, ";
                    sSql += sCampos;
                    sSql += "       (select	sum(nrofot) ";
                    sSql += "       from 	pedid aa ";
                    sSql += "               inner join pedic bb on aa.idpedido=bb.idpedido ";
                    sSql += "       where 	aa.tipo='E' and ";
                    sSql += sFiltro2;
                    sSql += "       ) as [Qty.Fotoc] ";
                    sSql += "from	pedic a ";
                    sSql += "       inner join pedid b on a.idpedido=b.idpedido ";
                    sSql += "       left join ingredoc d on b.idpedido=d.idpedido and b.idinst=d.idinst ";
                    sSql += "       left join vingrecima c on d.tfile=c.tfile and d.codim=c.codim and d.nrosec=c.nrosec ";
                    sSql += "where	b.tipo='E' and ";
                    sSql += sFiltro;
                    sSql += "order by 1";
                    break;
                case "Reingreso":
                    sSql = "select	a.idmovif,a.Tipo,a.Tfile,a.CodIm,b.numero as [Dni / Ruc], ";
                    sSql += "       b.Nomraz as [Nombre / Razón Social], ";
                    sSql += "       a.nrosec as SecDoc, ";
                    sSql += "       d.iddocu as [Tipo Doc], ";
                    sSql += "       case when c.ncontrato='' then c.descrip else d.descrip end as Descripción, ";
                    sSql += "       c.fecdoc as Fec_Doc, ";
                    sSql += "       fmov as [Fec Reingreso],hmov as [Hora Reingreso],umov as [Usuario Reingreso] ";
                    sSql += "from	movif a  ";
                    sSql += "       left join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.nrosec=c.nrosec  ";
                    sSql += "       left join documc d on c.iddocu=d.iddocu ";
                    sSql += "where	tmovi='REINGRESO' and ";
                    sSql += "       fmov between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sTipreing != "T") sSql += "and a.tipo='" + sTipreing + "' ";

                    sSql += "order by idmovif ";
                    break;

                case "Pendientes":

                    sSql = "select	'F' as Tipo,a.Tfile,a.CodIm,a.numero as [Dni / Ruc], ";
                    sSql += "       a.Nomraz as [Nombre / Razón Social], ";
                    sSql += "       '' as SecDoc, ";
                    sSql += "       '' as [Tipo Doc], ";
                    sSql += "       '' Descripción, ";
                    sSql += "       null as Fec_Doc, ";
                    sSql += "       a.ereg as Est, ";
                    sSql += "       a.OrdenSkp, ";
                    sSql += "       a.fsalida as [Fec Salida], ";
                    sSql += "       IdpedidoRet ";
                    sSql += "from	ingrec a ";
                    sSql += "where	ereg<>'' and";
                    sSql += "       a.fsalida between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sTipreing == "D") sSql += "and a.ereg='X' ";
                    sSql += "union all ";
                    sSql += "select	'D' as Tipo,a.Tfile,a.CodIm,a.numero as [Dni / Ruc], ";
                    sSql += "       a.Nomraz as [Nombre / Razón Social], ";
                    sSql += "       b.nrosec as SecDoc, ";
                    sSql += "       b.iddocu as [Tipo Doc], ";
                    sSql += "       case when b.ncontrato='' then b.descrip else c.descrip end as Descripción, ";
                    sSql += "       b.fecdoc as Fec_Doc, ";
                    sSql += "       b.ereg as Est, ";
                    sSql += "       b.OrdenSkp, ";
                    sSql += "       b.fsalida as [Fec Salida], ";
                    sSql += "       b.IdpedidoRet ";
                    sSql += "from	ingrec a ";
                    sSql += "       inner join ingredoc b on a.tfile=b.tfile and a.codim=b.codim  ";
                    sSql += "       left join documc c on b.iddocu=c.iddocu ";
                    sSql += "where	b.ereg<>'' and ";
                    sSql += "       b.fsalida between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sTipreing == "F") sSql += "and b.ereg='X' ";
                    sSql += "order by [Fec Salida],Tipo desc,tfile,codim  ";
                    break;
            }
            return Helper.fDatatable(sSql);
        }

        //Reportes de Control de Calidad
        public DataTable Rep_ControlCalidad(string sReporte, Boolean bFechas, DateTime dFecIni, DateTime dFecfin, Boolean bTodos, string sMesrec, string sAñorec, string sIdoficina, string sTiprec)
        {
            string sFiltro = "";
            if (sIdoficina != "") sFiltro += "and idoficina ='" + sIdoficina + "' ";
            if (bFechas) sFiltro = "and freg between '" + dFecIni.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
            else
            { if (!bTodos) sFiltro += "and mesrec='" + sMesrec + "' and añorec='" + sAñorec + "' "; }
            if (sTiprec != "") sFiltro += "and tiprec ='" + sTiprec + "' ";

            switch (sReporte)
            {
                case "opcIgualDniDifNombre":
                    sSql = "select	numero as [Dni / Ruc], ";
                    sSql += "       nomraz as [Nombre / Razón Social], ";
                    sSql += "       Tfile,CodIm,idofiproc as [Ofi.Proc],FecRec,TipRec,MesRec,AñoRec, ";
                    sSql += "       codbar as Caja,npaque as Paq,Apepat,Apemat,Nombre,Razsoc,a.Freg,a.Hreg,a.Ureg ";
                    sSql += "from	ingrec a WITH (NOLOCK) ";
                    sSql += "       left join recojos r on a.idrecojo=r.idrecojo ";
                    sSql += "where	numero in ( ";
                    sSql += "       select	numero ";
                    sSql += "       from	ingrec nolock ";
                    sSql += "       where	nomraz<>'' and numero<>'' and left(numero,8)<>'00000000' and ";
                    sSql += "               numero in ( ";
                    sSql += "               select	numero ";
                    sSql += "               from	ingrec nolock ";
                    sSql += "               group by numero ";
                    sSql += "               having 	COUNT(numero)>1 and ";
                    sSql += "               MAX(rtrim(nomraz))<>MIN(rtrim(nomraz))) ";
                    sSql += sFiltro + ") ";
                    sSql += "order by numero,nomraz ";
                    break;
                case "opcIgualNombreDifDni":
                    sSql = "select	numero as [Dni / Ruc], ";
                    sSql += "       nomraz as [Nombre / Razón Social], ";
                    sSql += "       Tfile,CodIm,idofiproc as [Ofi.Proc],FecRec,TipRec,MesRec,AñoRec, ";
                    sSql += "       codbar as Caja,npaque as Paq,Apepat,Apemat,Nombre,Razsoc,a.Freg,a.Hreg,a.Ureg ";
                    sSql += "from	ingrec a WITH (NOLOCK) ";
                    sSql += "       left join recojos r on a.idrecojo=r.idrecojo ";
                    sSql += "where	nomraz<>'' and ";
                    sSql += "       nomraz in ( ";
                    sSql += "       select	nomraz ";
                    sSql += "       from	ingrec nolock ";
                    sSql += "       where	nomraz<>'' and ";
                    sSql += "       nomraz in ( ";
                    sSql += "               select	nomraz ";
                    sSql += "               from	ingrec nolock ";
                    sSql += "               group by nomraz ";
                    sSql += "               having 	COUNT(nomraz)>1 and ";
                    sSql += "               MAX(rtrim(numero))<>MIN(rtrim(numero))) ";
                    sSql += sFiltro + ") ";
                    sSql += "order by nomraz,numero ";
                    break;
                case "opcCuentaIgualDifDni":
                case "opcCuentaIgualDifNombre":
                    sSql = "select	a.tfile as TF,a.codim as [Cod.IM], ";
                    sSql += "       a.nrosubprod as NroSubProd, ";
                    sSql += "       a.Tipo, ";
                    sSql += "       numero as [Dni/Ruc], ";
                    sSql += "       Apepat,Apemat,Nombre,Razsoc, ";
                    sSql += "       idofiproc as [Ofi.Proc], ";
                    sSql += "       fecrec as [F.Recojo], ";
                    sSql += "       TipRec, ";
                    sSql += "       MesRec,AñoRec, ";
                    sSql += "       codbar as Caja, ";
                    sSql += "       npaque as Paq,nfolio, ";
                    sSql += "       nomraz as descrip ";
                    sSql += "from	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "where	nrosubprod<>'' and nrosubprod in  ";
                    sSql += "       ( ";
                    sSql += "           select	a.nrosubprod ";
                    sSql += "           from	ingreman a ";
                    sSql += "                   inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    if (sReporte == "opcCuentaIgualDifDni") sSql += " where numero<>'' ";
                    if (sReporte == "opcCuentaIgualDifNombre") sSql += " where nomraz<>'' ";
                    sSql += "           group by a.nrosubprod ";
                    sSql += "           having 	COUNT(a.nrosubprod)>1 and ";
                    if (sReporte == "opcCuentaIgualDifDni") sSql += " MAX(rtrim(numero))<>MIN(rtrim(numero)) ";
                    if (sReporte == "opcCuentaIgualDifNombre") sSql += " MAX(rtrim(nomraz))<>MIN(rtrim(nomraz)) ";
                    
                    sSql += "       ) ";

                    if (sIdoficina != "") sSql += "and b.idoficina ='" + sIdoficina + "' ";

                    if (bFechas) sSql += "and a.freg between '" + dFecIni.ToString("yyyyMMdd") + "' and '" + dFecIni.ToString("yyyyMMdd") + "' ";
                    else
                    { if (!bTodos) sSql += "and r.mesrec='" + sMesrec + "' and r.añorec='" + sAñorec + "' "; }

                    if (sTiprec != "") sSql += "and r.tiprec ='" + sTiprec + "' ";
                    sSql += "order by a.nrosubprod ";
                    break;
            }
            return Helper.fDatatable(sSql);
        }

        //Reportes de Gestion
        public DataTable Rep_Gestion(string sReporte, string sTipoAvance, Boolean bFechas, DateTime dFecIni, DateTime dFecfin, Boolean bTodos, string sMesrec, string sAñorec, string sIdoficina, string sTiprec)
        {
            switch (sReporte)
            {
                case "opcAvanceCabeRecojo":
                    sSql = "select	a.IdRecojo,min(c.Idoficina) as [Id.Oficina],min(c.Descripcion) as [Desc.Oficina], ";
                    sSql += "       min(a.TipoRecojo) as [TipRec], ";
                    sSql += "       min(a.FechaRecojo) as [Fecrec], ";
                    sSql += "       min(a.MesRecojo) as [MesRec], ";
                    sSql += "       min(a.AñoRecojo) as [AñoRec], ";
                    sSql += "       min(a.NroGuia) as NroGuia, ";
                    sSql += "       COUNT(b.CodigoIM) as Files, ";
                    sSql += "       SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end)  as [Files Digit.], ";
                    sSql += "       (SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end) *100)/(case when COUNT(b.CodigoIM)= 0 then 1 else COUNT(b.CodigoIM) end) as [Porc Digit.] ";
                    sSql += "from	Reg_Recojo a ";
                    sSql += "       left join Reg_Transmital t on a.IdCliente = t.IdCliente and a.Idrecojo = t.Idrecojo  ";
                    sSql += "       left join Reg_Legajo b on t.IdCliente = b.IdCliente and t.CodBarra = b.CodBarra and t.NroSecuencia = b.NroSecuencia  ";
                    sSql += "       left join T_Oficina c on a.IdCliente = c.IdCliente and a.Idoficina=c.Idoficina  ";
                    sSql += "where	a.IdCliente = '"+Helper.oBE_Sis_Cliente.IdCliente+"' ";
                    if (sIdoficina != "") sSql += "and a.Idoficina ='" + sIdoficina + "' ";

                    if (bFechas) sSql += "and a.FechaRegistro between '" + dFecIni.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    else
                    { if (!bTodos) sSql += "and a.MesRecojo='" + sMesrec + "' and a.AñoRecojo='" + sAñorec + "' "; }
                    if (sTiprec != "") sSql += "and a.TipoRecojo ='" + sTiprec + "' ";

                    sSql += "group by a.idrecojo ";
                    if (sTipoAvance != "Todos") sSql += "having (SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end) *100)/(case when COUNT(b.CodigoIM)= 0 then 1 else COUNT(b.CodigoIM) end) " + (sTipoAvance == "Completos" ? "=" : "<>") + "100 ";
                    sSql += "order by 2,a.idrecojo ";
                    break;

                case "opcAvanceCabeCaja":
                    sSql = "select	a.IdRecojo,min(c.idoficina) as [Id.Oficina],min(c.Descripcion) as [Desc.Oficina], ";
                    sSql += "       min(a.TipoRecojo) as [TipRec], ";
                    sSql += "       min(a.FechaRecojo) as [Fecrec], ";
                    sSql += "       min(a.MesRecojo) as [MesRec], ";
                    sSql += "       min(a.AñoRecojo) as [AñoRec], ";
                    sSql += "       min(a.Nroguia) as NroGuia, ";
                    sSql += "       t.Codbarra as Caja, ";
                    sSql += "       t.NroSecuencia as Sec, ";
                    sSql += "       COUNT(b.CodigoIM) as Files, ";
                    sSql += "       SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end) as [Files Digit.], ";
                    sSql += "       (SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end) *100)/(case when COUNT(b.CodigoIM)= 0 then 1 else COUNT(b.CodigoIM) end)  as [Porc Digit.] ";
                    sSql += "from	Reg_Recojo a ";
                    sSql += "       left join Reg_Transmital t on a.IdCliente = t.IdCliente and a.Idrecojo = t.Idrecojo  ";
                    sSql += "       left join Reg_Legajo b on t.IdCliente = b.IdCliente and t.CodBarra = b.CodBarra and t.NroSecuencia = b.NroSecuencia  ";
                    sSql += "       left join T_Oficina c on a.IdCliente = c.IdCliente and a.Idoficina=c.Idoficina  ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "'  ";
                    if (sIdoficina != "") sSql += "and a.Idoficina ='" + sIdoficina + "' ";

                    if (bFechas) sSql += "and a.FechaRegistro between '" + dFecIni.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    else
                    { if (!bTodos) sSql += "and a.MesRecojo='" + sMesrec + "' and a.AñoRecojo='" + sAñorec + "' "; }
                    if (sTiprec != "") sSql += "and a.TipoRecojo ='" + sTiprec + "' ";

                    sSql += "group by a.Idrecojo,t.CodBarra,t.NroSecuencia ";
                    if (sTipoAvance != "Todos") sSql += "having (SUM(case when isnull(b.CodigoIM,'')= 0 then 0 else (case when NombreRazon='' then 0 else 1 end) end) *100)/(case when COUNT(b.CodigoIM)= 0 then 1 else COUNT(b.CodigoIM) end) " + (sTipoAvance == "Completos" ? "=" : "<>") + "100 ";
                    sSql += "order by 2,a.Idrecojo,t.CodBarra ";
                    break;

                case "opcPendientesCabe":
                    sSql = "select	a.TipoLegajo,a.CodigoIM,r.IdRecojo, ";
                    sSql += "       a.IdOficinaGestora as [Id.Oficina], ";
                    sSql += "       b.Descripcion as [Desc.Oficina], ";
                    sSql += "       r.TipoRecojo as [TipRec], ";
                    sSql += "       r.FechaRecojo as [Fecrec], ";
                    sSql += "       r.MesRecojo as [MesRec], ";
                    sSql += "       r.AñoRecojo as [AñoRec], ";
                    sSql += "       t.CodBarra as Caja, ";
                    sSql += "       a.FechaRegistro as [FecReg], ";
                    sSql += "       a.HoraRegistro as [HorReg], ";
                    sSql += "       a.UsuarioRegistro as [UsuReg] ";
                    sSql += "from	Reg_Legajo a ";
                    sSql += "       left join T_Oficina b on a.IdCliente = b.IdCliente and a.IdOficinaGestora = b.Idoficina ";
                    sSql += "       left join Reg_Transmital t on a.IdCliente = t.IdCliente and a.CodBarra = t.CodBarra and a.NroSecuencia = t.NroSecuencia  ";
                    sSql += "       inner join Reg_Recojo r on t.IdCliente = r.IdCliente and t.idrecojo = r.idrecojo ";
                    sSql += "where	a.IdCliente = '" + Helper.oBE_Sis_Cliente.IdCliente + "' and a.NombreRazon='' ";
                    if (sIdoficina != "") sSql += "and a.IdOficinaGestora ='" + sIdoficina + "' ";

                    if (bFechas) sSql += "and a.FechaRegistro between '" + dFecIni.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    else
                    { if (!bTodos) sSql += "and r.MesRecojo='" + sMesrec + "' and r.AñoRecojo='" + sAñorec + "' "; }

                    if (sTiprec != "") sSql += "and r.TipoRecojo ='" + sTiprec + "' ";
                    sSql += "order by a.TipoLegajo,a.CodigoIM";
                    break;
            }

            return Helper.fDatatable(sSql);
        }

        //Reportes de Retiros
        public DataTable Rep_Retiros(int nOpc, string sFiltro, DateTime dFecini, DateTime dFecfin, string sMesrec, string sAñorec, string sIdofiproc)
        {
            switch (nOpc)
            {
                case 0:
                    sSql = "select	tfile as TF, ";
                    sSql += "       codim as Cod_IM, ";
                    sSql += "	    a.Idrecojo, ";
                    sSql += "       a.idofiproc as [Ofic. Procedencia], ";
                    sSql += "       tiprec as [Tip. Recojo], ";
                    sSql += "       tipdoc as [Tip. File], ";
                    sSql += "       fecrec as [Fecha Recojo], ";
                    sSql += "       mesrec as [Mes Recojo], ";
                    sSql += "       añorec as [Año Recojo], ";
                    sSql += "       codbar as Caja, ";
                    sSql += "       npaque as Paq, ";
                    sSql += "       case when tfileref='' then '' else tfileref+'-'+codimref end as IM_Asignado, ";
                    sSql += "       a.idoficina as [Ofic. Gestora], ";
                    sSql += "       fecinv as [Fecha Invent], ";
                    sSql += "       invent as Inventariador, ";
                    sSql += "       tcarpeta as TC, ";
                    sSql += "       tcliente as TP, ";
                    sSql += "       numero as [Dni / Ruc], ";
                    sSql += "       Apepat,Apemat,a.Nombre,Razsoc, ";
                    sSql += "       nomraz as [Nombre / Razón Social], ";
                    sSql += "       nfolio as Folios, ";
                    sSql += "       nfolioindex as [Folios Index], ";
                    sSql += "       a.ereg as Est, ";
                    sSql += "       fsalida as [Fec Salida], ";
                    sSql += "       a.Ordenskp, ";
                    sSql += "       case  ";
                    sSql += "       when convert(int,case nfolio when '' then 1 else nfolio end)+convert(int,case nfolioindex when '' then 0 else nfolioindex end) between 1 and 100 then 'I'  ";
                    sSql += "       when convert(int,case nfolio when '' then 1 else nfolio end)+convert(int,case nfolioindex when '' then 0 else nfolioindex end) between 101 and 300 then 'II'  ";
                    sSql += "       when convert(int,case nfolio when '' then 1 else nfolio end)+convert(int,case nfolioindex when '' then 0 else nfolioindex end) >300 then 'III'  ";
                    sSql += "       end as Categoria, ";
                    sSql += "       a.idpedidoret as [Id.Pedido Ret.], ";
                    sSql += "       b.idusuario as [Id.Usuario Ret.], ";
                    sSql += "       c.nombre as [Nombre Usuario], ";
                    sSql += "       b.idoficina as [Id.Oficina Ret.] ";
                    sSql += "from	ingrec a  ";
                    sSql += "       left join recojos r on a.idrecojo=r.idrecojo ";
                    sSql += "       left join pedic b on a.idpedidoret=idpedido ";
                    sSql += "       left join usuariosweb c on b.idusuario=c.idusuweb ";
                    sSql += "where	a.ereg<>'' and ";

                    if (sFiltro == "F") sSql += " a.fsalida between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " month(a.fsalida) = '" + sMesrec + "' and year(a.fsalida) = '" + sAñorec + "' and ";
                    sSql += "       a.idofiproc like '" + sIdofiproc + "%' ";
                    sSql += "order by a.fsalida";
                    break;
                case 1:
                    sSql = "select	b.idofiproc as [Ofic. Procedencia], ";
                    sSql += "       r.tiprec as [Tip. Recojo], ";
                    sSql += "       r.fecrec as [Fecha Recojo], ";
                    sSql += "       r.mesrec as [Mes Recojo], ";
                    sSql += "       r.añorec as [Año Recojo], ";
                    sSql += "       b.codbar as Caja, ";
                    sSql += "       a.tfile as TF, ";
                    sSql += "       a.codim as Cod_IM, ";
                    sSql += "       b.numero as [Dni/Ruc], ";
                    sSql += "       b.nomraz as [Nombre / Razón Social], ";
                    sSql += "       a.nrosec as Sec, ";
                    sSql += "       a.iddocu as [Tip. Doc], ";
                    sSql += "       a.fecdoc as [Fec. Doc], ";
                    sSql += "       a.numero as [Nro. Doc], ";
                    sSql += "       a.descrip as Descripción, ";
                    sSql += "       a.ereg as Est, ";
                    sSql += "       a.fsalida as [Fec Salida], ";
                    sSql += "       a.Ordenskp, ";
                    sSql += "       a.idpedidoret as [Id.Pedido Ret.], ";
                    sSql += "       c.idusuario as [Id.Usuario Ret.], ";
                    sSql += "       d.nombre as [Nombre Usuario], ";
                    sSql += "       c.idoficina as [Id.Oficina Ret.] ";
                    sSql += "from	ingredoc a  ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join pedic c on a.idpedidoret=c.idpedido ";
                    sSql += "       left join usuariosweb d on c.idusuario=d.idusuweb ";
                    sSql += "where	a.ereg<>'' and ";
                    if (sFiltro == "F") sSql += " a.fsalida between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and ";
                    if (sFiltro == "P") sSql += " month(a.fsalida) = '" + sMesrec + "' and year(a.fsalida) = '" + sAñorec + "' and ";
                    sSql += "       b.idofiproc like '" + sIdofiproc + "%' ";
                    sSql += "order by a.fsalida";

                    break;
            }
            return Helper.fDatatable(sSql);
        }

        //Reportes de Digitalizacion
        //Interbank
        public void Gen_Dig_Pend_Vs_Trab()
        {
            Helper.fExecute("IBK_Gen_Dig_Pend_Vs_Trab");
        }
        public DataTable Listar_Meses_Entrega()
        {
            sSql = "select	Periodo_Entrega, ";
            sSql += "		case LEFT(Periodo_Entrega,3) ";
            sSql += "		when 'Ene' then 1 ";
            sSql += "		when 'Feb' then 2 ";
            sSql += "		when 'Mar' then 3 ";
            sSql += "		when 'Abr' then 4 ";
            sSql += "		when 'May' then 5 ";
            sSql += "		when 'Jun' then 6 ";
            sSql += "		when 'Jul' then 7 ";
            sSql += "		when 'Ago' then 8 ";
            sSql += "		when 'Sep' then 9 ";
            sSql += "		when 'Oct' then 10 ";
            sSql += "		when 'Nov' then 11 ";
            sSql += "		when 'Dic' then 12 end as nMes ";
            sSql += "from	IBK_Resumenes ";
            sSql += "group by Periodo_Entrega ";
            sSql += "order by right(Periodo_Entrega,4) desc,2 desc ";

            return Helper.fDatatable(sSql);
        }
        public DataTable Listar_Periodos_Dig_Pend_Vs_Trab()
        {
            sSql = "select  Periodo,MesRecojo ";
            sSql += "from   IBK_r_Dig_Pend_Vs_Trab ";
            sSql += "group by Periodo,AñoRecojo,MesRecojo ";
            sSql += "order by AñoRecojo desc,MesRecojo desc ";
            return Helper.fDatatable(sSql);
        }
        public DataTable Rep_Digitalizacion(int nOpc, string sPeriodo_Entrega, string sMesrec, string sAñorec, string sTipo, string sAño, string sTipoProducto, string sTipoTC, string sTipo4)
        {
            switch (nOpc)
            {
                case 0:
                    sSql = "select  a.*,case when total_dig-Total_Tra_Dig<0 then 0 else total_dig-Total_Tra_Dig end as Pendientes, ";
                    sSql += "		Descripcion as DesProducto ";
                    sSql += "from	IBK_r_Dig_Pend_Vs_Trab a ";
                    sSql += "		left join T_Producto b on a.Idproducto = b.IdProducto and b.IdCliente = 'INTERBANK' ";
                    sSql += "order by AñoRecojo,MesRecojo,a.Idproducto ";
                    break;
                case 1:
                    sSql = "select	AñoRecojo,MesRecojo, ";
                    sSql += "       dbo.FNombreMes(CONVERT(int,MesRecojo))+'-'+AñoRecojo as Periodo, ";
                    sSql += "       a.CodBarra as Caja,a.NroSecuencia,b.NroPaquete as Paq,a.IdProducto,p.Descripcion as Des_Producto, ";
                    sSql += "       a.TipoLegajo,a.CodigoIM,b.NumeroDoi as Dni,b.NombreRazon as Nombre ";
                    sSql += "from	IBK_v_Dig_Pend_Vs_Trab a ";
                    sSql += "       inner join Reg_Legajo b on b.IdCliente = 'INTERBANK' and a.TipoLegajo = b.TipoLegajo and a.CodigoIM=b.CodigoIM ";
                    sSql += "       inner join Reg_Recojo r on r.IdCliente = 'INTERBANK' and a.Idrecojo= r.Idrecojo ";
                    sSql += "       left join T_Producto p on  p.IdCliente = 'INTERBANK' and a.IdProducto = p.IdProducto ";
                    sSql += "where	b.IdCliente = 'INTERBANK' and r.MesRecojo='" + sMesrec + "' and r.AñoRecojo='" + sAñorec + "' and a.Digitalizable=1 and a.Trabajados=0 ";
                    sSql += "order by a.CodBarra,a.NroSecuencia,a.TipoLegajo,a.CodigoIM ";
                    break;
                case 2:
                    //filtra por periodo de entrega de resumenes agrupado por periodo de recojo del file trabajado 
                    sSql = "select	dbo.FNombreMes(MesRecojo)+'-'+AñoRecojo as Periodo, ";
                    sSql += "		AñoRecojo as Año,MesRecojo as Mes, ";
                    sSql += "       '' as Producto, ";
                    sSql += "       a.Producto as Descripción, ";
                    sSql += "       count(b.TipoLegajo) as [Cantidad IMs], ";
                    sSql += "       SUM(CantidadImagenesNuevo) as [Cantidad Imag.] ";
                    sSql += "from	IBK_Resumenes a ";
                    sSql += "		left join Reg_Legajo b on b.IdCliente = 'INTERBANK' and a.TipoLegajo=b.TipoLegajo and a.CodigoIM = b.CodigoIM ";
                    sSql += "		left join Reg_Transmital t on b.IdCliente = t.IdCliente and b.CodBarra = t.CodBarra and b.NroSecuencia = t.NroSecuencia ";
                    sSql += "       inner join Reg_Recojo c on t.IdCliente = c.IdCliente and t.Idrecojo=c.Idrecojo ";
                    sSql += "where	b.IdCliente = 'INTERBANK' and Duplicado=0 and a.TipoLegajo<>'' and a.CodigoIM<>'' and Periodo_Entrega='" + sPeriodo_Entrega + "' ";
                    sSql += "group by c.MesRecojo,c.AñoRecojo,a.Producto ";
                    sSql += "order by AñoRecojo,MesRecojo ";
                    break;
                case 3:
                    sSql = "select * from IBK_Resumenes where TIPOLEGAJO='' and Duplicado=0 ";
                    break;
                case 4:
                    sSql = "select	Tipo_Documento, ";
                    sSql += "       COUNT(idregistro) as Total_Registros, ";
                    sSql += "       SUM(CantidadImagenes) as Cant_Imagenes, ";
                    sSql += "       COUNT(distinct Caja) as Cant_Cajas ";
                    sSql += "from	IBK_Resumenes ";
                    sSql += "where	TIPOLEGAJO='' and Duplicado=0 ";
                    sSql += "group by Tipo_Documento ";
                    break;
                case 5:
                    Helper.fExecute("[IBK_Rep_Dig_Resumen_Por_Caja]");

                    if (sTipo == "Cons" || sTipo == "Det")
                    {
                        sSql  = " select a.*,a.IdProducto+' '+Descripcion  as DesProducto,Descripcion  ";
                        sSql += " from IBK_tmp_cajas_final a inner join T_Producto b on b.IdCliente = 'INTERBANK' and  a.IdProducto=b.IdProducto  ";
                        sSql += " where SUBSTRING(Periodo,1,4) = '" + sAño + "' ";
                    }
                    if (sTipo == "Trab_No_Dig")
                    {
                        sSql  = " select a.*,c.Descripcion from IBK_tmp_cajas_trab a ";
                        sSql += " left join IBK_tmp_cajas_dig b on a.CodBarra=b.CodBarra ";
                        sSql += " left join T_Producto c on a.IdProducto=c.Idproducto and c.IdCliente = 'INTERBANK' ";
                        sSql += " where ISNULL(b.CodBarra,'')='' and SUBSTRING(Periodo,1,4) = '" + sAño + "' ";
                    }

                    break;
                case 6:

                    if (sTipo == "Cons" || sTipo == "Det")
                    {
                        sSql  = " select AñoRecojo + MesRecojo as Periodo,sum(Digitalizable) as Digitalizables,  ";
                        sSql += " sum(case when v.Digitalizable=1 and v.Trabajados=1 then 1 else 0 end) as Trabajadas,  ";
                        sSql += " sum(Digitalizable) - sum(case when v.Digitalizable=1 and v.Trabajados=1 then 1 else 0 end) as Pendientes, ";
                        sSql += " Descripcion as DesProducto, v.IdProducto  ";
                        sSql += " from IBK_v_Dig_Pend_Vs_Trab v ";
                        sSql += " inner join   Reg_Recojo a  on a.Idrecojo = v.Idrecojo and a.IdCliente = 'INTERBANK' ";
                        sSql += " inner join T_Producto b  on v.IdProducto = b.IdProducto and b.IdCliente = 'INTERBANK' ";
                        sSql += " where AñoRecojo = '" + sAño + "' ";
                        sSql += " group by AñoRecojo + MesRecojo  ,v.IdProducto,b.Descripcion  ";
                        sSql += " order by  AñoRecojo + MesRecojo ";

                    }
                    if (sTipo == "Trab_No_Dig")
                    {
                        sSql = "  select v.CodigoIM,g.Linea, v.IdProducto,b.Descripcion ";
                        sSql += "  from IBK_v_Dig_Pend_Vs_Trab v  ";
                        sSql += "  inner join   Reg_Recojo a 	on a.IdCliente = 'INTERBANK' and a.Idrecojo = v.IdRecojo ";
                        sSql += "  inner join T_Producto b 	on b.IdCliente = 'INTERBANK' and v.IdProducto = b.IdProducto  ";
                        sSql += "  left join IBK_Resumenes AS g ON v.TipoLegajo = g.TIPOLEGAJO AND v.CodigoIM = g.CODIGOIM AND g.DUPLICADO = 0  ";
                        sSql += "where AñoRecojo = '" + sAño + "' and Trabajados > Digitalizable ";
                    }
                    break;
                case 7:
                    if (sTipoProducto == "0101")
                    {
                        if (sTipoTC == "Acum")
                        {
                            sSql  = " select CodBarra, COUNT(*) as [Total Ims],sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Trabajados],  ";
                            sSql += " COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Pendientes],  ";
                            sSql += " case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = 0 then  'Caja Digitalizada'  ";
                            sSql += " else ( case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = count(*) then 'Caja Pendiente de Digitalizar'  ";
                            sSql += " else 'Caja Parcialmente Digitalizada' end ) end as Observaciones  ";
                            sSql += " from  IBK_v_Dig_Pend_Vs_Trab a  ";
                            sSql += " inner join Reg_Recojo b on a.IdRecojo = b.Idrecojo and b.IdCliente = 'INTERBANK'  ";
                            sSql += " where IdProducto = '0101' and  substring(CONVERT(varchar(10),FechaRecojo,112),1,6) < '201106'  ";
                            sSql += " group by CodBarra  ";
                        }

                        if (sTipoTC == "Dia")
                        {
                            sSql = " select CodBarra, COUNT(*) as [Total Ims],sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Trabajados],  ";
                            sSql += " COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Pendientes],  ";
                            sSql += " case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = 0 then  'Caja Digitalizada'  ";
                            sSql += " else ( case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = count(*) then 'Caja Pendiente de Digitalizar'  ";
                            sSql += " else 'Caja Parcialmente Digitalizada' end ) end as Observaciones  ";
                            sSql += " from  IBK_v_Dig_Pend_Vs_Trab a inner join Reg_Recojo b on a.Idrecojo = b.idrecojo and b.IdCliente = 'INTERBANK' ";
                            sSql += " where IdProducto = '0101' and  substring(CONVERT(varchar(10),FechaRecojo,112),1,6) > '201106'  ";
                            sSql += " group by CodBarra  ";
                        }

                        if (sTipoTC == "TCH")
                        {
                            sSql  = " select	CodBarra,count(*) as [Total Ims],   ";
                            sSql += " sum(case when isnull(b.TIPOLEGAJO,'')<>'' then 1 else 0 end) as [Ims Trabajados],   ";
                            sSql += " count(*) - sum(case when isnull(b.TIPOLEGAJO,'')<>'' then 1 else 0 end) as [Ims Pendientes],  ";
                            sSql += " case when count(*) - sum(case when isnull(b.TIPOLEGAJO,'')<>'' then 1 else 0 end) = 0 then 'Caja Digitalizada'   ";
                            sSql += " else(case when count(*) - sum(case when isnull(b.TIPOLEGAJO,'')<>'' then 1 else 0 end) = count(*) then 'Caja Pendiente de Digitalizar'   ";
                            sSql += " else 'Caja Parcialmente Digitalizada' end ) end as Observaciones   ";
                            sSql += " from	Reg_Legajo a  ";
                            sSql += " left join IBK_Resumenes b on a.TipoLegajo=b.TIPOLEGAJO and a.CodigoIM=b.CODIGOIM and b.Duplicado=0   ";
                            sSql += " where	a.IdCliente = 'INTERBANK' and   IdOficinaProcedencia = 'TCH'   ";
                            sSql += " group by CodBarra   ";
                        }
                        break;

                    }

                    sSql = " select CodBarra, COUNT(*) as [Total Ims],sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Trabajados],  ";
                    sSql += " COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) as [Ims Pendientes],  ";
                    sSql += " case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = 0 then  'Caja Digitalizada'  ";
                    sSql += " else ( case when COUNT(*) -  sum(case when Digitalizable = 1 and Trabajados = 1  then 1 else 0 end) = count(*) then 'Caja Pendiente de Digitalizar'  ";
                    sSql += " else 'Caja Parcialmente Digitalizada' end ) end as Observaciones  ";
                    sSql += " from  IBK_v_Dig_Pend_Vs_Trab a inner join Reg_Recojo b on a.idrecojo = b.idrecojo and b.IdCliente = 'INTERBANK' ";
                    sSql += " where IdProducto = '" + sTipoProducto + "'  ";
                    sSql += " group by CodBarra  ";
                    break;
                case 8:

                    sSql = " select count(distinct caja) as [Cantidad de Cajas], COUNT(CODIGOIM)as [Cantidad de IMs],   ";
                    sSql += " SUM(CantidadImagenes)[Cantidad de Imagenes] , isnull(producto,'VACIO') as producto,linea,   ";
                    sSql += "  Periodo_Entrega  ";
                    sSql += "  from IBK_Resumenes ";
                    sSql += "  where DUPLICADO=0 and TIPOLEGAJO<>'' and CODIGOIM <>'' and Periodo_Entrega = '" + sPeriodo_Entrega + "'  ";
                    sSql += "  group by Producto,Linea,Periodo_Entrega  ";
                    break;
                case 9:
                    if (sTipo4 == "Comercial")
                    {
                        sSql = " select NombreDisco as Disco,'TC Historico' as Linea,Descripcion as Producto , count(*) as [Total Archivos],   ";
                        sSql += "  SUM(TotalImagenes) as [Total Imágenes]  ";
                        sSql += "  from  IBK_v_Dig_Pend_Vs_Trab_Hist a inner join T_Producto b on b.IdCliente = 'INTERBANK' and b.Idproducto = a.IdProducto ";
                        sSql += "  where trabajados = 1  ";
                        sSql += "  group by NombreDisco,Descripcion  ";
                        sSql += "  union  ";
                        sSql += "  select NombreDisco as Disco,'TC - Dia a dia' as Linea,Descripcion as Producto , count(*) as [Total Archivos],  ";
                        sSql += "  SUM(TotalImagenes) as [Total Imágenes]  ";
                        sSql += "  from IBK_v_Dig_Pend_Vs_Trab a inner join T_Producto b on b.IdCliente = 'INTERBANK' and b.Idproducto = a.Idproducto  ";
                        sSql += "  where trabajados = 1 and a.Idproducto = '0101'  ";
                        sSql += "  group by NombreDisco,Descripcion  ";
                        sSql += "  union  ";
                        sSql += "  select NombreDisco as Disco,'Archivos comerciales - Dia a dia' as Linea,Descripcion as Producto , count(*) as [Total Archivos],  ";
                        sSql += "  SUM(TotalImagenes) as [Total Imágenes]  ";
                        sSql += "  from IBK_v_Dig_Pend_Vs_Trab a inner join T_Producto b on b.IdCliente = 'INTERBANK' and b.Idproducto = a.Idproducto ";
                        sSql += "  where trabajados = 1 and a.Idproducto <> '0101'  ";
                        sSql += "  group by NombreDisco,Descripcion  ";
                        sSql += "  order by NombreDisco  ";

                    }
                    if (sTipo4 == "Transaccional")
                    {
                        sSql  = " select NombreDisco as Disco,DESCRIPCIONDELPAQUETE as Descp_Registros ,TIENDA as Tienda ,count(*) as [Total Archivos], ";
                        sSql += " sum(CantidadImagenes) as [Total Imágenes] ";
                        sSql += " from IBK_Resumenes_Transaccionales ";
                        sSql += " group by  NombreDisco,DESCRIPCIONDELPAQUETE,TIENDA ";
                    }
                    if (sTipo == "Periodo")
                    {
                        sSql  = " select Periodo_Entrega as Periodo,Producto as Descripcion,COUNT(*) as [Suma de Cantidad IMs], SUM(CANTIDADIMAGENESNUEVO) as [Suma de Cantidad Imag.] ";
                        sSql += " from IBK_Resumenes ";
                        sSql += " where DUPLICADO = 0 and Periodo_Entrega = '" + sPeriodo_Entrega + "' ";
                        sSql += " group by Periodo_Entrega, Producto ";
                        sSql += " order by Periodo_Entrega ";
                    }

                    break;
                case 10:
                    sSql = " select	min(dbo.FNombreMes(CONVERT(int,MesRecojo))+'-'+AñoRecojo) as Periodo,  ";
                    sSql += "  a.CodBarra as Caja,min(p.Descripcion) as Des_Producto,min(t.Descripcion) as Producto  ";
                    sSql += "  from	IBK_v_Dig_Pend_Vs_Trab a  ";
                    sSql += "  inner join Reg_Recojo r on r.IdCliente = 'INTERBANK' and a.IdRecojo=r.Idrecojo  ";
                    sSql += "  left join T_Producto p on p.IdCliente = 'INTERBANK' and  a.IdProducto=p.IdProducto  ";
                    sSql += "  left join T_TipoOperacion t on  t.IdCliente = 'INTERBANK' and  a.IdTipoOperacion = t.IdTipoOperacion and a.IdProducto = t.IdProducto  ";
                    sSql += "  where	a.Digitalizable=1 and a.Trabajados=0  ";
                    sSql += "  group by a.CodBarra  ";
                    sSql += "  order by a.CodBarra  ";
                    break;
            }
            return Helper.fDatatable(sSql);
        }

        //Nextel
        public DataTable Rep_Digitalizacion_Nextel(int nOpc, string sFiltro, DateTime dFecini, DateTime dFecfin, string sMesrec, string sAñorec)
        {
            switch (nOpc)
            {
                case 0:
                    sSql = "select 	a.idenvio,min(fproceso) as [Fecha Proceso],c.codbar,b.archivo,b.version, ";
                    sSql += "       count(b.codim) as Tot_Registros, ";
                    sSql += "       sum(b.totimaenv) as Tot_Imagenes, ";
                    sSql += "       min(a.obse) as Observación ";
                    sSql += "from 	enviosc a  ";
                    sSql += "       inner join enviosd b on a.idenvio=b.idenvio ";
                    sSql += "       left join ingrec c on b.tfile=c.tfile and b.codim=c.codim ";
                    sSql += "where	";
                    if (sFiltro == "F") sSql += " fproceso between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " month(fproceso) = '" + sMesrec + "' and year(fproceso) = '" + sAñorec + "' ";
                    sSql += "group by a.idenvio,c.codbar,b.archivo,b.version ";
                    sSql += "order by a.idenvio,2 ";

                    break;
                case 1:

                    sSql = "select 	a.ureg, ";
                    sSql += "       min(b.Nombre) as Nombre, ";
                    sSql += "       a.freg,d.codbar, ";
                    sSql += "       sum(cant) as Tot_Imagenes, ";
                    sSql += "       convert(numeric(10,2),convert(numeric(10,2),sum(a.peso))/1024) as Peso ";
                    sSql += "from 	ingrecima a ";
                    sSql += "       left join sis_usuarios b on a.ureg=b.idusuario ";
                    sSql += "       left join ingreman c on a.tfile=c.tfile and a.codim=c.codim and ncontrato='01' ";
                    sSql += "left join ingrec d on c.tfile=d.tfile and c.codim=d.codim ";
                    sSql += "where	";
                    if (sFiltro == "F") sSql += " a.freg between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " month(a.freg) = '" + sMesrec + "' and year(a.freg) = '" + sAñorec + "' ";
                    sSql += "group by a.ureg,a.freg,d.codbar ";
                    sSql += "order by 3,4 ";

                    break;
                case 2:
                    sSql = "select 	fproceso as Fec_Envio,a.Idenvio,a.Tfile,a.Codim, ";
                    sSql += "       c.numero as [Dni / Ruc], ";
                    sSql += "       c.nomraz as [Nombre / Razón Social],b.NroOrden,b.NroSolicitud, ";
                    sSql += "       a.Archivo,a.Version,TotImaEnv ";
                    sSql += "from 	enviosd a  ";
                    sSql += "       inner join ingreman b on a.tfile=b.tfile and a.codim=b.codim and a.ncontrato=b.ncontrato ";
                    sSql += "       inner join ingrec c on a.tfile=c.tfile and a.codim=c.codim ";
                    sSql += "       left join enviosc d on a.idenvio=d.idenvio ";
                    if (sFiltro == "F") sSql += " where fproceso between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " where month(fproceso) = '" + sMesrec + "' and year(fproceso) = '" + sAñorec + "' ";
                    sSql += "order by fproceso,a.tfile,a.codim,a.archivo,a.version ";
                    break;
                case 3:
                    sSql = "select 	a.fecesc as Fec_Escaneo, ";
                    sSql += "       a.Tfile,a.Codim, ";
                    sSql += "       b.numero as [Dni / Ruc], ";
                    sSql += "       b.nomraz as [Nombre / Razón Social],a.NroOrden,a.NroSolicitud ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "where 	bescaneo=1 ";
                    if (sFiltro == "F") sSql += " and a.fecesc between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " and month(a.fecesc) = '" + sMesrec + "' and year(a.fecesc) = '" + sAñorec + "' ";
                    sSql += "order by a.fecesc,a.tfile,a.codim ";
                    break;
                case 4:
                    sSql = "select 	a.fecesc as Fec_Escaneo, ";
                    sSql += "       a.Tfile,a.Codim, ";
                    sSql += "       b.numero as [Dni / Ruc], ";
                    sSql += "       b.nomraz as [Nombre / Razón Social],a.NroOrden,a.NroSolicitud, ";
                    sSql += "       d.Archivo as Archivo_Cliente,d.Idregistro,d.PtoVenta,Vendedor ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join datanextel d on a.nroorden=d.nroorden and a.nrosolicitud=d.nrosolicitud ";
                    sSql += "where 	bescaneo=1 ";
                    if (sFiltro == "F") sSql += " and a.fecesc between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " and month(a.fecesc) = '" + sMesrec + "' and year(a.fecesc) = '" + sAñorec + "' ";
                    sSql += "order by a.fecesc,a.tfile,a.codim ";
                    break;
                case 5:
                    Helper.fExecute("Gen_Servicio_RCTD", dFecini.ToString("yyyyMMdd"), dFecfin.ToString("yyyyMMdd"));

                    sSql = "select	Periodo, ";
                    sSql += "		idprod, ";
                    sSql += "		idtiptran, ";
                    sSql += "		Carp_procesadas, ";
                    sSql += "		Carp_por_Procesar, ";
                    sSql += "		Carp_Cbd, ";
                    sSql += "		Esc_Prorateadas, ";
                    sSql += "		Estimadas_por_Escanear, ";
                    sSql += "		Esc_Prorateadas+Estimadas_por_Escanear as Total_Escaneadas, ";
                    sSql += "		Asignadas, ";
                    sSql += "		Enviadas, ";
                    sSql += "		convert(numeric(10,2),case when (Esc_Prorateadas+Estimadas_por_Escanear)>0 then Enviadas/convert(numeric(10,2),(Esc_Prorateadas+Estimadas_por_Escanear))*100 else 0 end) ";
                    sSql += "		as Porc_Enviados_Escaneados, ";
                    sSql += "		convert(int,right(idtiptran,2)) as ntip, ";
                    sSql += "		convert(varchar(4),año)+'-'+convert(varchar(2),mes) as nPeriodo ";
                    sSql += "from	w_Servicio_RCTD ";
                    sSql += "order by Año,mes,Orden ";

                    break;

                case 6:
                    sSql = "select	dbo.FNombreMes(month(r.fecrec))+'-'+convert(varchar(4),YEAR(r.fecrec)) as Periodo, ";
                    sSql += "		t.Codbar,t.Nrosec,FecRec, ";
                    sSql += "		TotImagenes ";
                    sSql += "from	transd t  ";
                    sSql += "		inner join transo o on t.codbar=o.codbar and t.nrosec=o.nrosec ";
                    sSql += "		inner join recojos r on t.idrecojo=r.idrecojo ";
                    sSql += "where	r.fecrec between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' and o.tipocaja='CBD' ";
                    sSql += "order by r.fecrec,t.codbar ";
                    break;
                case 7:
                    sSql = "select	AñoRec,MesRec, ";
                    sSql += "       dbo.FNombreMes(month(r.fecrec))+'-'+convert(varchar(4),YEAR(r.fecrec)) as Periodo, ";
                    sSql += "       a.codbar as Caja,a.npaque as Paquete,a.NroSec,r.FecRec, ";
                    sSql += "       a.TFile,a.CodIM,a.numero as [Dni / Ruc],a.nomraz as [Nombre / Razón Social], ";
                    sSql += "       idtiptran as Tipo_Operacion,b.NroOrden,b.NroSolicitud ";
                    sSql += "from	ingrec a  ";
                    sSql += "       inner join recojos r on a.idrecojo=r.idrecojo ";
                    sSql += "       inner join ingreman b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "where	b.bescaneo=0 ";
                    if (sFiltro == "F") sSql += " and r.fecrec between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " and month(r.fecrec) = '" + sMesrec + "' and year(r.fecrec) = '" + sAñorec + "' ";
                    sSql += "order by r.fecrec,a.tfile,a.codim ";
                    break;
                case 8:
                    sSql = "select	AñoRec,MesRec, ";
                    sSql += "		dbo.FNombreMes(CONVERT(int,mesrec))+'-'+añorec as Periodo, ";
                    sSql += "		a.codbar as Caja,a.npaque as Paquete,a.NroSec,r.FecRec, ";
                    sSql += "		a.TFile,a.CodIM,a.numero as [Dni / Ruc],a.nomraz as [Nombre / Razón Social], ";
                    sSql += "		idtiptran as Tipo_Operacion,b.NroOrden,b.NroSolicitud, ";
                    sSql += "		i.nfiles as Imagenes ";
                    sSql += "from	ingrec a  ";
                    sSql += "		inner join recojos r on a.idrecojo=r.idrecojo ";
                    sSql += "		inner join ingreman b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "		left join v_Ingrecima_Im i on a.tfile=i.tfile and a.codim=i.codim ";
                    sSql += "where	b.bescaneo=1 and benviado=0 ";
                    if (sFiltro == "F") sSql += " and r.fecrec between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " and month(r.fecrec) = '" + sMesrec + "' and year(r.fecrec) = '" + sAñorec + "' ";
                    sSql += "order by r.fecrec,a.tfile,a.codim ";
                    break;
                case 9:
                    sSql = "select 	a.RegistradoPor, ";
                    sSql += "       min(b.Nombre) as Nombre, ";
                    sSql += "       a.FechaRegistro,a.codbar, ";
                    sSql += "       sum(totalImagenes) as Tot_Imagenes ";
                    sSql += "from 	ProduccionDgtz a ";
                    sSql += "       left join sis_usuarios b on a.RegistradoPor=b.idusuario ";
                    sSql += "where	";
                    if (sFiltro == "F") sSql += " a.FechaRegistro between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
                    if (sFiltro == "P") sSql += " month(a.FechaRegistro) = '" + sMesrec + "' and year(a.FechaRegistro) = '" + sAñorec + "' ";

                    sSql += "group by a.RegistradoPor,a.FechaRegistro,a.codbar ";
                    sSql += "order by 3,4 ";
                    break;
                case 10:
                    Helper.fExecute("Gen_Carpetas_Cbd_Sbd", dFecini.ToString("yyyyMMdd"), dFecfin.ToString("yyyyMMdd"));
                    sSql = "select  *, ";
                    sSql += "       Carp_Cbd_Anexo1 +Carp_Sbd_Anexo1  as Total_Anexo1, ";
                    sSql += "       Carp_Cbd_Anexo2 +Carp_Sbd_Anexo2  as Total_Anexo2, ";
                    sSql += "       Carp_Cbd_Anexo11+Carp_Sbd_Anexo11 as Total_Anexo11, ";
                    sSql += "       Carp_Cbd_Anexo16+Carp_Sbd_Anexo16 as Total_Anexo16, ";
                    sSql += "       Carp_Cbd_Anexo17+Carp_Sbd_Anexo17 as Total_Anexo17, ";
                    sSql += "       Total_Cbd+Total_Sbd as Total ";
                    sSql += "from	w_Carpetas_CBD_SBD ";
                    break;

            }
            return Helper.fDatatable(sSql);
        }
        
        //Reportes de Ingresos
        public string Get_Total_Legajos(Boolean bPeriodo, Boolean bRecojo, Boolean bFecha, string sMesrec, string sAñorec, DateTime dFecini, DateTime dFecfin, string sRecojo1, string sRecojo2)
        {
            sSql = "select  count(*) as cantidad ";
            sSql += "from   ingrec a ";
            sSql += "       left join recojos r on a.idrecojo=r.idrecojo ";
            sSql += "where  nomraz<>'' ";
            if (bPeriodo) sSql += "and mesrec='" + sMesrec + "' and añorec='" + sAñorec + "' ";
            if (bRecojo) sSql += "and r.idrecojo between '" + sRecojo1 + "' and '" + sRecojo2 + "' ";
            if (bFecha) sSql += "and a.freg between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";

            return Convert.ToString(Helper.fEscalar(sSql));
        }
        public DataTable Rep_Facturacion(int nOpc, Boolean bPeriodo, Boolean bRecojo, Boolean bFecha, string sMesrec, string sAñorec, DateTime dFecini, DateTime dFecfin, string sRecojo1, string sRecojo2)
        {
            sSql = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[t_facope]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) ";
            sSql += "drop table t_facope ";
            sSql += "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[t_facdoc]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) ";
            sSql += "drop table t_facdoc ";
            sSql += "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[t_facdat]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) ";
            sSql += "drop table t_facdat ";
            Helper.fExecute(sSql);
            string sFiltro = "";
            if (bPeriodo) sFiltro = "and mesrec='" + sMesrec + "' and añorec='" + sAñorec + "' ";
            if (bRecojo) sFiltro += "and r.idrecojo between '" + sRecojo1 + "' and '" + sRecojo2 + "' ";
            if (bFecha) sFiltro += "and b.freg between '" + dFecini.ToString("yyyyMMdd") + "' and '" + dFecfin.ToString("yyyyMMdd") + "' ";
            switch (nOpc)
            {
                    // POR OPERACION
                case 0:
                    sSql += "select a.idtiptran, min(c.descrip) as Descripción,count(*) as cantidad into t_facope ";
                    sSql += "from 	ingreman a  ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join tiptranc c on a.idprod=c.idprod and a.idtiptran=c.idtiptran ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by a.idtiptran ";
                    sSql += "order by a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql += "select a.idtiptran,min(d.descrip) as Descripción,count(*) as cantidad into t_facdoc ";
                    sSql += "from 	ingreman a  ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join tiptranc d on a.idprod=d.idprod and a.idtiptran=d.idtiptran ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by a.idtiptran ";
                    sSql += "order by a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql += "select a.idtiptran,min(e.descrip) as Descripción,count(*) as cantidad into t_facdat ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim  ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       inner join ingredocdat d on c.tfile=d.tfile and c.codim=d.codim and c.nrosec=d.nrosec ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join tiptranc e on a.idprod=e.idprod and a.idtiptran=e.idtiptran ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by a.idtiptran ";
                    sSql += "order by a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	a.idtiptran as Tipo, ";
                    sSql += "       left(a.Descripción,len(a.descripción)-2) as Descripción, ";
                    sSql += "       a.cantidad as [Total Operaciones], ";
                    sSql += "       b.cantidad as [Total Documentos], ";
                    sSql += "       c.cantidad as [Total Datos] ";
                    sSql += "from 	t_facope a ";
                    sSql += "       left join t_facdoc b on a.idtiptran=b.idtiptran ";
                    sSql += "       left join t_facdat c on a.idtiptran=c.idtiptran ";
                    sSql += "order by a.idtiptran ";

                    break;
                case 1:
                    sSql = "select 	r.idrecojo,min(r.fecrec) as fecrec,min(e.descrip) as Oficina, ";
                    sSql += "       a.idtiptran,min(natura) as tregistro, ";
                    sSql += "       min(c.descrip) as Descripción,count(*) as cantidad into t_facope ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join tiptranc c on a.idprod=c.idprod and a.idtiptran=c.idtiptran ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join oficinas e on r.idoficina=e.idoficina ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by r.idrecojo,a.idtiptran ";
                    sSql += "order by r.idrecojo,3,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	r.idrecojo,min(r.fecrec) as fecrec,min(f.descrip) as Oficina, ";
                    sSql += "       a.idtiptran,min(natura) as tregistro, ";
                    sSql += "       min(d.descrip) as Descripción,count(*) as cantidad into t_facdoc ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       left join tiptranc d on a.idprod=d.idprod and a.idtiptran=d.idtiptran ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join oficinas f on r.idoficina=f.idoficina ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by r.idrecojo,a.idtiptran ";
                    sSql += "order by r.idrecojo,3,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	r.idrecojo,min(r.fecrec) as fecrec,min(g.descrip) as Oficina, ";
                    sSql += "       a.idtiptran,min(natura) as tregistro, ";
                    sSql += "       min(e.descrip) as Descripción,count(*) as cantidad into t_facdat ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       inner join ingredocdat d on c.tfile=d.tfile and c.codim=d.codim and c.nrosec=d.nrosec ";
                    sSql += "       left join tiptranc e on a.idprod=e.idprod and a.idtiptran=e.idtiptran ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join oficinas g on r.idoficina=g.idoficina ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by r.idrecojo,a.idtiptran ";
                    sSql += "order by r.idrecojo,3,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	a.idrecojo,a.fecrec,a.Oficina, ";
                    sSql += "       a.idtiptran as TipoOperacion, ";
                    sSql += "       a.tregistro as TipoRegistro, ";
                    sSql += "       left(a.Descripción,len(a.descripción)-2) as Descripción, ";
                    sSql += "       a.cantidad as [Total Operaciones], ";
                    sSql += "       b.cantidad as [Total Documentos], ";
                    sSql += "       c.cantidad as [Total Datos] ";
                    sSql += "from 	t_facope a ";
                    sSql += "       left join t_facdoc b on a.idrecojo=b.idrecojo and a.idtiptran=b.idtiptran ";
                    sSql += "       left join t_facdat c on a.idrecojo=c.idrecojo and a.idtiptran=c.idtiptran ";
                    sSql += "order by a.idrecojo,a.oficina,a.idtiptran ";
                    break;
                case 2:

                    sSql = "select 	b.idrecojo,min(fecrec) as fecrec, ";
                    sSql += "       b.idofiproc,min(d.descrip) as Oficina,a.idtiptran,min(c.descrip) as Descripción,count(*) as cantidad into t_facope ";
                    sSql += "from 	ingreman a  ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       left join tiptranc c on a.idprod=c.idprod and a.idtiptran=c.idtiptran ";
                    sSql += "       left join oficinas d on b.idofiproc=d.idoficina ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by b.idrecojo,b.idofiproc,a.idtiptran ";
                    sSql += "order by b.idrecojo,b.idofiproc,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select  b.idrecojo,min(fecrec) as fecrec, ";
                    sSql += "       b.idofiproc,min(e.descrip) as Oficina,a.idtiptran,min(d.descrip) as Descripción,count(*) as cantidad into t_facdoc ";
                    sSql += "from 	ingreman a ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       left join tiptranc d on a.idprod=d.idprod and a.idtiptran=d.idtiptran ";
                    sSql += "       left join oficinas e on b.idofiproc=e.idoficina ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by b.idrecojo,b.idofiproc,a.idtiptran ";
                    sSql += "order by b.idrecojo,b.idofiproc,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	b.idrecojo,min(fecrec) as fecrec, ";
                    sSql += "       b.idofiproc,min(f.descrip) as Oficina,a.idtiptran,min(e.descrip) as Descripción,count(*) as cantidad into t_facdat ";
                    sSql += "from 	ingreman a  ";
                    sSql += "       inner join ingrec b on a.tfile=b.tfile and a.codim=b.codim ";
                    sSql += "       inner join ingredoc c on a.tfile=c.tfile and a.codim=c.codim and a.ncontrato=c.ncontrato ";
                    sSql += "       inner join ingredocdat d on c.tfile=d.tfile and c.codim=d.codim and c.nrosec=d.nrosec ";
                    sSql += "       left join tiptranc e on a.idprod=e.idprod and a.idtiptran=e.idtiptran ";
                    sSql += "       left join oficinas f on b.idofiproc=f.idoficina ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "where 	a.idtiptran=a.idtiptran ";
                    sSql += sFiltro;
                    sSql += "group by b.idrecojo,b.idofiproc,a.idtiptran ";
                    sSql += "order by b.idrecojo,b.idofiproc,a.idtiptran ";
                    Helper.fExecute(sSql);

                    sSql = "select 	a.idrecojo,a.fecrec,a.idofiproc,a.oficina,a.idtiptran as Tipo, ";
                    sSql += "       left(a.Descripción,len(a.descripción)-2) as Descripción, ";
                    sSql += "       a.cantidad as [Total Operaciones], ";
                    sSql += "       b.cantidad as [Total Documentos], ";
                    sSql += "       c.cantidad as [Total Datos] ";
                    sSql += "from 	t_facope a  ";
                    sSql += "       left join t_facdoc b on a.idrecojo=b.idrecojo and a.idofiproc=b.idofiproc and a.idtiptran=b.idtiptran ";
                    sSql += "       left join t_facdat c on a.idrecojo=c.idrecojo and a.idofiproc=c.idofiproc and a.idtiptran=c.idtiptran ";
                    sSql += "order by a.idrecojo,a.idofiproc,a.idtiptran ";

                    break;
                case 3:
                    sSql = "select  b.idrecojo, ";
                    sSql += "       dbo.FNombreMes(CONVERT(int,min(mesrec)))+'-'+min(añorec) as Periodo, ";
                    sSql += "       r.idoficina,min(o.descrip) as Descrip,fecrec,nroguia, ";
                    sSql += "       SUM(case when tfile='NL' then 1 else 0 end) as Tot_NuevosLegajos, ";
                    sSql += "       SUM(case when tfile='LA' then 1 else 0 end) as Tot_LegajoAutomatico ";
                    sSql += "from	ingrec b ";
                    sSql += "       left join recojos r on b.idrecojo=r.idrecojo ";
                    sSql += "       left join oficinas o on r.idoficina=o.idoficina ";
                    sSql += "where	nomraz<>'' ";
                    sSql += sFiltro;
                    sSql += "group by b.idrecojo,r.idoficina,fecrec,nroguia ";
                    sSql += "order by b.idrecojo ";
                    break;
            }
            return Helper.fDatatable(sSql);
        }
    }

}