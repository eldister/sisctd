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
    public partial class Frm_T_RutaActividad   : Form
    {
        #region Declaración Variables
        public string sIdRuta;
        public string sIdActividad;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_RutaActividad oBL_T_RutaActividad = new BL_T_RutaActividad();
        BE_T_RutaActividad oBE_T_RutaActividad = new BE_T_RutaActividad();
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BL_T_Area oBL_T_Area = new BL_T_Area();

        #endregion

        #region Iniciar Formulario
        public Frm_T_RutaActividad(Helper.eOpcion _qOpcion, string IdRuta, string IdActividad)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdRuta = IdRuta;
            sIdActividad = IdActividad;
            txtCodigo.Text = IdRuta;
            lblRuta.Text = oBL_T_Ruta.Get_Descripcion(txtCodigo.Text);
        }
        private void Frm_T_RutaActividad_Load(object sender, EventArgs e)
        {
            try
            {
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        txtCodigo.ReadOnly = true;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtActividad.ReadOnly = true;
                            txtDuracionendias.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdRuta.Trim();
                        txtActividad.Text = sIdActividad.Trim();

                        oBE_T_RutaActividad = oBL_T_RutaActividad.Get_RutaActividad(sIdRuta, sIdActividad );
                        if (oBE_T_RutaActividad != null)
                        {
                            txtActividad.Text = oBE_T_RutaActividad.IdActividad;
                            txtIdOficina.Text = oBE_T_RutaActividad.IdOficina;
                            txtIdArea.Text = oBE_T_RutaActividad.IdArea;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_RutaActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_RutaActividad_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtActividad.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                oBE_T_RutaActividad.IdRuta = txtCodigo.Text.Trim();
                oBE_T_RutaActividad.IdActividad = txtActividad.Text.Trim();
                oBE_T_RutaActividad.DuracionenDia = Convert.ToInt32(txtDuracionendias.Text.Trim());
                oBE_T_RutaActividad.IdOficina = txtIdOficina.Text.Trim();
                oBE_T_RutaActividad.IdArea = txtIdArea.Text.Trim();

                if (oBE_T_RutaActividad.IdActividad == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    //oBL_T_RutaActividad.Existe(oBE_T_RutaActividad.IdRuta, oBE_T_RutaActividad.IdActividad);
                    if (oBL_T_RutaActividad.Existe(oBE_T_RutaActividad.IdRuta, oBE_T_RutaActividad.IdActividad))
                    {
                        MessageBox.Show("El Código " + oBE_T_RutaActividad.IdRuta + " - " + oBE_T_RutaActividad.IdActividad + " ya fue creado. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    int nOrden = oBL_T_RutaActividad.Max_Orden(oBE_T_RutaActividad);
                    oBE_T_RutaActividad.Orden = nOrden;
                    oBL_T_RutaActividad.Insertar(oBE_T_RutaActividad);
                }
                sIdRuta = txtCodigo.Text; bGrabo = true; this.Close();

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
                case "txtRuta": lblRuta.Text = oBL_T_Ruta.Get_Descripcion(txtCodigo.Text); break;
                case "txtActividad": lblActividad.Text = oBL_T_Actividad.Get_Descripcion(txtActividad.Text); break;
                case "txtIdOficina": lblOficina.Text = oBL_T_Oficina.Get_Descripcion(txtIdOficina.Text); break;
                case "txtIdArea": lblArea.Text = oBL_T_Area.Get_Descripcion(txtIdArea.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtActividad": txtActividad.Text = Helper.Buscar(oBL_T_Actividad.Buscar()); break;
                    case "txtIdOficina": txtIdOficina.Text = Helper.Buscar(oBL_T_Oficina.Buscar()); break;
                    case "txtIdArea": txtIdArea.Text = Helper.Buscar(oBL_T_Area.Buscar()); break;
                }
            }
        }


        #endregion

        
    }
}