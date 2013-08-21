using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Separadoras_Det : Form
    {
        #region Declaracion de Variables

        //public string sIdprod = "";
        public string sIdSeparadora = "";
        public Boolean bGrabo = false;
        int qOpc;

        //Cls_T_Productos oProductos = new Cls_T_Productos();
        Cls_T_Separadoras oSeparadora = new Cls_T_Separadoras();

        #endregion

        #region Iniciar Formulario

        public Frm_T_Separadoras_Det(int Opc, string IdSeparadora)
        {
            InitializeComponent();
            qOpc = Opc;
            sIdSeparadora = IdSeparadora;
        }
        private void Frm_T_SubProducto_Load(object sender, EventArgs e)
        {
           
            switch (qOpc)
            {
                case 3:
                    this.Text = " Nuevo";
                    cboEst.SelectedIndex = 0;
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
                    DataTable Dt = new DataTable();
                    try
                    {
                        Dt = oSeparadora.Get_Registro(sIdSeparadora);
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIdSeparadora.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            cboEst.SelectedIndex = Dt.Rows[0]["estado"].ToString() == "True"? 0:1;
                        }
                        Dt.Dispose();
                    }
                    catch (Exception Er)
                    { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
            }
        }
        private void Frm_T_SubProducto_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
        }
        private void Frm_T_SubProducto_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                if (oSeparadora.Existe(txtCodigo.Text) == true & qOpc == 3)
                {
                    MessageBox.Show("El Código ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }

                oSeparadora.Grabar(qOpc, txtCodigo.Text.Trim(),txtDescrip.Text.Trim(), (cboEst.SelectedIndex == 0));
                sIdSeparadora = txtCodigo.Text; bGrabo = true; this.Close();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

    }
}