using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
namespace BESisCtd
{
    public partial class Frm_T_Oficinas_Det : Form
    {
        #region Declaración Variables
        public string sIdOficina;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BE_T_Oficina oBE_T_Oficina = new BE_T_Oficina();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Oficinas_Det(Helper.eOpcion _qOpcion, string IdOficina)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdOficina = IdOficina;
        }
        private void Frm_T_Oficinas_Det_Load(object sender, EventArgs e)
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
                            txtUbigeo.ReadOnly = true;
                            txtDireccion.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdOficina.Trim();

                        oBE_T_Oficina = oBL_T_Oficina.Get_Oficina (sIdOficina);
                        if (oBE_T_Oficina != null)
                        {
                            txtDescripcion.Text = oBE_T_Oficina.Descripcion;
                            txtUbigeo.Text = oBE_T_Oficina.Idubigeo ;
                            txtDireccion.Text = oBE_T_Oficina.Direccion ;
                            cboEstado.SelectedIndex = oBE_T_Oficina.Estado ? 0 : 1;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Oficina_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Oficina_Det_Activated(object sender, EventArgs e)
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
                oBE_T_Oficina.Idoficina = txtCodigo.Text.Trim();
                oBE_T_Oficina.Descripcion = txtDescripcion.Text.Trim();
                oBE_T_Oficina.Idubigeo  = txtUbigeo.Text.Trim();
                oBE_T_Oficina.Direccion  = txtDireccion.Text.Trim();
                oBE_T_Oficina.Estado = (cboEstado.SelectedIndex == 0);

                if (oBE_T_Oficina.Idoficina == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Oficina.Existe(oBE_T_Oficina.Idoficina);
                    if (oBL_T_Oficina.Existe(oBE_T_Oficina.Idoficina))
                    {
                        MessageBox.Show("El Código " + oBE_T_Oficina.Idoficina  + " ya existe en Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }
                if (oBE_T_Oficina.Descripcion == "")
                {
                    MessageBox.Show("Ingrese una Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Oficina.Insertar(oBE_T_Oficina);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_T_Oficina.Modificar(oBE_T_Oficina);
                }
                sIdOficina = txtCodigo.Text; bGrabo = true; this.Close();

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