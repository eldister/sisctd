namespace SisCtd
{
    partial class Frm_Reg_Control_List
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
            this.txtIdControl = new MigControls.MigTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.txtRazonSocial = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bModificar = new System.Windows.Forms.ToolStripButton();
            this.bEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bAsignarImagen = new System.Windows.Forms.ToolStripButton();
            this.bQuitarImagen = new System.Windows.Forms.ToolStripButton();
            this.bVerImagen = new System.Windows.Forms.ToolStripButton();
            this.bSello = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgControl = new MigControls.MigDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnQuitarActividad = new System.Windows.Forms.Button();
            this.btnAgregarActividad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDetalle = new MigControls.MigDataGridView();
            this.panel1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.Stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdControl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNroDocumento);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 32);
            this.panel1.TabIndex = 2;
            // 
            // txtIdControl
            // 
            this.txtIdControl.BackColor = System.Drawing.Color.White;
            this.txtIdControl.Car_Años = 4;
            this.txtIdControl.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdControl.ColorSalida = System.Drawing.Color.White;
            this.txtIdControl.Decimales = 2;
            this.txtIdControl.Guiones = false;
            this.txtIdControl.Location = new System.Drawing.Point(70, 7);
            this.txtIdControl.MaxLength = 10;
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.PasarEnter = true;
            this.txtIdControl.Size = new System.Drawing.Size(158, 20);
            this.txtIdControl.TabIndex = 0;
            this.txtIdControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdControl.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdControl.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id. Control";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(810, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
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
            "Iniciado",
            "Terminado",
            "Cerrado",
            "Anulado",
            "Todos"});
            this.cboEstado.Location = new System.Drawing.Point(856, 5);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(92, 22);
            this.cboEstado.TabIndex = 3;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            this.cboEstado.SelectionChangeCommitted += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Car_Años = 4;
            this.txtRazonSocial.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtRazonSocial.ColorSalida = System.Drawing.Color.White;
            this.txtRazonSocial.Decimales = 2;
            this.txtRazonSocial.Guiones = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(562, 6);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasarEnter = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(208, 20);
            this.txtRazonSocial.TabIndex = 2;
            this.txtRazonSocial.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razón Social";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNroDocumento.Car_Años = 4;
            this.txtNroDocumento.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNroDocumento.ColorSalida = System.Drawing.Color.White;
            this.txtNroDocumento.Decimales = 2;
            this.txtNroDocumento.Guiones = false;
            this.txtNroDocumento.Location = new System.Drawing.Point(370, 6);
            this.txtNroDocumento.MaxLength = 10;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.PasarEnter = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(90, 20);
            this.txtNroDocumento.TabIndex = 1;
            this.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroDocumento.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtNroDocumento.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Numero / Referencia";
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNuevo,
            this.bModificar,
            this.bEliminar,
            this.toolStripSeparator1,
            this.bExportar,
            this.toolStripSeparator2,
            this.bAsignarImagen,
            this.bQuitarImagen,
            this.bVerImagen,
            this.bSello,
            this.toolStripButton4,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(996, 23);
            this.BarraSis.TabIndex = 3;
            // 
            // bNuevo
            // 
            this.bNuevo.Image = global::SisCtd.Properties.Resources.Toolbar_New;
            this.bNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(62, 20);
            this.bNuevo.Text = "&Nuevo";
            this.bNuevo.ToolTipText = "Nuevo (F3)";
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bModificar
            // 
            this.bModificar.Image = global::SisCtd.Properties.Resources.control;
            this.bModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(78, 20);
            this.bModificar.Text = "&Modificar";
            this.bModificar.ToolTipText = "Modificar (F2)";
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Image = global::SisCtd.Properties.Resources.Toolbar_Delete;
            this.bEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(70, 20);
            this.bEliminar.Text = "&Eliminar";
            this.bEliminar.ToolTipText = "Eliminar (F4)";
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bExportar
            // 
            this.bExportar.Image = global::SisCtd.Properties.Resources.xls;
            this.bExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(70, 20);
            this.bExportar.Text = "E&xportar";
            this.bExportar.ToolTipText = "Exportar (F7)";
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bAsignarImagen
            // 
            this.bAsignarImagen.Image = global::SisCtd.Properties.Resources.descarga;
            this.bAsignarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bAsignarImagen.Name = "bAsignarImagen";
            this.bAsignarImagen.Size = new System.Drawing.Size(110, 20);
            this.bAsignarImagen.Text = "&Asignar Imagen";
            this.bAsignarImagen.ToolTipText = "Eliminar (F4)";
            this.bAsignarImagen.Click += new System.EventHandler(this.bAsignarImagen_Click);
            // 
            // bQuitarImagen
            // 
            this.bQuitarImagen.Image = global::SisCtd.Properties.Resources.Toolbar_Erase;
            this.bQuitarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bQuitarImagen.Name = "bQuitarImagen";
            this.bQuitarImagen.Size = new System.Drawing.Size(103, 20);
            this.bQuitarImagen.Text = "&Quitar Imagen";
            this.bQuitarImagen.ToolTipText = "Eliminar (F4)";
            this.bQuitarImagen.Click += new System.EventHandler(this.bQuitarImagen_Click);
            // 
            // bVerImagen
            // 
            this.bVerImagen.Image = global::SisCtd.Properties.Resources.iconoima;
            this.bVerImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bVerImagen.Name = "bVerImagen";
            this.bVerImagen.Size = new System.Drawing.Size(87, 20);
            this.bVerImagen.Text = "&Ver Imagen";
            this.bVerImagen.ToolTipText = "Eliminar (F4)";
            this.bVerImagen.Click += new System.EventHandler(this.bVerImagen_Click);
            // 
            // bSello
            // 
            this.bSello.Image = global::SisCtd.Properties.Resources.Toolbar_Print;
            this.bSello.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSello.Name = "bSello";
            this.bSello.Size = new System.Drawing.Size(52, 20);
            this.bSello.Text = "Sello";
            this.bSello.Click += new System.EventHandler(this.bSello_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 23);
            // 
            // bCerrar
            // 
            this.bCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(49, 20);
            this.bCerrar.Text = "&Salir";
            this.bCerrar.ToolTipText = "Salir (Esc)";
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Stb
            // 
            this.Stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMensaje});
            this.Stb.Location = new System.Drawing.Point(0, 253);
            this.Stb.Name = "Stb";
            this.Stb.Size = new System.Drawing.Size(996, 22);
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
            // dgControl
            // 
            this.dgControl.AllowUserToAddRows = false;
            this.dgControl.AllowUserToDeleteRows = false;
            this.dgControl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.dgControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgControl.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgControl.Location = new System.Drawing.Point(0, 55);
            this.dgControl.MultiSelect = false;
            this.dgControl.Name = "dgControl";
            this.dgControl.PasarEnter = false;
            this.dgControl.ReadOnly = true;
            this.dgControl.RowHeadersWidth = 25;
            this.dgControl.RowTemplate.Height = 18;
            this.dgControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgControl.Size = new System.Drawing.Size(996, 198);
            this.dgControl.StandardTab = true;
            this.dgControl.TabIndex = 0;
            this.dgControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellClick);
            this.dgControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellDoubleClick);
            this.dgControl.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellClick);
            this.dgControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgControl_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSubir);
            this.panel2.Controls.Add(this.btnBajar);
            this.panel2.Controls.Add(this.btnQuitarActividad);
            this.panel2.Controls.Add(this.btnAgregarActividad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 220);
            this.panel2.TabIndex = 1;
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.Image = global::SisCtd.Properties.Resources._16__Fill_up_;
            this.btnSubir.Location = new System.Drawing.Point(967, 29);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(26, 23);
            this.btnSubir.TabIndex = 6;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajar.Image = global::SisCtd.Properties.Resources._16__Fill_down_;
            this.btnBajar.Location = new System.Drawing.Point(967, 58);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(26, 23);
            this.btnBajar.TabIndex = 5;
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnQuitarActividad
            // 
            this.btnQuitarActividad.Image = global::SisCtd.Properties.Resources._16__Db_delete_;
            this.btnQuitarActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarActividad.Location = new System.Drawing.Point(134, 187);
            this.btnQuitarActividad.Name = "btnQuitarActividad";
            this.btnQuitarActividad.Size = new System.Drawing.Size(110, 23);
            this.btnQuitarActividad.TabIndex = 2;
            this.btnQuitarActividad.Text = "&Quitar Actividad";
            this.btnQuitarActividad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarActividad.UseVisualStyleBackColor = true;
            this.btnQuitarActividad.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.Image = global::SisCtd.Properties.Resources._16__Db_insert_;
            this.btnAgregarActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarActividad.Location = new System.Drawing.Point(12, 187);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarActividad.TabIndex = 1;
            this.btnAgregarActividad.Text = "&Agregar Actividad";
            this.btnAgregarActividad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarActividad.UseVisualStyleBackColor = true;
            this.btnAgregarActividad.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalle del Control";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.dgDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalle.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Location = new System.Drawing.Point(12, 29);
            this.dgDetalle.MultiSelect = false;
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.PasarEnter = false;
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersWidth = 25;
            this.dgDetalle.RowTemplate.Height = 18;
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(954, 152);
            this.dgDetalle.StandardTab = true;
            this.dgDetalle.TabIndex = 0;
            // 
            // Frm_Reg_Control_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(996, 495);
            this.Controls.Add(this.dgControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSis);
            this.Controls.Add(this.Stb);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_Reg_Control_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "  Registro de Tipos de Documento";
            this.Load += new System.EventHandler(this.Frm_Reg_Control_List_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Reg_Control_List_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Reg_Control_List_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.Stb.ResumeLayout(false);
            this.Stb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MigControls.MigTextbox txtNroDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bNuevo;
        private System.Windows.Forms.ToolStripButton bModificar;
        private System.Windows.Forms.ToolStripButton bEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        private System.Windows.Forms.StatusStrip Stb;
        private System.Windows.Forms.ToolStripStatusLabel LblMensaje;
        private MigControls.MigDataGridView dgControl;
        private MigControls.MigTextbox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuitarActividad;
        private System.Windows.Forms.Button btnAgregarActividad;
        private System.Windows.Forms.Label label1;
        private MigControls.MigDataGridView dgDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bAsignarImagen;
        private System.Windows.Forms.ToolStripButton bQuitarImagen;
        private System.Windows.Forms.ToolStripButton bVerImagen;
        private MigControls.MigTextbox txtIdControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.ToolStripButton bSello;
    }
}