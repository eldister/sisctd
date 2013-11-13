using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;

namespace BESisCtd
{
    public partial class Frm_T_Rutas_List : Form
    {
        #region Declaración Variables
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Rutas_List()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1);
        }
        private void Frm_T_Listados_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
        }
        private void Frm_T_Listados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            switch (e.KeyCode)
            {
                case Keys.F3: bNuevo.PerformClick(); break;
                case Keys.F2: bModificar.PerformClick(); break;
                case Keys.F4: bEliminar.PerformClick(); break;
                case Keys.F5: Listar(0); break;
                case Keys.F7: bExportar.PerformClick(); break;
            }
        }
        private void Frm_T_Listados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }

        #endregion

        #region Metodos
        private void Listar(Helper.eListar eListar)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Dt = oBL_T_Ruta.Listar(txtDescripcion.Text, cboEstado.Text.Substring(0,1));
                
                if (eListar == Helper.eListar.Grilla)
                {
                    Dg1.DataSource = Dt; Helper.FormatoGrilla(Dg1);
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                }
                else
                {
                    Helper.Exportar(Dt, "TiposDocumento");
                }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private string Get_Id(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            else { return Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim(); }
        }
        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_T_Detalle fDet = new Frm_T_Detalle(qOpcion, Helper.eTablas.Rutas, Get_Id(false));
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(Dg1, fDet.sIdtabla, 0);
            }
            fDet.Dispose();

        }
        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }
        private void Listar_RutaActividad()
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Get_IdRuta(false);
                Dt = oBL_T_TipoDocumento.Listar_RutaActividad(sIdRuta);

                dgActividades.DataSource = Dt; Helper.FormatoGrilla(dgActividades, false);
                dgActividades.Columns["Orden"].Width = 40;
                dgActividades.Columns["IdActividad"].Width = 70;
                dgActividades.Columns["Descripcion"].Width = 250;
                dgActividades.Columns["Estado"].Width = 45;

                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }

        #endregion

        #region Eventos Menu
        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Detalle(Helper.eOpcion.Nuevo);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (Get_Id(true) == "") return; Abrir_Detalle(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            string sId = Get_Id(true); if (sId == "") return;
            try
            {
                if (MessageBox.Show("¿Está seguro que desea de Eliminar la Posicion : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                oBL_T_Ruta.Eliminar(sId);
                
                Listar(0);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(Helper.eListar.Excel);
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }

        #endregion

        #region Eventos Objetos
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtCodigo.Text, 0);
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Listar(0);
        }

        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_Id(true) == "") return; Abrir_Detalle(Helper.eOpcion.Consultar);
        }
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_Id(true) == "") return;
                Abrir_Detalle(Helper.eOpcion.Consultar);
            }
        }
        private void dgActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_RutaActividad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Get_IdTipoDocumento(true) == false) return;
        Regresar:
            string sIdRuta = Helper.Buscar(oBL_T_Ruta.Buscar());
            if (sIdRuta == "") return;
            BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta = new BE_T_TipoDocumentoRuta();
            oBE_T_TipoDocumentoRuta.IdTipoDocumento = sIdTipoDocumento;
            oBE_T_TipoDocumentoRuta.IdRuta = sIdRuta;
            if (oBL_T_TipoDocumento.Existe_Ruta(oBE_T_TipoDocumentoRuta))
            {
                MessageBox.Show("La Ruta " + sIdRuta + " ya ha sido asignado al Tipo de Documento " + sIdTipoDocumento + ". Verificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }

            oBL_T_TipoDocumento.AgregarRuta(oBE_T_TipoDocumentoRuta);
            Listar_Rutas();
            Helper.Buscar_Grilla(dgRutas, sIdRuta, 0);
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Get_IdRuta(true);
            if (sIdRuta == "") return;
            BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta = new BE_T_TipoDocumentoRuta();
            oBE_T_TipoDocumentoRuta.IdTipoDocumento = sIdTipoDocumento;
            oBE_T_TipoDocumentoRuta.IdRuta = sIdRuta;

            if (MessageBox.Show("¿Está seguro que desea de Quitar la Ruta : " + sIdRuta + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            oBL_T_TipoDocumento.QuitarRuta(oBE_T_TipoDocumentoRuta);
            Listar_Rutas();
        }



        #endregion

    }
}