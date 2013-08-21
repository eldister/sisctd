using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
namespace SisCtd
{
    public partial class Frm_Sis_Acceso : Form
    {

        #region Declaración Variables
        string sIdPerfil = "";
        string sIdmenu = "";
        string sIdusuario = "";
        Boolean bPrimeraCarga = true;
        BL_Sis_Perfil oBL_Sis_Perfil = new BL_Sis_Perfil();
        BL_Sis_Cliente oBL_Sis_Cliente = new BL_Sis_Cliente(); 
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BL_Sis_Sistema oBL_Sis_Sistema = new BL_Sis_Sistema();
        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Acceso()
        {
            InitializeComponent();
            bNuevo.Enabled = (Helper.sAcceso.Substring(0, 1) == "1") ? true : false;
            bModificar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            bEliminar.Enabled = Helper.sAcceso.Substring(2, 1) == "1" ? true : false;
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            
            btnGrabar.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            btnExportarUsuarios.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            btnAgregarCliente.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
            btnQuitarCliente.Enabled = Helper.sAcceso.Substring(1, 1) == "1" ? true : false;
        }
        private void Frm_Sis_Acceso_Load(object sender, EventArgs e)
        {
            try
            {
                Listar_Perfiles(Helper.eListar.Grilla);
                bPrimeraCarga = false;
                Cargar_Menus();
                Listar_Usuarios(Helper.eListar.Grilla);
                Listar_Clientes(Helper.eListar.Grilla);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_Sis_Acceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)(Keys.Escape): Cancelar(); break;
            }

        }

        #endregion

        #region Metodos
        private void Listar_Perfiles(Helper.eListar oListar)
        {
            try
            {
                if (oListar == Helper.eListar.Grilla)
                {
                    Helper.LLenar_Listbox(oBL_Sis_Perfil.Listar_Combo(), lstPerfiles, "des", "idPerfil");
                    if (lstPerfiles.Items.Count > 0) lstPerfiles.SelectedIndex = 0;
                }
                else
                {
                    Helper.Exportar(oBL_Sis_Perfil.Listar());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Abrir_Det(Helper.eOpcion qOpcion)
        {
            Frm_Sis_Perfil_Det FrmDet = new Frm_Sis_Perfil_Det(qOpcion, (qOpcion == Helper.eOpcion.Nuevo ? "" : lstPerfiles.SelectedValue.ToString()));
            FrmDet.ShowDialog();
            if (FrmDet.bGrabo == true)
            {
                Listar_Perfiles(Helper.eListar.Grilla);
                lstPerfiles.SelectedValue = FrmDet.sIdPerfil;
            }
            FrmDet.Dispose();
        }
        private void Cargar_Menus()
        {
            if (bPrimeraCarga) return;
            try
            {
                treMenu.Nodes.Clear();
                treMenuPerfil.Nodes.Clear();
                if (lstPerfiles.SelectedItems.Count <= 0) return;
                sIdPerfil = lstPerfiles.SelectedValue.ToString();

                Helper.Cargar_menu(oBL_Sis_Sistema.Listar_Menu(sIdPerfil, "Menu"), "", null, treMenu, true);
                Helper.Cargar_menu(oBL_Sis_Sistema.Listar_Menu(sIdPerfil, "Perfil"), "", null, treMenuPerfil, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Limpiar_Permisos()
        {
            ChkNuevo.Checked = false;
            ChkModificar.Checked = false;
            ChkEliminar.Checked = false;
            ChkImprimir.Checked = false;
            ChkExportar.Checked = false;
            PanPermisos.Enabled = false;
        }
        private void Listar_Usuarios(Helper.eListar oListar)
        {
            if (bPrimeraCarga) return;
            DataTable Dt = new DataTable();
            try
            {
                sIdPerfil = "";
                if (lstPerfiles.SelectedItems.Count > 0) sIdPerfil = lstPerfiles.SelectedValue.ToString();
                Dt = oBL_Sis_Usuario.Listar(sIdPerfil,chkTodosUsuarios.Checked);

                if (oListar == Helper.eListar.Grilla)
                {
                    dgUsuarios.DataSource = Dt;
                    Helper.FormatoGrilla(dgUsuarios, false);
                    dgUsuarios.Columns["IdUsuario"].Width = 90;
                    dgUsuarios.Columns["Nombre"].Width = 150;
                    dgUsuarios.Columns["Perfil"].Width = 130;
                }
                else
                {
                    Helper.Exportar(Dt);
                }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private Boolean Get_IdUasuario(Boolean bMensaje)
        {
            if (dgUsuarios.Rows.Count <= 0)
            {
                if (bMensaje)
                    MessageBox.Show("Seleccione un Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblUsuario.Text = ""; sIdusuario = "";
                return false;
            }
            else
            {
                lblUsuario.Text = dgUsuarios.Rows[dgUsuarios.CurrentCellAddress.Y].Cells["Nombre"].Value.ToString().Trim();
                sIdusuario = dgUsuarios.Rows[dgUsuarios.CurrentCellAddress.Y].Cells["idusuario"].Value.ToString().Trim();
                return true;
            }
        }
        private void Listar_Clientes(Helper.eListar oListar)
        {
            if (bPrimeraCarga) return;
            DataTable Dt = new DataTable();
            try
            {
                Get_IdUasuario(false);
                Dt = oBL_Sis_Cliente.Listar_UsuarioCliente(sIdusuario);
                if (oListar == Helper.eListar.Grilla)
                {
                    dgClientes.DataSource = Dt;
                    Helper.FormatoGrilla(dgClientes, false);
                    dgClientes.Columns["IdCliente"].Width = 80;
                    dgClientes.Columns["Descripcion"].Width = 170;
                }
                else
                {
                    Helper.Exportar(Dt);
                }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        
        private void Cancelar()
        {
            this.Close();
        }
        private void HabilitarAcceso()
        {
            DataTable Dt = new DataTable();
            try
            {

                string sAccesos = "";
                string sAccesosMenu = "";
                sAccesos = oBL_Sis_Sistema.Get_Acceso("00", sIdmenu);
                sAccesosMenu = oBL_Sis_Sistema.Get_Acceso(lstPerfiles.SelectedValue.ToString(), sIdmenu);

                ChkNuevo.Enabled = (sAccesos.Substring(0, 1) == "1") ? true : false;
                ChkModificar.Enabled = (sAccesos.Substring(1, 1) == "1") ? true : false;
                ChkEliminar.Enabled = (sAccesos.Substring(2, 1) == "1") ? true : false;
                ChkImprimir.Enabled = (sAccesos.Substring(3, 1) == "1") ? true : false;
                ChkExportar.Enabled = (sAccesos.Substring(4, 1) == "1") ? true : false;

                ChkNuevo.Checked = (sAccesosMenu.Substring(0, 1) == "1") ? true : false;
                ChkModificar.Checked = (sAccesosMenu.Substring(1, 1) == "1") ? true : false;
                ChkEliminar.Checked = (sAccesosMenu.Substring(2, 1) == "1") ? true : false;
                ChkImprimir.Checked = (sAccesosMenu.Substring(3, 1) == "1") ? true : false;
                ChkExportar.Checked = (sAccesosMenu.Substring(4, 1) == "1") ? true : false;

            }
            catch (Exception Er)
            {
                MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Dt != null) { Dt.Dispose(); Dt = null; }
            }
        }

        #endregion


        #region Eventos Menu
        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Det(Helper.eOpcion.Nuevo);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (lstPerfiles.SelectedItems.Count <= 0) return;
            Abrir_Det(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lstPerfiles.SelectedItems.Count <= 0) return;
            sIdPerfil = lstPerfiles.SelectedValue.ToString();
            if (oBL_Sis_Usuario.Existe_Perfil(sIdPerfil) == true)
            {
                MessageBox.Show("El Perfil ha sido asignado a un usuario, Verificar", "Validación de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if (oPerfiles.Existe_En_Accesos(sIdPerfil) == true)
            //{
            //    MessageBox.Show("El Perfil cuenta con accesos, Verificar", "Validación de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            if (MessageBox.Show("¿Está seguro de Eliminar el Perfil: " + lstPerfiles.Text + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            oBL_Sis_Perfil.Eliminar(sIdPerfil);
            Listar_Perfiles(Helper.eListar.Grilla);
        }
        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar_Perfiles(Helper.eListar.Excel);
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        #endregion

        #region Eventos de Objetos
        private void lstPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar_Usuarios(Helper.eListar.Grilla);
            lblPerfilOpciones.Text = lstPerfiles.Text;
            lblPerfilUsuarios.Text = lstPerfiles.Text;
            Cargar_Menus();
            Limpiar_Permisos();
        }
        private void cboModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Menus();
        }
        private void treMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            sIdmenu = e.Node.Name.Trim();
            Limpiar_Permisos();
        }
        private void treMenu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (sIdmenu == "") return;
                sIdPerfil = lstPerfiles.SelectedValue.ToString();
                oBL_Sis_Perfil.Asignar_Acceso(sIdPerfil, sIdmenu);
                Cargar_Menus();
            }
            catch (Exception Er)
            {
                MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void treMenuPerfil_AfterSelect(object sender, TreeViewEventArgs e)
        {
            sIdmenu = e.Node.Name.Trim();

            if (oBL_Sis_Sistema.Get_Agrupador(sIdmenu) == false)
            {
                PanPermisos.Enabled = true;
                HabilitarAcceso();
            }
            else
            {
                PanPermisos.Enabled = false;
                Limpiar_Permisos();
            }

        }
        private void treMenuPerfil_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (sIdmenu == "") return;
                sIdPerfil = lstPerfiles.SelectedValue.ToString();
                oBL_Sis_Perfil.Quitar_Acceso(sIdPerfil, sIdmenu);
                Cargar_Menus();
            }
            catch (Exception Er)
            {
                MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            ChkNuevo.Checked = ChkNuevo.Enabled == true ? true : false;
            ChkModificar.Checked = ChkModificar.Enabled == true ? true : false;
            ChkEliminar.Checked = ChkEliminar.Enabled == true ? true : false;
            ChkImprimir.Checked = ChkImprimir.Enabled == true ? true : false;
            ChkExportar.Checked = ChkExportar.Enabled == true ? true : false;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                if (sIdmenu == "") return;
                    string sAccesoMenu = "";
                    sAccesoMenu += ChkNuevo.Checked == true ? "1" : "0";
                    sAccesoMenu += ChkModificar.Checked == true ? "1" : "0";
                    sAccesoMenu += ChkEliminar.Checked == true ? "1" : "0";
                    sAccesoMenu += ChkImprimir.Checked == true ? "1" : "0";
                    sAccesoMenu += ChkExportar.Checked == true ? "1" : "0";

                    oBL_Sis_Perfil.ModificarAcceso(sIdPerfil,sIdmenu, sAccesoMenu);
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void chkTodosUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            Listar_Usuarios(Helper.eListar.Grilla);
        }
        private void btnExportarUsuarios_Click(object sender, EventArgs e)
        {
            Listar_Usuarios(Helper.eListar.Excel);
        }
        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            Listar_Clientes(Helper.eListar.Grilla);
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //if (Get_IdUasuario(true) == false) return;
            //Helper.eTablaBus = Helper.eTablas.Clientes;
            //string sIdcliente = Helper.Buscar();
            //if (sIdcliente == "") return;
            //if (oBL_Sis_Usuario.Existe_UsuarioCliente(sIdusuario, sIdcliente))
            //{
            //    MessageBox.Show("El Cliente " + sIdcliente + " ya ha sido asignado al Usuario " + sIdusuario + ". Verificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    dgClientes.Focus(); return;
            //}

            //oAcceso.AgregarUsuarioCliente(sIdusuario, sIdcliente);
            //Listar_Clientes(Helper.eListar.Grilla);
            //Helper.Buscar_Grilla(dgClientes, sIdcliente, 0);
        }

        private void btnQuitarCliente_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count <= 0)
            {
                MessageBox.Show("Seleccione un Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string sIdcliente = dgClientes.Rows[dgClientes.CurrentCellAddress.Y].Cells["idcliente"].Value.ToString().Trim();

            if (MessageBox.Show("¿Está seguro de Quitar el Cliente : " + sIdcliente + " al usuario : " + sIdusuario + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            oBL_Sis_Cliente.QuitarUsuarioCliente(sIdusuario, sIdcliente);
            Listar_Clientes(Helper.eListar.Grilla);
            dgClientes.Focus();
        }

        #endregion

    }
}



        
       
  