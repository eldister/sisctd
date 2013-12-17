namespace SisCtd
{
    partial class Frm_T_Empleados_Det
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
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new MigControls.MigTextbox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPosicion = new MigControls.MigTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.txtOficina = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombres = new MigControls.MigTextbox();
            this.ChkResponsable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(149, 12);
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
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 736;
            this.label3.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.White;
            this.txtArea.Car_Años = 4;
            this.txtArea.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtArea.ColorSalida = System.Drawing.Color.White;
            this.txtArea.Decimales = 2;
            this.txtArea.Guiones = false;
            this.txtArea.Location = new System.Drawing.Point(149, 62);
            this.txtArea.MaxLength = 10;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasarEnter = true;
            this.txtArea.Size = new System.Drawing.Size(62, 20);
            this.txtArea.TabIndex = 3;
            this.txtArea.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtArea.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.Info;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(217, 62);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(373, 20);
            this.lblArea.TabIndex = 4;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cboEstado.Location = new System.Drawing.Point(149, 134);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(93, 22);
            this.cboEstado.TabIndex = 8;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 744;
            this.label14.Text = "Estado *";
            // 
            // lblPosicion
            // 
            this.lblPosicion.BackColor = System.Drawing.SystemColors.Info;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Location = new System.Drawing.Point(217, 86);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(372, 20);
            this.lblPosicion.TabIndex = 746;
            this.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPosicion
            // 
            this.txtPosicion.BackColor = System.Drawing.Color.White;
            this.txtPosicion.Car_Años = 4;
            this.txtPosicion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtPosicion.ColorSalida = System.Drawing.Color.White;
            this.txtPosicion.Decimales = 2;
            this.txtPosicion.Guiones = false;
            this.txtPosicion.Location = new System.Drawing.Point(149, 86);
            this.txtPosicion.MaxLength = 10;
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.PasarEnter = true;
            this.txtPosicion.Size = new System.Drawing.Size(62, 20);
            this.txtPosicion.TabIndex = 5;
            this.txtPosicion.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtPosicion.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 747;
            this.label4.Text = "Posicion";
            // 
            // lblOficina
            // 
            this.lblOficina.BackColor = System.Drawing.SystemColors.Info;
            this.lblOficina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOficina.Location = new System.Drawing.Point(217, 110);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(372, 20);
            this.lblOficina.TabIndex = 749;
            this.lblOficina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.Color.White;
            this.txtOficina.Car_Años = 4;
            this.txtOficina.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtOficina.ColorSalida = System.Drawing.Color.White;
            this.txtOficina.Decimales = 2;
            this.txtOficina.Guiones = false;
            this.txtOficina.Location = new System.Drawing.Point(149, 110);
            this.txtOficina.MaxLength = 10;
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.PasarEnter = true;
            this.txtOficina.Size = new System.Drawing.Size(62, 20);
            this.txtOficina.TabIndex = 6;
            this.txtOficina.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtOficina.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtOficina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 750;
            this.label5.Text = "Oficina";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(614, 152);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(535, 152);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 9;
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
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 723;
            this.label7.Text = "Nombres y Apellidos *";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.Car_Años = 4;
            this.txtNombres.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNombres.ColorSalida = System.Drawing.Color.White;
            this.txtNombres.Decimales = 2;
            this.txtNombres.Guiones = false;
            this.txtNombres.Location = new System.Drawing.Point(149, 35);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasarEnter = true;
            this.txtNombres.Size = new System.Drawing.Size(441, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // ChkResponsable
            // 
            this.ChkResponsable.AutoSize = true;
            this.ChkResponsable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkResponsable.Location = new System.Drawing.Point(603, 66);
            this.ChkResponsable.Name = "ChkResponsable";
            this.ChkResponsable.Size = new System.Drawing.Size(89, 18);
            this.ChkResponsable.TabIndex = 4;
            this.ChkResponsable.Text = "Responsable";
            this.ChkResponsable.UseVisualStyleBackColor = true;
            // 
            // Frm_T_Empleados_Det
            // 
            this.ClientSize = new System.Drawing.Size(699, 182);
            this.Controls.Add(this.ChkResponsable);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_T_Empleados_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Frm_T_Empleados_Det_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtArea;
        private System.Windows.Forms.Label lblArea;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPosicion;
        private MigControls.MigTextbox txtPosicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOficina;
        private MigControls.MigTextbox txtOficina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtNombres;
        private System.Windows.Forms.CheckBox ChkResponsable;

    }
}