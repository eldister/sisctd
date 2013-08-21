using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SisCtd
{
    public partial class Frm_Rep_Completitud : Form
    {
        public Frm_Rep_Completitud()
        {
            InitializeComponent();
        }
        
        Cls_Rep_Reportes OReportes = new Cls_Rep_Reportes();
        
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Rep_Retiros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        private void Frm_Rep_Retiros_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Años(cboAnio);
            cboMeses.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void opcFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) SendKeys.Send("{Tab}");
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            Listar(1);
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            Listar(0);
        }

        private void Listar(int nIndex)
        {
            DataTable Dt = new DataTable();
            string sTit = "";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (opcFechas.Checked == true)
                {
                    sTit = " Del " + dtpIni.Value.ToShortDateString() + " al " + dtpFin.Value.ToShortDateString();
                }
                else
                {
                    sTit = "Periodo : " + cboMeses.Text + " / " + cboAnio.Text;
                }

                string sFiltro = opcFechas.Checked ? "F" : "P";
                string sMes = Helper.Right("0" + Convert.ToString(cboMeses.SelectedIndex + 1),2);

                int nOpc = 0;
                if (opcDoc.Checked) nOpc = 1;
                if (opcDetenv.Checked) nOpc = 2;
                if (opcDetesc.Checked) nOpc = 3;
                if (opcDetescVen.Checked) nOpc = 4;

                Dt = OReportes.Rep_Digitalizacion_Nextel(nOpc, sFiltro, dtpIni.Value, dtpFin.Value, sMes,cboAnio.Text);
                if (Dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay Registro que mostrar. Realice otro filtro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (nIndex == 0)
                {
                    switch (nOpc)
                    {
                        case 0: Helper.MostrarReporte("Reporte de Envíos a Nextel", "Rep_Digital_Envios", Dt, sTit); break;
                        case 1: Helper.MostrarReporte("Reporte de Producción Personal", "Rep_Digital_Produccion", Dt, sTit); break;
                    }
                }
                else
                {
                    Helper.Exportar(Dt);
                }
                Dt.Dispose();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, " Error : " + Er.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (Dt != null) Dt = null; this.Cursor = Cursors.Default; }
        }

        private void opcFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (opcFechas.Checked == true)
            {
                cboMeses.Enabled = false;
                cboAnio.Enabled = false;
                dtpIni.Enabled = true;
                dtpFin.Enabled = true;
            }
            else
            {
                cboMeses.Enabled = true;
                cboAnio.Enabled = true;
                dtpIni.Enabled = false;
                dtpFin.Enabled = false;
            }
        }

        private void opcFile_Click(object sender, EventArgs e)
        {
            btnRep.Enabled = true;
            if (opcDetesc.Checked || opcDetenv.Checked || opcDetescVen.Checked)
                btnRep.Enabled = false;
        }
    }
}