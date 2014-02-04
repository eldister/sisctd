namespace SisCtd
{
    partial class Frm_T_Rutas_List
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
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgActividades = new MigControls.MigDataGridView();
            this.panel1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.Stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).BeginInit();
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
            this.Dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg1_CellClick);
            this.Dg1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg1_CellDoubleClick);
            this.Dg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dg1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBajar);
            this.panel2.Controls.Add(this.btnSubir);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgActividades);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 260);
            this.panel2.TabIndex = 663;
            // 
            // btnBajar
            // 
            this.btnBajar.Image = global::SisCtd.Properties.Resources._16__Fill_down_;
            this.btnBajar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajar.Location = new System.Drawing.Point(860, 128);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(24, 35);
            this.btnBajar.TabIndex = 679;
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Image = global::SisCtd.Properties.Resources._16__Fill_up_;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(860, 90);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(24, 37);
            this.btnSubir.TabIndex = 678;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::SisCtd.Properties.Resources._16__Db_delete_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(91, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 23);
            this.btnDelete.TabIndex = 677;
            this.btnDelete.Text = "Quitar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SisCtd.Properties.Resources._16__Db_insert_1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 676;
            this.btnAdd.Text = "  Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 674;
            this.label3.Text = "Actividades";
            // 
            // dgActividades
            // 
            this.dgActividades.AllowUserToAddRows = false;
            this.dgActividades.AllowUserToDeleteRows = false;
            this.dgActividades.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.dgActividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgActividades.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividades.Location = new System.Drawing.Point(12, 26);
            this.dgActividades.MultiSelect = false;
            this.dgActividades.Name = "dgActividades";
            this.dgActividades.PasarEnter = false;
            this.dgActividades.ReadOnly = true;
            this.dgActividades.RowHeadersWidth = 25;
            this.dgActividades.RowTemplate.Height = 18;
            this.dgActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgActividades.Size = new System.Drawing.Size(842, 203);
            this.dgActividades.StandardTab = true;
            this.dgActividades.TabIndex = 675;
            // 
            // Frm_T_Rutas_List
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
            this.Name = "Frm_T_Rutas_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Registro de Rutas";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).EndInit();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private MigControls.MigDataGridView dgActividades;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
    }
}