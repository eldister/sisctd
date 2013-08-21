using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_TipoDocumento_Det : Form
    {
        public Frm_T_TipoDocumento_Det(int Opc, string Iddocu)
        {
            InitializeComponent();
            qOpc = Opc;
            sIddocu = Iddocu;
        }

        public string sIddocu = "";
        public Boolean bGrabo = false;
        int qOpc;
        DataTable Dt = new DataTable();

        Cls_T_TipoDocumentos oTipoDoc = new Cls_T_TipoDocumentos();
        Cls_T_Separadoras oSeparadoras = new Cls_T_Separadoras();

        private void Frm_Mnt_Docum_Det_Load(object sender, EventArgs e)
        {
            
            switch (qOpc)
            {
                case 3:
                    this.Text = " Nuevo";
                    cboEst.SelectedIndex = 0;
                    break;
                case 1:
                case 2:
                    txtCodigo.ReadOnly = true;
                    if (qOpc == 1)
                    {
                        this.Text = " Consultar";
                        txtDescrip.ReadOnly = true;
                        txtDeslarga.ReadOnly = true;
                        txtOrden.ReadOnly = true;
                        BtnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text = " Modificar";
                    }
                    
                    try
                    {
                        Dt = oTipoDoc.Get_Registro(sIddocu);
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIddocu.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            txtDeslarga.Text = Dt.Rows[0]["DescripcionLarga"].ToString().Trim();
                            cboVerif.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["verificable"].ToString()) == true ? 0 : 1;
                            cboCri.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["critico"].ToString()) == true ? 0 : 1;
                            cboDigit.SelectedIndex = Convert.ToBoolean(Dt.Rows[0]["digitalizable"].ToString()) == true ? 0 : 1;
                            cboNivel.Text = Dt.Rows[0]["nivel"].ToString().Trim();
                            cboEst.SelectedIndex = (Boolean)Dt.Rows[0]["estado"] == true ? 0 : 1;
                            txtOrden.Text = Dt.Rows[0]["orden"].ToString();
                        }
                        Dt.Dispose();
                    }
                    catch (Exception Er)
                    { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
            }
        }
        private void Frm_Mnt_Docum_Det_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
        }
        private void Frm_Mnt_Docum_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        private void cboCri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNivel.Enabled = cboCri.SelectedIndex == 0 ? true : false;
            cboNivel.Text = "";
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }

                if (oTipoDoc.Existe(txtCodigo.Text) == true & qOpc == 3)
                {
                    MessageBox.Show("El Código del Documento ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }

                if (cboCri.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione si es Crítico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboCri.Focus(); return;
                }
                
                oTipoDoc.Grabar(qOpc,txtCodigo.Text, 
                                     txtDescrip.Text,txtDeslarga.Text,
                                     cboVerif.SelectedIndex == 0 ? true : false,
                                     cboCri.SelectedIndex == 0 ? true : false, 
                                     cboDigit.SelectedIndex == 0 ? true : false, 
                                     cboNivel.Text,
                                     (cboEst.SelectedIndex == 0), 
                                     txtOrden.Text.Trim() == "" ? 0 : Convert.ToInt32(txtOrden.Text),
                                     cboSeparadora.SelectedValue == null ? "" : cboSeparadora.SelectedValue.ToString());

                sIddocu = txtCodigo.Text; bGrabo = true; this.Close();
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