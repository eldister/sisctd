using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
namespace SisCtd
{
    public partial class Frm_Sis_Usuarios_Det : Form
    {
        #region Declaración Variables
        public string sIdusuario = "";
        public Boolean bGrabo = false;
        int qOpc;

        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();

        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Usuarios_Det(int Opc, string _Idusuario)
        {
            InitializeComponent();
            qOpc = Opc;
            sIdusuario = _Idusuario;
        }

        private void Frm_Sis_Usuarios_Det_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oBL_Sis_Usuario.Listar("", "", 2), cboProducto, "des", "id");
            switch (qOpc)
            {
                case 3:
                    this.Text = " Nuevo";
                    cboEst.SelectedIndex = 0;
                    if (sIdproducto != "") cboProducto.SelectedValue = sIdproducto;

                    cboCritico.Enabled = true;
                    cboDigita.Enabled = true;

                    break;
                case 1:
                case 2:
                    if (qOpc == 1)
                    {
                        this.Text = " Consulta";
                        txtDescrip.ReadOnly = true;
                        BtnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text = " Modificar";

                    }
                    txtCodigo.ReadOnly = true;
                    cboProducto.Enabled = false;
                    DataTable Dt = new DataTable();
                    try
                    {
                        Dt = oTipoOperacion.Get_Registro(sIdproducto, sIdTipoOperacion);
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIdTipoOperacion.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            cboProducto.SelectedValue = Dt.Rows[0]["idproducto"].ToString().Trim();
                            cboNat.Text = Dt.Rows[0]["naturaleza"].ToString().Trim();
                            cboCritico.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["critico"]) ? 0 : 1;
                            cboDigita.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["Digitalizable"]) ? 0 : 1;
                            cboEst.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["estado"]) ? 0 : 1;
                        }
                        Dt.Dispose();
                    }
                    catch (Exception Er)
                    { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
            }
        }
        private void Frm_Sis_Usuarios_Det_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
        }
        private void Frm_Sis_Usuarios_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProducto.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione un Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboProducto.Focus(); return;
                }
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (oTipoOperacion.Existe(cboProducto.SelectedValue.ToString(), txtCodigo.Text) == true & qOpc == 3)
                {
                    MessageBox.Show("El Código ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }
                if (cboNat.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione la Naturaleza de la Operación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboNat.Focus(); return;
                }

                if (cboCritico.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione si la Operación es Crítico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboCritico.Focus(); return;
                }

                if (cboDigita.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione si la Operación es Digitalizable", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboDigita.Focus(); return;
                }

                oTipoOperacion.Grabar(qOpc, cboProducto.SelectedValue.ToString(), txtCodigo.Text, txtDescrip.Text,cboNat.Text
                    , (cboCritico.SelectedIndex == 0), (cboDigita.SelectedIndex == 0), (cboEst.SelectedIndex == 0));

                sIdproducto = cboProducto.SelectedValue.ToString();
                sIdTipoOperacion = txtCodigo.Text; bGrabo = true; this.Close();
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