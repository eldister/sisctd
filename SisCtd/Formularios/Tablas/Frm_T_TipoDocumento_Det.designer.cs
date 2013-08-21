namespace SisCtd
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
            this.txtDeslarga = new MigControls.MigTextbox();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrden = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboCri = new MigControls.MigCombobox();
            this.cboEst = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNivel = new MigControls.MigCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescrip = new MigControls.MigTextbox();
            this.cboSeparadora = new MigControls.MigCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVerif = new MigControls.MigCombobox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDigit = new MigControls.MigCombobox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(452, 235);
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
            this.BtnGrabar.Location = new System.Drawing.Point(369, 235);
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
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripción Larga";
            // 
            // txtDeslarga
            // 
            this.txtDeslarga.BackColor = System.Drawing.Color.White;
            this.txtDeslarga.Car_Años = 4;
            this.txtDeslarga.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDeslarga.ColorSalida = System.Drawing.Color.White;
            this.txtDeslarga.Decimales = 2;
            this.txtDeslarga.Guiones = false;
            this.txtDeslarga.Location = new System.Drawing.Point(114, 64);
            this.txtDeslarga.MaxLength = 200;
            this.txtDeslarga.Multiline = true;
            this.txtDeslarga.Name = "txtDeslarga";
            this.txtDeslarga.PasarEnter = true;
            this.txtDeslarga.Size = new System.Drawing.Size(418, 52);
            this.txtDeslarga.TabIndex = 2;
            this.txtDeslarga.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(114, 12);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código *";
            // 
            // txtOrden
            // 
            this.txtOrden.BackColor = System.Drawing.Color.White;
            this.txtOrden.Car_Años = 4;
            this.txtOrden.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtOrden.ColorSalida = System.Drawing.Color.White;
            this.txtOrden.Decimales = 2;
            this.txtOrden.Guiones = false;
            this.txtOrden.Location = new System.Drawing.Point(114, 173);
            this.txtOrden.MaxLength = 4;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.PasarEnter = true;
            this.txtOrden.Size = new System.Drawing.Size(43, 20);
            this.txtOrden.TabIndex = 8;
            this.txtOrden.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Orden";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Crítico *";
            // 
            // cboCri
            // 
            this.cboCri.BackColor = System.Drawing.Color.White;
            this.cboCri.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboCri.ColorSalida = System.Drawing.Color.White;
            this.cboCri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCri.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCri.FormattingEnabled = true;
            this.cboCri.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboCri.Location = new System.Drawing.Point(351, 148);
            this.cboCri.Name = "cboCri";
            this.cboCri.PasarEnter = true;
            this.cboCri.Size = new System.Drawing.Size(43, 22);
            this.cboCri.TabIndex = 4;
            this.cboCri.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            this.cboCri.SelectedIndexChanged += new System.EventHandler(this.cboCri_SelectedIndexChanged);
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
            this.cboEst.Location = new System.Drawing.Point(114, 148);
            this.cboEst.Name = "cboEst";
            this.cboEst.PasarEnter = true;
            this.cboEst.Size = new System.Drawing.Size(74, 22);
            this.cboEst.TabIndex = 7;
            this.cboEst.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Estado *";
            // 
            // cboNivel
            // 
            this.cboNivel.BackColor = System.Drawing.Color.White;
            this.cboNivel.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboNivel.ColorSalida = System.Drawing.Color.White;
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.Enabled = false;
            this.cboNivel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "1111",
            "1110",
            "1100",
            "1000"});
            this.cboNivel.Location = new System.Drawing.Point(114, 123);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.PasarEnter = true;
            this.cboNivel.Size = new System.Drawing.Size(74, 22);
            this.cboNivel.TabIndex = 6;
            this.cboNivel.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clasificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción *";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Car_Años = 4;
            this.txtDescrip.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescrip.ColorSalida = System.Drawing.Color.White;
            this.txtDescrip.Decimales = 2;
            this.txtDescrip.Guiones = false;
            this.txtDescrip.Location = new System.Drawing.Point(114, 38);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(418, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // cboSeparadora
            // 
            this.cboSeparadora.BackColor = System.Drawing.Color.White;
            this.cboSeparadora.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboSeparadora.ColorSalida = System.Drawing.Color.White;
            this.cboSeparadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeparadora.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeparadora.FormattingEnabled = true;
            this.cboSeparadora.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboSeparadora.Location = new System.Drawing.Point(114, 200);
            this.cboSeparadora.Name = "cboSeparadora";
            this.cboSeparadora.PasarEnter = true;
            this.cboSeparadora.Size = new System.Drawing.Size(335, 22);
            this.cboSeparadora.TabIndex = 9;
            this.cboSeparadora.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Separadora ";
            // 
            // cboVerif
            // 
            this.cboVerif.BackColor = System.Drawing.Color.White;
            this.cboVerif.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboVerif.ColorSalida = System.Drawing.Color.White;
            this.cboVerif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVerif.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVerif.FormattingEnabled = true;
            this.cboVerif.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboVerif.Location = new System.Drawing.Point(351, 123);
            this.cboVerif.Name = "cboVerif";
            this.cboVerif.PasarEnter = true;
            this.cboVerif.Size = new System.Drawing.Size(43, 22);
            this.cboVerif.TabIndex = 3;
            this.cboVerif.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Verificable *";
            // 
            // cboDigit
            // 
            this.cboDigit.BackColor = System.Drawing.Color.White;
            this.cboDigit.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboDigit.ColorSalida = System.Drawing.Color.White;
            this.cboDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDigit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigit.FormattingEnabled = true;
            this.cboDigit.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboDigit.Location = new System.Drawing.Point(351, 173);
            this.cboDigit.Name = "cboDigit";
            this.cboDigit.PasarEnter = true;
            this.cboDigit.Size = new System.Drawing.Size(43, 22);
            this.cboDigit.TabIndex = 5;
            this.cboDigit.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Digitalizable *";
            // 
            // Frm_T_TipoDocumento_Det
            // 
            this.ClientSize = new System.Drawing.Size(540, 274);
            this.Controls.Add(this.cboDigit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboVerif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSeparadora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEst);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboCri);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeslarga);
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
            this.Text = " Documento";
            this.Activated += new System.EventHandler(this.Frm_Mnt_Docum_Det_Activated);
            this.Load += new System.EventHandler(this.Frm_Mnt_Docum_Det_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Mnt_Docum_Det_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtDeslarga;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private MigControls.MigTextbox txtOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private MigControls.MigCombobox cboCri;
        private MigControls.MigCombobox cboEst;
        private System.Windows.Forms.Label label14;
        private MigControls.MigCombobox cboNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtDescrip;
        private MigControls.MigCombobox cboSeparadora;
        private System.Windows.Forms.Label label4;
        private MigControls.MigCombobox cboVerif;
        private System.Windows.Forms.Label label6;
        private MigControls.MigCombobox cboDigit;
        private System.Windows.Forms.Label label8;

    }
}