using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;
using System.Runtime.InteropServices;
using System.Drawing.Text;
namespace SisCtd
{
    public partial class Frm_Reg_Seguimiento_Envio : Form
    {
        #region Declaración Variables

        public string sIdControl;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Seguimiento_Envio()
        {
            InitializeComponent();

        }
        private void Frm_Reg_Seguimiento_Envio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }


        #endregion



        #region Metodos

        #endregion

        #region Eventos Objetos

        private void txtIdControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    oBE_Reg_Control = oBL_Reg_Control.Get_Control(txtIdControl.Text);
                    if (oBE_Reg_Control != null)
                    {
                        lblFechaRecepcion.Text = oBE_Reg_Control.FechaRecepcion.ToString("dd/MM/yyyy");
                        lblIdOficinaRecepcion.Text = oBE_Reg_Control.IdOficinaRecepcion;
                        lblIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                        lblIdMaestroCliente.Text = oBE_Reg_Control.IdMaestroCliente;
                        lblNroDocumento.Text = oBE_Reg_Control.NroDocumento;
                        lblFechaDocumento.Text = oBE_Reg_Control.FechaDocumento.ToString("dd/MM/yyyy");
                        txtDetalle.Text = oBE_Reg_Control.Observacion;
                        txtIdOficinaDestinatario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Control No Existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdControl.Focus(); return;
                    }
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void txtIdControl_TextChanged(object sender, EventArgs e)
        {
            lblFechaRecepcion.Text = "";
            lblIdOficinaRecepcion.Text = "";
            lblIdTipoDocumento.Text = "";
            lblIdMaestroCliente.Text = "";
            lblNroDocumento.Text = "";
            lblFechaDocumento.Text = "";
            txtDetalle.Text = "";
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion








    }
}