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
    public partial class Frm_T_Detalle : Form
    {
        #region Declaración Variables
        public string sIdtabla;
        Helper.eTablas eTabla;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;
        
        BL_T_Posicion oBL_T_Posicion = new BL_T_Posicion();
        BE_T_Posicion oBE_T_Posicion = new BE_T_Posicion();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Detalle(Helper.eOpcion _qOpcion, Helper.eTablas _eTabla, string Idtabla)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            eTabla = _eTabla;
            sIdtabla = Idtabla;
        }

        private void Frm_T_Detalle_Load(object sender, EventArgs e)
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
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdtabla.Trim();
                        switch (eTabla)
                        {
                            case Helper.eTablas.Posiciones: oBE_T_Posicion = oBL_T_Posicion.Get_Posicion(sIdtabla);
                                if (oBE_T_Posicion != null)
                                {
                                    txtDescripcion.Text = oBE_T_Posicion.Descripcion;
                                    cboEstado.SelectedIndex = oBE_T_Posicion.Estado ? 0 : 1;
                                }
                                break;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Detalle_Activated(object sender, EventArgs e)
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
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                Boolean bExiste = false;
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: bExiste = oBL_T_Posicion.Existe(txtCodigo.Text); break;
                    }
                    if (bExiste)
                    {
                        MessageBox.Show("El Código ya existe para esta Tabla. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }

                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                switch (eTabla)
                {
                    case Helper.eTablas.Posiciones:
                        oBE_T_Posicion.IdPosicion = txtCodigo.Text.Trim();
                        oBE_T_Posicion.Descripcion = txtDescripcion.Text.Trim();
                        oBE_T_Posicion.Estado = (cboEstado.SelectedIndex == 0);
                        break;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: oBL_T_Posicion.Insertar(oBE_T_Posicion); break;
                    }
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: oBL_T_Posicion.Modificar(oBE_T_Posicion); break;
                    }
                }
                sIdtabla = txtCodigo.Text; bGrabo = true; this.Close();

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