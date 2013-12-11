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
    public partial class Frm_Sis_Usuarios_Det : Form
    {
        #region Declaración Variables
        public string sIdusuario = "";
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BE_Sis_Usuario oBE_Sis_Usuario = new BE_Sis_Usuario();
        BL_Sis_Perfil oBL_Sis_Perfil = new BL_Sis_Perfil();
        BL_T_Empleado oBL_T_Empleado = new BL_T_Empleado();
        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Usuarios_Det(Helper.eOpcion _qOpcion, string _Idusuario)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdusuario = _Idusuario;
        }

        private void Frm_Sis_Usuarios_Det_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oBL_Sis_Perfil.Listar_Combo(), cboPerfil, "des", "idPerfil");
            switch (qOpcion)
            {
                case Helper.eOpcion.Nuevo:
                    this.Text = " Nuevo";
                    cboEstado.SelectedIndex = 0;
                    break;
                case Helper.eOpcion.Modificar:
                case Helper.eOpcion.Consultar:
                    if (qOpcion == Helper.eOpcion.Consultar)
                    {
                        this.Text = " Consulta";
                        txtNombre.ReadOnly = true;
                        txtCorreo.ReadOnly = true;
                        txtEmpleado.ReadOnly = true;
                        cboPerfil.Enabled = false;
                        cboEstado.Enabled = false;
                        btnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text = " Modificar";
                    }
                    txtIdUsuario.ReadOnly = true;
                    
                    try
                    {
                        oBE_Sis_Usuario = oBL_Sis_Usuario.Get_Usuario(sIdusuario);
                        if (oBE_Sis_Usuario!=null)
                        {
                            txtIdUsuario.Text = oBE_Sis_Usuario.IdUsuario;
                            txtNombre.Text = oBE_Sis_Usuario.Nombre;
                            txtCorreo.Text = oBE_Sis_Usuario.Correo;
                            txtEmpleado.Text = oBE_Sis_Usuario.IdEmpleado;
                            cboPerfil.SelectedValue = oBE_Sis_Usuario.IdPerfil;
                            cboEstado.SelectedIndex = oBE_Sis_Usuario.Estado ? 0 : 1;
                        }
                    }
                    catch (Exception Er)
                    { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
            }
        }
        private void Frm_Sis_Usuarios_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtNombre.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { btnCancelar.Focus(); }
        }
        private void Frm_Sis_Usuarios_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Id de Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdUsuario.Focus(); return;
                }
                if (oBL_Sis_Usuario.Existe(txtIdUsuario.Text) == true & qOpcion == Helper.eOpcion.Nuevo)
                {
                    MessageBox.Show("El Id de Usuario ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdUsuario.Focus(); return;
                }

                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un Nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus(); return;
                }

                if (cboPerfil.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione un Perfil", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPerfil.Focus(); return;
                }

                oBE_Sis_Usuario.IdUsuario = txtIdUsuario.Text.Trim();
                oBE_Sis_Usuario.Nombre = txtNombre.Text.Trim();
                oBE_Sis_Usuario.IdEmpleado = txtEmpleado.Text.Trim();
                oBE_Sis_Usuario.IdPerfil = cboPerfil.SelectedValue.ToString();
                oBE_Sis_Usuario.Correo = txtCorreo.Text.Trim();
                oBE_Sis_Usuario.Contraseña = Helper.EncryptText(txtIdUsuario.Text.Trim()).Trim();
                oBE_Sis_Usuario.Estado = (cboEstado.SelectedIndex == 0);

                if (qOpcion == Helper.eOpcion.Nuevo) oBL_Sis_Usuario.Insertar(oBE_Sis_Usuario);
                if (qOpcion == Helper.eOpcion.Modificar) oBL_Sis_Usuario.Modificar(oBE_Sis_Usuario);
                    
                sIdusuario = oBE_Sis_Usuario.IdUsuario; 
                bGrabo = true; this.Close();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PonerDescrip_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (MigControls.MigTextbox)sender;
            switch (txt.Name)
            {
                case "txtEmpleado": lblEmpleado.Text = oBL_T_Empleado.Get_Nombre(txtEmpleado.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtEmpleado": txtEmpleado.Text = Helper.Buscar(oBL_T_Empleado.Buscar()); break;
                }
            }
        }


        #endregion
    }
}