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
    public partial class Frm_Sis_Perfil_Det : Form
    {
        #region Declaracion de Variables

        //public string sIdprod = "";
        public string sIdPerfil = "";
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_Sis_Perfil oBL_Sis_Perfil = new BL_Sis_Perfil();
        BE_Sis_Perfil oBE_Sis_Perfil = new BE_Sis_Perfil();

        #endregion

        #region Iniciar Formulario

        public Frm_Sis_Perfil_Det(Helper.eOpcion _Opcion, string _IdPerfil)
        {
            InitializeComponent();
            qOpcion = _Opcion;
            sIdPerfil = _IdPerfil;
        }
        private void Frm_Sis_Perfil_Det_Load(object sender, EventArgs e)
        {
           
            switch (qOpcion)
            {
                case Helper.eOpcion.Nuevo:
                    this.Text = " Nuevo";
                    lblIdPerfil.Text = "??";
                    break;
                case Helper.eOpcion.Consultar:
                case Helper.eOpcion.Modificar:
                    if (qOpcion == Helper.eOpcion.Consultar)
                    {
                        this.Text = " Consulta";
                        txtDescrip.ReadOnly = true;
                        BtnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text = " Modificar";

                    }
                    try
                    {
                        oBE_Sis_Perfil = oBL_Sis_Perfil.Get_Perfil(sIdPerfil);
                        if (oBE_Sis_Perfil!=null)
                        {
                            lblIdPerfil.Text = oBE_Sis_Perfil.IdPerfil;
                            txtDescrip.Text = oBE_Sis_Perfil.Descripcion;
                        }
                    }
                    catch (Exception Er)
                    { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
            }
        }
        private void Frm_Sis_Perfil_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtDescrip.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }
        private void Frm_Sis_Perfil_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        #endregion
        
        #region Metodos

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Eventos Menu
        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }
                oBE_Sis_Perfil.Descripcion = txtDescrip.Text.Trim();
                if (qOpcion == Helper.eOpcion.Nuevo) sIdPerfil = oBL_Sis_Perfil.Insertar(oBE_Sis_Perfil, Helper.oBE_Sis_Usuario.IdUsuario);
                if (qOpcion == Helper.eOpcion.Modificar) oBL_Sis_Perfil.Modificar(oBE_Sis_Perfil);
                bGrabo = true; this.Close();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

    }
}