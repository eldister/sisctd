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
    public partial class Frm_Sis_Usuarios_Det : Form
    {
        #region Declaración Variables
        public string sIdusuario = "";
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BE_Sis_Usuario oBE_Sis_Usuario = new BE_Sis_Usuario();

        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Usuarios_Det(Helper.eOpcion _qOpcion, string _Idusuario)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdusuario = _Idusuario;
        }

        private void Frm_Sis_Usuarios_Det_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oBL_Sis_Usuario.Listar("", "", 2), cboProducto, "des", "id");
            switch (qOpcion)
            {
                case 3:
                    this.Text = " Nuevo";
                    cboEstado.SelectedIndex = 0;
                    if (sIdproducto != "") cboProducto.SelectedValue = sIdproducto;

                    cboCritico.Enabled = true;
                    cboPerfil.Enabled = true;

                    break;
                case 1:
                case 2:
                    if (qOpcion == 1)
                    {
                        this.Text = " Consulta";
                        txtNombre.ReadOnly = true;
                        btnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text = " Modificar";

                    }
                    txtIdUsuario.ReadOnly = true;
                    cboProducto.Enabled = false;
                    DataTable Dt = new DataTable();
                    try
                    {
                        Dt = oTipoOperacion.Get_Registro(sIdproducto, sIdTipoOperacion);
                        if (Dt.Rows.Count > 0)
                        {
                            txtIdUsuario.Text = sIdTipoOperacion.Trim();
                            txtNombre.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            cboProducto.SelectedValue = Dt.Rows[0]["idproducto"].ToString().Trim();
                            cboNat.Text = Dt.Rows[0]["naturaleza"].ToString().Trim();
                            cboCritico.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["critico"]) ? 0 : 1;
                            cboPerfil.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["Digitalizable"]) ? 0 : 1;
                            cboEstado.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["estado"]) ? 0 : 1;
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
            if (qOpcion == Helper.eOpcion.Modificar) { txtNombre.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { btnCancelar.Focus(); }
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
                if (txtIdUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Id de Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdUsuario.Focus(); return;
                }
                if (oBL_Sis_Usuario.Existe(txtIdUsuario.Text) == true & qOpcion == Helper.eOpcion.Nuevo)
                {
                    MessageBox.Show("El Id de Usuario ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdUsuario.Focus(); return;
                }

                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un Nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus(); return;
                }

                if (cboPerfil.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione un Perfil", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPerfil.Focus(); return;
                }

                oTipoOperacion.Grabar(qOpcion, cboProducto.SelectedValue.ToString(), txtIdUsuario.Text, txtNombre.Text,cboNat.Text
                    , (cboCritico.SelectedIndex == 0), (cboPerfil.SelectedIndex == 0), (cboEstado.SelectedIndex == 0));

                sIdproducto = cboProducto.SelectedValue.ToString();
                sIdTipoOperacion = txtIdUsuario.Text; bGrabo = true; this.Close();
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