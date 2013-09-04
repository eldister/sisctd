using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using BLSisCtd;
using BESisCtd;
namespace BESisCtd
{
    public partial class Frm_Sis_Contraseña : Form
    {

        #region Declaración Variables
        public Boolean bGrabo = false;
        Boolean bInicio;
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Contraseña(Boolean Inicio)
        {
            InitializeComponent();
            bInicio = Inicio;
        }
        private void Frm_Sis_Contraseña_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = BE_Helper.oBE_Sis_Usuario.IdUsuario;
            if (bInicio)
            {
                TxtActual.Enabled = false;
                TxtActual.Text = Helper.DecryptText(BE_Helper.oBE_Sis_Usuario.Contraseña);
            }
        }
        private void Frm_Sis_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        #endregion

        #region Eventos Objetos
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtActual.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Contraseña Actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtActual.Focus(); return;
            }

            if (TxtActual.Text.Trim() != Helper.DecryptText(BE_Helper.oBE_Sis_Usuario.Contraseña))
            {
                TxtActual.Text = ""; TxtNuevo.Text = ""; txtConfirmar.Text = ""; 
                MessageBox.Show("La Contraseña Actual no es válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtActual.Focus(); return;
            }

            if (TxtNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Contraseña Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNuevo.Focus(); return;
            }

            if (lblUsuario.Text.Trim() == TxtNuevo.Text.Trim())
            {
                TxtActual.Text = ""; TxtNuevo.Text = ""; txtConfirmar.Text = "";
                MessageBox.Show("La Nueva contraseña debe ser diferente al de la cuenta de Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNuevo.Focus(); return;
            }

            if (TxtActual.Text.Trim() == TxtNuevo.Text.Trim())
            {
                TxtNuevo.Text = ""; txtConfirmar.Text = "";
                MessageBox.Show("La Nueva contraseña debe ser diferente a la Actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNuevo.Focus(); return;
            }

            if (txtConfirmar.Text.Trim() != TxtNuevo.Text.Trim())
            {
                TxtNuevo.Text = ""; txtConfirmar.Text = "";
                MessageBox.Show("La Confirmación de la contraseña debe ser igual a la Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNuevo.Focus(); return;
            }

            try
            {
                string sContraseña = Helper.EncryptText(TxtNuevo.Text);
                oBL_Sis_Usuario.Modificar_Contraseña(sContraseña);
                bGrabo = true;

                MessageBox.Show("Se ha modificado la Contraseña en forma exitosa.", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception Er) { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}