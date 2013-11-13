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
    public partial class Frm_T_Areas_Det : Form
    {
        #region Declaración Variables
        public string sIdArea;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_Area oBL_T_Area = new BL_T_Area();
        BE_T_Area oBE_T_Area = new BE_T_Area();
        BL_T_Gerencia   oBL_T_Gerencia = new BL_T_Gerencia();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Areas_Det(Helper.eOpcion _qOpcion, string IdArea)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdArea = IdArea;
        }
        private void Frm_T_Areas_Det_Load(object sender, EventArgs e)
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
                            txtGerencia.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdArea.Trim();

                        oBE_T_Area = oBL_T_Area.Get_Area (sIdArea);
                        if (oBE_T_Area != null)
                        {
                            txtDescripcion.Text = oBE_T_Area.Descripcion;
                            txtGerencia.Text = oBE_T_Area.IdGerencia ;
                            cboEstado.SelectedIndex = oBE_T_Area.Estado ? 0 : 1;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Area_Det_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Frm_T_Area_Det_Activated(object sender, EventArgs e)
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
                oBE_T_Area.IdArea = txtCodigo.Text.Trim();
                oBE_T_Area.Descripcion = txtDescripcion.Text.Trim();
                oBE_T_Area.IdGerencia = txtGerencia.Text.Trim();
                oBE_T_Area.Estado = (cboEstado.SelectedIndex == 0);

                if (oBE_T_Area.IdArea == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Area.Existe(oBE_T_Area.IdArea);
                    if (oBL_T_Area.Existe(oBE_T_Area.IdArea))
                    {
                        MessageBox.Show("El Código " + oBE_T_Area.IdArea + " ya existe en Tipos de Documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }
                if (oBE_T_Area.Descripcion == "")
                {
                    MessageBox.Show("Ingrese una Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Area.Insertar(oBE_T_Area);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_T_Area.Modificar(oBE_T_Area);
                }
                sIdArea = txtCodigo.Text; bGrabo = true; this.Close();

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
                case "txtGerencia": lblGerencia.Text = oBL_T_Gerencia.Get_Descripcion(txtGerencia.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtGerencia": txtGerencia.Text = Helper.Buscar(oBL_T_Gerencia.Buscar()); break;
                }
            }
        }



        #endregion

    }
}