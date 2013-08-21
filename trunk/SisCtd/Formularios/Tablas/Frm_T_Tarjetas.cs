using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Tarjetas : Form
    {
        public Frm_T_Tarjetas(int Opc, string Idtarjeta)
        {
            InitializeComponent();
            qOpc = Opc;
            sIdtarjeta = Idtarjeta;
        }

        public string sIdtarjeta = "";
        public Boolean bGrabo = false;
        int qOpc;

        Cls_T_Tarjetas oTarjetas = new Cls_T_Tarjetas();

        private void Frm_T_Tarjetas_Load(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            try
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
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        Dt = oTarjetas.Get_Registro(sIdtarjeta);
                        
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIdtarjeta.Trim();
                            txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                            cboEst.SelectedIndex = (Boolean)Dt.Rows[0]["estado"] == true ? 0 : 1;
                            txtDigitos.Text = Dt.Rows[0]["digitos"].ToString().Trim();
                        }
                        Dt.Dispose();
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Tarjetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Tarjetas_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
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
                
                if (qOpc == 3)
                {
                    if (oTarjetas.Existe(txtCodigo.Text))
                    {
                        MessageBox.Show("El Código ya existe para esta Tabla. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }
                if (txtDigitos.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la cantidad de dígitos a validar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDigitos.Focus(); return;
                }

                oTarjetas.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text,txtDigitos.Text,(cboEst.SelectedIndex == 0));
                sIdtarjeta = txtCodigo.Text; bGrabo = true; this.Close();
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