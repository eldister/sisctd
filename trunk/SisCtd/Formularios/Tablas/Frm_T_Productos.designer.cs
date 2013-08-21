namespace SisCtd
{
    partial class Frm_T_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new MigControls.MigCombobox();
            this.txtDescrip = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdprod = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bModificar = new System.Windows.Forms.ToolStripButton();
            this.bEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarDoc = new System.Windows.Forms.Button();
            this.btnQuitarDoc = new System.Windows.Forms.Button();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dg1 = new MigControls.MigDataGridView();
            this.Dg2 = new MigControls.MigDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuitarDato = new System.Windows.Forms.Button();
            this.btnAgregarDato = new System.Windows.Forms.Button();
            this.Dg3 = new MigControls.MigDataGridView();
            this.lblIddocu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.BarraSis.SuspendLayout();
            this.Stb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtDescrip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdprod);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 33);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 11);
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
            this.cboEstado.Location = new System.Drawing.Point(622, 6);
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
            this.txtDescrip.Location = new System.Drawing.Point(272, 7);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(265, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtDescrip.TextChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // txtIdprod
            // 
            this.txtIdprod.BackColor = System.Drawing.Color.White;
            this.txtIdprod.Car_Años = 4;
            this.txtIdprod.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdprod.ColorSalida = System.Drawing.Color.White;
            this.txtIdprod.Decimales = 2;
            this.txtIdprod.Guiones = false;
            this.txtIdprod.Location = new System.Drawing.Point(73, 7);
            this.txtIdprod.MaxLength = 10;
            this.txtIdprod.Name = "txtIdprod";
            this.txtIdprod.PasarEnter = true;
            this.txtIdprod.Size = new System.Drawing.Size(80, 20);
            this.txtIdprod.TabIndex = 0;
            this.txtIdprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdprod.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdprod.TextChanged += new System.EventHandler(this.txtIddocu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Id Producto";
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
            this.BarraSis.Size = new System.Drawing.Size(959, 23);
            this.BarraSis.TabIndex = 15;
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
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.Location = new System.Drawing.Point(3, 255);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(112, 28);
            this.btnAgregarDoc.TabIndex = 1;
            this.btnAgregarDoc.Text = "&Agregar Documento";
            this.btnAgregarDoc.UseVisualStyleBackColor = true;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarDoc_Click);
            // 
            // btnQuitarDoc
            // 
            this.btnQuitarDoc.Location = new System.Drawing.Point(118, 255);
            this.btnQuitarDoc.Name = "btnQuitarDoc";
            this.btnQuitarDoc.Size = new System.Drawing.Size(112, 28);
            this.btnQuitarDoc.TabIndex = 2;
            this.btnQuitarDoc.Text = "&Quitar Documento";
            this.btnQuitarDoc.UseVisualStyleBackColor = true;
            this.btnQuitarDoc.Click += new System.EventHandler(this.btnQuitarDoc_Click);
            // 
            // Stb
            // 
            this.Stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMensaje});
            this.Stb.Location = new System.Drawing.Point(0, 326);
            this.Stb.Name = "Stb";
            this.Stb.Size = new System.Drawing.Size(959, 22);
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
            this.Dg1.Location = new System.Drawing.Point(0, 56);
            this.Dg1.MultiSelect = false;
            this.Dg1.Name = "Dg1";
            this.Dg1.PasarEnter = false;
            this.Dg1.ReadOnly = true;
            this.Dg1.RowHeadersWidth = 25;
            this.Dg1.RowTemplate.Height = 18;
            this.Dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg1.Size = new System.Drawing.Size(959, 292);
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
            this.Dg2.Location = new System.Drawing.Point(3, 34);
            this.Dg2.MultiSelect = false;
            this.Dg2.Name = "Dg2";
            this.Dg2.PasarEnter = false;
            this.Dg2.ReadOnly = true;
            this.Dg2.RowHeadersWidth = 25;
            this.Dg2.RowTemplate.Height = 18;
            this.Dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg2.Size = new System.Drawing.Size(448, 217);
            this.Dg2.StandardTab = true;
            this.Dg2.TabIndex = 0;
            this.Dg2.SelectionChanged += new System.EventHandler(this.Dg2_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuitarDato);
            this.panel2.Controls.Add(this.btnAgregarDato);
            this.panel2.Controls.Add(this.Dg3);
            this.panel2.Controls.Add(this.lblIddocu);
            this.panel2.Controls.Add(this.btnQuitarDoc);
            this.panel2.Controls.Add(this.btnAgregarDoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblIdProd);
            this.panel2.Controls.Add(this.Dg2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 289);
            this.panel2.TabIndex = 1;
            // 
            // btnQuitarDato
            // 
            this.btnQuitarDato.Location = new System.Drawing.Point(552, 255);
            this.btnQuitarDato.Name = "btnQuitarDato";
            this.btnQuitarDato.Size = new System.Drawing.Size(80, 28);
            this.btnQuitarDato.TabIndex = 5;
            this.btnQuitarDato.Text = "Quitar Dato";
            this.btnQuitarDato.UseVisualStyleBackColor = true;
            this.btnQuitarDato.Click += new System.EventHandler(this.btnQuitarDato_Click);
            // 
            // btnAgregarDato
            // 
            this.btnAgregarDato.Location = new System.Drawing.Point(468, 255);
            this.btnAgregarDato.Name = "btnAgregarDato";
            this.btnAgregarDato.Size = new System.Drawing.Size(80, 28);
            this.btnAgregarDato.TabIndex = 4;
            this.btnAgregarDato.Text = "Agregar Dato";
            this.btnAgregarDato.UseVisualStyleBackColor = true;
            this.btnAgregarDato.Click += new System.EventHandler(this.btnAgregarDato_Click);
            // 
            // Dg3
            // 
            this.Dg3.AllowUserToAddRows = false;
            this.Dg3.AllowUserToDeleteRows = false;
            this.Dg3.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            this.Dg3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg3.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Dg3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg3.Location = new System.Drawing.Point(468, 34);
            this.Dg3.MultiSelect = false;
            this.Dg3.Name = "Dg3";
            this.Dg3.PasarEnter = false;
            this.Dg3.ReadOnly = true;
            this.Dg3.RowHeadersWidth = 25;
            this.Dg3.RowTemplate.Height = 18;
            this.Dg3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg3.Size = new System.Drawing.Size(480, 217);
            this.Dg3.StandardTab = true;
            this.Dg3.TabIndex = 3;
            // 
            // lblIddocu
            // 
            this.lblIddocu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIddocu.BackColor = System.Drawing.SystemColors.Info;
            this.lblIddocu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIddocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIddocu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIddocu.Location = new System.Drawing.Point(581, 7);
            this.lblIddocu.Name = "lblIddocu";
            this.lblIddocu.Size = new System.Drawing.Size(366, 20);
            this.lblIddocu.TabIndex = 10;
            this.lblIddocu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datos del Tipo de Doc.";
            // 
            // lblIdProd
            // 
            this.lblIdProd.BackColor = System.Drawing.SystemColors.Info;
            this.lblIdProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdProd.Location = new System.Drawing.Point(181, 7);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(269, 20);
            this.lblIdProd.TabIndex = 8;
            this.lblIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipos de Documento del Producto";
            // 
            // Frm_Mnt_Prod_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 637);
            this.Controls.Add(this.Stb);
            this.Controls.Add(this.Dg1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSis);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_Mnt_Prod_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Registro de Productos";
            this.Load += new System.EventHandler(this.Frm_T_Productos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_T_Productos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_T_Productos_KeyPress);
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
            ((System.ComponentModel.ISupportInitialize)(this.Dg3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MigControls.MigTextbox txtIdprod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bNuevo;
        private System.Windows.Forms.ToolStripButton bModificar;
        private System.Windows.Forms.ToolStripButton bEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        private System.Windows.Forms.Button btnAgregarDoc;
        private System.Windows.Forms.Button btnQuitarDoc;
        private System.Windows.Forms.StatusStrip Stb;
        private System.Windows.Forms.ToolStripStatusLabel LblMensaje;
        private MigControls.MigDataGridView Dg1;
        private MigControls.MigDataGridView Dg2;
        private MigControls.MigTextbox txtDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MigControls.MigCombobox cboEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label label6;
        private MigControls.MigDataGridView Dg3;
        private System.Windows.Forms.Label lblIddocu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitarDato;
        private System.Windows.Forms.Button btnAgregarDato;
    }
}