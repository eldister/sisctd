namespace SisCtd
{
    partial class Frm_Sis_Acceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sis_Acceso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstPerfiles = new System.Windows.Forms.ListBox();
            this.treMenu = new System.Windows.Forms.TreeView();
            this.Img = new System.Windows.Forms.ImageList(this.components);
            this.treMenuPerfil = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PanPermisos = new System.Windows.Forms.Panel();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.ChkExportar = new System.Windows.Forms.CheckBox();
            this.ChkImprimir = new System.Windows.Forms.CheckBox();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.ChkModificar = new System.Windows.Forms.CheckBox();
            this.ChkNuevo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bModificar = new System.Windows.Forms.ToolStripButton();
            this.bEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.dgUsuarios = new MigControls.MigDataGridView();
            this.dgClientes = new MigControls.MigDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerfilUsuarios = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chkTodosUsuarios = new System.Windows.Forms.CheckBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnQuitarCliente = new System.Windows.Forms.Button();
            this.btnExportarUsuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerfilOpciones = new System.Windows.Forms.Label();
            this.PanPermisos.SuspendLayout();
            this.BarraSis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPerfiles
            // 
            this.lstPerfiles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPerfiles.FormattingEnabled = true;
            this.lstPerfiles.ItemHeight = 14;
            this.lstPerfiles.Location = new System.Drawing.Point(11, 57);
            this.lstPerfiles.Name = "lstPerfiles";
            this.lstPerfiles.Size = new System.Drawing.Size(170, 312);
            this.lstPerfiles.TabIndex = 0;
            this.lstPerfiles.SelectedIndexChanged += new System.EventHandler(this.lstPerfiles_SelectedIndexChanged);
            // 
            // treMenu
            // 
            this.treMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treMenu.BackColor = System.Drawing.SystemColors.Window;
            this.treMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treMenu.ImageIndex = 0;
            this.treMenu.ImageList = this.Img;
            this.treMenu.Location = new System.Drawing.Point(187, 57);
            this.treMenu.Name = "treMenu";
            this.treMenu.SelectedImageIndex = 0;
            this.treMenu.Size = new System.Drawing.Size(213, 477);
            this.treMenu.TabIndex = 3;
            this.treMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treMenu_AfterSelect);
            this.treMenu.DoubleClick += new System.EventHandler(this.treMenu_DoubleClick);
            // 
            // Img
            // 
            this.Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img.ImageStream")));
            this.Img.TransparentColor = System.Drawing.Color.Transparent;
            this.Img.Images.SetKeyName(0, "folder.gif");
            this.Img.Images.SetKeyName(1, "field.gif");
            // 
            // treMenuPerfil
            // 
            this.treMenuPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treMenuPerfil.BackColor = System.Drawing.SystemColors.Window;
            this.treMenuPerfil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treMenuPerfil.ImageIndex = 0;
            this.treMenuPerfil.ImageList = this.Img;
            this.treMenuPerfil.Location = new System.Drawing.Point(406, 57);
            this.treMenuPerfil.Name = "treMenuPerfil";
            this.treMenuPerfil.SelectedImageIndex = 0;
            this.treMenuPerfil.Size = new System.Drawing.Size(213, 477);
            this.treMenuPerfil.TabIndex = 4;
            this.treMenuPerfil.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treMenuPerfil_AfterSelect);
            this.treMenuPerfil.DoubleClick += new System.EventHandler(this.treMenuPerfil_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 185;
            this.label2.Text = "Perfiles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 187;
            this.label5.Text = "Opciones del Perfil";
            // 
            // PanPermisos
            // 
            this.PanPermisos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPermisos.Controls.Add(this.btnMarcar);
            this.PanPermisos.Controls.Add(this.btnGrabar);
            this.PanPermisos.Controls.Add(this.ChkExportar);
            this.PanPermisos.Controls.Add(this.ChkImprimir);
            this.PanPermisos.Controls.Add(this.ChkEliminar);
            this.PanPermisos.Controls.Add(this.ChkModificar);
            this.PanPermisos.Controls.Add(this.ChkNuevo);
            this.PanPermisos.Controls.Add(this.label1);
            this.PanPermisos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanPermisos.Location = new System.Drawing.Point(628, 72);
            this.PanPermisos.Name = "PanPermisos";
            this.PanPermisos.Size = new System.Drawing.Size(99, 167);
            this.PanPermisos.TabIndex = 5;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Location = new System.Drawing.Point(70, 7);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(21, 19);
            this.btnMarcar.TabIndex = 7;
            this.btnMarcar.Text = "*";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(14, 134);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // ChkExportar
            // 
            this.ChkExportar.AutoSize = true;
            this.ChkExportar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkExportar.Location = new System.Drawing.Point(14, 108);
            this.ChkExportar.Name = "ChkExportar";
            this.ChkExportar.Size = new System.Drawing.Size(67, 18);
            this.ChkExportar.TabIndex = 4;
            this.ChkExportar.Text = "Exportar";
            this.ChkExportar.UseVisualStyleBackColor = true;
            // 
            // ChkImprimir
            // 
            this.ChkImprimir.AutoSize = true;
            this.ChkImprimir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkImprimir.Location = new System.Drawing.Point(14, 89);
            this.ChkImprimir.Name = "ChkImprimir";
            this.ChkImprimir.Size = new System.Drawing.Size(62, 18);
            this.ChkImprimir.TabIndex = 3;
            this.ChkImprimir.Text = "Imprimir";
            this.ChkImprimir.UseVisualStyleBackColor = true;
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEliminar.Location = new System.Drawing.Point(14, 71);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(62, 18);
            this.ChkEliminar.TabIndex = 2;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            // 
            // ChkModificar
            // 
            this.ChkModificar.AutoSize = true;
            this.ChkModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkModificar.Location = new System.Drawing.Point(14, 52);
            this.ChkModificar.Name = "ChkModificar";
            this.ChkModificar.Size = new System.Drawing.Size(70, 18);
            this.ChkModificar.TabIndex = 1;
            this.ChkModificar.Text = "Modificar";
            this.ChkModificar.UseVisualStyleBackColor = true;
            // 
            // ChkNuevo
            // 
            this.ChkNuevo.AutoSize = true;
            this.ChkNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkNuevo.Location = new System.Drawing.Point(14, 33);
            this.ChkNuevo.Name = "ChkNuevo";
            this.ChkNuevo.Size = new System.Drawing.Size(57, 18);
            this.ChkNuevo.TabIndex = 0;
            this.ChkNuevo.Text = "Nuevo";
            this.ChkNuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permisos :";
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
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(1456, 23);
            this.BarraSis.TabIndex = 6;
            this.BarraSis.Tag = "";
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
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.dgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(738, 72);
            this.dgUsuarios.MultiSelect = false;
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.PasarEnter = false;
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersWidth = 25;
            this.dgUsuarios.RowTemplate.Height = 18;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(428, 477);
            this.dgUsuarios.StandardTab = true;
            this.dgUsuarios.TabIndex = 1;
            this.dgUsuarios.SelectionChanged += new System.EventHandler(this.dgUsuarios_SelectionChanged);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.dgClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(1177, 72);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.PasarEnter = false;
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersWidth = 25;
            this.dgClientes.RowTemplate.Height = 18;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(279, 234);
            this.dgClientes.StandardTab = true;
            this.dgClientes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 195;
            this.label4.Text = "Usuarios del Perfil";
            // 
            // lblPerfilUsuarios
            // 
            this.lblPerfilUsuarios.BackColor = System.Drawing.SystemColors.Info;
            this.lblPerfilUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerfilUsuarios.Location = new System.Drawing.Point(738, 48);
            this.lblPerfilUsuarios.Name = "lblPerfilUsuarios";
            this.lblPerfilUsuarios.Size = new System.Drawing.Size(182, 19);
            this.lblPerfilUsuarios.TabIndex = 196;
            this.lblPerfilUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1177, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 197;
            this.label6.Text = "Clientes del Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Location = new System.Drawing.Point(1177, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(222, 19);
            this.lblUsuario.TabIndex = 198;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTodosUsuarios
            // 
            this.chkTodosUsuarios.AutoSize = true;
            this.chkTodosUsuarios.Location = new System.Drawing.Point(928, 51);
            this.chkTodosUsuarios.Name = "chkTodosUsuarios";
            this.chkTodosUsuarios.Size = new System.Drawing.Size(56, 17);
            this.chkTodosUsuarios.TabIndex = 206;
            this.chkTodosUsuarios.Text = "Todos";
            this.chkTodosUsuarios.UseVisualStyleBackColor = true;
            this.chkTodosUsuarios.CheckedChanged += new System.EventHandler(this.chkTodosUsuarios_CheckedChanged);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Image = global::SisCtd.Properties.Resources.Toolbar_New;
            this.btnAgregarCliente.Location = new System.Drawing.Point(1403, 46);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnAgregarCliente.TabIndex = 208;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnQuitarCliente
            // 
            this.btnQuitarCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarCliente.Image = global::SisCtd.Properties.Resources.Toolbar_Erase;
            this.btnQuitarCliente.Location = new System.Drawing.Point(1430, 46);
            this.btnQuitarCliente.Name = "btnQuitarCliente";
            this.btnQuitarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnQuitarCliente.TabIndex = 207;
            this.btnQuitarCliente.UseVisualStyleBackColor = true;
            this.btnQuitarCliente.Click += new System.EventHandler(this.btnQuitarCliente_Click);
            // 
            // btnExportarUsuarios
            // 
            this.btnExportarUsuarios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarUsuarios.Image = global::SisCtd.Properties.Resources.xls;
            this.btnExportarUsuarios.Location = new System.Drawing.Point(1140, 46);
            this.btnExportarUsuarios.Name = "btnExportarUsuarios";
            this.btnExportarUsuarios.Size = new System.Drawing.Size(26, 23);
            this.btnExportarUsuarios.TabIndex = 201;
            this.btnExportarUsuarios.UseVisualStyleBackColor = true;
            this.btnExportarUsuarios.Click += new System.EventHandler(this.btnExportarUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 186;
            this.label3.Text = "Opciones del Sistema";
            // 
            // lblPerfilOpciones
            // 
            this.lblPerfilOpciones.BackColor = System.Drawing.SystemColors.Info;
            this.lblPerfilOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerfilOpciones.Location = new System.Drawing.Point(502, 29);
            this.lblPerfilOpciones.Name = "lblPerfilOpciones";
            this.lblPerfilOpciones.Size = new System.Drawing.Size(130, 19);
            this.lblPerfilOpciones.TabIndex = 200;
            this.lblPerfilOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Sis_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1376, 656);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnQuitarCliente);
            this.Controls.Add(this.chkTodosUsuarios);
            this.Controls.Add(this.btnExportarUsuarios);
            this.Controls.Add(this.lblPerfilOpciones);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPerfilUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.BarraSis);
            this.Controls.Add(this.PanPermisos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treMenuPerfil);
            this.Controls.Add(this.treMenu);
            this.Controls.Add(this.lstPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Frm_Sis_Acceso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Configuración de Accesos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sis_Acceso_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Acceso_KeyPress);
            this.PanPermisos.ResumeLayout(false);
            this.PanPermisos.PerformLayout();
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerfiles;
        private System.Windows.Forms.TreeView treMenu;
        private System.Windows.Forms.TreeView treMenuPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanPermisos;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.CheckBox ChkExportar;
        private System.Windows.Forms.CheckBox ChkImprimir;
        private System.Windows.Forms.CheckBox ChkEliminar;
        private System.Windows.Forms.CheckBox ChkModificar;
        private System.Windows.Forms.CheckBox ChkNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.ImageList Img;
        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bNuevo;
        private System.Windows.Forms.ToolStripButton bModificar;
        private System.Windows.Forms.ToolStripButton bEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        private MigControls.MigDataGridView dgUsuarios;
        private MigControls.MigDataGridView dgClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerfilUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnExportarUsuarios;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnQuitarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPerfilOpciones;
    }
}