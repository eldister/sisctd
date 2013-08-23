using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;

namespace SisCtd
{
    public partial class Frm_T_Listados : Form
    {
        #region Declaración Variables
        Helper.eTablas eTabla;
        BL_T_Posicion oBL_T_Posicion = new BL_T_Posicion();
        BL_T_Gerencia oBL_T_Gerencia = new BL_T_Gerencia();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Listados(Helper.eTablas _eTabla)
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1);
            eTabla = _eTabla;
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
                switch (eTabla)
                {
                    case Helper.eTablas.Posiciones: Dt = oBL_T_Posicion.Listar(txtDescripcion.Text, cboEstado.Text.Substring(0,1)); break;
                    case Helper.eTablas.Gerencias: Dt = oBL_T_Gerencia.Listar(txtDescripcion.Text, cboEstado.Text.Substring(0, 1)); break;
                    
                }
                if (eListar == Helper.eListar.Grilla)
                {
                    Dg1.DataSource = Dt; Helper.FormatoGrilla(Dg1);
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
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
            switch (eTabla)
            {
                //case Helper.eTablas.Oficinas :
                //    Frm_T_Oficinas_Det fOfi = new Frm_T_Oficinas_Det(nOpc, Get_Id(false));
                //    fOfi.ShowDialog();
                //    if (fOfi.bGrabo == true)
                //    {
                //        Listar(0);
                //        Helper.Buscar_Grilla(Dg1, fOfi.sIdOficina, 0);
                //    } fOfi.Dispose();
                //    break;
                default:
                    Frm_T_Detalle fDet = new Frm_T_Detalle(qOpcion, eTabla, Get_Id(false));
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
            if (Get_Id(true) == "") return; Abrir_Detalle(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            string sId = Get_Id(true); if (sId == "") return;
            try
            {
                switch (eTabla)
                {
                    case Helper.eTablas.Posiciones:
                        //Validar en Empleados
                        //if (oDatos.Existe_TipoDoc(sId) == true)
                        //{
                        //    MessageBox.Show("El Dato ya ha sido asignado a uno o más Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        //}

                        if (MessageBox.Show("¿Está seguro que desea de Eliminar la Posicion : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oBL_T_Posicion.Eliminar(sId);
                        break;
                    case Helper.eTablas.Gerencias:
                        //Validar en Areas
                        //if (oDatos.Existe_TipoDoc(sId) == true)
                        //{
                        //    MessageBox.Show("El Dato ya ha sido asignado a uno o más Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        //}

                        if (MessageBox.Show("¿Está seguro que desea de Eliminar la Gerencia : " + sId + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                        oBL_T_Gerencia.Eliminar(sId);
                        break;

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
                }
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

        #endregion

    }
}