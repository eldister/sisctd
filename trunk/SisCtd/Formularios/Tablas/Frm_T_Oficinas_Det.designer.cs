namespace SisCtd
{
    partial class Frm_T_Oficinas_Det
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
            this.txtDescripcion = new MigControls.MigTextbox();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbigeo = new MigControls.MigTextbox();
            this.lblUbigeo = new System.Windows.Forms.Label();
            this.txtDireccion = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(410, 157);
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
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(329, 157);
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
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 723;
            this.label7.Text = "Descripción *";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Car_Años = 4;
            this.txtDescripcion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescripcion.ColorSalida = System.Drawing.Color.White;
            this.txtDescripcion.Decimales = 2;
            this.txtDescripcion.Guiones = false;
            this.txtDescripcion.Location = new System.Drawing.Point(108, 40);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasarEnter = true;
            this.txtDescripcion.Size = new System.Drawing.Size(382, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 736;
            this.label3.Text = "Ubicación";
            // 
            // txtUbigeo
            // 
            this.txtUbigeo.BackColor = System.Drawing.Color.White;
            this.txtUbigeo.Car_Años = 4;
            this.txtUbigeo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtUbigeo.ColorSalida = System.Drawing.Color.White;
            this.txtUbigeo.Decimales = 2;
            this.txtUbigeo.Guiones = false;
            this.txtUbigeo.Location = new System.Drawing.Point(108, 68);
            this.txtUbigeo.MaxLength = 10;
            this.txtUbigeo.Name = "txtUbigeo";
            this.txtUbigeo.PasarEnter = true;
            this.txtUbigeo.Size = new System.Drawing.Size(62, 20);
            this.txtUbigeo.TabIndex = 3;
            this.txtUbigeo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtUbigeo.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtUbigeo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // lblUbigeo
            // 
            this.lblUbigeo.BackColor = System.Drawing.SystemColors.Info;
            this.lblUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbigeo.Location = new System.Drawing.Point(172, 68);
            this.lblUbigeo.Name = "lblUbigeo";
            this.lblUbigeo.Size = new System.Drawing.Size(318, 20);
            this.lblUbigeo.TabIndex = 4;
            this.lblUbigeo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Car_Años = 4;
            this.txtDireccion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDireccion.ColorSalida = System.Drawing.Color.White;
            this.txtDireccion.Decimales = 2;
            this.txtDireccion.Guiones = false;
            this.txtDireccion.Location = new System.Drawing.Point(108, 96);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasarEnter = true;
            this.txtDireccion.Size = new System.Drawing.Size(382, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 742;
            this.label5.Text = "Dirección";
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.White;
            this.cboEstado.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboEstado.ColorSalida = System.Drawing.Color.White;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(108, 123);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(93, 22);
            this.cboEstado.TabIndex = 743;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 744;
            this.label14.Text = "Estado *";
            // 
            // Frm_T_Oficinas_Det
            // 
            this.ClientSize = new System.Drawing.Size(499, 195);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblUbigeo);
            this.Controls.Add(this.txtUbigeo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_T_Oficinas_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Oficina";
            this.Load += new System.EventHandler(this.Frm_T_Oficinas_Det_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtDescripcion;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtUbigeo;
        private System.Windows.Forms.Label lblUbigeo;
        private MigControls.MigTextbox txtDireccion;
        private System.Windows.Forms.Label label5;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Label label14;

    }
}