namespace SisCtd
{
    partial class Frm_T_TipoOperacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.txtDescrip = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIddocu = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bModificar = new System.Windows.Forms.ToolStripButton();
            this.bEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bCritico = new System.Windows.Forms.ToolStripButton();
            this.bDgita = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.bHistorial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dg1 = new MigControls.MigDataGridView();
            this.Dg2 = new MigControls.MigDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDigita = new System.Windows.Forms.Button();
            this.btnCritico = new System.Windows.Forms.Button();
            this.lblTransac = new System.Windows.Forms.Label();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.Stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtDescrip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIddocu);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 32);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
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
            "Activos",
            "Inactivos",
            "Todos"});
            this.cboEstado.Location = new System.Drawing.Point(623, 5);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(92, 22);
            this.cboEstado.TabIndex = 2;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Car_Años = 4;
            this.txtDescrip.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescrip.ColorSalida = System.Drawing.Color.White;
            this.txtDescrip.Decimales = 2;
            this.txtDescrip.Guiones = false;
            this.txtDescrip.Location = new System.Drawing.Point(285, 6);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(259, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtDescrip.TextChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // txtIddocu
            // 
            this.txtIddocu.BackColor = System.Drawing.Color.White;
            this.txtIddocu.Car_Años = 4;
            this.txtIddocu.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIddocu.ColorSalida = System.Drawing.Color.White;
            this.txtIddocu.Decimales = 2;
            this.txtIddocu.Guiones = false;
            this.txtIddocu.Location = new System.Drawing.Point(120, 6);
            this.txtIddocu.MaxLength = 10;
            this.txtIddocu.Name = "txtIddocu";
            this.txtIddocu.PasarEnter = true;
            this.txtIddocu.Size = new System.Drawing.Size(80, 20);
            this.txtIddocu.TabIndex = 0;
            this.txtIddocu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIddocu.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIddocu.TextChanged += new System.EventHandler(this.txtIddocu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Id Tipo de Operación";
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNuevo,
            this.bModificar,
            this.bEliminar,
            this.toolStripSeparator1,
            this.bCritico,
            this.bDgita,
            this.toolStripButton4,
            this.bExportar,
            this.bHistorial,
            this.toolStripSeparator2,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(911, 23);
            this.BarraSis.TabIndex = 3;
            // 
            // bNuevo
            // 
            this.bNuevo.Image = global::SisCtd.Properties.Resources.Toolbar_New;
            this.bNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(58, 20);
            this.bNuevo.Text = "&Nuevo";
            this.bNuevo.ToolTipText = "Nuevo (F3)";
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bModificar
            // 
            this.bModificar.Image = global::SisCtd.Properties.Resources.control;
            this.bModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(70, 20);
            this.bModificar.Text = "&Modificar";
            this.bModificar.ToolTipText = "Modificar (F2)";
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Image = global::SisCtd.Properties.Resources.Toolbar_Delete;
            this.bEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(63, 20);
            this.bEliminar.Text = "&Eliminar";
            this.bEliminar.ToolTipText = "Eliminar (F4)";
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bCritico
            // 
            this.bCritico.Image = global::SisCtd.Properties.Resources.Aceptar;
            this.bCritico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCritico.Name = "bCritico";
            this.bCritico.Size = new System.Drawing.Size(57, 20);
            this.bCritico.Text = "&Crítico";
            this.bCritico.ToolTipText = "Asignar Crítico";
            this.bCritico.Click += new System.EventHandler(this.bCritico_Click);
            // 
            // bDgita
            // 
            this.bDgita.Image = global::SisCtd.Properties.Resources.iconoima;
            this.bDgita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDgita.Name = "bDgita";
            this.bDgita.Size = new System.Drawing.Size(83, 20);
            this.bDgita.Text = "&Digitalizable";
            this.bDgita.ToolTipText = "Asignar Digitalizable";
            this.bDgita.Click += new System.EventHandler(this.bDgita_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 23);
            // 
            // bExportar
            // 
            this.bExportar.Image = global::SisCtd.Properties.Resources.xls;
            this.bExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(69, 20);
            this.bExportar.Text = "E&xportar";
            this.bExportar.ToolTipText = "Exportar (F7)";
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // bHistorial
            // 
            this.bHistorial.Image = global::SisCtd.Properties.Resources.xls;
            this.bHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bHistorial.Name = "bHistorial";
            this.bHistorial.Size = new System.Drawing.Size(110, 20);
            this.bHistorial.Text = "E&xportar Historial";
            this.bHistorial.Click += new System.EventHandler(this.bHistorial_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bCerrar
            // 
            this.bCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(47, 20);
            this.bCerrar.Text = "&Salir";
            this.bCerrar.ToolTipText = "Salir (Esc)";
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(68, 240);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(59, 24);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Stb
            // 
            this.Stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMensaje});
            this.Stb.Location = new System.Drawing.Point(0, 321);
            this.Stb.Name = "Stb";
            this.Stb.Size = new System.Drawing.Size(911, 22);
            this.Stb.TabIndex = 662;
            this.Stb.Text = "statusStrip1";
            // 
            // LblMensaje
            // 
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(31, 17);
            this.LblMensaje.Text = ".*.*.*.";
            // 
            // Dg1
            // 
            this.Dg1.AllowUserToAddRows = false;
            this.Dg1.AllowUserToDeleteRows = false;
            this.Dg1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.Dg1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Dg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dg1.Location = new System.Drawing.Point(0, 55);
            this.Dg1.MultiSelect = false;
            this.Dg1.Name = "Dg1";
            this.Dg1.PasarEnter = false;
            this.Dg1.ReadOnly = true;
            this.Dg1.RowHeadersWidth = 25;
            this.Dg1.RowTemplate.Height = 18;
            this.Dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg1.Size = new System.Drawing.Size(911, 266);
            this.Dg1.StandardTab = true;
            this.Dg1.TabIndex = 0;
            this.Dg1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg1_CellDoubleClick);
            this.Dg1.SelectionChanged += new System.EventHandler(this.Dg1_SelectionChanged);
            this.Dg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dg1_KeyPress);
            // 
            // Dg2
            // 
            this.Dg2.AllowUserToAddRows = false;
            this.Dg2.AllowUserToDeleteRows = false;
            this.Dg2.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.Dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dg2.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Dg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg2.Location = new System.Drawing.Point(6, 35);
            this.Dg2.MultiSelect = false;
            this.Dg2.Name = "Dg2";
            this.Dg2.PasarEnter = false;
            this.Dg2.ReadOnly = true;
            this.Dg2.RowHeadersWidth = 25;
            this.Dg2.RowTemplate.Height = 18;
            this.Dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg2.Size = new System.Drawing.Size(831, 199);
            this.Dg2.StandardTab = true;
            this.Dg2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDigita);
            this.panel2.Controls.Add(this.btnCritico);
            this.panel2.Controls.Add(this.lblTransac);
            this.panel2.Controls.Add(this.btnBajar);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.btnSubir);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Dg2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 272);
            this.panel2.TabIndex = 2;
            // 
            // btnDigita
            // 
            this.btnDigita.Image = global::SisCtd.Properties.Resources.iconoima;
            this.btnDigita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigita.Location = new System.Drawing.Point(718, 240);
            this.btnDigita.Name = "btnDigita";
            this.btnDigita.Size = new System.Drawing.Size(119, 24);
            this.btnDigita.TabIndex = 4;
            this.btnDigita.Text = "Anexo Digitalizable";
            this.btnDigita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDigita.UseVisualStyleBackColor = true;
            this.btnDigita.Click += new System.EventHandler(this.btnDigita_Click);
            // 
            // btnCritico
            // 
            this.btnCritico.Image = global::SisCtd.Properties.Resources.Aceptar;
            this.btnCritico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCritico.Location = new System.Drawing.Point(615, 240);
            this.btnCritico.Name = "btnCritico";
            this.btnCritico.Size = new System.Drawing.Size(97, 24);
            this.btnCritico.TabIndex = 3;
            this.btnCritico.Text = "Anexo Crítico";
            this.btnCritico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCritico.UseVisualStyleBackColor = true;
            this.btnCritico.Click += new System.EventHandler(this.btnCritico_Click);
            // 
            // lblTransac
            // 
            this.lblTransac.BackColor = System.Drawing.SystemColors.Info;
            this.lblTransac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTransac.Location = new System.Drawing.Point(169, 7);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(668, 20);
            this.lblTransac.TabIndex = 8;
            this.lblTransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(847, 64);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(49, 23);
            this.btnBajar.TabIndex = 6;
            this.btnBajar.Text = "&Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnSubirBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(847, 35);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(49, 23);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "&Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubirBajar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Anexos del Tipo de Operación";
            // 
            // Frm_T_TipoOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(911, 615);
            this.Controls.Add(this.Dg1);
            this.Controls.Add(this.Stb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_T_TipoOperacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Registro de Tipos de Operación";
            this.Load += new System.EventHandler(this.Frm_T_TipoOperacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_T_TipoOperacion_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_TipoOperacion_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.Stb.ResumeLayout(false);
            this.Stb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MigControls.MigTextbox txtIddocu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bNuevo;
        private System.Windows.Forms.ToolStripButton bModificar;
        private System.Windows.Forms.ToolStripButton bEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.StatusStrip Stb;
        private System.Windows.Forms.ToolStripStatusLabel LblMensaje;
        private MigControls.MigDataGridView Dg1;
        private MigControls.MigDataGridView Dg2;
        private MigControls.MigTextbox txtDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTransac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnCritico;
        private System.Windows.Forms.Button btnDigita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bCritico;
        private System.Windows.Forms.ToolStripButton bDgita;
        private System.Windows.Forms.ToolStripButton bHistorial;
    }
}