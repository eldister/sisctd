using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;
namespace BESisCtd
{
    public partial class Frm_Sis_Principal : Form
    {
        #region Declaración Variables
        BL_Sis_Sistema oBL_Sis_Sistema = new BL_Sis_Sistema();
        BL_Sis_Cliente oBL_Sis_Cliente = new BL_Sis_Cliente();
        BL_Sis_Perfil oBL_Sis_Perfil = new BL_Sis_Perfil();

        public string FormActivo;
        string vNode;
        MdiClient CtlMDI;
        Form mFormHijo;

        #endregion

        #region Iniciar Formulario
        public Frm_Sis_Principal()
        {
            InitializeComponent();
        }
        private void Frm_Sis_Principal_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            tabPrincipal.Dock = DockStyle.Fill;
            lblVersion.Text = " Versión : 1.0" ;
            lblUsuario.Text = " Usuario : " + BE_Helper.oBE_Sis_Usuario.IdUsuario + " - " + BE_Helper.oBE_Sis_Usuario.Nombre;

            DataTable Dt = new DataTable();
            Dt = oBL_Sis_Cliente.Listar("A");

            System.Object[] ItemObject = new System.Object[Dt.Rows.Count];
            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                ItemObject[i] = Dt.Rows[i][0].ToString();
            }
            cboCliente.Items.AddRange(ItemObject);
            
            cboCliente.Text = BE_Helper.oBE_Sis_Cliente.IdCliente;
            Dt.Dispose();

            CambiarLogo();

            
            foreach (Control Ctl in this.Controls)
            {
                try
                {
                    CtlMDI = (MdiClient)Ctl;
                    //CtlMDI.BackgroundImage = global::SisCtd.Properties.Resources.;
                }
                catch (InvalidCastException)
                {
                }
            }
            try
            {
                TreOpc.Nodes.Clear();
                Helper.Cargar_menu(oBL_Sis_Sistema.Listar_Menu(BE_Helper.oBE_Sis_Usuario.IdPerfil, ""), "", null, TreOpc, true);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos

        private void CambiarLogo()
        {
            switch (BE_Helper.oBE_Sis_Cliente.IdCliente)
            {
                case "DEMO": picLogo.Image = BESisCtd.Properties.Resources.logo_vsistems; break;
            }
        }

        private void Abrir()
        {
            cboCliente.Enabled = false;
            switch (vNode)
            {
                case "0101": mFormHijo.Text = " Registro de Posiciones"; break;
                case "0102": mFormHijo.Text = " Registro de Gerencias"; break;
                case "0103": mFormHijo.Text = " Registro de Areas"; break;
                case "0104": mFormHijo.Text = " Registro de Empleados"; break;
                case "0105": mFormHijo.Text = " Registro de Oficinas"; break;

                case "0108": mFormHijo.Text = " Registro de Rutas"; break;


            }
            foreach (TabPage TB in tabPrincipal.TabPages)
            {
                if (TB.Text == mFormHijo.Text)
                {
                    tabPrincipal.Focus();
                    tabPrincipal.SelectedTab = TB;
                    return;
                }
            }

            tabPrincipal.Visible = true;
            Helper.nForm += 1;
            string sKey = "f" + Helper.nForm.ToString();

            tabPrincipal.TabPages.Add(sKey, mFormHijo.Text);
            mFormHijo.TopLevel = false;
            mFormHijo.FormBorderStyle = FormBorderStyle.None;
            mFormHijo.Dock = DockStyle.Fill;

            tabPrincipal.TabPages[sKey].Controls.Add(mFormHijo);
            tabPrincipal.SelectedTab = tabPrincipal.TabPages[sKey];

            tabPrincipal.TabPages[sKey].Tag = mFormHijo;
            mFormHijo.Tag = tabPrincipal.TabPages[sKey];
            mFormHijo.KeyPreview = true;
            mFormHijo.Show();
            mFormHijo.Focus();
        }
        private void Abrir_Normal()
        {
            mFormHijo.Text = vNode + " - " + mFormHijo.Text;            
            mFormHijo.ShowDialog();
        }
        private void Ingresa_Opcion()
        {
            Helper.ComboCliente = cboCliente;
            switch (vNode)
            {
                case "0101": mFormHijo = new Frm_T_Listados(Helper.eTablas.Posiciones); Abrir(); break;
                case "0102": mFormHijo = new Frm_T_Listados(Helper.eTablas.Gerencias); Abrir(); break;

                case "0103": mFormHijo = new Frm_T_Listados(Helper.eTablas.Areas); Abrir(); break;
                case "0104": mFormHijo = new Frm_T_Listados(Helper.eTablas.Empleados); Abrir(); break;
                case "0105": mFormHijo = new Frm_T_Listados(Helper.eTablas.Oficinas); Abrir(); break;
                

                case "0108": mFormHijo = new Frm_T_Rutas_List(); Abrir(); break;

                case "0110": mFormHijo = new Frm_T_TiposDocumento_List(); Abrir(); break;
    
                //Registro
                case "0201": mFormHijo = new Frm_Reg_Control_List(); Abrir(); break;

                //Sistema
                case "0901": mFormHijo = new Frm_Sis_Usuarios(); Abrir(); break;
                case "0902": mFormHijo = new Frm_Sis_Acceso(); Abrir_Normal(); break;
                
             
            }
        }
        private void Ver_Menu()
        {
            if (bMenu.Text == "&Ver Menú")
            {
                bMenu.Text = "&Ocultar Menú";
                panMenu.Visible = true;
                //TreOpc.Focus();
            }
            else
            {
                bMenu.Text = "&Ver Menú";
                panMenu.Visible = false;
            }
        }        

        #endregion

        #region Eventos Menu
        private void bCambiarContraseña_Click(object sender, EventArgs e)
        {
            Frm_Sis_Contraseña fDet = new Frm_Sis_Contraseña(false);
            fDet.ShowDialog();
        }
        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea Salir del Sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No) return;
            Application.ExitThread(); 
        }
        private void bMenu_Click(object sender, EventArgs e)
        {
            Ver_Menu();
        }
        private void bAcercade_Click(object sender, EventArgs e)
        {
            Frm_About FormAbout = new Frm_About();
            FormAbout.ShowDialog();
        }
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_Helper.oBE_Sis_Cliente = oBL_Sis_Cliente.Get_Cliente(cboCliente.Text);
            TreOpc.Nodes.Clear();
            Helper.Cargar_menu(oBL_Sis_Sistema.Listar_Menu(BE_Helper.oBE_Sis_Usuario.IdPerfil, ""), "", null, TreOpc, true);
            CambiarLogo();
            SendKeys.Send("{F5}");
        }
        #endregion

        #region Eventos Objetos
        private void TreOpc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            vNode = e.Node.Name.Trim();
            Helper.sAcceso = oBL_Sis_Sistema.Get_Acceso(BE_Helper.oBE_Sis_Usuario.IdPerfil, vNode);
        }
        private void TreOpc_DoubleClick(object sender, EventArgs e)
        {
            Ingresa_Opcion();
        }
        private void TreOpc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ingresa_Opcion();
            }
        }

        #endregion

    }
}