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
        //Cls_T_Territorios oTerritorios = new Cls_T_Territorios();
        //Cls_T_Datos oDatos = new Cls_T_Datos();
        //Cls_T_Estados oEstados = new Cls_T_Estados();
        //Cls_T_Areas oAreas = new Cls_T_Areas();
        //Cls_T_Oficinas oOficinas = new Cls_T_Oficinas();
        //Cls_T_Ejecutivos oEjecutivos = new Cls_T_Ejecutivos();

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
                //switch (eTabla)
                //{
                //    case Helper.eTablas.Territorios: Dt = oTerritorios.Listar(txtDescrip.Text, cboEstado.SelectedIndex); break;
                //    case Helper.eTablas.Datos: Dt = oDatos.Listar("D",txtDescrip.Text, cboEstado.SelectedIndex); break;
                //    case Helper.eTablas.Estados: Dt = oEstados.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                //    case Helper.eTablas.Areas: Dt = oAreas.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                //    case Helper.eTablas.Oficinas: 
                //        Dt = oOficinas.Listar("D",txtDescrip.Text);
                //        lblEstado.Visible = false; cboEstado.Visible = false; break;
                //    case Helper.eTablas.Ejecutivos: Dt = oEjecutivos.Listar("D", txtDescrip.Text, cboEstado.SelectedIndex); break;
                //}
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
                            Dg1.Columns["Ubicación Geográfica"].Visible = false;
                            Dg1.Columns["Dirección"].Visible = false; break;
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
            //    switch (eTabla)
            //    {
            //        case Helper.eTablas.Territorios:
            //            if (oTerritorios.Existe_Oficinas(sId) == true)
            //            {
            //                MessageBox.Show("El Territorio ya ha sido asignado a una o más oficinas. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            }
            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Territorio : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oTerritorios.Eliminar(sId);
            //            break;
            //        case Helper.eTablas.Datos:
            //            if (oDatos.Existe_Productos(sId) == true)
            //            {
            //                MessageBox.Show("El Dato ya ha sido asignado a uno o más Productos. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            }
            //            if (oDatos.Existe_TipoDoc(sId) == true)
            //            {
            //                MessageBox.Show("El Dato ya ha sido asignado a uno o más Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            }
            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Dato : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oDatos.Eliminar(sId);
            //            break;
            //        case Helper.eTablas.Estados:
            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Estado : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oEstados.Eliminar(sId);
            //            break;
            //        case Helper.eTablas.Areas:
            //            if (oAreas.Existe_Productos(sId) == true)
            //            {
            //                MessageBox.Show("El Area ya ha sido asignado a uno o más Productos. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            }
            //            if (oAreas.Existe_Ingresos(sId) == true)
            //            {
            //                MessageBox.Show("El Area ya ha sido asignado a uno o más Ingresos. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            }
            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Area : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oAreas.Eliminar(sId);
            //            break;
            //        case Helper.eTablas.Oficinas:
            //            string sIdoficina = Get_Id(true);
            //            if (oOficinas.Existe_UsuariosWeb(sIdoficina) == true)
            //            {
            //                MessageBox.Show("La oficina " + sIdoficina + " está asignada a uno o más Usuarios Web. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }

            //            if (oOficinas.Existe_UsuWebOficinas(sIdoficina) == true)
            //            {
            //                MessageBox.Show("La oficina " + sIdoficina + " está asignada a uno o más Accesos de Usuarios Web. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }

            //            if (oOficinas.Existe_Recojos(sIdoficina) == true)
            //            {
            //                MessageBox.Show("La oficina " + sIdoficina + " está asignada a uno o más Recojos. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }

            //            if (oOficinas.Existe_Legajos_Procedencia(sIdoficina) == true)
            //            {
            //                MessageBox.Show("La oficina " + sIdoficina + " está asignada a uno o más Registros en Procedencia. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }

            //            if (oOficinas.Existe_Legajos_Gestora(sIdoficina) == true)
            //            {
            //                MessageBox.Show("La oficina " + sIdoficina + " está asignada a uno o más Registros en Gestora. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }

            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar la Oficina : " + sIdoficina + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oOficinas.Eliminar(sIdoficina);
            //            break;

            //        case Helper.eTablas.Ejecutivos:
            //            //if (oEjecutivos.Existe_Registro(sId) == true)
            //            //{
            //            //    MessageBox.Show("El Ejecutivo ya ha sido asignado a uno o más Ingresos. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //            //}
            //            if (MessageBox.Show("¿Está seguro que desea de Eliminar al Ejectuvo: " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //            oEjecutivos.Eliminar(sId);
            //            break;
            //    }
            //    Listar(0);
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
                
                case Helper.eTablas.Oficinas :
                    Frm_T_Oficinas_Det fOfi = new Frm_T_Oficinas_Det(nOpc, Get_Id(false));
                    fOfi.ShowDialog();
                    if (fOfi.bGrabo == true)
                    {
                        Listar(0);
                        Helper.Buscar_Grilla(Dg1, fOfi.sIdOficina, 0);
                    } fOfi.Dispose();
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
                if (bMsg == true) MessageBox.Show("Seleccione un Registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            else { return Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["id"].Value.ToString().Trim(); }
        }




    }
}