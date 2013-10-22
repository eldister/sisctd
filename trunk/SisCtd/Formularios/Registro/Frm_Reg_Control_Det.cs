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
        #region Declaración Variables
        public string sIdControl;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Control_Det(Helper.eOpcion _qOpcion, string IdControl)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdControl = IdControl;
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
                        txtIdControl.Text = sIdControl.Trim();

                        oBE_Reg_Control = oBL_Reg_Control.Get_Control(sIdControl);
                        if (oBE_Reg_Control != null)
                        {
                            txtIdControl.Text = oBE_Reg_Control.IdControl.ToString();
                            txtIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                            txtIdMaestroCliente.Text= oBE_Reg_Control.IdMaestroCliente;
                            txtNumero.Text= oBE_Reg_Control.NroDocumento ;
                            dtpFechaDocumento.Value= oBE_Reg_Control.FechaDocumento;
                            txtCodigoBarra.Text= oBE_Reg_Control.CodigoBarra;
                            txtObservacion.Text= oBE_Reg_Control.Observacion;
                            lblFechaInicio.Text = oBE_Reg_Control.FechaInicio.ToString("dd/MM/yyyy");
                            lblFechaTermino.Text = oBE_Reg_Control.FechaTermino.ToString("dd/MM/yyyy") ;
                            lblEstado.Text= oBE_Reg_Control.Estado;
                            txtIdRuta.Text= oBE_Reg_Control.IdRuta;
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
                case "txtIdTipoDocumento": lblDesTipoDocumneto.Text = oBL_T_TipoDocumento.Get_Descripcion(txtIdTipoDocumento.Text); break;
                case "txtIdRuta": lblDesRuta.Text = oBL_T_Ruta.Get_Descripcion(txtIdRuta.Text); break;
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
                    case "txtIdRuta": txtIdRuta.Text = Helper.Buscar(oBL_T_Ruta.Buscar()); break;
                    case "txtIdMaestroCliente": txtIdMaestroCliente.Text = Helper.Buscar(oBL_T_MaestroCliente.Buscar()); break;
                }
            }
        }
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //oBE_Reg_Control.IdTipoDocumento = txtIdControl.Text.Trim();
                //oBE_Reg_Control.Descripcion = txtIdTipoDocumento.Text.Trim();
                //oBE_Reg_Control.DescripcionLarga = txtObservacion.Text.Trim();
                ////oBE_T_TipoDocumento.Estado = lblEstado.Text;

                //if (oBE_Reg_Control.IdTipoDocumento == "")
                //{
                //    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtIdControl.Focus(); return;
                //}
                //if (qOpcion == Helper.eOpcion.Nuevo)
                //{
                //    oBL_Reg_Control.Existe(oBE_Reg_Control.IdTipoDocumento);
                //    if (oBL_Reg_Control.Existe(oBE_Reg_Control.IdTipoDocumento))
                //    {
                //        MessageBox.Show("El Código " + oBE_Reg_Control.IdTipoDocumento + " ya existe en Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        txtIdControl.Focus(); return;
                //    }
                //}
                //if (oBE_Reg_Control.Descripcion == "")
                //{
                //    MessageBox.Show("Ingrese una Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtIdTipoDocumento.Focus(); return;
                //}

                //if (qOpcion == Helper.eOpcion.Nuevo)
                //{
                //    oBL_Reg_Control.Insertar(oBE_Reg_Control);
                //}
                //if (qOpcion == Helper.eOpcion.Modificar)
                //{
                //    oBL_Reg_Control.Modificar(oBE_Reg_Control);
                //}
                //sIdControl = txtIdControl.Text; bGrabo = true; this.Close();

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