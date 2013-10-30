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
    public partial class Frm_T_Empleados_Det   : Form
    {
        #region Declaración Variables
        public string sIdEmpleado;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_T_Empleado oBL_T_Empleado = new BL_T_Empleado();
        BE_T_Empleado oBE_T_Empleado = new BE_T_Empleado();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Empleados_Det(Helper.eOpcion _qOpcion, string IdEmpleado)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdEmpleado = IdEmpleado;
        }
        private void Frm_T_Empleados_Det_Load(object sender, EventArgs e)
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
                            txtUbigeo.ReadOnly = true;
                            txtDireccion.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdEmpleado.Trim();

                        oBE_T_Empleado = oBL_T_Empleado.Get_Empleado (sIdEmpleado);
                        if (oBE_T_Empleado != null)
                        {
                            txtDescripcion.Text = oBE_T_Empleado.Nombre ;
                            cboEstado.SelectedIndex = oBE_T_Empleado.Estado ? 0 : 1;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Empleados_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Empleados_Det_Activated(object sender, EventArgs e)
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
                oBE_T_Empleado.IdEmpleado = txtCodigo.Text.Trim();
                oBE_T_Empleado.Nombre  = txtDescripcion.Text.Trim();
                oBE_T_Empleado.Estado = (cboEstado.SelectedIndex == 0);

                if (oBE_T_Empleado.IdEmpleado  == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Empleado.Existe(oBE_T_Empleado.IdEmpleado);
                    if (oBL_T_Empleado.Existe(oBE_T_Empleado.IdEmpleado))
                    {
                        MessageBox.Show("El Código " + oBE_T_Empleado.IdEmpleado + " El Empleado ya fue creado. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }
                if (oBE_T_Empleado.Nombre == "")
                {
                    MessageBox.Show("Ingrese una Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    oBL_T_Empleado.Insertar(oBE_T_Empleado);
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_T_Empleado.Modificar(oBE_T_Empleado);
                }
                sIdEmpleado = txtCodigo.Text; bGrabo = true; this.Close();

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