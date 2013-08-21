using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Productos : Form
    {
        public Frm_T_Productos()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            if (bModificar.Enabled == false)
            {
                btnAgregarDoc.Enabled = false;
                btnQuitarDoc.Enabled = false;
                btnAgregarDato.Enabled = false;
                btnQuitarDato.Enabled = false;
            }
            Helper.FormatoGrilla(Dg1, true);
        }
        Cls_T_Productos oProductos = new Cls_T_Productos();
        private Boolean bPaso = false;

        private string sIddocu = "", sIddato = "",sIdprod = "";
        private void Frm_T_Productos_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            bPaso = true;
        }

        private void Frm_T_Productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }
        private void Frm_T_Productos_KeyDown(object sender, KeyEventArgs e)
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

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar(0); Listar_Documentos(); Listar_Datos();
        }

        private void txtIddocu_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtIdprod.Text, 0);
            Listar_Documentos();
        }

        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            if (bPaso == false) return;
            Listar_Documentos(); Listar_Datos();
        }

        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_IdProd(true) == "") return;
                Abrir_Det(1);
            }
        }
        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_IdProd(true) == "") return;
            Abrir_Det(1);
        }
        private void Dg2_SelectionChanged(object sender, EventArgs e)
        {
            if (bPaso == false) return;
            Listar_Datos();
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Det(3);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (Get_IdProd(true) == "") return;
            Abrir_Det(2);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (Get_IdProd(true) == "") return;

            if (oProductos.Existe_ProductoTipoDocumentos(sIdprod) == true)
            {
                MessageBox.Show("El Producto " + sIdprod + " tiene Tipos de Documento asignados. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (oProductos.Existe_Subproductos(sIdprod) == true)
            {
                MessageBox.Show("El Producto " + sIdprod + " tiene Sub-Productos asignados. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (oProductos.Existe_Operaciones(sIdprod) == true)
            {
                MessageBox.Show("El Producto " + sIdprod + " se encuentra en uno o más Contratos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Producto : " + sIdprod.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oProductos.Eliminar(sIdprod);
                Listar(0); Listar_Documentos(); Listar_Datos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(1);
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }



        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (Get_IdProd(true) == "") return;
                Helper.eTablaBus = Helper.eTablas.TiposDoc;
                sIdprod = Get_IdProd(false);
                string sIddocu = Helper.Buscar();
                if (sIddocu != "")
                {
                    if (oProductos.Existe_ProductoTipoDocumento(sIdprod, sIddocu))
                    {
                        MessageBox.Show("El Registro Seleccionado ya ha sido Ingresado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    oProductos.Grabar_ProductoTipoDocumento(sIdprod, sIddocu);
                    Listar_Documentos();
                    Helper.Buscar_Grilla(Dg2, sIddocu, 0); Listar_Datos();
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnQuitarDoc_Click(object sender, EventArgs e)
        {
            if (Get_Iddocu(true) == "") return;
            sIdprod = Get_IdProd(false);

            if (MessageBox.Show("¿Está seguro de que desea Quitar el Tipo de Documento : " + sIddocu.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oProductos.Eliminar_ProductoTipoDocumentoDato(sIdprod, sIddocu);
                Listar_Documentos(); Listar_Datos();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarDato_Click(object sender, EventArgs e)
        {
            try
            {
                if (Get_Iddocu(true) == "") return;
                Helper.eTablaBus = Helper.eTablas.TiposDoc_Datos;
                sIdprod = Get_IdProd(false);
                sIddocu = Get_Iddocu(false);
                Helper.sParamBus1 = sIddocu;
                sIddato = Helper.Buscar();
                if (sIddato != "")
                {
                    if (oProductos.Existe_ProductoTipoDocumentoDato(sIdprod, sIddocu,sIddato))
                    {
                        MessageBox.Show("El Registro Seleccionado ya ha sido Ingresado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    oProductos.Grabar_Dato(sIdprod, sIddocu, sIddato);
                    Listar_Datos();
                    Helper.Buscar_Grilla(Dg3, sIddato, 0);
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQuitarDato_Click(object sender, EventArgs e)
        {
            if (Get_IdDato(true) == "") return;
            sIdprod = Get_IdProd(false);
            sIddocu = Get_Iddocu(false);
            sIddato = Get_IdDato(false);
            if (MessageBox.Show("¿Está seguro de que desea Quitar el Dato : " + sIddato.Trim() + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oProductos.Eliminar_ProductoTipoDocumentoDato(sIdprod, sIddocu, sIddato);
                Listar_Datos();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Listar(int nOpc)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Dt = oProductos.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex);
                if (nOpc == 0)
                {
                    Dg1.DataSource = Dt; Helper.FormatoGrilla(Dg1, true);
                    Dg1.Columns["des"].Visible = false;
                    Dt.Dispose();
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                }
                else
                {
                    Helper.Exportar(Dt, "Productos");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }

        private void Abrir_Det(int nOpc)
        {
            Frm_T_Productos_Det fDet = new Frm_T_Productos_Det(nOpc, Get_IdProd(false));
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(0);
                Helper.Buscar_Grilla(Dg1, fDet.sIdprod, 0);
                Listar_Documentos(); Listar_Datos();
            } fDet.Dispose();
        }


        private void Listar_Documentos()
        {
            sIdprod = Get_IdProd(false);
            try
            {
                Dg2.DataSource = oProductos.Listar_ProductoTipoDocumentos(sIdprod); 
                Helper.FormatoGrilla(Dg2, true);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Listar_Datos()
        {
            sIdprod = Get_IdProd(false);
            sIddocu = Get_Iddocu(false);
            try
            {
                Dg3.DataSource = oProductos.Listar_ProductoTipoDocumentoDatos(sIdprod, sIddocu);
                Helper.FormatoGrilla(Dg3, true);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }

        private string Get_IdProd(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblIdProd.Text = ""; return "";
            }
            else
            {
                sIdprod = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Id"].Value.ToString().Trim();
                lblIdProd.Text = sIdprod + " - " + Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["descripción"].Value.ToString();
                return sIdprod; 
            }
        }

        private string Get_Iddocu(bool bMsg)
        {
            if (Dg2.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Documento", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblIddocu.Text = ""; return "";
            }
            else
            { 
                sIddocu = Dg2.Rows[Dg2.CurrentCellAddress.Y].Cells["id"].Value.ToString().Trim();
                lblIddocu.Text = sIddocu + " - " + Dg2.Rows[Dg2.CurrentCellAddress.Y].Cells["descripción"].Value.ToString();
                return sIddocu; 
            }
        }

        private string Get_IdDato(bool bMsg)
        {
            if (Dg3.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Dato", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            else { return Dg3.Rows[Dg3.CurrentCellAddress.Y].Cells["id"].Value.ToString(); }
        }
    }
}