namespace SisCtd
{
    partial class Frm_Rep_Registros
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
            this.opcCont = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOfi = new MigControls.MigTextbox();
            this.opcDoc = new System.Windows.Forms.RadioButton();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.lblOfi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opcDato = new System.Windows.Forms.RadioButton();
            this.opcConsol = new System.Windows.Forms.RadioButton();
            this.cboAño = new MigControls.MigCombobox();
            this.cboMeses = new MigControls.MigCombobox();
            this.opcFechas = new System.Windows.Forms.RadioButton();
            this.opcPeriodos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodbar = new MigControls.MigTextbox();
            this.opcCaja = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRec = new MigControls.MigCombobox();
            this.panProces = new System.Windows.Forms.Panel();
            this.lblProc = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            this.lblIdtiptran = new System.Windows.Forms.Label();
            this.txtIdtiptran = new MigControls.MigTextbox();
            this.opcResumenOpe = new System.Windows.Forms.RadioButton();
            this.opcIndex = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panProces.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCerrar.Location = new System.Drawing.Point(426, 365);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(61, 40);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Image = global::SisCtd.Properties.Resources.xls1;
            this.BtnExportar.Location = new System.Drawing.Point(363, 365);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(61, 40);
            this.BtnExportar.TabIndex = 11;
            this.BtnExportar.Text = "E&xcel";
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // opcFile
            // 
            this.opcFile.AutoSize = true;
            this.opcFile.Checked = true;
            this.opcFile.Location = new System.Drawing.Point(21, 10);
            this.opcFile.Name = "opcFile";
            this.opcFile.Size = new System.Drawing.Size(62, 17);
            this.opcFile.TabIndex = 0;
            this.opcFile.Text = "&Legajos";
            this.opcFile.UseVisualStyleBackColor = true;
            this.opcFile.Click += new System.EventHandler(this.opcFile_Click);
            this.opcFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // opcCont
            // 
            this.opcCont.AutoSize = true;
            this.opcCont.Location = new System.Drawing.Point(21, 54);
            this.opcCont.Name = "opcCont";
            this.opcCont.Size = new System.Drawing.Size(85, 17);
            this.opcCont.TabIndex = 2;
            this.opcCont.Text = "&Operaciones";
            this.opcCont.UseVisualStyleBackColor = true;
            this.opcCont.Click += new System.EventHandler(this.opcFile_Click);
            this.opcCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 664;
            this.label1.Text = "Del";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 665;
            this.label2.Text = "al";
            // 
            // txtOfi
            // 
            this.txtOfi.BackColor = System.Drawing.Color.White;
            this.txtOfi.Car_Años = 4;
            this.txtOfi.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtOfi.ColorSalida = System.Drawing.Color.White;
            this.txtOfi.Decimales = 2;
            this.txtOfi.Guiones = false;
            this.txtOfi.Location = new System.Drawing.Point(141, 293);
            this.txtOfi.MaxLength = 10;
            this.txtOfi.Name = "txtOfi";
            this.txtOfi.PasarEnter = true;
            this.txtOfi.Size = new System.Drawing.Size(80, 20);
            this.txtOfi.TabIndex = 9;
            this.txtOfi.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtOfi.TextChanged += new System.EventHandler(this.txtOfi_TextChanged);
            this.txtOfi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAyudaF1);
            // 
            // opcDoc
            // 
            this.opcDoc.AutoSize = true;
            this.opcDoc.Location = new System.Drawing.Point(21, 76);
            this.opcDoc.Name = "opcDoc";
            this.opcDoc.Size = new System.Drawing.Size(85, 17);
            this.opcDoc.TabIndex = 3;
            this.opcDoc.Text = "&Documentos";
            this.opcDoc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.opcDoc.UseVisualStyleBackColor = true;
            this.opcDoc.Click += new System.EventHandler(this.opcFile_Click);
            this.opcDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(292, 8);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(183, 8);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(86, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // lblOfi
            // 
            this.lblOfi.BackColor = System.Drawing.SystemColors.Info;
            this.lblOfi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOfi.Location = new System.Drawing.Point(222, 293);
            this.lblOfi.Name = "lblOfi";
            this.lblOfi.Size = new System.Drawing.Size(262, 20);
            this.lblOfi.TabIndex = 671;
            this.lblOfi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 675;
            this.label6.Text = "Oficina de Procedencia";
            // 
            // opcDato
            // 
            this.opcDato.AutoSize = true;
            this.opcDato.Location = new System.Drawing.Point(21, 98);
            this.opcDato.Name = "opcDato";
            this.opcDato.Size = new System.Drawing.Size(53, 17);
            this.opcDato.TabIndex = 4;
            this.opcDato.Text = "D&atos";
            this.opcDato.UseVisualStyleBackColor = true;
            this.opcDato.Click += new System.EventHandler(this.opcFile_Click);
            this.opcDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // opcConsol
            // 
            this.opcConsol.AutoSize = true;
            this.opcConsol.Location = new System.Drawing.Point(21, 120);
            this.opcConsol.Name = "opcConsol";
            this.opcConsol.Size = new System.Drawing.Size(83, 17);
            this.opcConsol.TabIndex = 5;
            this.opcConsol.Text = "Con&solidado";
            this.opcConsol.UseVisualStyleBackColor = true;
            this.opcConsol.Click += new System.EventHandler(this.opcFile_Click);
            this.opcConsol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opcFile_KeyPress);
            // 
            // cboAño
            // 
            this.cboAño.BackColor = System.Drawing.Color.White;
            this.cboAño.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboAño.ColorSalida = System.Drawing.Color.White;
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.Enabled = false;
            this.cboAño.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(275, 39);
            this.cboAño.Name = "cboAño";
            this.cboAño.PasarEnter = true;
            this.cboAño.Size = new System.Drawing.Size(73, 22);
            this.cboAño.TabIndex = 6;
            this.cboAño.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
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
            this.cboMeses.Location = new System.Drawing.Point(153, 39);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.PasarEnter = true;
            this.cboMeses.Size = new System.Drawing.Size(116, 22);
            this.cboMeses.TabIndex = 5;
            this.cboMeses.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // opcFechas
            // 
            this.opcFechas.AutoSize = true;
            this.opcFechas.Checked = true;
            this.opcFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opcFechas.Location = new System.Drawing.Point(13, 10);
            this.opcFechas.Name = "opcFechas";
            this.opcFechas.Size = new System.Drawing.Size(129, 17);
            this.opcFechas.TabIndex = 0;
            this.opcFechas.TabStop = true;
            this.opcFechas.Text = "Fecha de Registro";
            this.opcFechas.UseVisualStyleBackColor = true;
            this.opcFechas.CheckedChanged += new System.EventHandler(this.opcFechas_CheckedChanged);
            // 
            // opcPeriodos
            // 
            this.opcPeriodos.AutoSize = true;
            this.opcPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcPeriodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opcPeriodos.Location = new System.Drawing.Point(13, 42);
            this.opcPeriodos.Name = "opcPeriodos";
            this.opcPeriodos.Size = new System.Drawing.Size(91, 17);
            this.opcPeriodos.TabIndex = 1;
            this.opcPeriodos.Text = "Por Periodo";
            this.opcPeriodos.UseVisualStyleBackColor = true;
            this.opcPeriodos.CheckedChanged += new System.EventHandler(this.opcFechas_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCodbar);
            this.panel1.Controls.Add(this.opcCaja);
            this.panel1.Controls.Add(this.cboAño);
            this.panel1.Controls.Add(this.opcFechas);
            this.panel1.Controls.Add(this.cboMeses);
            this.panel1.Controls.Add(this.opcPeriodos);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Location = new System.Drawing.Point(21, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 107);
            this.panel1.TabIndex = 8;
            // 
            // txtCodbar
            // 
            this.txtCodbar.BackColor = System.Drawing.Color.White;
            this.txtCodbar.Car_Años = 4;
            this.txtCodbar.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodbar.ColorSalida = System.Drawing.Color.White;
            this.txtCodbar.Decimales = 2;
            this.txtCodbar.Guiones = false;
            this.txtCodbar.Location = new System.Drawing.Point(153, 72);
            this.txtCodbar.MaxLength = 10;
            this.txtCodbar.Name = "txtCodbar";
            this.txtCodbar.PasarEnter = true;
            this.txtCodbar.Size = new System.Drawing.Size(86, 20);
            this.txtCodbar.TabIndex = 7;
            this.txtCodbar.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            // 
            // opcCaja
            // 
            this.opcCaja.AutoSize = true;
            this.opcCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opcCaja.Location = new System.Drawing.Point(13, 74);
            this.opcCaja.Name = "opcCaja";
            this.opcCaja.Size = new System.Drawing.Size(73, 17);
            this.opcCaja.TabIndex = 2;
            this.opcCaja.Text = "Por Caja";
            this.opcCaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 682;
            this.label3.Text = "Tipo de Recojo";
            // 
            // cboRec
            // 
            this.cboRec.BackColor = System.Drawing.Color.White;
            this.cboRec.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboRec.ColorSalida = System.Drawing.Color.White;
            this.cboRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRec.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRec.FormattingEnabled = true;
            this.cboRec.Items.AddRange(new object[] {
            "Stock",
            "Día día",
            "Ambos"});
            this.cboRec.Location = new System.Drawing.Point(141, 316);
            this.cboRec.Name = "cboRec";
            this.cboRec.PasarEnter = true;
            this.cboRec.Size = new System.Drawing.Size(80, 22);
            this.cboRec.TabIndex = 10;
            this.cboRec.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // panProces
            // 
            this.panProces.BackColor = System.Drawing.SystemColors.Control;
            this.panProces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panProces.Controls.Add(this.lblProc);
            this.panProces.Controls.Add(this.btnProc);
            this.panProces.Location = new System.Drawing.Point(2, 359);
            this.panProces.Name = "panProces";
            this.panProces.Size = new System.Drawing.Size(251, 63);
            this.panProces.TabIndex = 683;
            this.panProces.Visible = false;
            // 
            // lblProc
            // 
            this.lblProc.BackColor = System.Drawing.SystemColors.Info;
            this.lblProc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProc.Location = new System.Drawing.Point(3, 32);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(235, 20);
            this.lblProc.TabIndex = 689;
            this.lblProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(3, 4);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(98, 25);
            this.btnProc.TabIndex = 0;
            this.btnProc.Text = "&Procesar Datos";
            this.btnProc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // lblIdtiptran
            // 
            this.lblIdtiptran.BackColor = System.Drawing.SystemColors.Info;
            this.lblIdtiptran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdtiptran.Location = new System.Drawing.Point(201, 52);
            this.lblIdtiptran.Name = "lblIdtiptran";
            this.lblIdtiptran.Size = new System.Drawing.Size(283, 20);
            this.lblIdtiptran.TabIndex = 685;
            this.lblIdtiptran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdtiptran
            // 
            this.txtIdtiptran.BackColor = System.Drawing.Color.White;
            this.txtIdtiptran.Car_Años = 4;
            this.txtIdtiptran.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdtiptran.ColorSalida = System.Drawing.Color.White;
            this.txtIdtiptran.Decimales = 2;
            this.txtIdtiptran.Guiones = false;
            this.txtIdtiptran.Location = new System.Drawing.Point(119, 52);
            this.txtIdtiptran.MaxLength = 10;
            this.txtIdtiptran.Name = "txtIdtiptran";
            this.txtIdtiptran.PasarEnter = true;
            this.txtIdtiptran.Size = new System.Drawing.Size(80, 20);
            this.txtIdtiptran.TabIndex = 7;
            this.txtIdtiptran.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdtiptran.TextChanged += new System.EventHandler(this.txtIdtiptran_TextChanged);
            this.txtIdtiptran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAyudaF1);
            // 
            // opcResumenOpe
            // 
            this.opcResumenOpe.AutoSize = true;
            this.opcResumenOpe.Location = new System.Drawing.Point(21, 142);
            this.opcResumenOpe.Name = "opcResumenOpe";
            this.opcResumenOpe.Size = new System.Drawing.Size(140, 17);
            this.opcResumenOpe.TabIndex = 6;
            this.opcResumenOpe.Text = "&Resúmen por Operación";
            this.opcResumenOpe.UseVisualStyleBackColor = true;
            this.opcResumenOpe.Click += new System.EventHandler(this.opcFile_Click);
            // 
            // opcIndex
            // 
            this.opcIndex.AutoSize = true;
            this.opcIndex.Location = new System.Drawing.Point(21, 32);
            this.opcIndex.Name = "opcIndex";
            this.opcIndex.Size = new System.Drawing.Size(77, 17);
            this.opcIndex.TabIndex = 1;
            this.opcIndex.Text = "&Indexación";
            this.opcIndex.UseVisualStyleBackColor = true;
            this.opcIndex.Click += new System.EventHandler(this.opcFile_Click);
            // 
            // Frm_Rep_Registros
            // 
            this.ClientSize = new System.Drawing.Size(504, 427);
            this.Controls.Add(this.opcIndex);
            this.Controls.Add(this.opcResumenOpe);
            this.Controls.Add(this.lblIdtiptran);
            this.Controls.Add(this.txtIdtiptran);
            this.Controls.Add(this.panProces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRec);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.opcConsol);
            this.Controls.Add(this.opcDato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOfi);
            this.Controls.Add(this.opcDoc);
            this.Controls.Add(this.txtOfi);
            this.Controls.Add(this.opcCont);
            this.Controls.Add(this.opcFile);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rep_Registros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reporte de Registros";
            this.Load += new System.EventHandler(this.Frm_Rep_Registros_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Rep_Registros_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panProces.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.RadioButton opcFile;
        private System.Windows.Forms.RadioButton opcCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtOfi;
        private System.Windows.Forms.RadioButton opcDoc;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label lblOfi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton opcDato;
        private System.Windows.Forms.RadioButton opcConsol;
        private MigControls.MigCombobox cboAño;
        private MigControls.MigCombobox cboMeses;
        private System.Windows.Forms.RadioButton opcFechas;
        private System.Windows.Forms.RadioButton opcPeriodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private MigControls.MigCombobox cboRec;
        private System.Windows.Forms.Panel panProces;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.RadioButton opcCaja;
        private MigControls.MigTextbox txtCodbar;
        private System.Windows.Forms.Label lblIdtiptran;
        private MigControls.MigTextbox txtIdtiptran;
        private System.Windows.Forms.RadioButton opcResumenOpe;
        private System.Windows.Forms.RadioButton opcIndex;

    }
}