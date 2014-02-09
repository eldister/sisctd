namespace SisCtd
{
    partial class Frm_Rep_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_Reportes));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipos = new MigControls.MigCombobox();
            this.cboArea = new MigControls.MigCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.RBPro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.RBDet = new System.Windows.Forms.RadioButton();
            this.RBRes = new System.Windows.Forms.RadioButton();
            this.cboEstado = new MigControls.MigCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblTabla = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bEjecutar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.lstTablas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 813;
            this.label2.Text = "Seleccione una tabla";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CboTipos);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RBPro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RBDet);
            this.groupBox1.Controls.Add(this.RBRes);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 299);
            this.groupBox1.TabIndex = 816;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 93;
            this.label6.Text = "Tipo";
            // 
            // CboTipos
            // 
            this.CboTipos.BackColor = System.Drawing.Color.White;
            this.CboTipos.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.CboTipos.ColorSalida = System.Drawing.Color.White;
            this.CboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipos.FormattingEnabled = true;
            this.CboTipos.Items.AddRange(new object[] {
            "Envio",
            "Recepcion"});
            this.CboTipos.Location = new System.Drawing.Point(236, 122);
            this.CboTipos.Name = "CboTipos";
            this.CboTipos.PasarEnter = true;
            this.CboTipos.Size = new System.Drawing.Size(112, 22);
            this.CboTipos.TabIndex = 92;
            this.CboTipos.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // cboArea
            // 
            this.cboArea.BackColor = System.Drawing.Color.White;
            this.cboArea.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboArea.ColorSalida = System.Drawing.Color.White;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(236, 64);
            this.cboArea.Name = "cboArea";
            this.cboArea.PasarEnter = true;
            this.cboArea.Size = new System.Drawing.Size(417, 22);
            this.cboArea.TabIndex = 91;
            this.cboArea.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Area";
            // 
            // RBPro
            // 
            this.RBPro.AutoSize = true;
            this.RBPro.Location = new System.Drawing.Point(464, 198);
            this.RBPro.Name = "RBPro";
            this.RBPro.Size = new System.Drawing.Size(79, 17);
            this.RBPro.TabIndex = 89;
            this.RBPro.TabStop = true;
            this.RBPro.Text = "Produccion";
            this.RBPro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tipo de Reporte           ";
            // 
            // RBDet
            // 
            this.RBDet.AutoSize = true;
            this.RBDet.Checked = true;
            this.RBDet.Location = new System.Drawing.Point(236, 199);
            this.RBDet.Name = "RBDet";
            this.RBDet.Size = new System.Drawing.Size(58, 17);
            this.RBDet.TabIndex = 84;
            this.RBDet.TabStop = true;
            this.RBDet.Text = "Detalle";
            this.RBDet.UseVisualStyleBackColor = true;
            // 
            // RBRes
            // 
            this.RBRes.AutoSize = true;
            this.RBRes.Location = new System.Drawing.Point(351, 198);
            this.RBRes.Name = "RBRes";
            this.RBRes.Size = new System.Drawing.Size(70, 17);
            this.RBRes.TabIndex = 85;
            this.RBRes.TabStop = true;
            this.RBRes.Text = "Resumen";
            this.RBRes.UseVisualStyleBackColor = true;
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
            "Pendiente",
            "Terminado",
            "Cerrado",
            "Todos"});
            this.cboEstado.Location = new System.Drawing.Point(236, 94);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(112, 22);
            this.cboEstado.TabIndex = 75;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "Estado ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(355, 166);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(99, 22);
            this.dtpHasta.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Desde";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(69, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Rango de Fechas    ";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(242, 166);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(95, 22);
            this.dtpDesde.TabIndex = 77;
            // 
            // lblTabla
            // 
            this.lblTabla.BackColor = System.Drawing.SystemColors.Info;
            this.lblTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTabla.Location = new System.Drawing.Point(12, 179);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(789, 33);
            this.lblTabla.TabIndex = 815;
            this.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarraSis
            // 
            this.BarraSis.Dock = System.Windows.Forms.DockStyle.None;
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEjecutar,
            this.toolStripButton4,
            this.bExportar,
            this.toolStripSeparator2,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(10, 4);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(164, 29);
            this.BarraSis.TabIndex = 814;
            // 
            // bEjecutar
            // 
            this.bEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("bEjecutar.Image")));
            this.bEjecutar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEjecutar.Name = "bEjecutar";
            this.bEjecutar.Size = new System.Drawing.Size(69, 20);
            this.bEjecutar.Text = "&Ejecutar";
            this.bEjecutar.ToolTipText = "Ejecutar (F3)";
            this.bEjecutar.Click += new System.EventHandler(this.bEjecutar_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 23);
            // 
            // bExportar
            // 
            this.bExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bExportar.Image = global::SisCtd.Properties.Resources.xls;
            this.bExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(24, 24);
            this.bExportar.Text = "E&xportar";
            this.bExportar.ToolTipText = "Exportar a Excel (F6)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bCerrar
            // 
            this.bCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(27, 26);
            this.bCerrar.Text = "&Cerrar (Esc)";
            this.bCerrar.ToolTipText = "Cerrar (Esc)";
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lstTablas
            // 
            this.lstTablas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.ItemHeight = 14;
            this.lstTablas.Location = new System.Drawing.Point(12, 46);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(544, 130);
            this.lstTablas.TabIndex = 812;
            // 
            // Frm_Rep_Reportes
            // 
            this.ClientSize = new System.Drawing.Size(963, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.BarraSis);
            this.Controls.Add(this.lstTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rep_Reportes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Frm_Rep_Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RBDet;
        private System.Windows.Forms.RadioButton RBRes;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bEjecutar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        private System.Windows.Forms.ListBox lstTablas;
        private System.Windows.Forms.Label label4;
        private MigControls.MigCombobox cboArea;
        private System.Windows.Forms.Label label6;
        private MigControls.MigCombobox CboTipos;


    }
}