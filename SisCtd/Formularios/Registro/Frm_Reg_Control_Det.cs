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
using Limilabs.Barcode;
using System.Drawing.Imaging;

namespace SisCtd
{
    public partial class Frm_Reg_Control_Det : Form
    {
        #region Declaración Variables

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        public string sIdControl;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;

        
        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        ClsConvertImagen ConvImagen = new ClsConvertImagen();
        

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Control_Det(Helper.eOpcion _qOpcion, string _IdControl)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            sIdControl = _IdControl;
        }
        private void Frm_Reg_Control_Det_Load(object sender, EventArgs e)
        {
            try
            {
                CargoPrivateFontCollection();
                CargoEtiqueta(font);
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        txtIdControl.Text = "??????????????";
                        lblFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lblHoraRecepcion.Text = DateTime.Now.ToString("HH:mm:ss");
                        lblIdOficinaRecepcion.Text = oBL_Sis_Usuario.Get_IdOficina(BE_Helper.oBE_Sis_Usuario.IdUsuario);
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        lblCodigoBarra.Text = sIdControl;
                        txtIdControl.ReadOnly = true;
                        cboRuta.Enabled = false;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtIdTipoDocumento.ReadOnly = true;
                            BtnGrabar.Visible = false;
                            grpSeguimiento.Visible = true;
                            lblCodigoBarra.Visible = true;
                            lblCodigoBarraTit.Visible = true;
                        }
                        else
                        {
                            this.Text = " Modificar";
                            grpSeguimiento.Visible = true;
                            lblCodigoBarra.Visible = true;
                            lblCodigoBarraTit.Visible = true;
                        }

                        oBE_Reg_Control = oBL_Reg_Control.Get_Control(sIdControl);
                        if (oBE_Reg_Control != null)
                        {
                            txtIdControl.Text = oBE_Reg_Control.IdControl.ToString();
                            lblFechaRecepcion.Text = oBE_Reg_Control.FechaRecepcion.ToString("dd/MM/yyyy");
                            lblHoraRecepcion.Text = oBE_Reg_Control.FechaRecepcion.ToString("hh:mm tt");
                            lblIdOficinaRecepcion.Text = oBE_Reg_Control.IdOficinaRecepcion;
                            txtIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                            txtIdMaestroCliente.Text= oBE_Reg_Control.IdMaestroCliente;
                            txtNumero.Text= oBE_Reg_Control.NroDocumento ;
                            dtpFechaDocumento.Value= oBE_Reg_Control.FechaDocumento;
                            txtObservacion.Text= oBE_Reg_Control.Observacion;
                            if (oBE_Reg_Control.FechaInicio!=null) lblFechaInicio.Text = Convert.ToString(oBE_Reg_Control.FechaInicio);
                            if (oBE_Reg_Control.FechaTermino != null) lblFechaTermino.Text = Convert.ToString(oBE_Reg_Control.FechaTermino);
                            lblEstado.Text= oBE_Reg_Control.Estado;
                            cboRuta.SelectedValue = oBE_Reg_Control.IdRuta;
                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_Reg_Control_Det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_Reg_Control_Det_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Nuevo) { txtIdTipoDocumento.Focus(); }
            if (qOpcion == Helper.eOpcion.Modificar) { txtIdTipoDocumento.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Metodos
        private void CargoPrivateFontCollection()
        {
            // CREO EL BYTE[] Y TOMO SU LONGITUD
            byte[] fontArray = SisCtd.Properties.Resources.code128;
            int dataLength = SisCtd.Properties.Resources.code128.Length;


            // ASIGNO MEMORIA Y COPIO BYTE[] EN LA DIRECCION
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //PASO LA FUENTE A LA PRIVATEFONTCOLLECTION
            pfc.AddMemoryFont(ptrData, dataLength);

            //LIBERO LA MEMORIA "UNSAFE"
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }
        private void CargoEtiqueta(Font font)
        {
            FontStyle fontStyle = FontStyle.Regular;
            this.lblCodigoBarra.Font = new Font(ff, 20, fontStyle);

        }
        #endregion

        #region Eventos Objetos
        private void PonerDescrip_TextChanged(object sender, EventArgs e)
        {
            TextBox txt=(MigControls.MigTextbox)sender;
            switch (txt.Name)
            {
                case "txtIdTipoDocumento": 
                    lblDesTipoDocumento.Text = oBL_T_TipoDocumento.Get_Descripcion(txtIdTipoDocumento.Text);
                    Helper.LLenar_Combobox(oBL_T_TipoDocumento.Listar_Rutas(txtIdTipoDocumento.Text), cboRuta, "Descripcion", "IdRuta");
                    break;
                case "txtIdMaestroCliente": lblDesMaestroCliente.Text = oBL_T_MaestroCliente.Get_RazonSocial(txtIdMaestroCliente.Text); break;
            }

        }
        private void AyudaF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TextBox txt = (MigControls.MigTextbox)sender;
                switch (txt.Name)
                {
                    case "txtIdTipoDocumento": txtIdTipoDocumento.Text = Helper.Buscar(oBL_T_TipoDocumento.Buscar()); break;
                    case "txtIdMaestroCliente": txtIdMaestroCliente.Text = Helper.Buscar(oBL_T_MaestroCliente.Buscar()); break;
                }
            }
        }
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDesTipoDocumento.Text == "")
                {
                    MessageBox.Show("Ingrese un Tipo de Documento válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdTipoDocumento.Focus(); return;
                }

                if (lblDesMaestroCliente.Text == "")
                {
                    MessageBox.Show("Ingrese un Cliente válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdMaestroCliente.Focus(); return;
                }

                if (txtNumero.Text == "")
                {
                    MessageBox.Show("Ingrese un Número", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.Focus(); return;
                }

                if (cboRuta.Text == "")
                {
                    MessageBox.Show("Seleccione una Ruta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboRuta.Focus(); return;
                }
            
                oBE_Reg_Control.IdControl = sIdControl;
                oBE_Reg_Control.FechaRecepcion = Convert.ToDateTime(lblFechaRecepcion.Text + " " + lblHoraRecepcion.Text);
                oBE_Reg_Control.IdOficinaRecepcion = lblIdOficinaRecepcion.Text;
                oBE_Reg_Control.IdTipoDocumento = txtIdTipoDocumento.Text.Trim();
                oBE_Reg_Control.IdMaestroCliente = txtIdMaestroCliente.Text.Trim();
                oBE_Reg_Control.NroDocumento = txtNumero.Text.Trim();
                oBE_Reg_Control.FechaDocumento = dtpFechaDocumento.Value;
                oBE_Reg_Control.Observacion = txtObservacion.Text;
                oBE_Reg_Control.Estado = lblEstado.Text;
                oBE_Reg_Control.IdRuta = cboRuta.SelectedValue.ToString();
                
                BaseBarcode barcode = BarcodeFactory.GetBarcode(Symbology.Code128);
                barcode.Number = sIdControl;
                barcode.ChecksumAdd = true;
                barcode.Height = 40;
                // Render barcode:
                this.pictureBox1.Image = barcode.Render();
                // You can also save it to file:
                oBE_Reg_Control.CodBarra = ClsConvertImagen.ImageToByteArray(pictureBox1.Image);

                //barcode.Save("c:\\sistemas\\barcode.jpg", Limilabs.Barcode.ImageType.Jpeg);
                //this.pictureBox1.Image.Save("c:\\sistemas\\barcode.gif", System.Drawing.Imaging.ImageFormat.Gif);


                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    sIdControl = oBL_Reg_Control.Insertar(oBE_Reg_Control);
                    oBE_Reg_Control.IdControl = sIdControl;
                    sIdControl = oBL_Reg_Control.Actualizar(oBE_Reg_Control);
                } 
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    oBL_Reg_Control.Modificar(oBE_Reg_Control);
                }
                bGrabo = true; this.Close();

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void lblIdOficinaRecepcion_TextChanged(object sender, EventArgs e)
        {
            lblIdOficinaRecepcionDes.Text = oBL_T_Oficina.Get_Descripcion(lblIdOficinaRecepcion.Text);
        }





    }
}