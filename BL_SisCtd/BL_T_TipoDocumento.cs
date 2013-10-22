using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESisCtd;
using System.Data;
using DLSisCtd;

namespace BLSisCtd
{
    public class BL_T_TipoDocumento
    {
        DL_T_TipoDocumento oDL_T_TipoDocumento = new DL_T_TipoDocumento();
        #region Listados
        public DataTable Listar(string sDescripcion, string sEstado)
        {
            return oDL_T_TipoDocumento.Listar(sDescripcion, sEstado);
        }
        public DataTable Buscar()
        {
            return oDL_T_TipoDocumento.Buscar();
        }
        public DataTable Listar_Rutas(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Listar_Rutas(sIdTipoDocumento);
        }
        public DataTable Listar_RutaActividad(string sIdRuta)
        {
            return oDL_T_TipoDocumento.Listar_RutaActividad(sIdRuta);
        }
        #endregion

        #region Obtener Valores
        public BE_T_TipoDocumento Get_TipoDocumento(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Get_TipoDocumento(sIdTipoDocumento);
        }
        public string Get_Descripcion(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Get_Descripcion(sIdTipoDocumento);
        }
        public Boolean Existe(string sIdTipoDocumento)
        {
            return oDL_T_TipoDocumento.Existe(sIdTipoDocumento);
        }
        public Boolean Existe_Ruta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            return oDL_T_TipoDocumento.Existe_Ruta(oBE_T_TipoDocumentoRuta);
        }
        #endregion

        #region Operaciones
        public void Insertar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            oDL_T_TipoDocumento.Insertar(oBE_T_TipoDocumento);
        }
        public void Modificar(BE_T_TipoDocumento oBE_T_TipoDocumento)
        {
            oDL_T_TipoDocumento.Modificar(oBE_T_TipoDocumento);
        }
        public void Eliminar(string sIdTipoDocumento)
        {
            oDL_T_TipoDocumento.Eliminar(sIdTipoDocumento);
        }

        public void AgregarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            oDL_T_TipoDocumento.AgregarRuta(oBE_T_TipoDocumentoRuta);
        }
        public void QuitarRuta(BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta)
        {
            oDL_T_TipoDocumento.QuitarRuta(oBE_T_TipoDocumentoRuta);
        }
        #endregion
    }
}
