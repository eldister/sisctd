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
    public partial class Frm_VerDocumentos_Envio : Form
    {
        #region Declaración Variables

        public string sIdControl;
        public string sNroSecuencia;
        public string sIdImagen;

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();
        BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
        //BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();

        #endregion

        #region Iniciar Formulario
        public Frm_VerDocumentos_Envio(string _IdControl, string _NroSecuencia)
        {
            InitializeComponent();
            sIdControl = _IdControl;
            sNroSecuencia = _NroSecuencia;
        }
        private void Frm_VerDocumentos_Envio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void Frm_Reg_Seguimiento_Envio_Load(object sender, EventArgs e)
        {

            Listar(Helper.eListar.Grilla); 
        }

        #endregion



        #region Metodos
        private bool Get_IdImagen(bool bMsg)
        {
            if (dgDetalle.Rows.Count <= 0)
            {
                if (bMsg == true) MessageBox.Show("Seleccione una Imagen", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sIdImagen = "";
                return false;
            }
            else
            {
                sIdImagen = dgDetalle.Rows[dgDetalle.CurrentCellAddress.Y].Cells[0].Value.ToString().Trim();
                return true;
            }
        }

        #endregion

        #region Eventos Objetos
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                }
            }
        }
        private void Listar(Helper.eListar eListar)
        {
            DataTable Dt = new DataTable();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Dt = oBL_Reg_Control.Listar_DocumentosAnexos(sIdControl, sNroSecuencia );
                {
                    dgDetalle.DataSource = Dt; Helper.FormatoGrilla(dgDetalle, false);
                    //LblMensaje.Text = " Registros Encontrados : " + dgControl.Rows.Count.ToString();
                    dgDetalle.Columns["Idimagen"].Width = 100;
                    dgDetalle.Columns["Nombre"].Width = 180;
                    dgDetalle.Columns["ExtensionImagen"].Width = 90;
                }
                Dt.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (Dt != null) { Dt = null; } this.Cursor = Cursors.Default; }
        }


        private void bVerImagen_Click(object sender, EventArgs e)
        {
            // Declaramos fs para tener crear un nuevo archivo temporal en la maquina cliente.
            // y memStream para almacenar en memoria la cadena recibida.
            BE_Reg_ControlImagenes oBE_Reg_ControlImagenes = new BE_Reg_ControlImagenes();
            byte[] bytes;
            try
            {
                if (Get_IdImagen(true) == false) return;
                if (sIdImagen == "")
                {
                    MessageBox.Show("No se ha asignado la imagen al Control. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgDetalle.Focus(); return;
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
                MessageBox.Show("Ocurrió un error al leer la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                oBE_Reg_ControlImagenes = null;
                bytes = null;
            }
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

       

    }
}
