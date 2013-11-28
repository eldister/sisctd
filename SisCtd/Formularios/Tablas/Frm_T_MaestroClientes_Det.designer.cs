namespace SisCtd
{
    partial class Frm_T_MaestroClientes_Det
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
            this.txtRazonSocial = new MigControls.MigTextbox();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoPersona = new MigControls.MigCombobox();
            this.cboTipoDoi = new MigControls.MigCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroDoi = new MigControls.MigTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContacto = new MigControls.MigTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new MigControls.MigTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFax = new MigControls.MigTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new MigControls.MigTextbox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(487, 299);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(408, 299);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 12;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 723;
            this.label7.Text = "Razon Social *";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Car_Años = 4;
            this.txtRazonSocial.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtRazonSocial.ColorSalida = System.Drawing.Color.White;
            this.txtRazonSocial.Decimales = 2;
            this.txtRazonSocial.Guiones = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(108, 119);
            this.txtRazonSocial.MaxLength = 200;
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasarEnter = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(450, 40);
            this.txtRazonSocial.TabIndex = 4;
            this.txtRazonSocial.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(108, 12);
            this.txtCodigo.MaxLength = 12;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 708;
            this.label1.Text = "Código *";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Car_Años = 4;
            this.txtDireccion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDireccion.ColorSalida = System.Drawing.Color.White;
            this.txtDireccion.Decimales = 2;
            this.txtDireccion.Guiones = false;
            this.txtDireccion.Location = new System.Drawing.Point(108, 165);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasarEnter = true;
            this.txtDireccion.Size = new System.Drawing.Size(450, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 742;
            this.label5.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 745;
            this.label2.Text = "Tipo Persona ";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.BackColor = System.Drawing.Color.White;
            this.cboTipoPersona.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboTipoPersona.ColorSalida = System.Drawing.Color.White;
            this.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPersona.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Items.AddRange(new object[] {
            "Natural",
            "Juridica"});
            this.cboTipoPersona.Location = new System.Drawing.Point(108, 39);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.PasarEnter = true;
            this.cboTipoPersona.Size = new System.Drawing.Size(151, 22);
            this.cboTipoPersona.TabIndex = 1;
            this.cboTipoPersona.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // cboTipoDoi
            // 
            this.cboTipoDoi.BackColor = System.Drawing.Color.White;
            this.cboTipoDoi.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboTipoDoi.ColorSalida = System.Drawing.Color.White;
            this.cboTipoDoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoi.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDoi.FormattingEnabled = true;
            this.cboTipoDoi.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CEXTRA",
            "OTROS"});
            this.cboTipoDoi.Location = new System.Drawing.Point(108, 67);
            this.cboTipoDoi.Name = "cboTipoDoi";
            this.cboTipoDoi.PasarEnter = true;
            this.cboTipoDoi.Size = new System.Drawing.Size(197, 22);
            this.cboTipoDoi.TabIndex = 2;
            this.cboTipoDoi.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 747;
            this.label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 750;
            this.label4.Text = "Num.Documento";
            // 
            // txtNumeroDoi
            // 
            this.txtNumeroDoi.BackColor = System.Drawing.Color.White;
            this.txtNumeroDoi.Car_Años = 4;
            this.txtNumeroDoi.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNumeroDoi.ColorSalida = System.Drawing.Color.White;
            this.txtNumeroDoi.Decimales = 2;
            this.txtNumeroDoi.Guiones = false;
            this.txtNumeroDoi.Location = new System.Drawing.Point(108, 95);
            this.txtNumeroDoi.MaxLength = 11;
            this.txtNumeroDoi.Name = "txtNumeroDoi";
            this.txtNumeroDoi.PasarEnter = true;
            this.txtNumeroDoi.Size = new System.Drawing.Size(112, 20);
            this.txtNumeroDoi.TabIndex = 3;
            this.txtNumeroDoi.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 752;
            this.label6.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.Car_Años = 4;
            this.txtContacto.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtContacto.ColorSalida = System.Drawing.Color.White;
            this.txtContacto.Decimales = 2;
            this.txtContacto.Guiones = false;
            this.txtContacto.Location = new System.Drawing.Point(108, 190);
            this.txtContacto.MaxLength = 100;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.PasarEnter = true;
            this.txtContacto.Size = new System.Drawing.Size(450, 20);
            this.txtContacto.TabIndex = 6;
            this.txtContacto.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 754;
            this.label8.Text = "Telefono 1";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.Car_Años = 4;
            this.txtTelefono1.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtTelefono1.ColorSalida = System.Drawing.Color.White;
            this.txtTelefono1.Decimales = 2;
            this.txtTelefono1.Guiones = false;
            this.txtTelefono1.Location = new System.Drawing.Point(108, 216);
            this.txtTelefono1.MaxLength = 20;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.PasarEnter = true;
            this.txtTelefono1.Size = new System.Drawing.Size(112, 20);
            this.txtTelefono1.TabIndex = 7;
            this.txtTelefono1.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 756;
            this.label9.Text = "Telefono 2";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.Car_Años = 4;
            this.txtTelefono2.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtTelefono2.ColorSalida = System.Drawing.Color.White;
            this.txtTelefono2.Decimales = 2;
            this.txtTelefono2.Guiones = false;
            this.txtTelefono2.Location = new System.Drawing.Point(374, 217);
            this.txtTelefono2.MaxLength = 20;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.PasarEnter = true;
            this.txtTelefono2.Size = new System.Drawing.Size(112, 20);
            this.txtTelefono2.TabIndex = 8;
            this.txtTelefono2.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 758;
            this.label10.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Car_Años = 4;
            this.txtFax.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtFax.ColorSalida = System.Drawing.Color.White;
            this.txtFax.Decimales = 2;
            this.txtFax.Guiones = false;
            this.txtFax.Location = new System.Drawing.Point(108, 242);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasarEnter = true;
            this.txtFax.Size = new System.Drawing.Size(112, 20);
            this.txtFax.TabIndex = 9;
            this.txtFax.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 760;
            this.label11.Text = "E_Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Car_Años = 4;
            this.txtEmail.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtEmail.ColorSalida = System.Drawing.Color.White;
            this.txtEmail.Decimales = 2;
            this.txtEmail.Guiones = false;
            this.txtEmail.Location = new System.Drawing.Point(108, 267);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasarEnter = true;
            this.txtEmail.Size = new System.Drawing.Size(450, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // Frm_T_MaestroClientes_Det
            // 
            this.ClientSize = new System.Drawing.Size(575, 330);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroDoi);
            this.Controls.Add(this.cboTipoDoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_T_MaestroClientes_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_T_MaestroClientes_Det_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtRazonSocial;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private MigControls.MigTextbox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MigControls.MigCombobox cboTipoPersona;
        private MigControls.MigCombobox cboTipoDoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MigControls.MigTextbox txtNumeroDoi;
        private System.Windows.Forms.Label label6;
        private MigControls.MigTextbox txtContacto;
        private System.Windows.Forms.Label label8;
        private MigControls.MigTextbox txtTelefono1;
        private System.Windows.Forms.Label label9;
        private MigControls.MigTextbox txtTelefono2;
        private System.Windows.Forms.Label label10;
        private MigControls.MigTextbox txtFax;
        private System.Windows.Forms.Label label11;
        private MigControls.MigTextbox txtEmail;

    }
}