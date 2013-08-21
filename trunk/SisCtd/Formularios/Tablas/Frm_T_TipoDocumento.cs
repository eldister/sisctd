using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_TipoDocumento : Form
    {
        
        public Frm_T_TipoDocumento()
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
                btnBajar.Enabled = false;
                btnSubir.Enabled = false;
            }
            Helper.FormatoGrilla(Dg1, true);
        }
        Cls_T_TipoDocumentos oTipoDoc = new Cls_T_TipoDocumentos();

        private Boolean bPaso = false;
        private string sIddocu = "";
        private string sIddato = "";
        private void Frm_T_TipoDocumento_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            bPaso = true;
        }

        private void Frm_T_TipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }
        private void Frm_T_TipoDocumento_KeyDown(object sender, KeyEventArgs e)
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

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar(0); 
        }

        private void txtIddocu_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtIddocu.Text, 0);
            Listar_Datos();
        }
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_IdDocu(true) == "") return;
                Abrir_Det(1);
            }
        }
        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            if (bPaso == true) Listar_Datos();
        }

        # region Botones_Mantenimiento
        // BOTONES DE MANTENIMIENTO

            private void bNuevo_Click(object sender, EventArgs e)
            {
                Abrir_Det(3);
            }

            private void bModificar_Click(object sender, EventArgs e)
            {
                if (Get_IdDocu(true) == "") return;
                Abrir_Det(2);
            }

            private void bEliminar_Click(object sender, EventArgs e)
            {
                if (Get_IdDocu(true) == "") return;

                if (oTipoDoc.Existe_Productos(sIddocu) == true)
                {
                    MessageBox.Show("El Tipo de Documento " + sIddocu.Trim() + " se encuentra en uno o más Productos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (oTipoDoc.Existe_Documentos(sIddocu) == true)
                {
                    MessageBox.Show("El Tipo de Documento " + sIddocu.Trim() + " ya se encuentra registrado en Documentos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea de Eliminar el Documento : " + sIddocu.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                try
                {
                    oTipoDoc.Eliminar(sIddocu);
                    Listar(0); Listar_Datos();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            private void bExportar_Click(object sender, EventArgs e)
            {
                Listar(1);
            }

            private void bCerrar_Click(object sender, EventArgs e)
            {
                oCancelar();
            }

        # endregion

        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_IdDocu(true) == "") return;
            Abrir_Det(1);
        }

        # region Botones_Grilla
        // BOTONES QUE SON PARTE DEL MANTENIMIENTO DE LA GRILLA

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                if (Get_IdDocu(true) == "") return;
                Helper.eTablaBus = Helper.eTablas.Datos;
                sIddato = Helper.Buscar();
                if (sIddato != "")
                {
                    if (oTipoDoc.Existe_Dato(sIddocu, sIddato))
                    {
                        MessageBox.Show("El Registro Seleccionado ya ha sido Ingresado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }

                    oTipoDoc.Grabar_Dato(sIddocu, sIddato);
                    Listar_Datos();
                    Helper.Buscar_Grilla(Dg2, sIddato, 0);
                }
            }

            private void btnQuitar_Click(object sender, EventArgs e)
            {
                if (Get_IdDato(true) == "") return;

                sIddocu = Get_IdDocu(false);
                sIddato = Get_IdDato(false);

                if (MessageBox.Show("¿Está seguro de que desea Quitar el Dato : " + sIddato.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                try
                {
                    oTipoDoc.Eliminar_Dato(sIddocu, sIddato);
                    Listar_Datos();
                }
                catch (Exception Er)
                { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            private void btnSubirBajar_Click(object sender, EventArgs e)
            {
                if (Get_IdDato(true) == "") return;

                Button btn = (Button)sender;
                sIddocu = Get_IdDocu(false);
                sIddato = Get_IdDato(false);

                if (btn.Name == "btnSubir")
                    oTipoDoc.Orden_SubirDato(sIddocu, sIddato);
                else
                    oTipoDoc.Orden_BajarDato(sIddocu, sIddato);

                Listar_Datos();
                Helper.Buscar_Grilla(Dg2, sIddato, 0);
            }

        # endregion

        private void Listar(int nOpc)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Dt = oTipoDoc.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex, 2);

                if (nOpc == 0)
                {
                    Dg1.DataSource = Dt;
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                    Dt.Dispose();
                    Helper.FormatoGrilla(Dg1, true);
                    Listar_Datos();
                }
                else
                {
                    Helper.Exportar(Dt, "Anexos");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }

        private void Listar_Datos()
        {
            sIddocu = Get_IdDocu(false);
            try
            {
                Dg2.DataSource = oTipoDoc.Listar_Datos("D", sIddocu, "");
                Helper.FormatoGrilla(Dg2, true);
                for (int i = 0; i < Dg2.Columns.Count; i++) Dg2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private string Get_IdDocu(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Documento", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDoc.Text = ""; return "";
            }
            else
            {
                sIddocu = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["id"].Value.ToString().Trim();
                lblDoc.Text = sIddocu + " - " + Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Descripcion"].Value.ToString();
                return sIddocu;
            }
        }

        private string Get_IdDato(bool bMsg)
        {
            if (Dg2.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Dato", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Frm_T_TipoDocumento_Det fDet = new Frm_T_TipoDocumento_Det(nOpc, Get_IdDocu(false));
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(Dg1, fDet.sIddocu, 0);
                Listar_Datos();
            } fDet.Dispose();
        }

    }
}