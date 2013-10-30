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

        private void txtAyudaF1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F1) return;
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                //case "txtPai": Helper.qBus = Helper.eBuscar.Paises; break;
                //case "txtUbi": Helper.qBus = Helper.eBuscar.Ubigeo; break;
                //case "txtZon": Helper.qBus = Helper.eBuscar.Zventa; break;
                //case "txtVen": Helper.qBus = Helper.eBuscar.Vended; break;
                //case "txtGru": Helper.qBus = Helper.eBuscar.GrupoCli; break;
                //case "txtSec": Helper.qBus = Helper.eBuscar.Sector; break;
                //case "txtMonven": Helper.qBus = Helper.eBuscar.Moneda; break;
                //case "txtConven": Helper.qBus = Helper.eBuscar.Cpago; break;
                //case "txtPre": Helper.qBus = Helper.eBuscar.GrupoPre; break;
                //case "txtDes": Helper.qBus = Helper.eBuscar.GrupoDesc; break;
                //case "txtRub": Helper.qBus = Helper.eBuscar.Rubro; break;
                //case "txtMoncom": Helper.qBus = Helper.eBuscar.Moneda; break;
                //case "txtConcom": Helper.qBus = Helper.eBuscar.Cpago; break;
            }
            //Helper.Buscar(txt);
        }
        private void txtPonerDescrip(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                //case "txtPai": txtDesPais.Text = oTablas.Get_Descrip_Pais(txt.Text); break;
                //case "txtUbi": txtDesUbi.Text = oTablas.Get_Descrip_Ubigeo(txt.Text); break;
                //case "txtZon": txtDeszon.Text = oTablas.Get_Descrip(Helper.eTablas.Zonaventas, txt.Text); break;
                //case "txtVen": txtDesven.Text = oVendedores.Get_Nombre(txt.Text); break;
                //case "txtGru": txtDesgru.Text = oTablas.Get_Descrip(Helper.eTablas.GrupoCliente, txt.Text); break;
                //case "txtSec": txtDessec.Text = oTablas.Get_Descrip(Helper.eTablas.Sectores, txt.Text); break;
                //case "txtMonven": txtDesMonven.Text = oTablas.Get_Descrip(Helper.eTablas.Monedas, txt.Text); break;
                //case "txtConven": txtDesconven.Text = oCondiciones.Get_Descrip(txt.Text); break;
                //case "txtPre": txtDespre.Text = oTablas.Get_Descrip(Helper.eTablas.GrupoPrecios, txt.Text); break;
                //case "txtDes": txtDesdes.Text = oTablas.Get_Descrip(Helper.eTablas.GrupoDesc, txt.Text); break;
                //case "txtRub": txtDesrub.Text = oTablas.Get_Descrip(Helper.eTablas.Rubros, txt.Text); break;
                //case "txtMoncom": txtDesMoncom.Text = oTablas.Get_Descrip(Helper.eTablas.Monedas, txt.Text); break;
                //case "txtConcom": txtDesconcom.Text = oCondiciones.Get_Descrip(txt.Text); break;
            }

        }


        #endregion
    }
}