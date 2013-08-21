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
    public partial class Frm_Sis_Busquedas : Form
    {
        DataTable Dt = new DataTable();
        public Frm_Sis_Busquedas(DataTable _Dt)
        {
            InitializeComponent();
            Helper.FormatoGrilla(Dg1);
            Dt = _Dt;
        }
        public string sValor = "";
        private string sFiltro = "D";
        public DataGridView bDg;
        public string sDefault = "";

        private void Frm_Sis_Busquedas_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Frm_Sis_Busquedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) { this.Close(); }
        }

        private void Frm_Sis_Busquedas_Activated(object sender, EventArgs e)
        {
            if (sDefault == "") return;
            else
            {
                Dg1.Focus();
                Helper.Buscar_Grilla(Dg1, sDefault, 0);
            }
        }

        private void Frm_Sis_Busquedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            if (e.KeyCode==Keys.F7)
            {
                if (sFiltro == "C")
                {
                    lblFil.Text = "F7 = Filtrar por Código"; sFiltro = "D"; lblBus.Text = "Descripción";
                }
                else
                {
                    lblFil.Text = "F7 = Filtrar por Descripción"; sFiltro = "C"; lblBus.Text = "Código";
                }
                Listar(); txtBus.Focus();
            }
        }

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
        private void txtBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) Dg1.Focus();
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

        private void Listar()
        {
            try
            {
                Dg1.DataSource = Dt;
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Aceptar()
        {
            if (Dg1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione un Registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                sValor = Dg1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                bDg = Dg1;
                //SendKeys.Send("{Home}+{End}");
            
                this.Close();
        }


    }
}