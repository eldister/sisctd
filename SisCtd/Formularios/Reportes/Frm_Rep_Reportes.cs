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
    public partial class Frm_Rep_Reportes   : Form
    {
        #region Declaración Variables
        public string sIdControl;
        public string sNroSecuencia;
        public Boolean bGrabo = false;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();

        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Area oBL_T_Area = new BL_T_Area();

        #endregion

        #region Iniciar Formulario
        public Frm_Rep_Reportes()
        {
            InitializeComponent();
            //sIdControl = _IdControl;
        }
        private void Frm_Rep_Reportes_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oBL_T_Area.Listar("", ""), cboArea, "Descripcion", "IdArea");
            lstTablas.Items.Add("Reportes Pendientes");
            lstTablas.SelectedIndex = 0;
            lblTabla.Text = "  " + lstTablas.Text;
        }

        private void Frm_Rep_Reportes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }


        #endregion

        #region Eventos Objetos
        private void bEjecutar_Click(object sender, EventArgs e)
        {
            DataTable Dt1 = new DataTable();

            if (lstTablas.SelectedIndex == 0)
            {
                Dt1 = oBL_Reg_Control.Reporte();
                Helper.MostrarReporte("RepDocPendientes", "RepDocPendientes", Dt1);
                Dt1.Dispose();
            }


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
                //case "txtActividad": lblActividad.Text = oBL_T_Actividad.Get_Descripcion(txtActividad.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    //case "txtActividad": txtActividad.Text = Helper.Buscar(oBL_T_Actividad.Buscar()); break;
                }
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }

        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }

        #endregion


 
        
    }
}