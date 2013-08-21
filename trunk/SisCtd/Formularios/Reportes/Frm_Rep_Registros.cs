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
    public partial class Frm_Rep_Registros : Form
    {
        public Frm_Rep_Registros()
        {
            InitializeComponent();
        }
        Cls_T_Oficinas oOficinas = new Cls_T_Oficinas();
        Cls_Rep_Reportes oReportes = new Cls_Rep_Reportes();
        BL_Sis_Sistema BL_Sis_Sistema = new BL_Sis_Sistema();
        Cls_T_TipoOperacion oTiptran = new Cls_T_TipoOperacion();
        int nOpc = 0;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Rep_Registros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }

        private void Frm_Rep_Registros_Load(object sender, EventArgs e)
        {
            Helper.LLenar_Años(cboAño);
            cboMeses.SelectedIndex = DateTime.Now.Month - 1;
            cboRec.SelectedIndex = 0;
            Leer_Proceso();
        }

        private void txtOfi_TextChanged(object sender, EventArgs e)
        {
            lblOfi.Text = oOficinas.Get_Descripcion(txtOfi.Text);
        }

        private void txtAyudaF1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F1) return;
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                //case "txtOfi": Helper.eTablaBus = Helper.eTablas.Oficinas; break;
                //case "txtIdtiptran": Helper.sParamBus1 = ""; Helper.eTablaBus = Helper.eTablas.Tipo_Transac; break;
            }
            //Helper.Buscar(txt);
        }

        private void opcFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) SendKeys.Send("{Tab}");
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void opcFile_Click(object sender, EventArgs e)
        {
            panProces.Visible = false;
            txtIdtiptran.Visible = false;
            lblIdtiptran.Visible = false;
            if (opcFile.Checked) nOpc = 0;
            if (opcIndex.Checked) nOpc = 4;
            if (opcCont.Checked)
            {
                nOpc = 1;
                txtIdtiptran.Visible = true;
                lblIdtiptran.Visible = true;
                txtIdtiptran.Focus();
            }
            if (opcDoc.Checked) nOpc = 2;
            if (opcDato.Checked) nOpc = 3;
            if
                (opcConsol.Checked)
            {
                nOpc = 5; //panProces.Visible = true; 
            }
            if (opcResumenOpe.Checked) nOpc = 6;
        }

        private void Listar()
        {
            DataTable Dt = new DataTable();
            try
            {
                //if (lblOfi.Text == "")
                //{
                //    MessageBox.Show("La Oficina es Obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtOfi.Focus(); return;
                //}
                this.Cursor = Cursors.WaitCursor;
                string sFiltro = "";
                if (opcFechas.Checked) sFiltro = "F";
                if (opcPeriodos.Checked) sFiltro = "P";
                if (opcCaja.Checked) sFiltro = "C";

                string sMes = Helper.Right("0" + Convert.ToString(cboMeses.SelectedIndex + 1), 2);
                string sTiprec = cboRec.SelectedIndex == 2 ? "" : Helper.Left(cboRec.Text, 1);
                Dt = oReportes.Rep_Registro(nOpc, sFiltro, dtpIni.Value, dtpFin.Value, sMes, cboAño.Text, txtOfi.Text, sTiprec, txtCodbar.Text, txtIdtiptran.Text, "");
                if (Dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay Registro que mostrar. Realice otro filtro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Helper.Exportar(Dt);

                Dt.Dispose();
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, " Error : " + Er.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (Dt != null) Dt = null; this.Cursor = Cursors.Default; }
        }

        private void opcFechas_CheckedChanged(object sender, EventArgs e)
        {
            cboMeses.Enabled = false;
            cboAño.Enabled = false;
            dtpIni.Enabled = false;
            dtpFin.Enabled = false;
            txtCodbar.Enabled = false;

            if (opcFechas.Checked == true)
            {
                dtpIni.Enabled = true;
                dtpFin.Enabled = true;
            }
            if (opcPeriodos.Checked == true)
            {
                cboMeses.Enabled = true;
                cboAño.Enabled = true;
            }
            if (opcCaja.Enabled == true)
            {
                txtCodbar.Enabled = true;
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea procesar los Datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                this.Cursor = Cursors.WaitCursor;
                oReportes.Gen_Datos();
                Leer_Proceso();
                MessageBox.Show("Se ha procesado en forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, " Error : " + Er.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { this.Cursor = Cursors.Default; }
        }
        private void Leer_Proceso()
        {
            lblProc.Text = " Último Proceso : " + BL_Sis_Sistema.Get_Parametro("fecdatos",Helper.oBE_Sis_Cliente.IdCliente);
        }

        private void txtIdtiptran_TextChanged(object sender, EventArgs e)
        {
            lblIdtiptran.Text = oTiptran.Get_Descrip(txtIdtiptran.Text);
        }
    }
}