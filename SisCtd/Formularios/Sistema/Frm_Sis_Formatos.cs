using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace BESisCtd
{
    public partial class Frm_Sis_Formatos : Form
    {
        public Frm_Sis_Formatos()
        {
            InitializeComponent();
        }
        public Boolean Grabo=false;
        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFormatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) { this.Close();}
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea imprimir el Formato?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Grabo = true;
                Report.PrintReport();
                this.Close();
            }
        }

    }
} 