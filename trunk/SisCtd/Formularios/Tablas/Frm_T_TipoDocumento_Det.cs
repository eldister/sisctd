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
    public partial class Frm_T_TipoDocumento_Det : Form
    {
        #region Declaración Variables
        public string sIdTipoDocumento;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BE_T_TipoDocumento oBE_T_TipoDocumento = new BE_T_TipoDocumento();

        #endregion

        #region Iniciar Formulario
        public Frm_T_TipoDocumento_Det(Helper.eOpcion _qOpcion, string IdTipoDocumento)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdTipoDocumento = IdTipoDocumento;
        }
        private void Frm_T_TipoDocumento_Det_Load(object sender, EventArgs e)
        {
            try
            {
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        cboEstado.SelectedIndex = 0;
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        txtCodigo.ReadOnly = true;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtDescripcion.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdTipoDocumento.Trim();

                        oBE_T_TipoDocumento = oBL_T_TipoDocumento.Get_TipoDocumento(sIdTipoDocumento);
                        if (oBE_T_TipoDocumento != null)
                        {
                            txtDescripcion.Text = oBE_T_TipoDocumento.Descripcion;
                            txtDescripcionLarga.Text = oBE_T_TipoDocumento.DescripcionLarga;
                            cboEstado.SelectedIndex = oBE_T_TipoDocumento.Estado ? 0 : 1;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_TipoDocumento_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_TipoDocumento_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtDescripcion.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                oBE_T_TipoDocumento.IdTipoDocumento = txtCodigo.Text.Trim();
                oBE_T_TipoDocumento.Descripcion = txtDescripcion.Text.Trim();
                oBE_T_TipoDocumento.DescripcionLarga = txtDescripcionLarga.Text.Trim();
                oBE_T_TipoDocumento.Estado = (cboEstado.SelectedIndex == 0);

                if (oBE_T_TipoDocumento.IdTipoDocumento == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_TipoDocumento.Existe(oBE_T_TipoDocumento.IdTipoDocumento);
                    if (oBL_T_TipoDocumento.Existe(oBE_T_TipoDocumento.IdTipoDocumento))
                    {
                        MessageBox.Show("El Código " + oBE_T_TipoDocumento.IdTipoDocumento + " ya existe en Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }
                if (oBE_T_TipoDocumento.Descripcion == "")
                {
                    MessageBox.Show("Ingrese una Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_TipoDocumento.Insertar(oBE_T_TipoDocumento);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_T_TipoDocumento.Modificar(oBE_T_TipoDocumento);
                }
                sIdTipoDocumento = txtCodigo.Text; bGrabo = true; this.Close();

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