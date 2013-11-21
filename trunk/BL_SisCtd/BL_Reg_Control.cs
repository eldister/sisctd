using System;
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

        public DataTable Listar_Detalle(Int32 nIdControl)
        {
            return oDL_Reg_Control.Listar_Detalle(nIdControl);
        }

        #endregion

        #region Obtener Valores
        public BE_Reg_Control Get_Control(Int32 nIdControl)
        {
            return oDL_Reg_Control.Get_Control(nIdControl);
        }

        //public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    return oDL_T_TipoDocumento.Existe_Ruta(oBE_T_TipoDocumentoRuta);
        //}

        public Boolean Existe_Imagen(Int32 nIdControl)
        {
            return oDL_Reg_Control.Existe_Imagen(nIdControl);
        }
        public BE_Reg_ControlImagenes Get_Reg_ControlImagenes(string sIdCliente, string sIdImagen)
        {
            return oDL_Reg_Control.Get_Reg_ControlImagenes(sIdCliente,sIdImagen);
        }   
        #endregion

        #region Operaciones
        public Int32 Insertar(BE_Reg_Control oBE_Reg_Control)
        {
            return oDL_Reg_Control.Insertar(oBE_Reg_Control);
        }
        public void Modificar(BE_Reg_Control oBE_Reg_Control)
        {
            oDL_Reg_Control.Modificar(oBE_Reg_Control);
        }
        public string Insertar_Archivo(BE_Reg_ControlImagenes oBE_Reg_ControlImagenes, int nIdControl)
        {
            return oDL_Reg_Control.Insertar_Archivo(oBE_Reg_ControlImagenes, nIdControl);
        }
        public void Quitar_Archivo(int nIdControl)
        {
            oDL_Reg_Control.Quitar_Archivo(nIdControl);
        }
        //public void Eliminar(string sIdTipoDocumento)
        //{
        //    oDL_T_TipoDocumento.Eliminar(sIdTipoDocumento);
        //}

        //public void AgregarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    oDL_T_TipoDocumento.AgregarRuta(oBE_T_TipoDocumentoRuta);
        //}
        //public void QuitarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        //{
        //    oDL_T_TipoDocumento.QuitarRuta(oBE_T_TipoDocumentoRuta);
        //}
        #endregion
    }
}
