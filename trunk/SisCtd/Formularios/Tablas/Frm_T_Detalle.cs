using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_T_Detalle : Form
    {
        public Frm_T_Detalle(int Opc, Helper.eTablas Tabla, string Idtabla)
        {
            InitializeComponent();
            qOpc = Opc;
            eTabla = Tabla;
            sIdtabla = Idtabla;
        }

        public string sIdtabla = "";
        Helper.eTablas eTabla;
        public Boolean bGrabo = false;
        int qOpc;

        Cls_T_Territorios oTerritorios = new Cls_T_Territorios();
        Cls_T_Datos oDatos = new Cls_T_Datos();
        Cls_T_Estados oEstados = new Cls_T_Estados();
        Cls_T_Areas oAreas = new Cls_T_Areas();
        Cls_T_Ejecutivos oEjecutivos = new Cls_T_Ejecutivos();

        private void Frm_T_Detalle_Load(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            try
            {

                if (eTabla == Helper.eTablas.Ejecutivos)
                {
                    label7.Text = "Nombre *";
                    txtDescrip.MaxLength = 60;
                }

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
                        switch (eTabla)
                        {
                            case Helper.eTablas.Territorios: Dt = oTerritorios.Get_Registro(sIdtabla); break;
                            case Helper.eTablas.Datos: Dt = oDatos.Get_Registro(sIdtabla); break;
                            case Helper.eTablas.Estados: Dt = oEstados.Get_Registro(sIdtabla); break;
                            case Helper.eTablas.Areas: Dt = oAreas.Get_Registro(sIdtabla); break;
                            case Helper.eTablas.Ejecutivos: Dt = oEjecutivos.Get_Registro(sIdtabla); break;
                        }
                        if (Dt.Rows.Count > 0)
                        {
                            txtCodigo.Text = sIdtabla.Trim();
                            switch (eTabla)
                            { 
                                case Helper.eTablas.Ejecutivos:
                                    txtDescrip.Text = Dt.Rows[0]["nombre"].ToString().Trim();
                                    break;
                                default:
                                    txtDescrip.Text = Dt.Rows[0]["descripcion"].ToString().Trim(); break;
                            }
                            cboEst.SelectedIndex = (Boolean)Dt.Rows[0]["estado"] == true ? 0 : 1;
                        }
                        Dt.Dispose();
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
                Boolean bExiste = false;
                if (qOpc == 3)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Territorios: bExiste = oTerritorios.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Datos: bExiste = oDatos.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Estados: bExiste = oEstados.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Areas: bExiste = oAreas.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Ejecutivos: bExiste = oEjecutivos.Existe(txtCodigo.Text); break;
                    }
                    if (bExiste)
                    {
                        MessageBox.Show("El Código ya existe para esta Tabla. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }

                if (txtDescrip.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescrip.Focus(); return;
                }

                switch (eTabla)
                {
                    case Helper.eTablas.Territorios: oTerritorios.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0)); break;
                    case Helper.eTablas.Datos: oDatos.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0)); break;
                    case Helper.eTablas.Estados: oEstados.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0)); break;
                    case Helper.eTablas.Areas: oAreas.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0)); break;
                    case Helper.eTablas.Ejecutivos: oEjecutivos.Grabar(qOpc, txtCodigo.Text, txtDescrip.Text, (cboEst.SelectedIndex == 0)); break;
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
    }
}