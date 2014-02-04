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
    public partial class Frm_T_Rutas_List : Form
    {
        #region Declaración Variables
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_RutaActividad oBL_T_RutaActividad = new BL_T_RutaActividad();
        string sIdRuta, sIdActividad;

        #endregion

        #region Iniciar Formulario
        public Frm_T_Rutas_List()
        {
            InitializeComponent();
            bNuevo.Enabled = Helper.sAcceso.Substring(0, 1) == "1" ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.FormatoGrilla(Dg1);
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
                Dt = oBL_T_Ruta.Listar(txtDescripcion.Text, cboEstado.Text.Substring(0,1));
                
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
        private bool Get_IdRuta(bool bMsg)
        {
            if (Dg1.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Ruta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdRuta = "";
                return false;
            }
            else
            {
                sIdRuta = Dg1.Rows[Dg1.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();
                return true;
            }
        }

        private bool Get_IdActividad(bool bMsg)
        {
            if (dgActividades.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Actividad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdActividad = "";
                return false;
            }
            else
            {
                sIdActividad = dgActividades.Rows[dgActividades.CurrentCellAddress.Y].Cells[1].Value.ToString().Trim();
                return true;
            }
        }

        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_T_Detalle fDet = new Frm_T_Detalle(qOpcion, Helper.eTablas.Rutas, Get_Id(false));
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
        private void Listar_RutaActividad()
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Get_IdRuta(false);
                Dt = oBL_T_RutaActividad.Listar_Actividad(sIdRuta);

                dgActividades.DataSource = Dt; Helper.FormatoGrilla(dgActividades, false);
                dgActividades.Columns["Orden"].Width = 40;
                dgActividades.Columns["IdActividad"].Width = 100;
                dgActividades.Columns["Actividad"].Width = 200;
                dgActividades.Columns["DuracionEnDias"].Width = 100;
                dgActividades.Columns["Oficina"].Width = 170;
                dgActividades.Columns["Area"].Width = 200;

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
                oBL_T_Ruta.Eliminar(sId);
                
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
            Listar_RutaActividad();
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Listar(0);
            Listar_RutaActividad();
        }
        private void Dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_RutaActividad();
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
        private void dgActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_RutaActividad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Get_IdRuta(true) == false) return;

            Frm_T_RutaActividad fDet = new Frm_T_RutaActividad(Helper.eOpcion.Nuevo, sIdRuta, sIdActividad);
            fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar_RutaActividad();
            }
            fDet.Dispose();

        //Regresar:
        //    sIdActividad = Helper.Buscar(oBL_T_Actividad.Buscar());
        //    if (sIdActividad == "") return;
        //    BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
        //    oBE_T_RutaActividad.IdRuta = sIdRuta;
        //    oBE_T_RutaActividad.IdActividad = sIdActividad;
        //    if (oBL_T_RutaActividad.Existe_Actividad(oBE_T_RutaActividad))
        //    {
        //        MessageBox.Show("La Actividad " + sIdActividad + " ya ha sido asignado a la Ruta " + sIdRuta + ". Verificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        goto Regresar;
        //    }

        //    oBL_T_RutaActividad.Insertar(oBE_T_RutaActividad);
        //    Listar_RutaActividad();
        //    Helper.Buscar_Grilla(Dg1, sIdRuta, 0);


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Get_IdRuta(true);
            if (sIdRuta == "") return;
            Get_IdActividad(true);
            if (sIdActividad == "") return;
 
            BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
            oBE_T_RutaActividad.IdRuta = sIdRuta;
            oBE_T_RutaActividad.IdActividad = sIdActividad;

            if (MessageBox.Show("¿Está seguro que desea de Quitar la RutaActividad : " + sIdActividad + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            oBL_T_RutaActividad.Eliminar(oBE_T_RutaActividad);
            Listar_RutaActividad();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            Get_IdRuta(true);
            if (sIdRuta == "") return;
            Get_IdActividad(true);
            if (sIdActividad == "") return;

            BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
            oBE_T_RutaActividad.IdRuta = sIdRuta;
            oBE_T_RutaActividad.IdActividad = sIdActividad;

            oBL_T_RutaActividad.Subir(oBE_T_RutaActividad);
            Listar_RutaActividad();
        }
        private void btnBajar_Click(object sender, EventArgs e)
        {
            Get_IdRuta(true);
            if (sIdRuta == "") return;
            Get_IdActividad(true);
            if (sIdActividad == "") return;

            BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
            oBE_T_RutaActividad.IdRuta = sIdRuta;
            oBE_T_RutaActividad.IdActividad = sIdActividad;

            oBL_T_RutaActividad.Bajar(oBE_T_RutaActividad);
            Listar_RutaActividad();

        }


        #endregion


                
    }
}