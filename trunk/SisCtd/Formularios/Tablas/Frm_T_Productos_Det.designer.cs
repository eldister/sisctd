namespace SisCtd
{
    partial class Frm_T_Productos_Det
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
            this.txtIdprod = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEreg = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboTipo = new MigControls.MigCombobox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new MigControls.MigTextbox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(421, 152);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(338, 152);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 5;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripción *";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Car_Años = 4;
            this.txtDescrip.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescrip.ColorSalida = System.Drawing.Color.White;
            this.txtDescrip.Decimales = 2;
            this.txtDescrip.Location = new System.Drawing.Point(112, 39);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(389, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // txtIdprod
            // 
            this.txtIdprod.BackColor = System.Drawing.Color.White;
            this.txtIdprod.Car_Años = 4;
            this.txtIdprod.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdprod.ColorSalida = System.Drawing.Color.White;
            this.txtIdprod.Decimales = 2;
            this.txtIdprod.Location = new System.Drawing.Point(112, 12);
            this.txtIdprod.MaxLength = 10;
            this.txtIdprod.Name = "txtIdprod";
            this.txtIdprod.PasarEnter = true;
            this.txtIdprod.Size = new System.Drawing.Size(93, 20);
            this.txtIdprod.TabIndex = 0;
            this.txtIdprod.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id. Producto *";
            // 
            // cboEreg
            // 
            this.cboEreg.BackColor = System.Drawing.Color.White;
            this.cboEreg.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboEreg.ColorSalida = System.Drawing.Color.White;
            this.cboEreg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEreg.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEreg.FormattingEnabled = true;
            this.cboEreg.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEreg.Location = new System.Drawing.Point(112, 119);
            this.cboEreg.Name = "cboEreg";
            this.cboEreg.PasarEnter = true;
            this.cboEreg.Size = new System.Drawing.Size(93, 22);
            this.cboEreg.TabIndex = 4;
            this.cboEreg.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Estado *";
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.White;
            this.cboTipo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboTipo.ColorSalida = System.Drawing.Color.White;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "",
            "Activo",
            "Pasivo",
            "Mixto"});
            this.cboTipo.Location = new System.Drawing.Point(112, 92);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.PasarEnter = true;
            this.cboTipo.Size = new System.Drawing.Size(93, 22);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(14, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(96, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Producto *";
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.Info;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(207, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(294, 20);
            this.lblArea.TabIndex = 12;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Area Propietaria";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.White;
            this.txtArea.Car_Años = 4;
            this.txtArea.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtArea.ColorSalida = System.Drawing.Color.White;
            this.txtArea.Decimales = 2;
            this.txtArea.Location = new System.Drawing.Point(111, 66);
            this.txtArea.MaxLength = 10;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasarEnter = true;
            this.txtArea.Size = new System.Drawing.Size(94, 20);
            this.txtArea.TabIndex = 2;
            this.txtArea.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            // 
            // Frm_Mnt_Prod_Det
            // 
            this.ClientSize = new System.Drawing.Size(509, 190);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboEreg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtIdprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Mnt_Prod_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Productos";
            this.Load += new System.EventHandler(this.Frm_T_Productos_Det_Load);
            this.Activated += new System.EventHandler(this.Frm_T_Productos_Det_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_Productos_Det_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtDescrip;
        private MigControls.MigTextbox txtIdprod;
        private System.Windows.Forms.Label label1;
        private MigControls.MigCombobox cboEreg;
        private System.Windows.Forms.Label label14;
        private MigControls.MigCombobox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtArea;

    }
}