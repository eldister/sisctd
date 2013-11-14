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
    public partial class Frm_Reg_Control_List : Form
    {
        #region Declaración Variables
        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        //BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        Int32 nIdControl;
 
        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Control_List()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(dgControl);
        }
        private void Frm_Reg_Control_List_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
        }
        private void Frm_Reg_Control_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            switch (e.KeyCode)
            {
                case Keys.F3: bNuevo.PerformClick(); break;
                case Keys.F2: bModificar.PerformClick(); break;
                case Keys.F4: bEliminar.PerformClick(); break;
                case Keys.F5: Listar(0); Listar_Detalle(); break;
                case Keys.F7: bExportar.PerformClick(); break;
            }
        }
        private void Frm_Reg_Control_List_KeyPress(object sender, KeyPressEventArgs e)
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
                Dt = oBL_Reg_Control.Listar(txtNroDocumento.Text.Trim(), txtRazonSocial.Text.Trim(), cboEstado.Text);
                
                if (eListar == Helper.eListar.Grilla)
                {
                    dgControl.DataSource = Dt; Helper.FormatoGrilla(dgControl, false);
                    LblMensaje.Text = " Registros Encontrados : " + dgControl.Rows.Count.ToString();
                    dgControl.Columns["IdControl"].Width = 70;
                    dgControl.Columns["IdTipoDocumento"].Width = 70;
                    dgControl.Columns["IdMaestroCliente"].Visible = false;
                    dgControl.Columns["RazonSocial"].Width = 300;
                    dgControl.Columns["NroDocumento"].Width = 100;
                    dgControl.Columns["FechaDocumento"].Width = 100;
                    dgControl.Columns["IdRuta"].Visible = false;
                    dgControl.Columns["Descripción Ruta"].Width = 200;
                    dgControl.Columns["Observacion"].Width = 200;
                    dgControl.Columns["FechaInicio"].Width = 80;
                    dgControl.Columns["FechaTermino"].Width = 80;
                    dgControl.Columns["Estado"].Width = 80;
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
        private void Listar_Detalle()
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Get_IdControl(false);
                Dt = oBL_Reg_Control.Listar_Detalle(nIdControl);

                dgDetalle.DataSource = Dt; Helper.FormatoGrilla(dgDetalle, false);
                dgDetalle.Columns["NroSecuencia"].Visible = false;
                dgDetalle.Columns["Orden"].Width = 40;
                dgDetalle.Columns["IdActividad"].Visible = false;
                dgDetalle.Columns["Actividad"].Width = 100;
                dgDetalle.Columns["IdOficinaResponsable"].Visible = false;
                dgDetalle.Columns["Oficina"].Width = 150;
                dgDetalle.Columns["IdEmpleado"].Visible = false;
                dgDetalle.Columns["Empleado"].Width = 150;
                dgDetalle.Columns["IdArea"].Visible = false;
                dgDetalle.Columns["Area"].Width = 150;
                dgDetalle.Columns["Recibido"].Width = 30;
                dgDetalle.Columns["Visado"].Width = 30;
                dgDetalle.Columns["Firmado"].Width = 30;
                dgDetalle.Columns["Estado"].Width = 30;

                Listar_RutaActividad();
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private void Listar_RutaActividad()
        {
        //    DataTable Dt = new DataTable();
        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        Get_IdRuta(false);
        //        Dt = oBL_T_TipoDocumento.Listar_RutaActividad(sIdRuta);

        //        dgAnexos.DataSource = Dt; Helper.FormatoGrilla(dgAnexos, false);
        //        dgAnexos.Columns["Orden"].Width = 40;
        //        dgAnexos.Columns["IdActividad"].Width = 70;
        //        dgAnexos.Columns["Descripcion"].Width = 250;
        //        dgAnexos.Columns["Estado"].Width = 45;

        //        Dt.Dispose();
        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //    finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private bool Get_IdControl(bool bMsg)
        {
            if (dgControl.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Control", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nIdControl = 0;
                return false;
            }
            else 
            {
                nIdControl = Convert.ToInt32(dgControl.Rows[dgControl.CurrentCellAddress.Y].Cells[0].Value);
                return true; 
            }
        }
        //private bool Get_IdRuta(bool bMsg)
        //{
        //    if (dgDetalle.Rows.Count <= 0)
        //    {
        //        if (bMsg == true) MessageBox.Show("Seleccione una Ruta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        sIdRuta = "";
        //        return false;
        //    }
        //    else
        //    {
        //        sIdRuta = dgDetalle.Rows[dgDetalle.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();
        //        return true;
        //    }
        //}
        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_Reg_Control_Det fDet = new Frm_Reg_Control_Det(qOpcion, nIdControl);
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(dgControl, fDet.nIdControl.ToString(), 0);
                Listar_Detalle();
            }
            fDet.Dispose();

        }
        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }

        #endregion

        #region Eventos Menu
        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Detalle(Helper.eOpcion.Nuevo);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return; Abrir_Detalle(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return;
            try
            {
                if (MessageBox.Show("¿Está seguro que desea de Eliminar el Control : " + nIdControl + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                //oBL_Reg_Control.Eliminar(sIdControl);
                
                Listar(0);
                Listar_Detalle();
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Listar(0);
            Listar_Detalle();
        }

        private void dgControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_IdControl(true)== false) return; Abrir_Detalle(Helper.eOpcion.Consultar);
        }
        private void dgControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_IdControl(true) == false) return;
                Abrir_Detalle(Helper.eOpcion.Consultar);
            }
        }
        private void dgControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_Detalle();
        }
        private void dgDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_RutaActividad();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (Get_IdTipoDocumento(true) == false) return;
            //Regresar:
            //string sIdRuta = Helper.Buscar(oBL_T_Ruta.Buscar());
            //if (sIdRuta == "") return;
            //BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta = new BE_T_TipoDocumentoRuta();
            //oBE_T_TipoDocumentoRuta.IdTipoDocumento = sIdTipoDocumento;
            //oBE_T_TipoDocumentoRuta.IdRuta = sIdRuta;
            //if (oBL_T_TipoDocumento.Existe_Ruta(oBE_T_TipoDocumentoRuta))
            //{
            //    MessageBox.Show("La Ruta " + sIdRuta + " ya ha sido asignado al Tipo de Documento " + sIdTipoDocumento + ". Verificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    goto Regresar;
            //}

            //oBL_T_TipoDocumento.AgregarRuta(oBE_T_TipoDocumentoRuta);
            //Listar_Rutas();
            //Helper.Buscar_Grilla(dgDetalle, sIdRuta, 0);
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //Get_IdRuta(true);
            //if (sIdRuta == "") return;
            //BE_T_TipoDocumentoRuta oBE_T_TipoDocumentoRuta = new BE_T_TipoDocumentoRuta();
            //oBE_T_TipoDocumentoRuta.IdTipoDocumento = sIdTipoDocumento;
            //oBE_T_TipoDocumentoRuta.IdRuta = sIdRuta;

            //if (MessageBox.Show("¿Está seguro que desea de Quitar la Ruta : " + sIdRuta + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //oBL_T_TipoDocumento.QuitarRuta(oBE_T_TipoDocumentoRuta);
            //Listar_Rutas();
        }

        #endregion







    }
}