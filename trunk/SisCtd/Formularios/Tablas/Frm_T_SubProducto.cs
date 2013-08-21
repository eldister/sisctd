using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_SubProducto : Form
    {
        public Frm_T_SubProducto(int Opc,string Idprod, string Idsubprod)
        {
            InitializeComponent();
            qOpc = Opc;
            sIdprod = Idprod;
            sIdsubprod = Idsubprod;
        }
        public string sIdprod = "";
        public string sIdsubprod = "";
        public Boolean bGrabo = false;        
        int qOpc;
                
        Cls_T_Productos oProductos = new Cls_T_Productos();
        Cls_T_SubProductos oSubprod = new Cls_T_SubProductos();

        private void Frm_T_SubProducto_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Combobox(oProductos.Listar("", "", 2), cboProducto, "des", "id");
            switch (qOpc)
            {
                case 3:
                    this.Text = " Nuevo";
                    cboEst.SelectedIndex = 0;
                    if (sIdprod != "") cboProducto.SelectedValue = sIdprod;
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
                        Dt = oSubprod.Get_Registro(sIdprod, sIdsubprod);
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIdsubprod.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            cboProducto.SelectedValue = Dt.Rows[0]["idproducto"].ToString().Trim();
                            //cboEst.SelectedIndex = Dt.Rows[0]["estado"].ToString() == "1" ? 0 : 1;
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
                if (oSubprod.Existe(cboProducto.SelectedValue.ToString(), txtCodigo.Text) == true & qOpc == 3)
                {
                    MessageBox.Show("El Código ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }

                oSubprod.Grabar(qOpc, cboProducto.SelectedValue.ToString(), txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0));
                sIdprod = cboProducto.SelectedValue.ToString();
                sIdsubprod = txtCodigo.Text; bGrabo = true; this.Close();
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