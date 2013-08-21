using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace SisCtd
{
    public partial class Frm_T_Separadoras : Form
    {

        #region Declaración Variables

        Cls_T_Separadoras oSeparadoras = new Cls_T_Separadoras();
        Cls_Sis_Sistema oSistema = new Cls_Sis_Sistema();

        private Boolean bPaso = false;
        private string sIdSeparadora = "";
        private string sIdTipoDocumento = "";
        #endregion

        #region Iniciar Formulario
        public Frm_T_Separadoras()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;

            if (bModificar.Enabled == false)
            {
                btnAgregar.Enabled = false;
                btnQuitar.Enabled = false;
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
                Dt = oSeparadoras.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex);

                if (nOpc == 0)
                {
                    Dg1.DataSource = Dt;
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                    Dt.Dispose();
                    Helper.FormatoGrilla(Dg1, true);
                }
                else
                {
                    Helper.Exportar(Dt, "Separadoras");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private void Listar_Documentos()
        {
            Get_IdSeparadora(false);
            try
            {
                Dg2.DataSource = oSeparadoras.Listar_TiposDocumento(sIdSeparadora);
                Helper.FormatoGrilla(Dg2, true);
                for (int i = 0; i < Dg2.Columns.Count; i++) Dg2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private Boolean Get_IdSeparadora(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Separadora", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblSeparadora.Text = ""; sIdSeparadora = ""; return false;
            }
            else
            {
                sIdSeparadora = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Id"].Value.ToString().Trim();
                lblSeparadora.Text = sIdSeparadora + " - " + Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Descripción"].Value.ToString();
                return true;
            }
        }
        private string Get_IdTipoDocumento(bool bMsg)
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
            Frm_T_Separadoras_Det fDet = new Frm_T_Separadoras_Det(nOpc,sIdSeparadora);
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(Dg1, fDet.sIdSeparadora, 0);
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
            if (!Get_IdSeparadora(true)) return;
            Abrir_Det(2);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (!Get_IdSeparadora(true)) return;

            if (oSeparadoras.Existe_TiposDocumento(sIdSeparadora) == true)
            {
                MessageBox.Show("El Separador " + sIdSeparadora.Trim() + " tiene Tipos de Documentos registrados. Verificar ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Tipo de Transacción : " + sIdSeparadora.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oSeparadoras.Eliminar(sIdSeparadora);
                Listar(0); Listar_Documentos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(1);
        }
        private void bHistorial_Click(object sender, EventArgs e)
        {
            Helper.Exportar(oSistema.Listar_Historial("'TipoOperacion','TipoOperacionAnexos'"), "Tipos_Operacion_Historial");
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }

        #endregion

        #region Eventos Objetos
        private void txtIdSeparadora_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, IdSeparadora.Text, 0);
            Listar_Documentos();
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar(0);
            Listar_Documentos();
        }
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!Get_IdSeparadora(true)) return;
                Abrir_Det(1);
            }
        }
        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            if (bPaso == true) Listar_Documentos();
        }
        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Get_IdSeparadora(true)) return;
            Abrir_Det(1);
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Get_IdSeparadora(true)) return;
            Helper.eTablaBus = Helper.eTablas.TiposDoc_RRHH;
            sIdTipoDocumento = Helper.Buscar();
            if (sIdTipoDocumento != "")
            {
                //if (oSeparadoras.Existe(sIdSeparadora))
                //{
                //    MessageBox.Show("El Registro Seleccionado ya ha sido Ingresado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                //}

                oSeparadoras.Agregar_TipoDocumento(sIdSeparadora, sIdTipoDocumento);
                Listar_Documentos();
                Helper.Buscar_Grilla(Dg2, sIdTipoDocumento, 0);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (!Get_IdSeparadora(true)) return;
            if (Get_IdTipoDocumento(true) == "") return;

            sIdTipoDocumento = Get_IdTipoDocumento(false);

            if (MessageBox.Show("¿Está seguro de que desea Quitar el Tipo de Documento : " + sIdTipoDocumento.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {   //ANTES DE QUITAR ESTOS NO DEBEN TENER REGISTROS
                oSeparadoras.Quitar_TipoDocumento(sIdTipoDocumento);
                Listar_Documentos();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
    
        #endregion

    }
}