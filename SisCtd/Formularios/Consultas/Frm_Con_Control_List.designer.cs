namespace SisCtd
{
    partial class Frm_Con_Control_List
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
            this.CboTipos = new MigControls.MigCombobox();
            this.chkTodo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboArea = new MigControls.MigCombobox();
            this.txtIdControl = new MigControls.MigTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.txtRazonSocial = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bVerImagen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgControl = new MigControls.MigDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVerDocumento = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.CboTipos);
            this.panel1.Controls.Add(this.chkTodo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboArea);
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
            this.panel1.Size = new System.Drawing.Size(996, 58);
            this.panel1.TabIndex = 2;
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
            this.CboTipos.Location = new System.Drawing.Point(831, 29);
            this.CboTipos.Name = "CboTipos";
            this.CboTipos.PasarEnter = true;
            this.CboTipos.Size = new System.Drawing.Size(112, 22);
            this.CboTipos.TabIndex = 93;
            this.CboTipos.Tipo = MigControls.MigCombobox.TipoVal.Numerico;
            // 
            // chkTodo
            // 
            this.chkTodo.AutoSize = true;
            this.chkTodo.Location = new System.Drawing.Point(493, 9);
            this.chkTodo.Name = "chkTodo";
            this.chkTodo.Size = new System.Drawing.Size(56, 17);
            this.chkTodo.TabIndex = 10;
            this.chkTodo.Text = "Todos";
            this.chkTodo.UseVisualStyleBackColor = true;
            this.chkTodo.CheckedChanged += new System.EventHandler(this.chkTodo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area";
            // 
            // cboArea
            // 
            this.cboArea.BackColor = System.Drawing.Color.White;
            this.cboArea.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboArea.ColorSalida = System.Drawing.Color.White;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(70, 4);
            this.cboArea.Name = "cboArea";
            this.cboArea.PasarEnter = true;
            this.cboArea.Size = new System.Drawing.Size(417, 22);
            this.cboArea.TabIndex = 8;
            this.cboArea.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // txtIdControl
            // 
            this.txtIdControl.BackColor = System.Drawing.Color.White;
            this.txtIdControl.Car_Años = 4;
            this.txtIdControl.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdControl.ColorSalida = System.Drawing.Color.White;
            this.txtIdControl.Decimales = 2;
            this.txtIdControl.Guiones = false;
            this.txtIdControl.Location = new System.Drawing.Point(70, 32);
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
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id. Control";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(772, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estados";
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
            this.cboEstado.Location = new System.Drawing.Point(851, 4);
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
            this.txtRazonSocial.Location = new System.Drawing.Point(562, 31);
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
            this.label2.Location = new System.Drawing.Point(486, 35);
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
            this.txtNroDocumento.Location = new System.Drawing.Point(370, 31);
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
            this.label10.Location = new System.Drawing.Point(257, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Numero / Referencia";
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bExportar,
            this.toolStripSeparator2,
            this.bVerImagen,
            this.toolStripButton4,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(996, 23);
            this.BarraSis.TabIndex = 3;
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
            this.dgControl.Location = new System.Drawing.Point(0, 81);
            this.dgControl.MultiSelect = false;
            this.dgControl.Name = "dgControl";
            this.dgControl.PasarEnter = false;
            this.dgControl.ReadOnly = true;
            this.dgControl.RowHeadersWidth = 25;
            this.dgControl.RowTemplate.Height = 18;
            this.dgControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgControl.Size = new System.Drawing.Size(996, 172);
            this.dgControl.StandardTab = true;
            this.dgControl.TabIndex = 0;
            this.dgControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellClick);
            this.dgControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellDoubleClick);
            this.dgControl.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellClick);
            this.dgControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgControl_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVerDocumento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 220);
            this.panel2.TabIndex = 1;
            // 
            // btnVerDocumento
            // 
            this.btnVerDocumento.Image = global::SisCtd.Properties.Resources._045;
            this.btnVerDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDocumento.Location = new System.Drawing.Point(12, 187);
            this.btnVerDocumento.Name = "btnVerDocumento";
            this.btnVerDocumento.Size = new System.Drawing.Size(99, 23);
            this.btnVerDocumento.TabIndex = 1;
            this.btnVerDocumento.Text = "&Ver Archivos";
            this.btnVerDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDocumento.UseVisualStyleBackColor = true;
            this.btnVerDocumento.Click += new System.EventHandler(this.btnVerDocumento_Click);
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
            // Frm_Con_Control_List
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
            this.Name = "Frm_Con_Control_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "  Registro de Tipos de Documento";
            this.Load += new System.EventHandler(this.Frm_Con_Control_List_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Con_Control_List_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Con_Control_List_KeyPress);
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
        private System.Windows.Forms.Label label1;
        private MigControls.MigDataGridView dgDetalle;
        private System.Windows.Forms.ToolStripButton bVerImagen;
        private MigControls.MigTextbox txtIdControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerDocumento;
        private MigControls.MigCombobox cboArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTodo;
        private MigControls.MigCombobox CboTipos;
    }
}