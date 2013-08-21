namespace SisCtd
{
    partial class Frm_Rep_Completitud
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.opcFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opcDoc = new System.Windows.Forms.RadioButton();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.btnRep = new System.Windows.Forms.Button();
            this.cboAnio = new MigControls.MigCombobox();
            this.cboMeses = new MigControls.MigCombobox();
            this.opcFechas = new System.Windows.Forms.RadioButton();
            this.opcPeiodos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.opcDetesc = new System.Windows.Forms.RadioButton();
            this.opcDetenv = new System.Windows.Forms.RadioButton();
            this.opcDetescVen = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCerrar.Location = new System.Drawing.Point(369, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(61, 40);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Image = global::SisCtd.Properties.Resources.xls1;
            this.BtnExportar.Location = new System.Drawing.Point(306, 266);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(61, 40);
            this.BtnExportar.TabIndex = 7;
            this.BtnExportar.Text = "E&xcel";
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // opcFile
            // 
            this.opcFile.AutoSize = true;
            this.opcFile.Checked = true;
            this.opcFile.Location = new System.Drawing.Point(21, 12);
            this.opcFile.Name = "opcFile";
            this.opcFile.Size = new System.Drawing.Size(101, 17);
            this.opcFile.TabIndex = 0;
            this.opcFile.TabStop = true;
            this.opcFile.Text = "Envíos a Nextel";
            this.opcFile.UseVisualStyleBackColor = true;
            this.opcFile.Click += new System.EventHandler(this.opcFile_Click);
            this.opcFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 664;
            this.label1.Text = "Del";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 665;
            this.label2.Text = "al";
            // 
            // opcDoc
            // 
            this.opcDoc.AutoSize = true;
            this.opcDoc.Location = new System.Drawing.Point(21, 35);
            this.opcDoc.Name = "opcDoc";
            this.opcDoc.Size = new System.Drawing.Size(137, 17);
            this.opcDoc.TabIndex = 1;
            this.opcDoc.Text = "Producción de personal";
            this.opcDoc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.opcDoc.UseVisualStyleBackColor = true;
            this.opcDoc.Click += new System.EventHandler(this.opcFile_Click);
            this.opcDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(207, 28);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFin.TabIndex = 2;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(98, 28);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(86, 20);
            this.dtpIni.TabIndex = 1;
            // 
            // btnRep
            // 
            this.btnRep.Image = global::SisCtd.Properties.Resources.ATTACHED;
            this.btnRep.Location = new System.Drawing.Point(243, 266);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(61, 40);
            this.btnRep.TabIndex = 6;
            this.btnRep.Text = "&Pantalla";
            this.btnRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // cboAnio
            // 
            this.cboAnio.BackColor = System.Drawing.Color.White;
            this.cboAnio.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboAnio.ColorSalida = System.Drawing.Color.White;
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.Enabled = false;
            this.cboAnio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(220, 73);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.PasarEnter = true;
            this.cboAnio.Size = new System.Drawing.Size(73, 22);
            this.cboAnio.TabIndex = 5;
            this.cboAnio.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // cboMeses
            // 
            this.cboMeses.BackColor = System.Drawing.Color.White;
            this.cboMeses.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboMeses.ColorSalida = System.Drawing.Color.White;
            this.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeses.Enabled = false;
            this.cboMeses.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMeses.Location = new System.Drawing.Point(98, 73);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.PasarEnter = true;
            this.cboMeses.Size = new System.Drawing.Size(116, 22);
            this.cboMeses.TabIndex = 4;
            this.cboMeses.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // opcFechas
            // 
            this.opcFechas.AutoSize = true;
            this.opcFechas.Checked = true;
            this.opcFechas.Location = new System.Drawing.Point(13, 8);
            this.opcFechas.Name = "opcFechas";
            this.opcFechas.Size = new System.Drawing.Size(129, 17);
            this.opcFechas.TabIndex = 0;
            this.opcFechas.TabStop = true;
            this.opcFechas.Text = "Por Rango de Fechas";
            this.opcFechas.UseVisualStyleBackColor = true;
            this.opcFechas.CheckedChanged += new System.EventHandler(this.opcFechas_CheckedChanged);
            // 
            // opcPeiodos
            // 
            this.opcPeiodos.AutoSize = true;
            this.opcPeiodos.Location = new System.Drawing.Point(13, 53);
            this.opcPeiodos.Name = "opcPeiodos";
            this.opcPeiodos.Size = new System.Drawing.Size(80, 17);
            this.opcPeiodos.TabIndex = 3;
            this.opcPeiodos.Text = "Por Periodo";
            this.opcPeiodos.UseVisualStyleBackColor = true;
            this.opcPeiodos.CheckedChanged += new System.EventHandler(this.opcFechas_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboAnio);
            this.panel1.Controls.Add(this.opcFechas);
            this.panel1.Controls.Add(this.cboMeses);
            this.panel1.Controls.Add(this.opcPeiodos);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Location = new System.Drawing.Point(21, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 105);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 682;
            this.label4.Text = "Periodo";
            // 
            // opcDetesc
            // 
            this.opcDetesc.AutoSize = true;
            this.opcDetesc.Location = new System.Drawing.Point(21, 81);
            this.opcDetesc.Name = "opcDetesc";
            this.opcDetesc.Size = new System.Drawing.Size(123, 17);
            this.opcDetesc.TabIndex = 3;
            this.opcDetesc.Text = "Detalle de Escaneos";
            this.opcDetesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.opcDetesc.UseVisualStyleBackColor = true;
            this.opcDetesc.Click += new System.EventHandler(this.opcFile_Click);
            // 
            // opcDetenv
            // 
            this.opcDetenv.AutoSize = true;
            this.opcDetenv.Location = new System.Drawing.Point(21, 58);
            this.opcDetenv.Name = "opcDetenv";
            this.opcDetenv.Size = new System.Drawing.Size(110, 17);
            this.opcDetenv.TabIndex = 2;
            this.opcDetenv.Text = "Detalle de Envíos";
            this.opcDetenv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.opcDetenv.UseVisualStyleBackColor = true;
            this.opcDetenv.Click += new System.EventHandler(this.opcFile_Click);
            // 
            // opcDetescVen
            // 
            this.opcDetescVen.AutoSize = true;
            this.opcDetescVen.Location = new System.Drawing.Point(21, 104);
            this.opcDetescVen.Name = "opcDetescVen";
            this.opcDetescVen.Size = new System.Drawing.Size(254, 17);
            this.opcDetescVen.TabIndex = 4;
            this.opcDetescVen.Text = "Detalle de Escaneos con Pto. Venta y Vendedor";
            this.opcDetescVen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.opcDetescVen.UseVisualStyleBackColor = true;
            // 
            // Frm_Rep_Completitud
            // 
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(this.opcDetescVen);
            this.Controls.Add(this.opcDetenv);
            this.Controls.Add(this.opcDetesc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.opcDoc);
            this.Controls.Add(this.opcFile);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rep_Completitud";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reportes de Completitud";
            this.Load += new System.EventHandler(this.Frm_Rep_Retiros_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Rep_Retiros_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.RadioButton opcFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opcDoc;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Button btnRep;
        private MigControls.MigCombobox cboAnio;
        private MigControls.MigCombobox cboMeses;
        private System.Windows.Forms.RadioButton opcFechas;
        private System.Windows.Forms.RadioButton opcPeiodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton opcDetesc;
        private System.Windows.Forms.RadioButton opcDetenv;
        private System.Windows.Forms.RadioButton opcDetescVen;

    }
}