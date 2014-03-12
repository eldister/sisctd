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
    public partial class Frm_Sis_Login : Form
    {
        public Frm_Sis_Login()
        {
            InitializeComponent();
        }

        BL_Sis_Cliente oBL_Sis_Cliente = new BL_Sis_Cliente();
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();

        private void Frm_Sis_Login_Load(object sender, EventArgs e)
        {
            //TxtUsu.Text = "admin";
            //TxtPas.Text = "123456";
            Helper.LLenar_Combobox(oBL_Sis_Cliente.Listar("A"), cboCliente, 0);
            cboCliente.SelectedIndex = 0;
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

         try
           {

            if (cboCliente.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione el Cliente", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCliente.Focus(); return;
            }

            if (oBL_Sis_Usuario.Existe_Usuario_Empresa(TxtUsu.Text, cboCliente.Text)) 
            {
                MessageBox.Show("No tiene Asignado la Empresa", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsu.Focus(); return;
            }

                    BE_Helper.oBE_Sis_Usuario = oBL_Sis_Usuario.Get_Usuario(TxtUsu.Text.Trim());

                    if (BE_Helper.oBE_Sis_Usuario == null)
                    {
                        MessageBox.Show("El usuario ingresado no existe. Verificar", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtUsu.Focus();
                        return;
                    }
                    else
                    {
                        if (!BE_Helper.oBE_Sis_Usuario.Estado)
                        {
                            MessageBox.Show("Usuario bloqueado, comuníquese con el área de Sistemas por favor.", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TxtUsu.Focus();
                            return;
                        }
                        string sContraseña = Helper.DecryptText(BE_Helper.oBE_Sis_Usuario.Contraseña).Trim().ToUpper();
                        if (sContraseña == TxtPas.Text.Trim().ToUpper())
                        {
                            //Helper.LLenar_Combobox(oBL_Sis_Cliente.Listar("A"), cboCliente, 0);
                            //cboCliente.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La contraseña no es válida. Vuelva a intentarlo", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TxtPas.Focus();
                            return;
                        }
                    }

                    BE_Helper.oBE_Sis_Cliente = oBL_Sis_Cliente.Get_Cliente(cboCliente.Text);
                    this.DialogResult = DialogResult.OK;
                    Hide();
               }
                catch (Exception Er)
                {
                    MessageBox.Show(Er.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void TxtUsu_TextChanged(object sender, EventArgs e)
        {
            cboCliente.Text = "DEMO";
            //cboCliente.Items.Clear();
            //cboCliente.Text = "";
        }

        private void TxtPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
                
            //    try
            //    {
            //        BE_Helper.oBE_Sis_Usuario = oBL_Sis_Usuario.Get_Usuario(TxtUsu.Text.Trim());

            //        if (BE_Helper.oBE_Sis_Usuario == null)
            //        {
            //            MessageBox.Show("El usuario ingresado no existe. Verificar", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            TxtUsu.Focus();
            //            return;
            //        }
            //        else
            //        {
            //            if (!BE_Helper.oBE_Sis_Usuario.Estado)
            //            {
            //                MessageBox.Show("Usuario bloqueado, comuníquese con el área de Sistemas por favor.", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                TxtUsu.Focus();
            //                return;
            //            }
            //            string sContraseña = Helper.DecryptText(BE_Helper.oBE_Sis_Usuario.Contraseña).Trim().ToUpper();
            //            if (sContraseña == TxtPas.Text.Trim().ToUpper())
            //            {
            //                Helper.LLenar_Combobox(oBL_Sis_Cliente.Listar("A"), cboCliente, 0);
            //                cboCliente.Focus();
            //            }
            //            else
            //            {
            //                MessageBox.Show("La contraseña no es válida. Vuelva a intentarlo", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                TxtPas.Focus();
            //                return;
            //            }
            //        }
            //    }
            //    catch (Exception Er)
            //    {
            //        MessageBox.Show(Er.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void TxtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }

    }
}