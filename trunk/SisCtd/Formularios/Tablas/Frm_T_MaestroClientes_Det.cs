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
    public partial class Frm_T_MaestroClientes_Det : Form
    {
        #region Declaración Variables
        public string sIdMaestroCliente;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();
        BE_T_MaestroCliente oBE_T_MaestroCliente = new BE_T_MaestroCliente();

        #endregion

        #region Iniciar Formulario
        public Frm_T_MaestroClientes_Det(Helper.eOpcion _qOpcion, string IdMaestroCliente)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdMaestroCliente = IdMaestroCliente;
        }
        private void Frm_T_MaestroClientes_Det_Load(object sender, EventArgs e)
        {
            try
            {
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        cboTipoPersona.SelectedIndex = 0;
                        cboTipoDoi.SelectedIndex = 0;
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        txtCodigo.ReadOnly = true;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtRazonSocial.ReadOnly = true;
                            txtNumeroDoi.ReadOnly = true;
                            txtDireccion.ReadOnly = true;
                            txtContacto.ReadOnly = true;
                            txtTelefono1.ReadOnly = true;
                            txtTelefono2.ReadOnly = true;
                            txtFax.ReadOnly = true;
                            txtEmail.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdMaestroCliente.Trim();

                        oBE_T_MaestroCliente = oBL_T_MaestroCliente.Get_MaestroCliente(sIdMaestroCliente);
                        if (oBE_T_MaestroCliente != null)
                        {
                            cboTipoDoi.Text = oBE_T_MaestroCliente.TipoDoi;
                            cboTipoPersona.SelectedIndex = oBE_T_MaestroCliente.TipoPersona == "N" ? 0 : 1;
                            txtNumeroDoi.Text = oBE_T_MaestroCliente.NumeroDoi;
                            txtRazonSocial.Text = oBE_T_MaestroCliente.RazonSocial;
                            txtDireccion.Text = oBE_T_MaestroCliente.Direccion;
                            txtContacto.Text = oBE_T_MaestroCliente.Contacto;
                            txtTelefono1.Text = oBE_T_MaestroCliente.Telefono1;
                            txtTelefono2.Text = oBE_T_MaestroCliente.Telefono2;
                            txtFax.Text = oBE_T_MaestroCliente.Fax;
                            txtEmail.Text = oBE_T_MaestroCliente.Email;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_MaestroClientes_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_MaestroClientes_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtRazonSocial.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                oBE_T_MaestroCliente.TipoDoi = cboTipoDoi.Text.Trim();
                oBE_T_MaestroCliente.TipoPersona = cboTipoPersona.Text.Trim();
                oBE_T_MaestroCliente.NumeroDoi = txtNumeroDoi.Text.Trim();
                oBE_T_MaestroCliente.IdMaestroCliente = txtCodigo.Text.Trim();
                oBE_T_MaestroCliente.RazonSocial = txtRazonSocial.Text.Trim();
                oBE_T_MaestroCliente.Direccion = txtDireccion.Text.Trim();
                oBE_T_MaestroCliente.Contacto = txtContacto.Text.Trim();
                oBE_T_MaestroCliente.Telefono1 = txtTelefono1.Text.Trim();
                oBE_T_MaestroCliente.Telefono2 = txtTelefono2.Text.Trim();
                oBE_T_MaestroCliente.Fax = txtFax.Text.Trim();
                oBE_T_MaestroCliente.Email = txtEmail.Text.Trim();

                if (oBE_T_MaestroCliente.IdMaestroCliente == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_MaestroCliente.Existe(oBE_T_MaestroCliente.IdMaestroCliente);
                    if (oBL_T_MaestroCliente.Existe(oBE_T_MaestroCliente.IdMaestroCliente))
                    {
                        MessageBox.Show("El Código " + oBE_T_MaestroCliente.IdMaestroCliente + " ya existe en Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }
                if (oBE_T_MaestroCliente.RazonSocial == "")
                {
                    MessageBox.Show("Ingrese La Razon Social", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRazonSocial.Focus(); return;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_MaestroCliente.Insertar(oBE_T_MaestroCliente);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_T_MaestroCliente.Modificar(oBE_T_MaestroCliente);
                }
                sIdMaestroCliente = txtCodigo.Text; bGrabo = true; this.Close();

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void PonerDescrip_TextChanged(object sender, EventArgs e)
        //{
        //    TextBox txt = (MigControls.MigTextbox)sender;
        //    switch (txt.Name)
        //    {
        //        case "txtUbigeo": lblUbigeo.Text = oBL_T_Ubigeo.Get_DesUbigeo(txtUbigeo.Text); break;
        //    }

        //}
        //private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F1)
        //    {
        //        TextBox txt = (MigControls.MigTextbox)sender;
        //        switch (txt.Name)
        //        {
        //            case "txtUbigeo": txtUbigeo.Text = Helper.Buscar(oBL_T_Ubigeo.Buscar()); break;
        //        }
        //    }
        //}



        #endregion

     
    }
}