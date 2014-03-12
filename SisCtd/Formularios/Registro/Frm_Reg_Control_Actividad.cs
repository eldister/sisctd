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
    public partial class Frm_Reg_Control_Actividad   : Form
    {
        #region Declaración Variables
        public string sIdControl;
        public string sNroSecuencia;
        public Boolean bGrabo = false;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BL_T_Area oBL_T_Area = new BL_T_Area();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Control_Actividad(string _IdControl)
        {
            InitializeComponent();
            sIdControl = _IdControl;
        }

        private void Frm_Reg_Control_Actividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }


        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActividad.Text == "")
                {
                    MessageBox.Show("Ingrese una Actividad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtActividad.Focus(); return;
                }

                if (oBL_Reg_Control.Existe_Actividad(sIdControl, txtActividad.Text))
                {
                    MessageBox.Show("La Actividad " + lblActividad.Text + " ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtActividad.Focus(); return;
                }

                sNroSecuencia = oBL_Reg_Control.Max_NroSecuencia(sIdControl);
                int nOrden = oBL_Reg_Control.Max_Orden(sIdControl);

                oBE_Reg_ControlDetalle.IdControl = sIdControl;
                oBE_Reg_ControlDetalle.IdActividad = txtActividad.Text.Trim();
                oBE_Reg_ControlDetalle.DuracionEnDias = Convert.ToInt32(txtDuracionendias.Text.Trim());
                oBE_Reg_ControlDetalle.NroSecuencia = sNroSecuencia;
                oBE_Reg_ControlDetalle.Orden = nOrden;

                oBL_Reg_Control.Agregar_Actividad(oBE_Reg_ControlDetalle);
                bGrabo = true; this.Close();

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

        private void Frm_Reg_Control_Actividad_Load(object sender, EventArgs e)
        {

        }

        
    }
}