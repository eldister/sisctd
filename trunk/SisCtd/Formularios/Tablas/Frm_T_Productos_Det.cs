using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Productos_Det : Form
    {
        public Frm_T_Productos_Det(int Opc, string Idprod)
        {
            InitializeComponent();
            qOpc = Opc; sIdprod = Idprod;
        }

        public string sIdprod = "";
        public Boolean bGrabo = false;
        int qOpc;
        Cls_T_Productos oProductos = new Cls_T_Productos();
        Cls_T_Areas oAreas = new Cls_T_Areas();

        private void Frm_T_Productos_Det_Load(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            try
            {

                switch (qOpc)
                {
                    case 3:
                        this.Text = " Nuevo";
                        cboEreg.SelectedIndex = 0;
                        break;
                    case 1:
                    case 2:
                        txtIdprod.ReadOnly = true;
                        if (qOpc == 1)
                        {
                            this.Text = " Consultar";
                            txtDescrip.ReadOnly = true;
                            txtArea.ReadOnly = true;
                            cboTipo.Enabled = false;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        Dt = oProductos.Get_Registro(sIdprod); 
                        if (Dt.Rows.Count > 0)
                        {
                            txtIdprod.Text = sIdprod.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            txtArea.Text = Dt.Rows[0]["idarea"].ToString().Trim();
                            cboTipo.Text = Dt.Rows[0]["tipo"].ToString().Trim();
                            cboEreg.SelectedIndex = (Boolean)Dt.Rows[0]["estado"] == true ? 0 : 1;
                        }
                        Dt.Dispose();
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Productos_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Productos_Det_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            if (e.KeyCode == Keys.F1)
            {
                Helper.eTablaBus = Helper.eTablas.Areas;
                txtArea.Text = Helper.Buscar();
            }
        }
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            lblArea.Text = oAreas.Get_Descrip(txtArea.Text);
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdprod.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdprod.Focus(); return;
                }
                if (qOpc == 3)
                {
                    if (oProductos.Existe(txtIdprod.Text))
                    {
                        MessageBox.Show("El Código del Producto ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdprod.Focus(); return;
                    }
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }

                if (lblArea.Text.Trim() == "" && txtArea.Text.Trim() != "")
                {
                    MessageBox.Show("El Area ingresado no existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtArea.Focus(); return;
                }

                oProductos.Grabar(qOpc, txtIdprod.Text, txtDescrip.Text, txtArea.Text, cboTipo.Text, (cboEreg.SelectedIndex == 0));
                sIdprod = txtIdprod.Text; bGrabo = true; this.Close();

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}