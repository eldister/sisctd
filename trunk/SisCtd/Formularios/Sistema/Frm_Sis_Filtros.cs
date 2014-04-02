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
    public partial class Frm_Sis_Filtros : Form
    {
        #region Declaración Variables
        DataTable Dt = new DataTable();
        public string sValor = "";
        public DataGridView bDg;
        public string sDefault = "";
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BL_T_Area oBL_T_Area = new BL_T_Area();

        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Filtros()
        {
            InitializeComponent();
            dtpDesdeD.Checked = false;
            dtpHastaD.Checked = false;
            dtpDesdeR.Checked = false;
            dtpHastaR.Checked = false;
            //Helper.FormatoGrilla(Dg1);
            //Dt = _Dt;
        }
        private void Frm_Sis_Filtros_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Frm_Sis_Filtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) { Dt.Dispose(); Dt = null; this.Close(); }
        }
        private void Frm_Sis_Filtros_Activated(object sender, EventArgs e)
        {
            if (sDefault == "") return;
            else
            {
            }
        }
        private void Frm_Sis_Filtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            if (e.KeyCode == Keys.F7)
            {
            }
        }
        #endregion

        #region Metodos
        private void Listar()
        {
            DataRow[] rows;
            DataTable dtNew;
            try
            {

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Aceptar()
        {
            Helper.sOficinaFil = txtOficina.Text ;
            Helper.sAreaFil = txtArea.Text ;
            Helper.sRutaFil = txtRuta.Text ;
            Helper.sDFecRec = dtpDesdeR.Value;
            Helper.sHFecRec = dtpHastaR.Value;
            Helper.sDFecDoc = dtpDesdeD.Value;
            Helper.sHFecDoc = dtpHastaD.Value;
            if (dtpDesdeD.Checked == false)
            {
                Helper.sDFecDoc = Convert.ToDateTime("01/01/1973");
                Helper.sHFecDoc = Convert.ToDateTime("01/01/2999");
            }

            if (dtpDesdeR.Checked == false)
            {
                Helper.sDFecRec = Convert.ToDateTime("01/01/1973");
                Helper.sHFecRec = Convert.ToDateTime("01/01/2999");
            }

            this.Close();
        }

        #endregion

        #region Eventos de Objetos
        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
        private void txtBus_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down) Dg1.Focus();
        }

        private void Dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Aceptar();
        }
        private void Dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Aceptar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            sValor = ""; this.Close();
        }
        private void PonerDescrip_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (MigControls.MigTextbox)sender;
            switch (txt.Name)
            {
                case "txtRuta": lblRuta.Text = oBL_T_Ruta.Get_Descripcion(txtRuta.Text); break;
                case "txtOficina": lblOficina.Text = oBL_T_Oficina.Get_Descripcion(txtOficina.Text); break;
                case "txtArea": lblArea.Text = oBL_T_Area.Get_Descripcion(txtArea.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtRuta": txtRuta.Text = Helper.Buscar(oBL_T_Ruta.Buscar()); break;
                    case "txtOficina": txtOficina.Text = Helper.Buscar(oBL_T_Oficina.Buscar()); break;
                    case "txtArea": txtArea.Text = Helper.Buscar(oBL_T_Area.Buscar()); break;
                }
            }
        }


        #endregion

    }
}