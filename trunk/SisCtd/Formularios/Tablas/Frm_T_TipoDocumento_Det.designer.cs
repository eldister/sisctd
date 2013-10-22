namespace BESisCtd
{
    partial class Frm_T_TipoDocumento_Det
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
            this.cboEstado = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionLarga = new MigControls.MigTextbox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(365, 196);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::BESisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(282, 196);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 4;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
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
            this.txtDescripcion.Location = new System.Drawing.Point(112, 43);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasarEnter = true;
            this.txtDescripcion.Size = new System.Drawing.Size(333, 20);
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
            this.txtCodigo.Location = new System.Drawing.Point(112, 15);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(93, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 708;
            this.label1.Text = "Código *";
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
            this.cboEstado.Location = new System.Drawing.Point(112, 159);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(93, 22);
            this.cboEstado.TabIndex = 3;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 734;
            this.label14.Text = "Estado *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 736;
            this.label2.Text = "Descripción Larga";
            // 
            // txtDescripcionLarga
            // 
            this.txtDescripcionLarga.BackColor = System.Drawing.Color.White;
            this.txtDescripcionLarga.Car_Años = 4;
            this.txtDescripcionLarga.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescripcionLarga.ColorSalida = System.Drawing.Color.White;
            this.txtDescripcionLarga.Decimales = 2;
            this.txtDescripcionLarga.Guiones = false;
            this.txtDescripcionLarga.Location = new System.Drawing.Point(112, 69);
            this.txtDescripcionLarga.MaxLength = 200;
            this.txtDescripcionLarga.Multiline = true;
            this.txtDescripcionLarga.Name = "txtDescripcionLarga";
            this.txtDescripcionLarga.PasarEnter = true;
            this.txtDescripcionLarga.Size = new System.Drawing.Size(333, 82);
            this.txtDescripcionLarga.TabIndex = 2;
            this.txtDescripcionLarga.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // Frm_T_TipoDocumento_Det
            // 
            this.ClientSize = new System.Drawing.Size(454, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionLarga);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label14);
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
            this.Name = "Frm_T_TipoDocumento_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Detalle";
            this.Activated += new System.EventHandler(this.Frm_T_TipoDocumento_Det_Activated);
            this.Load += new System.EventHandler(this.Frm_T_TipoDocumento_Det_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_TipoDocumento_Det_KeyPress);
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
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtDescripcionLarga;

    }
}