using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;
using System.IO;
using System.Diagnostics;
namespace SisCtd
{
    public partial class Frm_Con_Control_List : Form
    {
        #region Declaraci�n Variables
        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BL_T_Area oBL_T_Area = new BL_T_Area();
        string sIdControl, sNroSecuencia;
 
        #endregion

        #region Iniciar Formulario
        public Frm_Con_Control_List()
        {
            InitializeComponent();
            bExportar.Enabled = Helper.sAcceso.Substring(4, 1) == "1" ? true : false;
            Helper.sOficinaFil = "";
            Helper.sAreaFil = "";
            Helper.sRutaFil = "";
            Helper.sDFecDoc = Convert.ToDateTime("01/01/1973");
            Helper.sHFecDoc = Convert.ToDateTime("01/01/2999");
            Helper.sDFecRec = Convert.ToDateTime("01/01/1973");
            Helper.sHFecRec = Convert.ToDateTime("01/01/2999");
            Helper.FormatoGrilla(dgControl);
            Helper.LLenar_Combobox(oBL_T_Area.Listar("",""), cboArea, "Descripcion", "IdArea");

        }
        private void Frm_Con_Control_List_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            chkTodo.Checked = true;
            cboEstadoDet.SelectedIndex = 0;
            Listar(Helper.eListar.Grilla); Listar_Detalle();
        }
        private void Frm_Con_Control_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) return;
            switch (e.KeyCode)
            {
                case Keys.F5: Listar(Helper.eListar.Grilla); Listar_Detalle(); break;
                case Keys.F7: bExportar.PerformClick(); break;
            }
        }
        private void Frm_Con_Control_List_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) oCancelar();
        }

        #endregion

        #region Metodos
        private void Listar(Helper.eListar eListar)
        {
            DataTable Dt = new DataTable();
            DataTable Dt1 = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (chkTodo.Checked == true)
                {
                    Dt = oBL_Reg_Control.Listar(txtIdControl.Text, txtNroDocumento.Text.Trim(), txtRazonSocial.Text.Trim(), cboEstado.Text,Helper.sOficinaFil,Helper.sAreaFil,Helper.sRutaFil,Helper.sDFecRec,Helper.sHFecRec,Helper.sDFecDoc,Helper.sHFecDoc);
                }
                else
                {
                    Dt = oBL_Reg_Control.Listar_Doc(txtIdControl.Text, txtNroDocumento.Text.Trim(), txtRazonSocial.Text.Trim(), Convert.ToString( cboArea.SelectedValue)    , cboEstado.Text);
                }
                
                if (eListar == Helper.eListar.Grilla)
                {
                    dgControl.DataSource = Dt; Helper.FormatoGrilla(dgControl, false);
                    LblMensaje.Text = " Registros Encontrados : " + dgControl.Rows.Count.ToString();
                    dgControl.Columns["IdControl"].Width = 130;
                    dgControl.Columns["Fecha Recepci�n"].Width = 160;
                    dgControl.Columns["IdOficinaRecepcion"].Visible = false;
                    dgControl.Columns["Oficina Recepci�n"].Width = 150;
                    dgControl.Columns["IdTipoDocumento"].Width = 100;
                    dgControl.Columns["IdMaestroCliente"].Visible = false;
                    dgControl.Columns["RazonSocial"].Width = 200;
                    dgControl.Columns["NroDocumento"].Width = 100;
                    dgControl.Columns["FechaDocumento"].Width = 100;
                    dgControl.Columns["IdRuta"].Visible = false;
                    dgControl.Columns["Descripci�n Ruta"].Width = 180;
                    dgControl.Columns["Observacion"].Width = 150;
                    dgControl.Columns["FechaInicio"].Width = 80;
                    dgControl.Columns["FechaTermino"].Width = 80;
                    dgControl.Columns["Estado"].Width = 80;
                    dgControl.Columns["Img"].Width = 30;
                    dgControl.Columns["IdImagen"].Visible = false;
                }
                else
                    if (eListar == Helper.eListar.Excel)
                    {
                        Helper.Exportar(Dt, "TiposDocumento");
                    }
                    else
                    {
                        Get_IdControl(true);
                        Dt1 = oBL_Reg_Control.Get_ControlImp(sIdControl);
                        Helper.MostrarReporte("Sello", "Sello", Dt1 );
                        Dt1.Dispose();
                    }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
        private void Listar_Detalle()
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Get_IdControl(false);
                Dt = oBL_Reg_Control.Listar_Detalle(sIdControl, cboEstadoDet.Text);

                dgDetalle.DataSource = Dt; Helper.FormatoGrilla(dgDetalle, false);
                dgDetalle.Columns["NroSecuencia"].Visible = false;
                dgDetalle.Columns["Orden"].Width = 40;
                dgDetalle.Columns["IdActividad"].Visible = false;
                dgDetalle.Columns["Actividad"].Width = 180;
                
                dgDetalle.Columns["IdOficinaRecepcion"].Visible = false;
                dgDetalle.Columns["Oficina Recepci�n"].Width = 120;
                dgDetalle.Columns["IdEmpleadoRecepcion"].Visible = false;
                dgDetalle.Columns["Empleado Recepci�n"].Width = 120;
                dgDetalle.Columns["IdAreaRecepcion"].Visible = false;
                dgDetalle.Columns["Area Recepci�n"].Width = 120;
                dgDetalle.Columns["Fecha Recepci�n"].Width = 120;
                dgDetalle.Columns["IdOficinaDestinatario"].Visible = false;
                dgDetalle.Columns["Oficina Destinatario"].Width = 120;
                dgDetalle.Columns["IdEmpleadoDestinatario"].Visible = false;
                dgDetalle.Columns["Empleado Destinatario"].Width = 120;
                dgDetalle.Columns["IdAreaDestinatario"].Visible = false;
                dgDetalle.Columns["Fecha Destinatario"].Width = 120;

                dgDetalle.Columns["Estado"].Width = 80;

                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }
  
        private bool Get_IdControl(bool bMsg)
        {
            if (dgControl.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione un Control", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdControl = "";
                return false;
            }
            else 
            {
                sIdControl = dgControl.Rows[dgControl.CurrentCellAddress.Y].Cells[0].Value.ToString();
                return true; 
            }
        }
        private bool Get_NroSecuencia(bool bMsg)
        {
            if (dgDetalle.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Secuencia", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sNroSecuencia = "";
                return false;
            }
            else
            {
                sNroSecuencia = dgDetalle.Rows[dgDetalle.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();
                return true;
            }
        }
        private void Abrir_Detalle(Helper.eOpcion qOpcion)
        {
            Frm_Reg_Control_Det fDet = new Frm_Reg_Control_Det(qOpcion, sIdControl);
             fDet.ShowDialog();
            if (fDet.bGrabo == true)
            {
                Listar(Helper.eListar.Grilla);
                Helper.Buscar_Grilla(dgControl, fDet.sIdControl, 0);
                Listar_Detalle();
            }
            fDet.Dispose();

        }
        private void oCancelar()
        {
            Helper.Cerrar_Ventana(this, (TabControl)this.Parent.Parent);
        }

        private void chkTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodo.Checked == true)
            {
                cboArea.Enabled = false;
            }
            else
            {
                cboArea.Enabled = true; 
            }
            Listar(Helper.eListar.Grilla);
            Listar_Detalle();
        }

        #endregion

        #region Eventos Menu
        private void bNuevo_Click(object sender, EventArgs e)
        {
            Abrir_Detalle(Helper.eOpcion.Nuevo);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return; Abrir_Detalle(Helper.eOpcion.Modificar);
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return;
            try
            {
                if (MessageBox.Show("�Est� seguro que desea de Eliminar el Control : " + sIdControl + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                oBL_Reg_Control.Eliminar(sIdControl);

                MessageBox.Show("Se ha Eliminado el Control " + sIdControl + " en forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listar(Helper.eListar.Grilla);
                Listar_Detalle();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bExportar_Click(object sender, EventArgs e)
        {
            Listar(Helper.eListar.Excel);
        }
        private void bSello_Click(object sender, EventArgs e)
        {
            Listar(Helper.eListar.Reporte);
            //using (Engine btengine = new Engine(true)) ;

        }


        private void bAsignarImagen_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return; 
            BinaryReader br;
            BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
            BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();
            byte[] bytes;
            try
            {

                if (oBL_Reg_Control.Get_Imagen(sIdControl) != "")
                {
                    MessageBox.Show("Ya se ha asignado la imagen al Control. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgControl.Focus(); return;
                }

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Selecccionar Archivo";
                dlg.Filter = "Archivo JPG,GIF;DOC,DOCX;PDF|*.jpg;*.gif;*.doc;*.docx;*.pdf";
                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {

                    //Direccion del archivo
                    FileInfo File = new System.IO.FileInfo(dlg.FileName);
                    int nKb = Convert.ToInt32(File.Length / 1024);

                    string sExtension = System.IO.Path.GetExtension(dlg.FileName);
                    string sNombre = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);
                    string sNombreRuta = dlg.FileName;

                    // Declaramos fs para tener acceso al archivo residente en la maquina cliente.
                    FileStream fs = new FileStream(sNombreRuta, FileMode.Open);
                    // Declaramos un Leector Binario para accesar a los datos del archivo pasarlos a un arreglo de bytes
                    br = new BinaryReader(fs);
                    bytes = new byte[(int)fs.Length];

                    br.Read(bytes, 0, bytes.Length);
                    // base64 es la cadena en donde se guarda el arreglo de bytes ya convertido
                    oBE_Reg_ControlImagenes.Nombre = sNombre;
                    oBE_Reg_ControlImagenes.Archivo = bytes;
                    oBE_Reg_ControlImagenes.PesoArchivo = nKb;
                    oBE_Reg_ControlImagenes.ExtensionImagen = sExtension;
                    oBL_Reg_Control.Insertar_Archivo(oBE_Reg_ControlImagenes, sIdControl);
                    fs.Close();
                    fs = null;
                    Listar(Helper.eListar.Grilla);
                    Helper.Buscar_Grilla(dgControl, sIdControl, 0);
                    Listar_Detalle();
                    MessageBox.Show("Se ha Asignado la Imagen " + sNombre + " en forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                br = null;
                bytes = null;
                oBL_Reg_Control = null;
                oBE_Reg_ControlImagenes = null;
            }
        }
        private void bVerImagen_Click(object sender, EventArgs e)
        {
            // Declaramos fs para tener crear un nuevo archivo temporal en la maquina cliente.
            // y memStream para almacenar en memoria la cadena recibida.
            if (Get_IdControl(true) == false) return; 
            BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();

            byte[] bytes;
            try
            {
                string sIdImagen = oBL_Reg_Control.Get_Imagen(sIdControl);
                if (sIdImagen == "")
                {
                    MessageBox.Show("No se ha asignado la imagen al Control. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgControl.Focus(); return;
                }

                oBE_Reg_ControlImagenes = oBL_Reg_Control.Get_Reg_ControlImagenes(BE_Helper.oBE_Sis_Cliente.IdCliente, sIdImagen);
                bytes = oBE_Reg_ControlImagenes.Archivo;

                string sNombre = oBE_Reg_ControlImagenes.Nombre + oBE_Reg_ControlImagenes.ExtensionImagen;
                //- ArchivoPDF toma el valor de la columna binaria

                File.WriteAllBytes(Application.StartupPath + @"\" + sNombre, bytes);

                Process.Start(Application.StartupPath + @"\" + sNombre);


                //return sImagenTemporal;
            }
            catch
            {
                MessageBox.Show("Ocurri� un error al leer la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                oBE_Reg_ControlImagenes = null;
                bytes = null;
            }
        }
        private void bFiltro_Click(object sender, EventArgs e)
        {
            Frm_Sis_Filtros fFil = new Frm_Sis_Filtros();
            fFil.ShowDialog();
            Listar(Helper.eListar.Grilla);
            Listar_Detalle();
            fFil.Dispose();
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            oCancelar();
        }
        private void bQuitarImagen_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return;
            BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
            try
            {
                if (oBL_Reg_Control.Get_Imagen(sIdControl) == "")
                {
                    MessageBox.Show("No se ha asignado la imagen al Control. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgControl.Focus(); return;
                }

                if (MessageBox.Show("�Est� seguro que desea de Quitar la Imagen al Control : " + sIdControl + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                oBL_Reg_Control.Quitar_Archivo(sIdControl);
                Listar(Helper.eListar.Grilla);
                Helper.Buscar_Grilla(dgControl, sIdControl, 0);
                Listar_Detalle();

                MessageBox.Show("Se ha Quitado la Imagen en forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocurri� un error al Quitar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                oBL_Reg_Control = null;
            }
        }


        #endregion

        #region Eventos Objetos

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Listar(Helper.eListar.Grilla);
            Listar_Detalle();
        }

        private void dgControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Get_IdControl(true)== false) return; Abrir_Detalle(Helper.eOpcion.Consultar);
        }
        private void dgControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Get_IdControl(true) == false) return;
                Abrir_Detalle(Helper.eOpcion.Consultar);
            }
        }
        private void dgControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Listar_Detalle();
        }

        private void btnVerDocumento_Click(object sender, EventArgs e)
        {
            if (Get_IdControl(true) == false) return;
            if (Get_NroSecuencia(true) == false) return;

            Frm_VerDocumentos_Envio fEnvd = new Frm_VerDocumentos_Envio(sIdControl, sNroSecuencia);
            fEnvd.ShowDialog();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Get_NroSecuencia(true);
            if (sNroSecuencia == "") return;

            BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
            oBE_Reg_ControlDetalle.IdControl = sIdControl;
            oBE_Reg_ControlDetalle.NroSecuencia = sNroSecuencia;


            if (MessageBox.Show("�Est� seguro que desea de Quitar la Secuencia : " + sNroSecuencia + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            oBL_Reg_Control.Quitar_Actividad(oBE_Reg_ControlDetalle);
            Listar_Detalle();
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            Get_IdControl(true);
            if (sIdControl == "") return;
            Get_NroSecuencia(true);
            if (sNroSecuencia == "") return;

            BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
            oBE_Reg_ControlDetalle.IdControl = sIdControl;
            oBE_Reg_ControlDetalle.NroSecuencia = sNroSecuencia;

            oBL_Reg_Control.Subir(oBE_Reg_ControlDetalle);
            Listar_Detalle();
            Helper.Buscar_Grilla(dgDetalle, sNroSecuencia, 0);
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            Get_IdControl(true);
            if (sIdControl == "") return;
            Get_NroSecuencia(true);
            if (sNroSecuencia == "") return;

            BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
            oBE_Reg_ControlDetalle.IdControl = sIdControl;
            oBE_Reg_ControlDetalle.NroSecuencia = sNroSecuencia;

            oBL_Reg_Control.Bajar(oBE_Reg_ControlDetalle);
            Listar_Detalle();
            Helper.Buscar_Grilla(dgDetalle, sNroSecuencia, 0);
        }
        #endregion



  






    }
}