using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.IO;
using System.Diagnostics;
namespace SisCtd
{
    public partial class Frm_Reg_Seguimiento_Envio : Form
    {
        #region Declaración Variables

        public string sIdControl;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();
        BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
        //BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Area oBL_T_Area = new BL_T_Area();
        BL_T_Empleado oBL_T_Empleado = new BL_T_Empleado();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Seguimiento_Envio()
        {
            InitializeComponent();

        }
        private void Frm_Reg_Seguimiento_Envio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                if (lblIdTipoDocumento.Text != "")
                {
                    txtIdControl.Text = "";
                    txtIdControl.Focus();
                }
                else
                    this.Close();
            }
        }


        #endregion



        #region Metodos

        #endregion

        #region Eventos Objetos
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtIdOficinaDestinatario": txtIdOficinaDestinatario.Text = Helper.Buscar(oBL_T_Oficina.Buscar()); break;
                    case "txtIdArea": txtIdArea.Text = Helper.Buscar(oBL_T_Area.Buscar()); break;
                }
            }
        }
        private void PonerDescrip_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (MigControls.MigTextbox)sender;
            switch (txt.Name)
            {
                case "txtIdOficinaDestinatario": 
                    lblDesOficinaDestinatario.Text = oBL_T_Oficina.Get_Descripcion(txtIdOficinaDestinatario.Text);
                    txtIdArea.Text = "";

                    break;
                case "txtIdArea":
                    lblDesArea.Text = oBL_T_Area.Get_Descripcion(txtIdArea.Text);
                    lblIdEmpleado.Text = oBL_T_Area.Get_IdEmpleadoResponsable(txtIdArea.Text);
                    lblDesEmpleado.Text = oBL_T_Empleado.Get_Nombre(lblIdEmpleado.Text);
                    break;

            }
        }
        private void txtIdControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    oBE_Reg_Control = oBL_Reg_Control.Get_Control(txtIdControl.Text);
                    if (oBE_Reg_Control != null)
                    {
                        lblIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                        lblDesTipoDocumento.Text = oBL_T_TipoDocumento.Get_Descripcion(lblIdTipoDocumento.Text);

                        lblIdMaestroCliente.Text = oBE_Reg_Control.IdMaestroCliente;
                        lblDesMaestroCliente.Text = oBL_T_MaestroCliente.Get_RazonSocial(lblIdMaestroCliente.Text);

                        lblNroDocumento.Text = oBE_Reg_Control.NroDocumento;
                        lblFechaDocumento.Text = oBE_Reg_Control.FechaDocumento.ToString("dd/MM/yyyy");
                        txtObservacionGeneral.Text = oBE_Reg_Control.Observacion;

                        string sActividadPendiente = oBL_Reg_Control.ActividadPendiente(txtIdControl.Text);
                        if (sActividadPendiente == "")
                        {
                            MessageBox.Show("No hay Actividades Pendientes de Envío. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BtnGrabar.Visible = false; txtIdControl.Focus(); return;
                        }

                        oBE_Reg_ControlDetalle = oBL_Reg_Control.Get_ControlDetalleRecepcion(txtIdControl.Text);

                        if (oBE_Reg_ControlDetalle != null)
                        {
                            lblIdActividad.Text = oBE_Reg_ControlDetalle.IdActividad;
                            lblDesActividad.Text = oBL_T_Actividad.Get_Descripcion(lblIdActividad.Text);
                            lblIdOficinaRecepcion.Text = oBE_Reg_ControlDetalle.IdOficinaRecepcion;
                            lblDesOficinaRecepcion.Text = oBL_T_Oficina.Get_Descripcion(lblIdOficinaRecepcion.Text);
                            lblFechaRecepcion.Text = oBE_Reg_ControlDetalle.FechaRecepcion.ToString("dd/MM/yyyy");
                            txtObservacion.Text = oBE_Reg_ControlDetalle.Observacion;
                            txtIdOficinaDestinatario.Text = oBE_Reg_ControlDetalle.IdOficinaDestinatario ;
                            txtIdArea.Text = oBE_Reg_ControlDetalle.IdAreaDestinatario ;
                            lblIdEmpleado.Text = oBE_Reg_ControlDetalle.IdEmpleadoDestinatario ;
                        }
                        else
                        {
                            MessageBox.Show("Ya no hay mas actividades para este control. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BtnGrabar.Visible = false; txtIdControl.Focus(); return;
                        }

                        lblFechaEnvio.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        txtIdOficinaDestinatario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Control No Existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdControl.Focus(); return;
                    }
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void txtIdControl_TextChanged(object sender, EventArgs e)
        {
            lblIdTipoDocumento.Text = "";
            lblDesTipoDocumento.Text = "";
            lblIdMaestroCliente.Text = "";
            lblDesMaestroCliente.Text = "";
            lblNroDocumento.Text = "";
            lblFechaDocumento.Text = "";
            txtObservacionGeneral.Text = "";

            lblIdActividad.Text = "";
            lblDesActividad.Text = "";
            lblIdEmpleado.Text = "";
            lblDesEmpleado.Text = "";
            lblFechaRecepcion.Text = "";
            lblIdOficinaRecepcion.Text = "";
            lblDesOficinaRecepcion.Text = "";
            txtObservacion.Text = "";
            lblFechaEnvio.Text = "";
            txtIdOficinaDestinatario.Text = "";
            txtIdArea.Text = "";
            BtnGrabar.Visible = true;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Selecccionar Archivo";
                dlg.Filter = "Archivo JPG,GIF;DOC,DOCX;PDF|*.jpg;*.gif;*.doc;*.docx;*.pdf";
                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    string sExtension = System.IO.Path.GetExtension(dlg.FileName);
                    string sNombre = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);
                    string sNombreRuta = dlg.FileName;

                    // Declaramos fs para tener acceso al archivo residente en la maquina cliente.

                    foreach (DataGridViewRow Fila in dgDetalle.Rows)
                    {
                        string sNombreRutaExistente = Fila.Cells["Archivo"].Value.ToString();
                        if (sNombreRutaExistente == sNombreRuta)
                        {
                            MessageBox.Show("Documento ya ha sido Agregado. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgDetalle.Focus(); return;
                        }
                    }

                    dgDetalle.Rows.Add(sNombreRuta, sExtension, sNombre);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgDetalle.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un Archivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgDetalle.Focus(); return;
                }

                string sNombre = dgDetalle.Rows[dgDetalle.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();

                if (MessageBox.Show("¿Está seguro que desea de Quitar el Archvio : " + sNombre + " del envío ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

                dgDetalle.Rows.RemoveAt(dgDetalle.CurrentCell.RowIndex);
                dgDetalle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bVerImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgDetalle.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un Archivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgDetalle.Focus(); return;
                }

                string sNombre = dgDetalle.Rows[dgDetalle.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();

                Process.Start(sNombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDesTipoDocumento.Text == "")
                {
                    MessageBox.Show("El registro de control no existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdControl.Focus(); return;
                }
                if (lblDesActividad.Text == "")
                {
                    MessageBox.Show("El registro de control no tiene actividades pendientes de Envío. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdControl.Focus(); return;
                }
                if (lblDesOficinaDestinatario.Text == "")
                {
                    MessageBox.Show("Ingrese una Oficina Correcta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdOficinaDestinatario.Focus(); return;
                }
                if (lblDesArea.Text == "")
                {
                    MessageBox.Show("Ingrese un Area Correcta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdArea.Focus(); return;
                }

                if (lblDesEmpleado.Text == "")
                {
                    MessageBox.Show("El Area ingresado no tiene un Empleado Responsable asignado. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdArea.Focus(); return;
                }

                //Archivos
                List<BE_Reg_ControlImagenes> ListaImagenes = new List<BE_Reg_ControlImagenes>();

                BinaryReader br;
                
                byte[] bytes;

                foreach (DataGridViewRow Fila in dgDetalle.Rows)
                {
                    string sNombreRuta = Fila.Cells["Archivo"].Value.ToString();
                    string sExtension = Fila.Cells["formato"].Value.ToString();
                    string sNombre = Fila.Cells["nombre"].Value.ToString();

                    FileInfo File = new System.IO.FileInfo(sNombreRuta);
                    int nKb = Convert.ToInt32(File.Length / 1024);
                    
                    // Declaramos fs para tener acceso al archivo residente en la maquina cliente.
                    FileStream fs = new FileStream(sNombreRuta, FileMode.Open);
                    // Declaramos un Leector Binario para accesar a los datos del archivo pasarlos a un arreglo de bytes
                    br = new BinaryReader(fs);
                    bytes = new byte[(int)fs.Length];
                    br.Read(bytes, 0, bytes.Length);
                    BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();

                    oBE_Reg_ControlImagenes.Nombre = sNombre;
                    oBE_Reg_ControlImagenes.Archivo = bytes;
                    oBE_Reg_ControlImagenes.PesoArchivo = nKb;
                    oBE_Reg_ControlImagenes.ExtensionImagen = sExtension;

                    ListaImagenes.Add(oBE_Reg_ControlImagenes);
                    fs.Close();
                    fs = null;
                }

                oBE_Reg_ControlDetalle.IdControl = txtIdControl.Text;
                oBE_Reg_ControlDetalle.IdOficinaDestinatario = txtIdOficinaDestinatario.Text;
                oBE_Reg_ControlDetalle.IdAreaDestinatario = txtIdArea.Text;
                oBE_Reg_ControlDetalle.IdEmpleadoDestinatario = lblIdEmpleado.Text;
                
                oBE_Reg_ControlDetalle.Observacion = txtObservacion.Text;
                oBL_Reg_Control.Enviar(oBE_Reg_ControlDetalle, ListaImagenes);

                MessageBox.Show("Se ha Enviado el Control " + txtIdControl.Text + " en la actividad " + lblDesActividad.Text + " en forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdControl.Text = "";
                dgDetalle.Rows.Clear();
                txtIdControl.Focus();

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        















    }
}