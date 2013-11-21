using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows;
using System.IO;

namespace SisCtd
{
    public partial class Frm_Con_Registro : Form
    {
        public Frm_Con_Registro()
        {
            InitializeComponent();
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;

            //if (Helper.eIDempresa == Helper.eEmpresas.RIPLEY)
            //{
            //    lblNroReclamacion.Visible = true;
            //    txtNroReclamacion.Visible = true;
            //}

            Helper.FormatoGrilla(dgvCab);
        }
        //Cls_Con_Consultas oConsulta = new Cls_Con_Consultas();

        private void Frm_Con_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }
        private void Frm_Con_Registro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btnConsultar.PerformClick(); break;
                case Keys.F7: bExportar.PerformClick(); break;
                case Keys.F3: btnLimpiar.PerformClick(); break;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            oCancelar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Listar(0);
        }

        private void Listar(int nOpc)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //Dt = oConsulta.Listar_Legajos_2(cboTfile.Text.Trim(), txtCodim1.Text.Trim(), txtCodim2.Text.Trim(),
                //    txtNum.Text.Trim(), txtNroReclamacion.Text.Trim(), txtApepat.Text.Trim(), txtApemat.Text.Trim(), txtNombre.Text.Trim(), txtRazsoc.Text.Trim(),txtCodcli.Text.Trim());
                if (nOpc == 0)
                {
                    dgvCab.DataSource = Dt;
                    Helper.FormatoGrilla(dgvCab);
                    //dgvCab.Columns[0].Width = 100;
                    LblMensaje.Text = " Registros Encontrados : " + dgvCab.Rows.Count.ToString();
                    Listar_Detalles();
                }
                else
                {
                    Helper.Exportar(Dt);
                }
                
                Dt.Dispose();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, " Error : " + Er.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { this.Cursor = Cursors.Default; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ObjCtrl in this.panel1.Controls)
            {
                if (ObjCtrl is TextBox) ObjCtrl.Text = "";
            }
            cboTfile.SelectedIndex = 2;
        }

        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }

        private void Listar_Detalles()
        {
            try
            {
                string sTfile = "",sCodim="";
                if (dgvCab.Rows.Count > 0)
                {
                    sTfile = dgvCab.Rows[dgvCab.CurrentCellAddress.Y].Cells[0].Value.ToString();
                    sCodim = dgvCab.Rows[dgvCab.CurrentCellAddress.Y].Cells[1].Value.ToString();
                }

                Helper.FormatoGrilla(dgvDet1,true);
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, " Error : " + Er.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvCab_SelectionChanged(object sender, EventArgs e)
        {
            Listar_Detalles();
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(1);
        }

    }
}