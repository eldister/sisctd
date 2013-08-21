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
        public Frm_Sis_Busquedas()
        {
            InitializeComponent();
            Helper.FormatoGrilla(Dg1);
        }
        public string sValor = "";
        private string sFiltro = "D";
        public DataGridView bDg;
        public string sDefault = "";

        Cls_T_Datos oDatos = new Cls_T_Datos();
        Cls_T_Areas oAreas = new Cls_T_Areas();
        Cls_T_TipoDocumentos oTiposDoc = new Cls_T_TipoDocumentos();
        Cls_T_Oficinas oOficinas = new Cls_T_Oficinas();
        Cls_T_Productos oProductos = new Cls_T_Productos();
        Cls_T_SubProductos oSubproductos = new Cls_T_SubProductos();
        Cls_T_TipoOperacion oTransac = new Cls_T_TipoOperacion();
        Cls_T_Estados oEstados = new Cls_T_Estados();
        Cls_Sis_Sistema oSistema = new Cls_Sis_Sistema();
        Cls_T_Ejecutivos oEjecutivos = new Cls_T_Ejecutivos();
        Cls_T_Separadoras oSeparadores = new Cls_T_Separadoras();

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
                switch (Helper.eTablaBus)
                {
                    case Helper.eTablas.Clientes:
                        this.Text = "Buscar Cliente"; Dg1.DataSource = oSistema.BuscarCliente(sFiltro, txtBus.Text); break;
                    //case Helper.eTablas.Usuarios:
                    //    this.Text = "Buscar Usuarios"; Dg1.DataSource = oSistema.BuscarUsuarioIron(sFiltro, txtBus.Text); break;
                    case Helper.eTablas.Ubigeo:
                        this.Text = "Buscar Ubicación Geográfica"; Dg1.DataSource = oSistema.Listar_Ubigeo(sFiltro, txtBus.Text); break;
                    case Helper.eTablas.Datos:
                        this.Text = "Buscar Dato"; Dg1.DataSource = oDatos.Listar(sFiltro, txtBus.Text, 0); break;
                    case Helper.eTablas.Estados:
                        this.Text = "Buscar Estados"; Dg1.DataSource = oEstados.Listar(sFiltro, txtBus.Text, 0); break;
                    case Helper.eTablas.Areas:
                        this.Text = "Buscar Area"; Dg1.DataSource = oAreas.Listar(sFiltro, txtBus.Text, 0); break;
                    case Helper.eTablas.TiposDoc:
                        this.Text = "Buscar Tipo de Documento"; Dg1.DataSource = oTiposDoc.Listar(sFiltro, txtBus.Text, 0, 2); break;
                    case Helper.eTablas.TiposDoc_Escaneo:
                        this.Text = "Buscar Tipo de Documento"; Dg1.DataSource = oTiposDoc.Listar(sFiltro, txtBus.Text, 0, 2);
                        Dg1.MultiSelect = true; break;
                    case Helper.eTablas.TiposDoc_Datos:
                        this.Text = "Buscar Datos del Tipo de Documento " + Helper.sParamBus1; 
                        Dg1.DataSource = oTiposDoc.Listar_Datos(sFiltro, Helper.sParamBus1, txtBus.Text); break;
                    case Helper.eTablas.Oficinas:
                        this.Text = "Buscar Oficina"; Dg1.DataSource = oOficinas.Listar(sFiltro, txtBus.Text); break;
                    case Helper.eTablas.Productos:
                        this.Text = "Buscar Producto"; Dg1.DataSource = oProductos.Listar(sFiltro, txtBus.Text, 0); break;
                    case Helper.eTablas.SubProductos:
                        this.Text = "Buscar Sub-Producto del Producto : " + Helper.sParamBus1;
                        Dg1.DataSource = oSubproductos.Listar_Por_Producto(sFiltro, Helper.sParamBus1, txtBus.Text); break;
                    case Helper.eTablas.Tipo_Transac:
                        this.Text = "Buscar Tipos de Operación del Producto : " + Helper.sParamBus1;
                        Dg1.DataSource = oTransac.Listar_Por_Producto(sFiltro, Helper.sParamBus1, txtBus.Text); break;
                    case Helper.eTablas.Ejecutivos:
                        this.Text = "Buscar Ejecutivo"; Dg1.DataSource = oEjecutivos.Listar(sFiltro, txtBus.Text, 0);
                        this.Width = 520; break;
                    case Helper.eTablas.TiposDoc_RRHH:
                        this.Text = "Buscar Tipos de Documentos por Separadora ";
                        Dg1.DataSource = oSeparadores.Listar_TiposDocumento_NoAgregados(); break;
                }
                switch (Helper.eTablaBus)
                {
                    case Helper.eTablas.DataNextelOrden: break;
                    case Helper.eTablas.DataNextelSolicitud: break;
                    case Helper.eTablas.Recojos: break;
                    default:
                        foreach (DataGridViewColumn Col in Dg1.Columns) { Col.Visible = false; }
                        Dg1.Columns[0].Visible = true; Dg1.Columns[1].Visible = true;
                        break;
                }
                Helper.FormatoGrilla(Dg1, true);
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