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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescrip = new MigControls.MigTextbox();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEst = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new MigControls.MigCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNat = new MigControls.MigCombobox();
            this.cboCritico = new MigControls.MigCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDigita = new MigControls.MigCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(364, 218);
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
            this.BtnGrabar.Location = new System.Drawing.Point(281, 218);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 7;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 723;
            this.label7.Text = "Descripción *";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Car_Años = 4;
            this.txtDescrip.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescrip.ColorSalida = System.Drawing.Color.White;
            this.txtDescrip.Decimales = 2;
            this.txtDescrip.Guiones = false;
            this.txtDescrip.Location = new System.Drawing.Point(121, 66);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(323, 20);
            this.txtDescrip.TabIndex = 2;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(121, 38);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(89, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 708;
            this.label1.Text = "Id. Tipo Operación *";
            // 
            // cboEst
            // 
            this.cboEst.BackColor = System.Drawing.Color.White;
            this.cboEst.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboEst.ColorSalida = System.Drawing.Color.White;
            this.cboEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEst.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEst.FormattingEnabled = true;
            this.cboEst.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEst.Location = new System.Drawing.Point(121, 177);
            this.cboEst.Name = "cboEst";
            this.cboEst.PasarEnter = true;
            this.cboEst.Size = new System.Drawing.Size(89, 22);
            this.cboEst.TabIndex = 6;
            this.cboEst.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 734;
            this.label14.Text = "Estado *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 735;
            this.label2.Text = "Producto *";
            // 
            // cboProducto
            // 
            this.cboProducto.BackColor = System.Drawing.Color.White;
            this.cboProducto.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboProducto.ColorSalida = System.Drawing.Color.White;
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(121, 9);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.PasarEnter = true;
            this.cboProducto.Size = new System.Drawing.Size(323, 22);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 736;
            this.label3.Text = "Naturaleza *";
            // 
            // cboNat
            // 
            this.cboNat.BackColor = System.Drawing.Color.White;
            this.cboNat.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboNat.ColorSalida = System.Drawing.Color.White;
            this.cboNat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNat.FormattingEnabled = true;
            this.cboNat.Items.AddRange(new object[] {
            "Nuevo",
            "Index",
            "Acuse"});
            this.cboNat.Location = new System.Drawing.Point(121, 93);
            this.cboNat.Name = "cboNat";
            this.cboNat.PasarEnter = true;
            this.cboNat.Size = new System.Drawing.Size(89, 22);
            this.cboNat.TabIndex = 3;
            this.cboNat.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // cboCritico
            // 
            this.cboCritico.BackColor = System.Drawing.Color.White;
            this.cboCritico.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboCritico.ColorSalida = System.Drawing.Color.White;
            this.cboCritico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCritico.Enabled = false;
            this.cboCritico.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCritico.FormattingEnabled = true;
            this.cboCritico.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboCritico.Location = new System.Drawing.Point(121, 121);
            this.cboCritico.Name = "cboCritico";
            this.cboCritico.PasarEnter = true;
            this.cboCritico.Size = new System.Drawing.Size(58, 22);
            this.cboCritico.TabIndex = 4;
            this.cboCritico.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 738;
            this.label4.Text = "Es Crítico *";
            // 
            // cboDigita
            // 
            this.cboDigita.BackColor = System.Drawing.Color.White;
            this.cboDigita.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboDigita.ColorSalida = System.Drawing.Color.White;
            this.cboDigita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDigita.Enabled = false;
            this.cboDigita.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigita.FormattingEnabled = true;
            this.cboDigita.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboDigita.Location = new System.Drawing.Point(121, 149);
            this.cboDigita.Name = "cboDigita";
            this.cboDigita.PasarEnter = true;
            this.cboDigita.Size = new System.Drawing.Size(58, 22);
            this.cboDigita.TabIndex = 5;
            this.cboDigita.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 740;
            this.label5.Text = "Es Digitalizable *";
            // 
            // Frm_Sis_Usuarios_Det
            // 
            this.ClientSize = new System.Drawing.Size(457, 260);
            this.Controls.Add(this.cboDigita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCritico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEst);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
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

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtDescrip;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private MigControls.MigCombobox cboEst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private MigControls.MigCombobox cboProducto;
        private System.Windows.Forms.Label label3;
        private MigControls.MigCombobox cboNat;
        private MigControls.MigCombobox cboCritico;
        private System.Windows.Forms.Label label4;
        private MigControls.MigCombobox cboDigita;
        private System.Windows.Forms.Label label5;

    }
}