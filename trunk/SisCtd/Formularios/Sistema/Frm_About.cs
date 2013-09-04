using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BESisCtd
{
    public partial class Frm_About : Form
    {        
        public Frm_About()
        {
            InitializeComponent();
        }
        
        
        private void Frm_About_Load(object sender, EventArgs e)
        {
            Lblversion.Text += "    " + Application.ProductVersion;
            LblDescrip.Text = Application.ProductName;
        }       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
        }

        private void Frm_About_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
       
    }
}