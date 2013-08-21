using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BLSisCtd;
namespace SisCtd
{
    public partial class Frm_T_TipoOperacion : Form
    {

        #region Declaración Variables
        Cls_T_TipoOperacion oTipoOperacion = new Cls_T_TipoOperacion();
        BL_Sis_Sistema oBL_Sis_Sistema = new BL_Sis_Sistema();

        private Boolean bPaso = false;
        private string sIdproducto = "";
        private string sIdTipoOperacion = "";
        private string sIdTipoDocumento = "";
        #endregion

        #region Iniciar Formulario
        public Frm_T_TipoOperacion()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;

            if (bModificar.Enabled == false)
            {
                bCritico.Enabled = false;
                bDgita.Enabled = false;
                btnAgregar.Enabled = false;
                btnQuitar.Enabled = false;
                btnBajar.Enabled = false;
                btnSubir.Enabled = false;
            }
            Helper.FormatoGrilla(Dg1, true);
        }
        private void Frm_T_TipoOperacion_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            bPaso = true;
        }
        private void Frm_T_TipoOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }
        private void Frm_T_TipoOperacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            switch (e.KeyCode)
            {
                case Keys.F3: bNuevo.PerformClick(); break;
                case Keys.F2: bModificar.PerformClick(); break;
                case Keys.F4: bEliminar.PerformClick(); break;
                case Keys.F7: bExportar.PerformClick(); break;
                case Keys.F5: Listar(0); break;
            }
        }
        #endregion

        #region Metodos
        private void Listar(int nOpc)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Dt = oTipoOperacion.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex, 2);

                if (nOpc == 0)
                {
                    Dg1.DataSource = Dt;
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                    Dt.Dispose();
                    Helper.FormatoGrilla(Dg1, true);
                    Dg1.Columns[0].Visible = false;
                    //Listar_Datos();
                }
                else
                {
                    Helper.Exportar(Dt, "Tipos_Operacion");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private void Listar_Documentos()
        {
            Get_IdTipoOperacion(false);
            try
            {
                Dg2.DataSource = oTipoOperacion.Listar_TipoOperacionTipoDocumentos("D", sIdproducto, sIdTipoOperacion, "");
                Helper.FormatoGrilla(Dg2, true);
                for (int i = 0; i < Dg2.Columns.Count; i++) Dg2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private Boolean Get_IdTipoOperacion(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Tipo de Operación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTransac.Text = ""; sIdproducto = ""; sIdTipoOperacion = ""; return false;
            }
            else
            {
                sIdTipoOperacion = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Id.Transac"].Value.ToString().Trim();
                sIdproducto = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["producto"].Value.ToString().Trim();
                lblTransac.Text = sIdTipoOperacion + " - " + Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Descripción"].Value.ToString();
                return true;
            }
        }
        private string Get_IdDocu(bool bMsg)
        {
            if (Dg2.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Documento", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            else { return Dg2.Rows[Dg2.CurrentCellAddress.Y].Cells["id"].Value.ToString().Trim(); }
        }
        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }
        private void Abrir_Det(int nOpc)
        {
            Frm_T_TipoOperacion_Det fDet = new Frm_T_TipoOperacion_Det(nOpc, sIdproducto, sIdTipoOperacion);
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(Dg1, fDet.sIdproducto +fDet.sIdTipoOperacion, 0);
                Listar_Documentos();
            } fDet.Dispose();
        }
        #endregion

        #region Eventos Menu
        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Det(3);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            Abrir_Det(2);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;

            if (oTipoOperacion.Existe_Operaciones(sIdproducto, sIdTipoOperacion) == true)
            {
                MessageBox.Show("El Tipo de Documento " + sIdTipoOperacion.Trim() + " ya se encuentra registrado en Operaciones", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Tipo de Transacción : " + sIdTipoOperacion.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oTipoOperacion.Eliminar(sIdproducto, sIdTipoOperacion);
                Listar(0); Listar_Documentos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bCritico_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            string sCritico = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["critico"].Value.ToString().Trim();
            Boolean bCritico = !(sCritico == "Si");

            Regresar:
            string sValor = "";
            if (Helper.InputBox("Cambiar Criticidad",
                "Ingrese un motivo por el cual desea " + (bCritico ? "ACTIVAR" : "DESACTIVAR") + " la Criticidad del Tipo de Operación " + sIdTipoOperacion, 100, true, ref sValor) == DialogResult.Cancel) return;

            if (sValor == "")
            {
                MessageBox.Show("Debe ingresar un motivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }
            oTipoOperacion.Upd_Critico(sIdproducto, sIdTipoOperacion, bCritico);

            oBL_Sis_Sistema.Grabar_Historial(Helper.oBE_Sis_Cliente.IdCliente, "TipoOperacion", "Critico", sIdproducto + "_" + sIdTipoOperacion, "Update", Convert.ToString(!bCritico), Convert.ToString(bCritico), sValor,Helper.oBE_Sis_Usuario.IdUsuario);

            string sId = sIdproducto + sIdTipoOperacion;
            Listar(0);
            Helper.Buscar_Grilla(Dg1, sId, 0);
            Listar_Documentos();
        }
        private void bDgita_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            string sDigita = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Digita"].Value.ToString().Trim();
            Boolean bDigita = !(sDigita == "Si");

            Regresar:
            string sValor = "";
            if (Helper.InputBox("Cambiar Digitalizable",
                "Ingrese un motivo por el cual desea " + (bDigita ? "ACTIVAR" : "DESACTIVAR") + " la Digitabilidad del Tipo de Operación " + sIdTipoOperacion, 100, true, ref sValor) == DialogResult.Cancel) return;

            if (sValor == "")
            {
                MessageBox.Show("Debe ingresar un motivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }
            oTipoOperacion.Upd_Digitalizable(sIdproducto, sIdTipoOperacion, bDigita);

            oBL_Sis_Sistema.Grabar_Historial(Helper.oBE_Sis_Cliente.IdCliente, "TipoOperacion", "Digita", sIdproducto + "_" + sIdTipoOperacion, "Update", Convert.ToString(!bDigita), Convert.ToString(bDigita), sValor, Helper.oBE_Sis_Usuario.IdUsuario);
            string sId = sIdproducto + sIdTipoOperacion;
            Listar(0);
            Helper.Buscar_Grilla(Dg1, sId, 0);
            Listar_Documentos();
            
        }
        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(1);
        }
        private void bHistorial_Click(object sender, EventArgs e)
        {
            Helper.Exportar(oBL_Sis_Sistema.Listar_Historial("'TipoOperacion','TipoOperacionAnexos'",Helper.oBE_Sis_Cliente.IdCliente), "Tipos_Operacion_Historial");
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }

        #endregion

        #region Eventos Objetos
        private void txtIddocu_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtIddocu.Text, 0);
            Listar_Documentos();
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar(0);
        }
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!Get_IdTipoOperacion(true)) return;
                Abrir_Det(1);
            }
        }
        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            if (bPaso == true) Listar_Documentos();
        }
        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            Abrir_Det(1);
        }
        private void btnSubirBajar_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            if (Get_IdDocu(true) == "") return;

            Button btn = (Button)sender;
            sIdTipoDocumento = Get_IdDocu(false);

            if (btn.Name == "btnSubir")
                oTipoOperacion.Orden_Subir(sIdproducto, sIdTipoOperacion, sIdTipoDocumento);
            else
                oTipoOperacion.Orden_Bajar(sIdproducto, sIdTipoOperacion, sIdTipoDocumento);

            Listar_Documentos();
            Helper.Buscar_Grilla(Dg2, sIdTipoDocumento, 0);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (!Get_IdTipoOperacion(true)) return;
            //Helper.eTablaBus = Helper.eTablas.TiposDoc;
            //sIdTipoDocumento = Helper.Buscar();
            //if (sIdTipoDocumento != "")
            //{
            //    if (oTipoOperacion.Existe_Documento(sIdproducto, sIdTipoOperacion, sIdTipoDocumento))
            //    {
            //        MessageBox.Show("El Registro Seleccionado ya ha sido Ingresado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //    }

            //    oTipoOperacion.Agregar_TipoDocumento(sIdproducto, sIdTipoOperacion, sIdTipoDocumento);
            //    Listar_Documentos();
            //    Helper.Buscar_Grilla(Dg2, sIdTipoDocumento, 0);
            //}
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            if (Get_IdDocu(true) == "") return;

            sIdTipoDocumento = Get_IdDocu(false);

            if (MessageBox.Show("¿Está seguro de que desea Quitar el Tipo de Documento : " + sIdTipoDocumento.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oTipoOperacion.Quitar_TipoDocumento(sIdproducto, sIdTipoOperacion, sIdTipoDocumento);
                Listar_Documentos();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnCritico_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            if (Get_IdDocu(true) == "") return;
            sIdTipoDocumento = Get_IdDocu(false);

            string sCritico = Dg2.Rows[Dg2.CurrentCellAddress.Y].Cells["critico"].Value.ToString().Trim();
            Boolean bCritico = !(sCritico == "Si");

            Regresar:
            string sValor = "";
            if (Helper.InputBox("Cambiar Criticidad",
                "Ingrese un motivo por el cual desea " + (bCritico ? "ACTIVAR" : "DESACTIVAR") + " Criticidad del Anexo " + sIdTipoDocumento, 100, true, ref sValor) == DialogResult.Cancel) return;

            if (sValor == "")
            {
                MessageBox.Show("Debe ingresar un motivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }
            oTipoOperacion.Upd_Critico_TipoDocumento(sIdproducto, sIdTipoOperacion, sIdTipoDocumento, bCritico);

            oBL_Sis_Sistema.Grabar_Historial(Helper.oBE_Sis_Cliente.IdCliente, "TipoOperacionAnexos", "Critico", sIdproducto + "_" + sIdTipoOperacion + "_" + sIdTipoDocumento, "Update", Convert.ToString(!bCritico), Convert.ToString(bCritico), sValor, Helper.oBE_Sis_Usuario.IdUsuario);
            
            Listar_Documentos();
            Helper.Buscar_Grilla(Dg2, sIdTipoDocumento, 0);
        }
        private void btnDigita_Click(object sender, EventArgs e)
        {
            if (!Get_IdTipoOperacion(true)) return;
            if (Get_IdDocu(true) == "") return;
            sIdTipoDocumento = Get_IdDocu(false);

            string sDigita = Dg2.Rows[Dg2.CurrentCellAddress.Y].Cells["Digita"].Value.ToString().Trim();
            Boolean bDigita = !(sDigita == "Si");

            Regresar:
            string sValor = "";
            if (Helper.InputBox("Cambiar Digitalizable",
                "Ingrese un motivo por el cual desea " + (bDigita ? "ACTIVAR" : "DESACTIVAR") + " la Digitabilidad del Anexo " + sIdTipoDocumento, 100, true, ref sValor) == DialogResult.Cancel) return;

            if (sValor == "")
            {
                MessageBox.Show("Debe ingresar un motivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }
            oTipoOperacion.Upd_Digitalizable_TipoDocumento(sIdproducto, sIdTipoOperacion, sIdTipoDocumento, bDigita);

            oBL_Sis_Sistema.Grabar_Historial(Helper.oBE_Sis_Cliente.IdCliente, "TipoOperacionAnexos", "Digita", sIdproducto + "_" + sIdTipoOperacion + "_" + sIdTipoDocumento, "Update", Convert.ToString(!bDigita), Convert.ToString(bDigita), sValor, Helper.oBE_Sis_Usuario.IdUsuario);

            Listar_Documentos();
            Helper.Buscar_Grilla(Dg2, sIdTipoDocumento, 0);
        }
        #endregion

    }
}