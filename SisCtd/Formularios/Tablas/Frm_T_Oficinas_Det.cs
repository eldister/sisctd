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
    public partial class Frm_T_Oficinas_Det : Form
    {
        public Frm_T_Oficinas_Det(int Opc, string IdOficina)
        {
            InitializeComponent();
            qOpc = Opc;            
            sIdOficina = IdOficina;
        }

        public string sIdOficina = "";       
        public Boolean bGrabo = false;        
        int qOpc;
                
        //Cls_T_Oficinas OOficina = new Cls_T_Oficinas();
        //Cls_T_Territorios OTerritorio = new Cls_T_Territorios();
        BL_Sis_Sistema oBL_Sis_Sistema = new BL_Sis_Sistema();

        private void Frm_T_Oficinas_Det_Activated(object sender, EventArgs e)
        {
            if (qOpc == 2) { txtDescrip.Focus(); }
            if (qOpc == 1) { BtnCancelar.Focus(); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion() == true)
                {
                    //OOficina.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, cboTerritorio.SelectedValue.ToString(), txtUbigeo.Text, txtDirec.Text,
                    //    cboRecojo.Text == "SI" ? true : false,
                    //    cboCierre.Text == "SI" ? true : false);
                    //sIdOficina = txtCodigo.Text; bGrabo = true; this.Close();
                }
            }
            catch (Exception Er) 
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private Boolean Validacion()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Código", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus(); return false;
            }

            //if (OOficina.Existe(txtCodigo.Text) == true & qOpc == 3)
            //{
            //    MessageBox.Show("El Código ya existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtCodigo.Focus(); return false;
            //}

            if (txtDescrip.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescrip.Focus(); return false;
            }

            if (cboTerritorio.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un Territorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTerritorio.Focus(); return false;
            }

            if (txtUbigeo.Text != "")
            {
                if (lblUbigeo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese una Ubicación Válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUbigeo.Focus(); return false;
                }
            }

            if (cboRecojo.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione el Campo de Recojo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboRecojo.Focus(); return false;
            }
            if (cboCierre.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione el Campo de Cierre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCierre.Focus(); return false;
            }

            return true;
        }


        private void Frm_T_Oficinas_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        private void Frm_T_Oficinas_Det_Load(object sender, EventArgs e)
        {
            //Helper.LLenar_Combobox(OTerritorio.Listar("", 2), cboTerritorio, "des", "id");
            switch (qOpc)
            {
                case 3:
                    this.Text += " - Nuevo";
                    break;
                case 1:
                case 2:
                    txtCodigo.ReadOnly = true;
                    if (qOpc == 1)
                    {
                        this.Text += " - Consulta";
                        txtDescrip.ReadOnly = true;
                        txtUbigeo.ReadOnly = true;
                        txtDirec.ReadOnly = true;
                        txtDescrip.ReadOnly = true;
                        BtnGrabar.Visible = false;
                    }
                    else
                    {
                        this.Text += " - Modificar";
                    }
                    //DataTable Dt = new DataTable();
                    //Dt = OOficina.Get_Registro(sIdOficina);
                    //if (Dt.Rows.Count > 0)
                    //{
                    //    txtCodigo.Text = sIdOficina.Trim();
                    //    txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim();
                    //    cboTerritorio.SelectedValue = Dt.Rows[0]["idterritorio"].ToString().Trim();
                    //    txtUbigeo.Text = Dt.Rows[0]["idubigeo"].ToString().Trim();
                    //    txtDirec.Text = Dt.Rows[0]["direccion"].ToString().Trim();
                    //    cboRecojo.Text = Convert.ToBoolean(Dt.Rows[0]["recojo"].ToString()) == true ? "SI" : "NO";
                    //    cboCierre.Text = Convert.ToBoolean(Dt.Rows[0]["cierre"].ToString()) == true ? "SI" : "NO";
                    //}
                    //Dt.Dispose();
                    break;
            }
        }

        private void txtUbigeo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //Helper.eTablaBus = Helper.eTablaBus = Helper.eTablas.Ubigeo; Helper.Buscar(txtUbigeo);
            }
        }

        private void txtUbigeo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUbigeo.Text.Trim() != "")
                {
                    lblUbigeo.Text = oBL_Sis_Sistema.Get_Descrip_Ubigeo(txtUbigeo.Text);
                }
                else { lblUbigeo.Text = ""; }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}