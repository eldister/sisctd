using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;

namespace BESisCtd
{
    public partial class Frm_Reg_Control_Det : Form
    {
        #region Declaraci�n Variables
        public Int32 nIdControl;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Control_Det(Helper.eOpcion _qOpcion, Int32 IdControl)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            nIdControl = IdControl;
        }
        private void Frm_Reg_Control_Det_Load(object sender, EventArgs e)
        {
            try
            {
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        txtIdControl.Text = "???";
                        lblEstado.Text = "Pendiente";
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        txtIdControl.ReadOnly = true;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtIdTipoDocumento.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }

                        oBE_Reg_Control = oBL_Reg_Control.Get_Control(nIdControl);
                        if (oBE_Reg_Control != null)
                        {
                            txtIdControl.Text = oBE_Reg_Control.IdControl.ToString();
                            txtIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                            txtIdMaestroCliente.Text= oBE_Reg_Control.IdMaestroCliente;
                            txtNumero.Text= oBE_Reg_Control.NroDocumento ;
                            dtpFechaDocumento.Value= oBE_Reg_Control.FechaDocumento;
                            txtObservacion.Text= oBE_Reg_Control.Observacion;
                            if (oBE_Reg_Control.FechaInicio!=null) lblFechaInicio.Text = Convert.ToString(oBE_Reg_Control.FechaInicio);
                            if (oBE_Reg_Control.FechaTermino != null) lblFechaTermino.Text = Convert.ToString(oBE_Reg_Control.FechaTermino);
                            lblEstado.Text= oBE_Reg_Control.Estado;
                            cboRuta.SelectedValue = oBE_Reg_Control.IdRuta;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_Reg_Control_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_Reg_Control_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Nuevo) { txtIdTipoDocumento.Focus(); }
            if (qOpcion == Helper.eOpcion.Modificar) { txtIdTipoDocumento.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Eventos Objetos
        private void PonerDescrip_TextChanged(object sender, EventArgs e)
        {
            TextBox txt=(MigControls.MigTextbox)sender;
            switch (txt.Name)
            {
                case "txtIdTipoDocumento": 
                    lblDesTipoDocumneto.Text = oBL_T_TipoDocumento.Get_Descripcion(txtIdTipoDocumento.Text);
                    Helper.LLenar_Combobox(oBL_T_TipoDocumento.Listar_Rutas(txtIdTipoDocumento.Text), cboRuta, "Descripcion", "IdRuta");
                    break;
                case "txtIdMaestroCliente": lblDesMaestroCliente.Text = oBL_T_MaestroCliente.Get_RazonSocial(txtIdMaestroCliente.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtIdTipoDocumento": txtIdTipoDocumento.Text = Helper.Buscar(oBL_T_TipoDocumento.Buscar()); break;
                    case "txtIdMaestroCliente": txtIdMaestroCliente.Text = Helper.Buscar(oBL_T_MaestroCliente.Buscar()); break;
                }
            }
        }
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDesTipoDocumneto.Text == "")
                {
                    MessageBox.Show("Ingrese un Tipo de Documento v�lido", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdTipoDocumento.Focus(); return;
                }

                if (lblDesMaestroCliente.Text == "")
                {
                    MessageBox.Show("Ingrese un Cliente v�lido", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdMaestroCliente.Focus(); return;
                }

                if (txtNumero.Text == "")
                {
                    MessageBox.Show("Ingrese un N�mero", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.Focus(); return;
                }

                if (cboRuta.Text == "")
                {
                    MessageBox.Show("Seleccione una Ruta", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboRuta.Focus(); return;
                }
            
                oBE_Reg_Control.IdControl = nIdControl;
                oBE_Reg_Control.IdTipoDocumento = txtIdTipoDocumento.Text.Trim();
                oBE_Reg_Control.IdMaestroCliente = txtIdMaestroCliente.Text.Trim();
                oBE_Reg_Control.NroDocumento = txtNumero.Text.Trim();
                oBE_Reg_Control.FechaDocumento = dtpFechaDocumento.Value;
                oBE_Reg_Control.Observacion = txtObservacion.Text;
                oBE_Reg_Control.Estado = lblEstado.Text;
                oBE_Reg_Control.IdRuta = cboRuta.SelectedValue.ToString();

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    nIdControl = oBL_Reg_Control.Insertar(oBE_Reg_Control);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_Reg_Control.Modificar(oBE_Reg_Control);
                }
                bGrabo = true; this.Close();

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