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
    public partial class Frm_Sis_Usuarios : Form
    {

        #region Declaración Variables
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();

        private Boolean bPaso = false;
        private string sIdusuario = "";
        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Usuarios()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1, true);
        }
        private void Frm_Sis_Usuarios_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            bPaso = true;
        }
        private void Frm_Sis_Usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }
        private void Frm_Sis_Usuarios_KeyDown(object sender, KeyEventArgs e)
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
        private void Listar(Helper.eListar eListar)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Dt = oBL_Sis_Usuario.Listar(txtNombre.Text, cboEstado.Text.Substring(0, 1));

                if (eListar == Helper.eListar.Grilla)
                {
                    Dg1.DataSource = Dt;
                    LblMensaje.Text = " Registros Encontrados : " + Dg1.Rows.Count.ToString();
                    Dt.Dispose();
                    Helper.FormatoGrilla(Dg1, true);
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
        private Boolean Get_IdUsuario(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdusuario = ""; return false;
            }
            else
            {
                sIdusuario = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells["Idusuario"].Value.ToString().Trim();
                return true;
            }
        }
        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_Sis_Usuarios_Det fDet = new Frm_Sis_Usuarios_Det(qOpcion, sIdusuario);
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(Helper.eListar.Grilla);
                Helper.Buscar_Grilla(Dg1, fDet.sIdusuario, 0);
            } fDet.Dispose();
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
            if (!Get_IdUsuario(true)) return;
            Abrir_Detalle(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (!Get_IdUsuario(true)) return;

            //Agregar consistencia de Data al eliminar...

            if (MessageBox.Show("¿Está seguro que desea de Eliminar el Usuario : " + sIdusuario + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                oBL_Sis_Usuario.Eliminar(sIdusuario);
                Listar(Helper.eListar.Grilla);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
        private void txtIdusuario_TextChanged(object sender, EventArgs e)
        {
            Helper.Buscar_Grilla(Dg1, txtIdusuario.Text, 0);
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar(Helper.eListar.Grilla);
        }
        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!Get_IdUsuario(true)) return;
                Abrir_Detalle(Helper.eOpcion.Consultar);
            }
        }

        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Get_IdUsuario(true)) return;
            Abrir_Detalle(Helper.eOpcion.Consultar);
        }


        #endregion

    }
}