namespace BESisCtd
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdTipoDocumento = new MigControls.MigTextbox();
            this.txtIdControl = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new MigControls.MigTextbox();
            this.lblDesTipoDocumneto = new System.Windows.Forms.Label();
            this.lblDesMaestroCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMaestroCliente = new MigControls.MigTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new MigControls.MigTextbox();
            this.dtpFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new MigControls.MigTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboRuta = new MigControls.MigCombobox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(457, 357);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::BESisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(374, 357);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
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
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(120, 42);
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
            this.txtIdControl.Size = new System.Drawing.Size(93, 20);
            this.txtIdControl.TabIndex = 0;
            this.txtIdControl.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id Control *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 208);
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
            this.txtObservacion.Location = new System.Drawing.Point(120, 208);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasarEnter = true;
            this.txtObservacion.Size = new System.Drawing.Size(417, 84);
            this.txtObservacion.TabIndex = 7;
            this.txtObservacion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // lblDesTipoDocumneto
            // 
            this.lblDesTipoDocumneto.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesTipoDocumneto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesTipoDocumneto.Location = new System.Drawing.Point(215, 42);
            this.lblDesTipoDocumneto.Name = "lblDesTipoDocumneto";
            this.lblDesTipoDocumneto.Size = new System.Drawing.Size(322, 20);
            this.lblDesTipoDocumneto.TabIndex = 10;
            this.lblDesTipoDocumneto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesMaestroCliente
            // 
            this.lblDesMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesMaestroCliente.Location = new System.Drawing.Point(215, 69);
            this.lblDesMaestroCliente.Name = "lblDesMaestroCliente";
            this.lblDesMaestroCliente.Size = new System.Drawing.Size(322, 20);
            this.lblDesMaestroCliente.TabIndex = 11;
            this.lblDesMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 73);
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
            this.txtIdMaestroCliente.Location = new System.Drawing.Point(120, 69);
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
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Número *";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Car_Años = 4;
            this.txtNumero.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNumero.ColorSalida = System.Drawing.Color.White;
            this.txtNumero.Decimales = 2;
            this.txtNumero.Guiones = false;
            this.txtNumero.Location = new System.Drawing.Point(120, 96);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasarEnter = true;
            this.txtNumero.Size = new System.Drawing.Size(93, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // dtpFechaDocumento
            // 
            this.dtpFechaDocumento.Location = new System.Drawing.Point(120, 123);
            this.dtpFechaDocumento.Name = "dtpFechaDocumento";
            this.dtpFechaDocumento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDocumento.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Documento *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Código de Barra *";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.Color.White;
            this.txtCodigoBarra.Car_Años = 4;
            this.txtCodigoBarra.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigoBarra.ColorSalida = System.Drawing.Color.White;
            this.txtCodigoBarra.Decimales = 2;
            this.txtCodigoBarra.Guiones = false;
            this.txtCodigoBarra.Location = new System.Drawing.Point(120, 177);
            this.txtCodigoBarra.MaxLength = 10;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.PasarEnter = true;
            this.txtCodigoBarra.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoBarra.TabIndex = 6;
            this.txtCodigoBarra.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ruta *";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Location = new System.Drawing.Point(120, 329);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(93, 20);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaInicio.Location = new System.Drawing.Point(120, 300);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(93, 20);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Fecha Inicio";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaTermino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaTermino.Location = new System.Drawing.Point(325, 300);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(93, 20);
            this.lblFechaTermino.TabIndex = 14;
            this.lblFechaTermino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(236, 304);
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
            this.cboRuta.Location = new System.Drawing.Point(120, 149);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.PasarEnter = true;
            this.cboRuta.Size = new System.Drawing.Size(417, 22);
            this.cboRuta.TabIndex = 27;
            this.cboRuta.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // Frm_Reg_Control_Det
            // 
            this.ClientSize = new System.Drawing.Size(549, 398);
            this.Controls.Add(this.cboRuta);
            this.Controls.Add(this.lblFechaTermino);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblDesMaestroCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdMaestroCliente);
            this.Controls.Add(this.lblDesTipoDocumneto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label14);
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
        private System.Windows.Forms.Label lblDesTipoDocumneto;
        private System.Windows.Forms.Label lblDesMaestroCliente;
        private System.Windows.Forms.Label label5;
        private MigControls.MigTextbox txtIdMaestroCliente;
        private System.Windows.Forms.Label label6;
        private MigControls.MigTextbox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFechaDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MigControls.MigTextbox txtCodigoBarra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label label17;
        private MigControls.MigCombobox cboRuta;

    }
}