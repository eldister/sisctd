using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Listados : Form
    {

        public Frm_T_Listados(Helper.eTablas Tabla)
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1);
            eTabla = Tabla;
        }
        Helper.eTablas eTabla;
        Cls_T_Territorios oTerritorios = new Cls_T_Territorios();
        Cls_T_Datos oDatos = new Cls_T_Datos();
        Cls_T_Estados oEstados = new Cls_T_Estados();
        Cls_T_Areas oAreas = new Cls_T_Areas();
        Cls_T_SubProductos oSubprod = new Cls_T_SubProductos();
        Cls_T_Oficinas oOficinas = new Cls_T_Oficinas();
        Cls_T_Tarjetas oTarjetas = new Cls_T_Tarjetas();
        Cls_T_Ejecutivos oEjecutivos = new Cls_T_Ejecutivos();

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

        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }
        private void Listar(int nOpc)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                switch (eTabla)
                {
                    case Helper.eTablas.Territorios: Dt = oTerritorios.Listar(txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.Datos: Dt = oDatos.Listar("D",txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.Estados: Dt = oEstados.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.Areas: Dt = oAreas.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.SubProductos: Dt = oSubprod.Listar(txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.Oficinas: 
                        Dt = oOficinas.Listar("D",txtDescrip.Text);
                        lblEstado.Visible = false; cboEstado.Visible = false; break;
                    
                    case Helper.eTablas.Tarjetas: Dt = oTarjetas.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                    case Helper.eTablas.Ejecutivos: Dt = oEjecutivos.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                }
                if (nOpc == 0)
                {
                    Dg1.DataSource = Dt; Helper.FormatoGrilla(Dg1);
                    Dg1.Columns["des"].Visible = false;
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                    switch (eTabla)
                    {
                        case Helper.eTablas.SubProductos: Dg1.Columns["id"].Visible = false; break;
                        case Helper.eTablas.Oficinas :
                            Dg1.Columns["idubigeo"].Visible = false;
                            Dg1.Columns["Ubicaci�n Geogr�fica"].Visible = false;
                            Dg1.Columns["Direcci�n"].Visible = false; break;
                    }
                }
                else
                {
                    Helper.Exportar(Dt, eTabla.ToString());
                }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
       
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_Id(true) == "") return;
                Abrir_Det(1);
            }
        }

        private void txtIdterri_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtCodigo.Text, 0);
        }

        private void txtDescrip_TextChanged(object sender, EventArgs e)
        {
            Listar(0);
        }

        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_Id(true) == "") return; Abrir_Det(1);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Det(3);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (Get_Id(true) == "") return; Abrir_Det(2);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            string sId = Get_Id(true); if (sId == "") return;
            try
            {
                switch (eTabla)
                {
                    case Helper.eTablas.Territorios:
                        if (oTerritorios.Existe_Oficinas(sId) == true)
                        {
                            MessageBox.Show("El Territorio ya ha sido asignado a una o m�s oficinas. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar el Territorio : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oTerritorios.Eliminar(sId);
                        break;
                    case Helper.eTablas.Datos:
                        if (oDatos.Existe_Productos(sId) == true)
                        {
                            MessageBox.Show("El Dato ya ha sido asignado a uno o m�s Productos. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (oDatos.Existe_TipoDoc(sId) == true)
                        {
                            MessageBox.Show("El Dato ya ha sido asignado a uno o m�s Tipos de Documento. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar el Dato : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oDatos.Eliminar(sId);
                        break;
                    case Helper.eTablas.Estados:
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar el Estado : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oEstados.Eliminar(sId);
                        break;
                    case Helper.eTablas.Areas:
                        if (oAreas.Existe_Productos(sId) == true)
                        {
                            MessageBox.Show("El Area ya ha sido asignado a uno o m�s Productos. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (oAreas.Existe_Ingresos(sId) == true)
                        {
                            MessageBox.Show("El Area ya ha sido asignado a uno o m�s Ingresos. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar el Area : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oAreas.Eliminar(sId);
                        break;
                    case Helper.eTablas.SubProductos:
                        string sIdprod = "", sIdsubprod = "";
                        if (Dg1.Rows.Count > 0)
                        {
                            sIdprod = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Producto"].Value.ToString();
                            sIdsubprod = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["SubProducto"].Value.ToString();
                        }
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar el Sub-Producto : " + sIdsubprod.Trim() + " del Producto : " + sIdprod + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oSubprod.Elminar(sIdprod, sIdsubprod);
                        break;
                    case Helper.eTablas.Oficinas:
                        string sIdoficina = Get_Id(true);
                        if (oOficinas.Existe_UsuariosWeb(sIdoficina) == true)
                        {
                            MessageBox.Show("La oficina " + sIdoficina + " est� asignada a uno o m�s Usuarios Web. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (oOficinas.Existe_UsuWebOficinas(sIdoficina) == true)
                        {
                            MessageBox.Show("La oficina " + sIdoficina + " est� asignada a uno o m�s Accesos de Usuarios Web. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (oOficinas.Existe_Recojos(sIdoficina) == true)
                        {
                            MessageBox.Show("La oficina " + sIdoficina + " est� asignada a uno o m�s Recojos. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (oOficinas.Existe_Legajos_Procedencia(sIdoficina) == true)
                        {
                            MessageBox.Show("La oficina " + sIdoficina + " est� asignada a uno o m�s Registros en Procedencia. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (oOficinas.Existe_Legajos_Gestora(sIdoficina) == true)
                        {
                            MessageBox.Show("La oficina " + sIdoficina + " est� asignada a uno o m�s Registros en Gestora. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (MessageBox.Show("�Est� seguro que desea de Eliminar la Oficina : " + sIdoficina + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oOficinas.Eliminar(sIdoficina);
                        break;

                    case Helper.eTablas.Tarjetas:
                        if (oTarjetas.Existe_Operaciones(sId) == true)
                        {
                            MessageBox.Show("La Tarjeta ya ha sido asignada a uno o m�s Operaciones. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar la Tarjeta: " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oTarjetas.Eliminar(sId);
                        break;

                    case Helper.eTablas.Ejecutivos:
                        //if (oEjecutivos.Existe_Registro(sId) == true)
                        //{
                        //    MessageBox.Show("El Ejecutivo ya ha sido asignado a uno o m�s Ingresos. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        //}
                        if (MessageBox.Show("�Est� seguro que desea de Eliminar al Ejectuvo: " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oEjecutivos.Eliminar(sId);
                        break;
                }
                Listar(0);
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

        private void Abrir_Det(int nOpc)
        {
            switch (eTabla)
            {
                case Helper.eTablas.SubProductos:
                    string sIdprod = "", sIdsubprod = "";
                    if (Dg1.Rows.Count > 0)
                    {
                        sIdprod = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Producto"].Value.ToString();
                        sIdsubprod = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["SubProducto"].Value.ToString();
                    }
                    Frm_T_SubProducto fSubp = new Frm_T_SubProducto(nOpc, sIdprod, sIdsubprod);
                    fSubp.ShowDialog();
                    if (fSubp.bGrabo == true)
                    {
                        Listar(0);
                        Helper.Buscar_Grilla(Dg1, fSubp.sIdprod + fSubp.sIdsubprod, 0);
                    } fSubp.Dispose();
                    break;
                case Helper.eTablas.Oficinas :
                    Frm_T_Oficinas_Det fOfi = new Frm_T_Oficinas_Det(nOpc, Get_Id(false));
                    fOfi.ShowDialog();
                    if (fOfi.bGrabo == true)
                    {
                        Listar(0);
                        Helper.Buscar_Grilla(Dg1, fOfi.sIdOficina, 0);
                    } fOfi.Dispose();
                    break;
                case Helper.eTablas.Tarjetas:
                    Frm_T_Tarjetas fTar = new Frm_T_Tarjetas(nOpc, Get_Id(false));
                    fTar.ShowDialog();
                    if (fTar.bGrabo == true)
                    {
                        Listar(0);
                        Helper.Buscar_Grilla(Dg1, fTar.sIdtarjeta, 0);
                    } fTar.Dispose();
                    break;
                default:
                    Frm_T_Detalle fDet = new Frm_T_Detalle(nOpc, eTabla, Get_Id(false));
                    fDet.ShowDialog();
                    if (fDet.bGrabo == true)
                    {
                        Listar(0);
                        Helper.Buscar_Grilla(Dg1, fDet.sIdtabla, 0);
                    }
                    fDet.Dispose();
                    break;
            }
        }


        private string Get_Id(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Registro", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            else { return Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["id"].Value.ToString().Trim(); }
        }




    }
}