using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_Sis_Acceso_Mod : Form
    {
        #region Declaracion de Variables

        public Boolean bGrabo = false;
        public string sIdPerfil = "";
        Cls_Sis_Acceso oAcceso = new Cls_Sis_Acceso();

        #endregion

        #region Iniciar Formulario

        public Frm_Sis_Acceso_Mod()
        {
            InitializeComponent();
        }
        private void Frm_Sis_Acceso_Mod_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oAcceso.Listar_Perfiles(), cboPerfiles, "des", "idPerfil");
           
        }
        private void Frm_Sis_Acceso_Mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPerfiles.Text == "")
                {
                    MessageBox.Show("Seleccione un Perfil", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPerfiles.Focus(); return;
                }
                sIdPerfil = cboPerfiles.SelectedValue.ToString();
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