namespace SisCtd
{
    partial class Frm_Sis_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sis_Principal));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.stbPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuSis = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cboCliente = new System.Windows.Forms.ToolStripComboBox();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.Img = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panMenu = new System.Windows.Forms.Panel();
            this.TreOpc = new System.Windows.Forms.TreeView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.stbPrincipal.SuspendLayout();
            this.MenuSis.SuspendLayout();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(391, 115);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(401, 128);
            this.tabPrincipal.TabIndex = 668;
            this.tabPrincipal.Visible = false;
            // 
            // stbPrincipal
            // 
            this.stbPrincipal.AutoSize = false;
            this.stbPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion,
            this.lblUsuario});
            this.stbPrincipal.Location = new System.Drawing.Point(0, 533);
            this.stbPrincipal.Name = "stbPrincipal";
            this.stbPrincipal.Size = new System.Drawing.Size(782, 23);
            this.stbPrincipal.TabIndex = 670;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = false;
            this.lblVersion.BackColor = System.Drawing.SystemColors.Control;
            this.lblVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 18);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(250, 18);
            // 
            // MenuSis
            // 
            this.MenuSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.bMenu,
            this.cboCliente,
            this.ayudaToolStripMenuItem});
            this.MenuSis.Location = new System.Drawing.Point(0, 0);
            this.MenuSis.Name = "MenuSis";
            this.MenuSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuSis.Size = new System.Drawing.Size(782, 27);
            this.MenuSis.TabIndex = 671;
            this.MenuSis.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bCambiarContraseña,
            this.toolStripSeparator2,
            this.bCerrarSesion,
            this.toolStripSeparator1,
            this.bSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // bCambiarContraseña
            // 
            this.bCambiarContraseña.Name = "bCambiarContraseña";
            this.bCambiarContraseña.Size = new System.Drawing.Size(189, 28);
            this.bCambiarContraseña.Text = "Cambiar Contraseña";
            this.bCambiarContraseña.Click += new System.EventHandler(this.bCambiarContraseña_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(189, 28);
            this.bCerrarSesion.Text = "&Cerrar Sesión";
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // bMenu
            // 
            this.bMenu.Name = "bMenu";
            this.bMenu.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.bMenu.Size = new System.Drawing.Size(92, 23);
            this.bMenu.Text = "&Ocultar Menú";
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 23);
            this.cboCliente.ToolTipText = "Seleccione Cliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAcercade});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // bAcercade
            // 
            this.bAcercade.Name = "bAcercade";
            this.bAcercade.Size = new System.Drawing.Size(138, 22);
            this.bAcercade.Text = "Acerca &de ...";
            this.bAcercade.Click += new System.EventHandler(this.bAcercade_Click);
            // 
            // Img
            // 
            this.Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img.ImageStream")));
            this.Img.TransparentColor = System.Drawing.Color.Transparent;
            this.Img.Images.SetKeyName(0, "folder.gif");
            this.Img.Images.SetKeyName(1, "field.gif");
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(259, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 506);
            this.splitter1.TabIndex = 673;
            this.splitter1.TabStop = false;
            // 
            // panMenu
            // 
            this.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panMenu.Controls.Add(this.TreOpc);
            this.panMenu.Controls.Add(this.picLogo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 27);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(259, 506);
            this.panMenu.TabIndex = 674;
            // 
            // TreOpc
            // 
            this.TreOpc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TreOpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreOpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreOpc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreOpc.ImageIndex = 0;
            this.TreOpc.ImageList = this.Img;
            this.TreOpc.Location = new System.Drawing.Point(0, 77);
            this.TreOpc.Name = "TreOpc";
            this.TreOpc.SelectedImageIndex = 0;
            this.TreOpc.Size = new System.Drawing.Size(255, 425);
            this.TreOpc.TabIndex = 673;
            this.TreOpc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreOpc_AfterSelect);
            this.TreOpc.DoubleClick += new System.EventHandler(this.TreOpc_DoubleClick);
            this.TreOpc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreOpc_KeyPress);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(255, 77);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 674;
            this.picLogo.TabStop = false;
            // 
            // bSalir
            // 
            this.bSalir.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bSalir.Name = "bSalir";
            this.bSalir.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.bSalir.Size = new System.Drawing.Size(189, 28);
            this.bSalir.Text = "Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Frm_Sis_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 556);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.MenuSis);
            this.Controls.Add(this.stbPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Sis_Principal";
            this.Text = "SisCtd - Control de Tramite Documentario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sis_Principal_Load);
            this.stbPrincipal.ResumeLayout(false);
            this.stbPrincipal.PerformLayout();
            this.MenuSis.ResumeLayout(false);
            this.MenuSis.PerformLayout();
            this.panMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.StatusStrip stbPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.MenuStrip MenuSis;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bSalir;
        private System.Windows.Forms.ToolStripMenuItem bMenu;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAcercade;
        private System.Windows.Forms.ImageList Img;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem bCambiarContraseña;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.TreeView TreOpc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripComboBox cboCliente;
    }
}

