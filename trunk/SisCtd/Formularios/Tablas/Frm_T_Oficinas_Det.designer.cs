namespace BESisCtd
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
            this.txtDescrip = new MigControls.MigTextbox();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCierre = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTerritorio = new MigControls.MigCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbigeo = new MigControls.MigTextbox();
            this.lblUbigeo = new System.Windows.Forms.Label();
            this.txtDirec = new MigControls.MigTextbox();
            this.cboRecojo = new MigControls.MigCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(410, 180);
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
            this.BtnGrabar.Location = new System.Drawing.Point(329, 180);
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
            this.label7.Location = new System.Drawing.Point(14, 39);
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
            this.txtDescrip.Location = new System.Drawing.Point(108, 36);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(382, 20);
            this.txtDescrip.TabIndex = 1;
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
            this.txtCodigo.Location = new System.Drawing.Point(108, 13);
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
            // cboCierre
            // 
            this.cboCierre.BackColor = System.Drawing.Color.White;
            this.cboCierre.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboCierre.ColorSalida = System.Drawing.Color.White;
            this.cboCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCierre.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCierre.FormattingEnabled = true;
            this.cboCierre.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cboCierre.Location = new System.Drawing.Point(108, 155);
            this.cboCierre.Name = "cboCierre";
            this.cboCierre.PasarEnter = true;
            this.cboCierre.Size = new System.Drawing.Size(62, 22);
            this.cboCierre.TabIndex = 7;
            this.cboCierre.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 734;
            this.label14.Text = "Cerrado *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 735;
            this.label2.Text = "Territorio *";
            // 
            // cboTerritorio
            // 
            this.cboTerritorio.BackColor = System.Drawing.Color.White;
            this.cboTerritorio.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboTerritorio.ColorSalida = System.Drawing.Color.White;
            this.cboTerritorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerritorio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTerritorio.FormattingEnabled = true;
            this.cboTerritorio.Location = new System.Drawing.Point(108, 59);
            this.cboTerritorio.Name = "cboTerritorio";
            this.cboTerritorio.PasarEnter = true;
            this.cboTerritorio.Size = new System.Drawing.Size(382, 22);
            this.cboTerritorio.TabIndex = 2;
            this.cboTerritorio.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
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
            this.txtUbigeo.Location = new System.Drawing.Point(108, 84);
            this.txtUbigeo.MaxLength = 10;
            this.txtUbigeo.Name = "txtUbigeo";
            this.txtUbigeo.PasarEnter = true;
            this.txtUbigeo.Size = new System.Drawing.Size(62, 20);
            this.txtUbigeo.TabIndex = 3;
            this.txtUbigeo.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtUbigeo.TextChanged += new System.EventHandler(this.txtUbigeo_TextChanged);
            this.txtUbigeo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUbigeo_KeyDown);
            // 
            // lblUbigeo
            // 
            this.lblUbigeo.BackColor = System.Drawing.SystemColors.Info;
            this.lblUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbigeo.Location = new System.Drawing.Point(172, 84);
            this.lblUbigeo.Name = "lblUbigeo";
            this.lblUbigeo.Size = new System.Drawing.Size(318, 20);
            this.lblUbigeo.TabIndex = 4;
            this.lblUbigeo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDirec
            // 
            this.txtDirec.BackColor = System.Drawing.Color.White;
            this.txtDirec.Car_Años = 4;
            this.txtDirec.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDirec.ColorSalida = System.Drawing.Color.White;
            this.txtDirec.Decimales = 2;
            this.txtDirec.Guiones = false;
            this.txtDirec.Location = new System.Drawing.Point(108, 107);
            this.txtDirec.MaxLength = 200;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.PasarEnter = true;
            this.txtDirec.Size = new System.Drawing.Size(382, 20);
            this.txtDirec.TabIndex = 5;
            this.txtDirec.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // cboRecojo
            // 
            this.cboRecojo.BackColor = System.Drawing.Color.White;
            this.cboRecojo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboRecojo.ColorSalida = System.Drawing.Color.White;
            this.cboRecojo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecojo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecojo.FormattingEnabled = true;
            this.cboRecojo.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cboRecojo.Location = new System.Drawing.Point(108, 130);
            this.cboRecojo.Name = "cboRecojo";
            this.cboRecojo.PasarEnter = true;
            this.cboRecojo.Size = new System.Drawing.Size(62, 22);
            this.cboRecojo.TabIndex = 6;
            this.cboRecojo.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 741;
            this.label4.Text = "Recojo *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 742;
            this.label5.Text = "Dirección";
            // 
            // Frm_Mnt_Oficinas_Det
            // 
            this.ClientSize = new System.Drawing.Size(499, 219);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRecojo);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.lblUbigeo);
            this.Controls.Add(this.txtUbigeo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTerritorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCierre);
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
            this.Name = "Frm_Mnt_Oficinas_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Oficina";
            this.Load += new System.EventHandler(this.Frm_T_Oficinas_Det_Load);
            this.Activated += new System.EventHandler(this.Frm_T_Oficinas_Det_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_Oficinas_Det_KeyPress);
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
        private MigControls.MigCombobox cboCierre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private MigControls.MigCombobox cboTerritorio;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtUbigeo;
        private System.Windows.Forms.Label lblUbigeo;
        private MigControls.MigTextbox txtDirec;
        private MigControls.MigCombobox cboRecojo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}