namespace SisCtd
{
    partial class Frm_Reg_Control_Det
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdTipoDocumento = new MigControls.MigTextbox();
            this.txtIdControl = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new MigControls.MigTextbox();
            this.lblDesTipoDocumento = new System.Windows.Forms.Label();
            this.lblDesMaestroCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMaestroCliente = new MigControls.MigTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new MigControls.MigTextbox();
            this.dtpFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboRuta = new MigControls.MigCombobox();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigoBarraTit = new System.Windows.Forms.Label();
            this.lblIdOficinaRecepcion = new System.Windows.Forms.Label();
            this.grpSeguimiento = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdOficinaRecepcionDes = new System.Windows.Forms.Label();
            this.grpSeguimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo Documento *";
            // 
            // txtIdTipoDocumento
            // 
            this.txtIdTipoDocumento.BackColor = System.Drawing.Color.White;
            this.txtIdTipoDocumento.Car_Años = 4;
            this.txtIdTipoDocumento.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdTipoDocumento.ColorSalida = System.Drawing.Color.White;
            this.txtIdTipoDocumento.Decimales = 2;
            this.txtIdTipoDocumento.Guiones = false;
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(120, 71);
            this.txtIdTipoDocumento.MaxLength = 10;
            this.txtIdTipoDocumento.Name = "txtIdTipoDocumento";
            this.txtIdTipoDocumento.PasarEnter = true;
            this.txtIdTipoDocumento.Size = new System.Drawing.Size(93, 20);
            this.txtIdTipoDocumento.TabIndex = 1;
            this.txtIdTipoDocumento.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdTipoDocumento.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtIdTipoDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // txtIdControl
            // 
            this.txtIdControl.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdControl.Car_Años = 4;
            this.txtIdControl.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdControl.ColorSalida = System.Drawing.Color.White;
            this.txtIdControl.Decimales = 2;
            this.txtIdControl.Guiones = false;
            this.txtIdControl.Location = new System.Drawing.Point(120, 15);
            this.txtIdControl.MaxLength = 10;
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.PasarEnter = true;
            this.txtIdControl.ReadOnly = true;
            this.txtIdControl.Size = new System.Drawing.Size(152, 20);
            this.txtIdControl.TabIndex = 0;
            this.txtIdControl.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id Control *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Car_Años = 4;
            this.txtObservacion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtObservacion.ColorSalida = System.Drawing.Color.White;
            this.txtObservacion.Decimales = 2;
            this.txtObservacion.Guiones = false;
            this.txtObservacion.Location = new System.Drawing.Point(120, 213);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasarEnter = true;
            this.txtObservacion.Size = new System.Drawing.Size(417, 65);
            this.txtObservacion.TabIndex = 6;
            this.txtObservacion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // lblDesTipoDocumento
            // 
            this.lblDesTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesTipoDocumento.Location = new System.Drawing.Point(215, 71);
            this.lblDesTipoDocumento.Name = "lblDesTipoDocumento";
            this.lblDesTipoDocumento.Size = new System.Drawing.Size(322, 20);
            this.lblDesTipoDocumento.TabIndex = 10;
            this.lblDesTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesMaestroCliente
            // 
            this.lblDesMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesMaestroCliente.Location = new System.Drawing.Point(215, 99);
            this.lblDesMaestroCliente.Name = "lblDesMaestroCliente";
            this.lblDesMaestroCliente.Size = new System.Drawing.Size(322, 20);
            this.lblDesMaestroCliente.TabIndex = 11;
            this.lblDesMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cliente *";
            // 
            // txtIdMaestroCliente
            // 
            this.txtIdMaestroCliente.BackColor = System.Drawing.Color.White;
            this.txtIdMaestroCliente.Car_Años = 4;
            this.txtIdMaestroCliente.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdMaestroCliente.ColorSalida = System.Drawing.Color.White;
            this.txtIdMaestroCliente.Decimales = 2;
            this.txtIdMaestroCliente.Guiones = false;
            this.txtIdMaestroCliente.Location = new System.Drawing.Point(120, 99);
            this.txtIdMaestroCliente.MaxLength = 10;
            this.txtIdMaestroCliente.Name = "txtIdMaestroCliente";
            this.txtIdMaestroCliente.PasarEnter = true;
            this.txtIdMaestroCliente.Size = new System.Drawing.Size(93, 20);
            this.txtIdMaestroCliente.TabIndex = 2;
            this.txtIdMaestroCliente.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdMaestroCliente.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtIdMaestroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Número / Referencia";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Car_Años = 4;
            this.txtNumero.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNumero.ColorSalida = System.Drawing.Color.White;
            this.txtNumero.Decimales = 2;
            this.txtNumero.Guiones = false;
            this.txtNumero.Location = new System.Drawing.Point(120, 127);
            this.txtNumero.MaxLength = 30;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasarEnter = true;
            this.txtNumero.Size = new System.Drawing.Size(192, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // dtpFechaDocumento
            // 
            this.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDocumento.Location = new System.Drawing.Point(120, 155);
            this.dtpFechaDocumento.Name = "dtpFechaDocumento";
            this.dtpFechaDocumento.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaDocumento.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Documento *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ruta *";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Location = new System.Drawing.Point(112, 43);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(93, 20);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaInicio.Location = new System.Drawing.Point(112, 17);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(93, 20);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Fecha Inicio";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaTermino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaTermino.Location = new System.Drawing.Point(315, 17);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(93, 20);
            this.lblFechaTermino.TabIndex = 14;
            this.lblFechaTermino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fecha Termino";
            // 
            // cboRuta
            // 
            this.cboRuta.BackColor = System.Drawing.Color.White;
            this.cboRuta.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboRuta.ColorSalida = System.Drawing.Color.White;
            this.cboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuta.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRuta.FormattingEnabled = true;
            this.cboRuta.Location = new System.Drawing.Point(120, 182);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.PasarEnter = true;
            this.cboRuta.Size = new System.Drawing.Size(417, 22);
            this.cboRuta.TabIndex = 5;
            this.cboRuta.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.BackColor = System.Drawing.Color.White;
            this.lblCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoBarra.Location = new System.Drawing.Point(8, 390);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(143, 52);
            this.lblCodigoBarra.TabIndex = 27;
            this.lblCodigoBarra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigoBarra.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(457, 414);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(374, 414);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 7;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(466, 15);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(71, 20);
            this.lblFechaRecepcion.TabIndex = 28;
            this.lblFechaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha de Recepción";
            // 
            // lblCodigoBarraTit
            // 
            this.lblCodigoBarraTit.AutoSize = true;
            this.lblCodigoBarraTit.Location = new System.Drawing.Point(8, 371);
            this.lblCodigoBarraTit.Name = "lblCodigoBarraTit";
            this.lblCodigoBarraTit.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoBarraTit.TabIndex = 30;
            this.lblCodigoBarraTit.Text = "Código de Barra";
            this.lblCodigoBarraTit.Visible = false;
            // 
            // lblIdOficinaRecepcion
            // 
            this.lblIdOficinaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaRecepcion.Location = new System.Drawing.Point(121, 43);
            this.lblIdOficinaRecepcion.Name = "lblIdOficinaRecepcion";
            this.lblIdOficinaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblIdOficinaRecepcion.TabIndex = 31;
            this.lblIdOficinaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIdOficinaRecepcion.TextChanged += new System.EventHandler(this.lblIdOficinaRecepcion_TextChanged);
            // 
            // grpSeguimiento
            // 
            this.grpSeguimiento.Controls.Add(this.lblFechaInicio);
            this.grpSeguimiento.Controls.Add(this.label14);
            this.grpSeguimiento.Controls.Add(this.lblEstado);
            this.grpSeguimiento.Controls.Add(this.label15);
            this.grpSeguimiento.Controls.Add(this.label17);
            this.grpSeguimiento.Controls.Add(this.lblFechaTermino);
            this.grpSeguimiento.Location = new System.Drawing.Point(8, 289);
            this.grpSeguimiento.Name = "grpSeguimiento";
            this.grpSeguimiento.Size = new System.Drawing.Size(529, 73);
            this.grpSeguimiento.TabIndex = 33;
            this.grpSeguimiento.TabStop = false;
            this.grpSeguimiento.Text = "Seguimiento";
            this.grpSeguimiento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Oficina Recepción";
            // 
            // lblIdOficinaRecepcionDes
            // 
            this.lblIdOficinaRecepcionDes.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaRecepcionDes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaRecepcionDes.Location = new System.Drawing.Point(215, 43);
            this.lblIdOficinaRecepcionDes.Name = "lblIdOficinaRecepcionDes";
            this.lblIdOficinaRecepcionDes.Size = new System.Drawing.Size(322, 20);
            this.lblIdOficinaRecepcionDes.TabIndex = 34;
            this.lblIdOficinaRecepcionDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Reg_Control_Det
            // 
            this.ClientSize = new System.Drawing.Size(551, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdOficinaRecepcionDes);
            this.Controls.Add(this.grpSeguimiento);
            this.Controls.Add(this.lblIdOficinaRecepcion);
            this.Controls.Add(this.lblCodigoBarraTit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFechaRecepcion);
            this.Controls.Add(this.lblCodigoBarra);
            this.Controls.Add(this.cboRuta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblDesMaestroCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdMaestroCliente);
            this.Controls.Add(this.lblDesTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdTipoDocumento);
            this.Controls.Add(this.txtIdControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reg_Control_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Detalle del Control";
            this.Activated += new System.EventHandler(this.Frm_Reg_Control_Det_Activated);
            this.Load += new System.EventHandler(this.Frm_Reg_Control_Det_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Reg_Control_Det_KeyPress);
            this.grpSeguimiento.ResumeLayout(false);
            this.grpSeguimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtIdTipoDocumento;
        private MigControls.MigTextbox txtIdControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtObservacion;
        private System.Windows.Forms.Label lblDesTipoDocumento;
        private System.Windows.Forms.Label lblDesMaestroCliente;
        private System.Windows.Forms.Label label5;
        private MigControls.MigTextbox txtIdMaestroCliente;
        private System.Windows.Forms.Label label6;
        private MigControls.MigTextbox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFechaDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label label17;
        private MigControls.MigCombobox cboRuta;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigoBarraTit;
        private System.Windows.Forms.Label lblIdOficinaRecepcion;
        private System.Windows.Forms.GroupBox grpSeguimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdOficinaRecepcionDes;

    }
}