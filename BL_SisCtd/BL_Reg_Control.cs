﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_Reg_Control
    {
        DL_Reg_Control oDL_Reg_Control = new DL_Reg_Control();
        #region Listados
        public DataTable Listar(string sIdControl, string sNroDocumento, string sRazonSocial, string sEstado)
        {
            return oDL_Reg_Control.Listar(sIdControl, sNroDocumento, sRazonSocial, sEstado);
        }

        public DataTable Listar_Detalle(string sIdControl)
        {
            return oDL_Reg_Control.Listar_Detalle(sIdControl);
        }

        #endregion

        #region Obtener Valores
        public BE_Reg_Control Get_Control(string nIdControl)
        {
            return oDL_Reg_Control.Get_Control(nIdControl);
        }

        //public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    return oDL_T_TipoDocumento.Existe_Ruta(oBE_T_TipoDocumentoRuta);
        //}

        public Boolean Existe_Imagen(string sIdControl)
        {
            return oDL_Reg_Control.Existe_Imagen(sIdControl);
        }
        public BE_Reg_ControlImagenes Get_Reg_ControlImagenes(string sIdCliente, string sIdImagen)
        {
            return oDL_Reg_Control.Get_Reg_ControlImagenes(sIdCliente,sIdImagen);
        }   
        #endregion

        #region Operaciones
        public string Insertar(BE_Reg_Control oBE_Reg_Control)
        {
            return oDL_Reg_Control.Insertar(oBE_Reg_Control);
        }
        public void Modificar(BE_Reg_Control oBE_Reg_Control)
        {
            oDL_Reg_Control.Modificar(oBE_Reg_Control);
        }
        public void Eliminar(string sIdControl)
        {
            oDL_Reg_Control.Eliminar(sIdControl);
        }

        public string Insertar_Archivo(BE_Reg_ControlImagenes oBE_Reg_ControlImagenes, string sIdControl)
        {
            return oDL_Reg_Control.Insertar_Archivo(oBE_Reg_ControlImagenes, sIdControl);
        }
        public void Quitar_Archivo(string sIdControl)
        {
            oDL_Reg_Control.Quitar_Archivo(sIdControl);
        }


        #endregion
    }
}