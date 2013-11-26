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
    public partial class Frm_T_Actividades_List : Form
    {
        #region Declaración Variables
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Empleado oBL_T_Empleado = new BL_T_Empleado();
        BL_T_EmpleadoActividad oBL_T_EmpleadoActividad = new BL_T_EmpleadoActividad();

        string sIdEmpleado, sIdActividad;

        #endregion

        #region Iniciar Formulario
        public Frm_T_Actividades_List()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1);
        }
        private void Frm_T_Actividades_List_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
        }
        private void Frm_T_Actividades_List_KeyDown(object sender, KeyEventArgs e)
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
        private void Frm_T_Actividades_List_KeyPress(object sender, KeyPressEventArgs e)
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
                Dt = oBL_T_Actividad.Listar(txtDescripcion.Text, cboEstado.Text.Substring(0,1));
                
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
        private bool Get_IdActividad(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Actividad ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdActividad = "";
                return false;
            }
            else
            {
                sIdActividad = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();
                return true;
            }
        }

        private bool Get_IdEmpleado(bool bMsg)
        {
            if (dgEmpleados.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Actividad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdEmpleado = "";
                return false;
            }
            else
            {
                sIdEmpleado = dgEmpleados.Rows[Dg1.CurrentCellAddress.Y].Cells[1].Value.ToString().Trim();
                return true;
            }
        }

        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_T_Detalle fDet = new Frm_T_Detalle(qOpcion, Helper.eTablas.Actividades, Get_Id(false));
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
        private void Listar_EmpleadoActividad()
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Get_IdActividad(false);
                Dt = oBL_T_EmpleadoActividad.Listar_Empleado(sIdActividad);

                dgEmpleados.DataSource = Dt; Helper.FormatoGrilla(dgEmpleados, false);
                dgEmpleados.Columns["IdEmpleado"].Width = 100;
                dgEmpleados.Columns["Nombre"].Width = 400;

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
                oBL_T_Actividad.Eliminar(sId);
                
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
            Listar_EmpleadoActividad();
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Listar(0);
            Listar_EmpleadoActividad();
        }
        private void Dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_EmpleadoActividad();
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
        private void dgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_EmpleadoActividad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Get_IdActividad(true) == false) return;
        Regresar:
            sIdEmpleado = Helper.Buscar(oBL_T_Empleado.Buscar());
            if (sIdEmpleado == "") return;
            BE_T_EmpleadoActividad oBE_T_EmpleadoActividad = new BE_T_EmpleadoActividad();
            oBE_T_EmpleadoActividad.IdActividad = sIdActividad;
            oBE_T_EmpleadoActividad.IdEmpleado = sIdEmpleado;
            if (oBL_T_EmpleadoActividad.Existe_EmpleadoActividad(oBE_T_EmpleadoActividad))
            {
                MessageBox.Show("El Empleado " + sIdEmpleado + " ya ha sido asignado a la Actividad " + sIdActividad + ". Verificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Regresar;
            }

            oBL_T_EmpleadoActividad.Insertar(oBE_T_EmpleadoActividad);
            Listar_EmpleadoActividad();
            Helper.Buscar_Grilla(Dg1, sIdActividad, 0);

            //Frm_T_RutaActividad fDet = new Frm_T_RutaActividad(Helper.eOpcion.Nuevo, sIdRuta, sIdActividad);
            //fDet.ShowDialog();
            //if (fDet.bGrabo == true)
            //{
            //    Listar_RutaActividad();
            //}
            //fDet.Dispose();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Get_IdActividad(true);
            if (sIdActividad == "") return;
            Get_IdEmpleado(true);
            if (sIdEmpleado == "") return;

            BE_T_EmpleadoActividad oBE_T_EmpleadoActividad = new BE_T_EmpleadoActividad();
            oBE_T_EmpleadoActividad.IdActividad = sIdActividad;
            oBE_T_EmpleadoActividad.IdEmpleado = sIdEmpleado;

            if (MessageBox.Show("¿Está seguro que desea de Quitar la EmpleadoActividad : " + sIdEmpleado + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            oBL_T_EmpleadoActividad.Eliminar(oBE_T_EmpleadoActividad);
            Listar_EmpleadoActividad();
        }



        #endregion

                
    }
}