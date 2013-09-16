namespace BESisCtd
{
    partial class Frm_T_TiposDocumento_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.txtDescripcion = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bModificar = new System.Windows.Forms.ToolStripButton();
            this.bEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dg1 = new MigControls.MigDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.migDataGridView1 = new MigControls.MigDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.migDataGridView2 = new MigControls.MigDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.migDataGridView3 = new MigControls.MigDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.Stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 32);
            this.panel1.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(570, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
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
            "Activos",
            "Inactivos",
            "Todos"});
            this.cboEstado.Location = new System.Drawing.Point(616, 5);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PasarEnter = true;
            this.cboEstado.Size = new System.Drawing.Size(92, 22);
            this.cboEstado.TabIndex = 2;
            this.cboEstado.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Car_Años = 4;
            this.txtDescripcion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescripcion.ColorSalida = System.Drawing.Color.White;
            this.txtDescripcion.Decimales = 2;
            this.txtDescripcion.Guiones = false;
            this.txtDescripcion.Location = new System.Drawing.Point(261, 6);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasarEnter = true;
            this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(63, 6);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Código";
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNuevo,
            this.bModificar,
            this.bEliminar,
            this.toolStripButton4,
            this.bExportar,
            this.toolStripSeparator2,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(915, 23);
            this.BarraSis.TabIndex = 3;
            // 
            // bNuevo
            // 
            this.bNuevo.Image = global::BESisCtd.Properties.Resources.Toolbar_New;
            this.bNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(62, 20);
            this.bNuevo.Text = "&Nuevo";
            this.bNuevo.ToolTipText = "Nuevo (F3)";
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bModificar
            // 
            this.bModificar.Image = global::BESisCtd.Properties.Resources.control;
            this.bModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(78, 20);
            this.bModificar.Text = "&Modificar";
            this.bModificar.ToolTipText = "Modificar (F2)";
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Image = global::BESisCtd.Properties.Resources.Toolbar_Delete;
            this.bEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(70, 20);
            this.bEliminar.Text = "&Eliminar";
            this.bEliminar.ToolTipText = "Eliminar (F4)";
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 23);
            // 
            // bExportar
            // 
            this.bExportar.Image = global::BESisCtd.Properties.Resources.xls;
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
            // bCerrar
            // 
            this.bCerrar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
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
            this.Stb.Location = new System.Drawing.Point(0, 205);
            this.Stb.Name = "Stb";
            this.Stb.Size = new System.Drawing.Size(915, 22);
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
            this.Dg1.Size = new System.Drawing.Size(915, 150);
            this.Dg1.StandardTab = true;
            this.Dg1.TabIndex = 0;
            this.Dg1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg1_CellDoubleClick);
            this.Dg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dg1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.migDataGridView3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.migDataGridView2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.migDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 260);
            this.panel2.TabIndex = 663;
            // 
            // migDataGridView1
            // 
            this.migDataGridView1.AllowUserToAddRows = false;
            this.migDataGridView1.AllowUserToDeleteRows = false;
            this.migDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory;
            this.migDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.migDataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.migDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.migDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.migDataGridView1.Location = new System.Drawing.Point(573, 24);
            this.migDataGridView1.MultiSelect = false;
            this.migDataGridView1.Name = "migDataGridView1";
            this.migDataGridView1.PasarEnter = false;
            this.migDataGridView1.ReadOnly = true;
            this.migDataGridView1.RowHeadersWidth = 25;
            this.migDataGridView1.RowTemplate.Height = 18;
            this.migDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.migDataGridView1.Size = new System.Drawing.Size(284, 203);
            this.migDataGridView1.StandardTab = true;
            this.migDataGridView1.TabIndex = 665;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 666;
            this.label3.Text = "Rutas";
            // 
            // migDataGridView2
            // 
            this.migDataGridView2.AllowUserToAddRows = false;
            this.migDataGridView2.AllowUserToDeleteRows = false;
            this.migDataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            this.migDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.migDataGridView2.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.migDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.migDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.migDataGridView2.Location = new System.Drawing.Point(12, 24);
            this.migDataGridView2.MultiSelect = false;
            this.migDataGridView2.Name = "migDataGridView2";
            this.migDataGridView2.PasarEnter = false;
            this.migDataGridView2.ReadOnly = true;
            this.migDataGridView2.RowHeadersWidth = 25;
            this.migDataGridView2.RowTemplate.Height = 18;
            this.migDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.migDataGridView2.Size = new System.Drawing.Size(257, 203);
            this.migDataGridView2.StandardTab = true;
            this.migDataGridView2.TabIndex = 667;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 668;
            this.label4.Text = "Actividades de la Ruta";
            // 
            // migDataGridView3
            // 
            this.migDataGridView3.AllowUserToAddRows = false;
            this.migDataGridView3.AllowUserToDeleteRows = false;
            this.migDataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.migDataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.migDataGridView3.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.migDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.migDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.migDataGridView3.Location = new System.Drawing.Point(279, 24);
            this.migDataGridView3.MultiSelect = false;
            this.migDataGridView3.Name = "migDataGridView3";
            this.migDataGridView3.PasarEnter = false;
            this.migDataGridView3.ReadOnly = true;
            this.migDataGridView3.RowHeadersWidth = 25;
            this.migDataGridView3.RowTemplate.Height = 18;
            this.migDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.migDataGridView3.Size = new System.Drawing.Size(209, 203);
            this.migDataGridView3.StandardTab = true;
            this.migDataGridView3.TabIndex = 669;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 670;
            this.button1.Text = "Agregar Dato";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 671;
            this.button2.Text = "Quitar Dato";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 673;
            this.button3.Text = "Quitar Ruta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 672;
            this.button4.Text = "Agregar Ruta";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Frm_T_TiposDocumento_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(915, 487);
            this.Controls.Add(this.Dg1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSis);
            this.Controls.Add(this.Stb);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_T_TiposDocumento_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Registro de Tipos de Documento";
            this.Load += new System.EventHandler(this.Frm_T_Listados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_T_Listados_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_Listados_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.Stb.ResumeLayout(false);
            this.Stb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.migDataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MigControls.MigTextbox txtCodigo;
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
        private MigControls.MigDataGridView Dg1;
        private MigControls.MigTextbox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MigControls.MigDataGridView migDataGridView1;
        private System.Windows.Forms.Label label4;
        private MigControls.MigDataGridView migDataGridView3;
        private System.Windows.Forms.Label label3;
        private MigControls.MigDataGridView migDataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}