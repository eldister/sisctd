namespace SisCtd
{
    partial class Frm_Sis_Usuarios_Det
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNombre = new MigControls.MigTextbox();
            this.txtIdUsuario = new MigControls.MigTextbox();
            this.cboEstado = new MigControls.MigCombobox();
            this.cboPerfil = new MigControls.MigCombobox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new MigControls.MigTextbox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.btnCancelar.Location = new System.Drawing.Point(365, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cerrar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.btnGrabar.Location = new System.Drawing.Point(282, 161);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Car_Años = 4;
            this.txtNombre.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNombre.ColorSalida = System.Drawing.Color.White;
            this.txtNombre.Decimales = 2;
            this.txtNombre.Guiones = false;
            this.txtNombre.Location = new System.Drawing.Point(122, 39);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasarEnter = true;
            this.txtNombre.Size = new System.Drawing.Size(323, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tipo = MigControls.MigTextbox.TipoVal.Letras;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.White;
            this.txtIdUsuario.Car_Años = 4;
            this.txtIdUsuario.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdUsuario.ColorSalida = System.Drawing.Color.White;
            this.txtIdUsuario.Decimales = 2;
            this.txtIdUsuario.Guiones = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(122, 11);
            this.txtIdUsuario.MaxLength = 10;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasarEnter = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(89, 20);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.Tipo = MigControls.MigTextbox.TipoVal.Texto;
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
            this.cboEstado.Location = new System.Drawing.Point(122, 122);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(89, 22);
            this.cboEstado.TabIndex = 4;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // cboPerfil
            // 
            this.cboPerfil.BackColor = System.Drawing.Color.White;
            this.cboPerfil.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboPerfil.ColorSalida = System.Drawing.Color.White;
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.Enabled = false;
            this.cboPerfil.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboPerfil.Location = new System.Drawing.Point(122, 94);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.PasarEnter = true;
            this.cboPerfil.Size = new System.Drawing.Size(202, 22);
            this.cboPerfil.TabIndex = 3;
            this.cboPerfil.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 735;
            this.label11.Text = "Estado *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 732;
            this.label8.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 729;
            this.label2.Text = "Nombre *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 728;
            this.label1.Text = "Id Usuario *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 730;
            this.label4.Text = "Perfil de Usuario *";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Car_Años = 4;
            this.txtCorreo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCorreo.ColorSalida = System.Drawing.Color.White;
            this.txtCorreo.Decimales = 2;
            this.txtCorreo.Guiones = false;
            this.txtCorreo.Location = new System.Drawing.Point(122, 67);
            this.txtCorreo.MaxLength = 200;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasarEnter = true;
            this.txtCorreo.Size = new System.Drawing.Size(323, 20);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.Tipo = MigControls.MigTextbox.TipoVal.Texto;
            // 
            // Frm_Sis_Usuarios_Det
            // 
            this.ClientSize = new System.Drawing.Size(457, 207);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Usuarios_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Usuarios";
            this.Activated += new System.EventHandler(this.Frm_Sis_Usuarios_Det_Activated);
            this.Load += new System.EventHandler(this.Frm_Sis_Usuarios_Det_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Usuarios_Det_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private MigControls.MigTextbox txtNombre;
        private MigControls.MigTextbox txtIdUsuario;
        private MigControls.MigCombobox cboEstado;
        private MigControls.MigCombobox cboPerfil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MigControls.MigTextbox txtCorreo;

    }
}