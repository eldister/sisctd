using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_Sis_Perfil_Det : Form
    {
        #region Declaracion de Variables

        //public string sIdprod = "";
        public string sIdPerfil = "";
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        Cls_Sis_Acceso oAcceso = new Cls_Sis_Acceso();

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
                    DataTable Dt = new DataTable();
                    try
                    {
                        Dt = oAcceso.Get_Registro_Perfil(sIdPerfil);
                        if (Dt.Rows.Count > 0)
                        {
                            lblIdPerfil.Text = sIdPerfil.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                        }
                        Dt.Dispose();
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

                sIdPerfil = oAcceso.Grabar_Perfil(qOpcion, lblIdPerfil.Text.Trim(), txtDescrip.Text.Trim());
                bGrabo = true; this.Close();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

    }
}