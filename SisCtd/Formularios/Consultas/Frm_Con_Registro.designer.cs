namespace SisCtd
{
    partial class Frm_Con_Registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNroReclamacion = new System.Windows.Forms.Label();
            this.txtNroReclamacion = new MigControls.MigTextbox();
            this.lblTipcar = new System.Windows.Forms.Label();
            this.cboTfile = new MigControls.MigCombobox();
            this.lblcodcli = new System.Windows.Forms.Label();
            this.txtCodcli = new MigControls.MigTextbox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCodim2 = new MigControls.MigTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCodim1 = new MigControls.MigTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRazsoc = new MigControls.MigTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new MigControls.MigTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApemat = new MigControls.MigTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApepat = new MigControls.MigTextbox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new MigControls.MigTextbox();
            this.dgvDet1 = new MigControls.MigDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCab = new MigControls.MigDataGridView();
            this.Stb = new System.Windows.Forms.StatusStrip();
            this.LblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdicionales = new System.Windows.Forms.Label();
            this.dgvAdicionales = new MigControls.MigDataGridView();
            this.BarraSis.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCab)).BeginInit();
            this.Stb.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bExportar,
            this.toolStripSeparator1,
            this.bSalir});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(994, 23);
            this.BarraSis.TabIndex = 0;
            // 
            // bExportar
            // 
            this.bExportar.Image = global::SisCtd.Properties.Resources.xls;
            this.bExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(69, 20);
            this.bExportar.Text = "E&xportar";
            this.bExportar.ToolTipText = "Exportar a Excel (F7)";
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bSalir
            // 
            this.bSalir.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(47, 20);
            this.bSalir.Text = "&Salir";
            this.bSalir.ToolTipText = "Salir (Esc)";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNroReclamacion);
            this.panel1.Controls.Add(this.txtNroReclamacion);
            this.panel1.Controls.Add(this.lblTipcar);
            this.panel1.Controls.Add(this.cboTfile);
            this.panel1.Controls.Add(this.lblcodcli);
            this.panel1.Controls.Add(this.txtCodcli);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtCodim2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.txtCodim1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtRazsoc);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtApemat);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtApepat);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 119);
            this.panel1.TabIndex = 0;
            // 
            // lblNroReclamacion
            // 
            this.lblNroReclamacion.AutoSize = true;
            this.lblNroReclamacion.Location = new System.Drawing.Point(212, 13);
            this.lblNroReclamacion.Name = "lblNroReclamacion";
            this.lblNroReclamacion.Size = new System.Drawing.Size(84, 13);
            this.lblNroReclamacion.TabIndex = 814;
            this.lblNroReclamacion.Text = "Nº SubProducto";
            // 
            // txtNroReclamacion
            // 
            this.txtNroReclamacion.BackColor = System.Drawing.Color.White;
            this.txtNroReclamacion.Car_Años = 4;
            this.txtNroReclamacion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNroReclamacion.ColorSalida = System.Drawing.Color.White;
            this.txtNroReclamacion.Decimales = 2;
            this.txtNroReclamacion.Guiones = false;
            this.txtNroReclamacion.Location = new System.Drawing.Point(300, 9);
            this.txtNroReclamacion.MaxLength = 20;
            this.txtNroReclamacion.Name = "txtNroReclamacion";
            this.txtNroReclamacion.PasarEnter = true;
            this.txtNroReclamacion.Size = new System.Drawing.Size(133, 20);
            this.txtNroReclamacion.TabIndex = 813;
            this.txtNroReclamacion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // lblTipcar
            // 
            this.lblTipcar.AutoSize = true;
            this.lblTipcar.Location = new System.Drawing.Point(13, 91);
            this.lblTipcar.Name = "lblTipcar";
            this.lblTipcar.Size = new System.Drawing.Size(62, 13);
            this.lblTipcar.TabIndex = 812;
            this.lblTipcar.Text = "Tipo de File";
            // 
            // cboTfile
            // 
            this.cboTfile.BackColor = System.Drawing.Color.White;
            this.cboTfile.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.cboTfile.ColorSalida = System.Drawing.Color.White;
            this.cboTfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTfile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTfile.FormattingEnabled = true;
            this.cboTfile.Items.AddRange(new object[] {
            "NL",
            "LA",
            ""});
            this.cboTfile.Location = new System.Drawing.Point(94, 86);
            this.cboTfile.Name = "cboTfile";
            this.cboTfile.PasarEnter = true;
            this.cboTfile.Size = new System.Drawing.Size(52, 22);
            this.cboTfile.TabIndex = 811;
            this.cboTfile.Tipo = MigControls.MigCombobox.TipoVal.TextoMayuscula;
            // 
            // lblcodcli
            // 
            this.lblcodcli.AutoSize = true;
            this.lblcodcli.Location = new System.Drawing.Point(439, 65);
            this.lblcodcli.Name = "lblcodcli";
            this.lblcodcli.Size = new System.Drawing.Size(75, 13);
            this.lblcodcli.TabIndex = 810;
            this.lblcodcli.Text = "Codigo Cliente";
            // 
            // txtCodcli
            // 
            this.txtCodcli.BackColor = System.Drawing.Color.White;
            this.txtCodcli.Car_Años = 4;
            this.txtCodcli.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodcli.ColorSalida = System.Drawing.Color.White;
            this.txtCodcli.Decimales = 2;
            this.txtCodcli.Guiones = false;
            this.txtCodcli.Location = new System.Drawing.Point(516, 61);
            this.txtCodcli.MaxLength = 20;
            this.txtCodcli.Name = "txtCodcli";
            this.txtCodcli.PasarEnter = true;
            this.txtCodcli.Size = new System.Drawing.Size(101, 20);
            this.txtCodcli.TabIndex = 809;
            this.txtCodcli.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(873, 84);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "&Limpiar campos (F3)";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCodim2
            // 
            this.txtCodim2.BackColor = System.Drawing.Color.White;
            this.txtCodim2.Car_Años = 4;
            this.txtCodim2.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodim2.ColorSalida = System.Drawing.Color.White;
            this.txtCodim2.Decimales = 2;
            this.txtCodim2.Guiones = false;
            this.txtCodim2.Location = new System.Drawing.Point(349, 87);
            this.txtCodim2.MaxLength = 10;
            this.txtCodim2.Name = "txtCodim2";
            this.txtCodim2.PasarEnter = true;
            this.txtCodim2.Size = new System.Drawing.Size(84, 20);
            this.txtCodim2.TabIndex = 6;
            this.txtCodim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodim2.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "al";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Código IM Del";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(787, 84);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(80, 25);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "C&onsultar F5";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCodim1
            // 
            this.txtCodim1.BackColor = System.Drawing.Color.White;
            this.txtCodim1.Car_Años = 4;
            this.txtCodim1.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodim1.ColorSalida = System.Drawing.Color.White;
            this.txtCodim1.Decimales = 2;
            this.txtCodim1.Guiones = false;
            this.txtCodim1.Location = new System.Drawing.Point(249, 87);
            this.txtCodim1.MaxLength = 10;
            this.txtCodim1.Name = "txtCodim1";
            this.txtCodim1.PasarEnter = true;
            this.txtCodim1.Size = new System.Drawing.Size(71, 20);
            this.txtCodim1.TabIndex = 5;
            this.txtCodim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodim1.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Razón Social";
            // 
            // txtRazsoc
            // 
            this.txtRazsoc.BackColor = System.Drawing.Color.White;
            this.txtRazsoc.Car_Años = 4;
            this.txtRazsoc.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtRazsoc.ColorSalida = System.Drawing.Color.White;
            this.txtRazsoc.Decimales = 2;
            this.txtRazsoc.Guiones = false;
            this.txtRazsoc.Location = new System.Drawing.Point(94, 61);
            this.txtRazsoc.MaxLength = 100;
            this.txtRazsoc.Name = "txtRazsoc";
            this.txtRazsoc.PasarEnter = true;
            this.txtRazsoc.Size = new System.Drawing.Size(339, 20);
            this.txtRazsoc.TabIndex = 4;
            this.txtRazsoc.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Car_Años = 4;
            this.txtNombre.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNombre.ColorSalida = System.Drawing.Color.White;
            this.txtNombre.Decimales = 2;
            this.txtNombre.Guiones = false;
            this.txtNombre.Location = new System.Drawing.Point(516, 35);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasarEnter = true;
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ape Materno";
            // 
            // txtApemat
            // 
            this.txtApemat.BackColor = System.Drawing.Color.White;
            this.txtApemat.Car_Años = 4;
            this.txtApemat.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtApemat.ColorSalida = System.Drawing.Color.White;
            this.txtApemat.Decimales = 2;
            this.txtApemat.Guiones = false;
            this.txtApemat.Location = new System.Drawing.Point(300, 35);
            this.txtApemat.MaxLength = 50;
            this.txtApemat.Name = "txtApemat";
            this.txtApemat.PasarEnter = true;
            this.txtApemat.Size = new System.Drawing.Size(133, 20);
            this.txtApemat.TabIndex = 2;
            this.txtApemat.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ape. Paterno";
            // 
            // txtApepat
            // 
            this.txtApepat.BackColor = System.Drawing.Color.White;
            this.txtApepat.Car_Años = 4;
            this.txtApepat.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtApepat.ColorSalida = System.Drawing.Color.White;
            this.txtApepat.Decimales = 2;
            this.txtApepat.Guiones = false;
            this.txtApepat.Location = new System.Drawing.Point(94, 35);
            this.txtApepat.MaxLength = 50;
            this.txtApepat.Name = "txtApepat";
            this.txtApepat.PasarEnter = true;
            this.txtApepat.Size = new System.Drawing.Size(120, 20);
            this.txtApepat.TabIndex = 1;
            this.txtApepat.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(13, 13);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(54, 13);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Dni / Ruc";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Car_Años = 4;
            this.txtNum.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtNum.ColorSalida = System.Drawing.Color.White;
            this.txtNum.Decimales = 2;
            this.txtNum.Guiones = false;
            this.txtNum.Location = new System.Drawing.Point(94, 9);
            this.txtNum.MaxLength = 11;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasarEnter = true;
            this.txtNum.Size = new System.Drawing.Size(86, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            // 
            // dgvDet1
            // 
            this.dgvDet1.AllowUserToAddRows = false;
            this.dgvDet1.AllowUserToDeleteRows = false;
            this.dgvDet1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.dgvDet1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDet1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDet1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDet1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDet1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDet1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDet1.Location = new System.Drawing.Point(0, 343);
            this.dgvDet1.MultiSelect = false;
            this.dgvDet1.Name = "dgvDet1";
            this.dgvDet1.PasarEnter = false;
            this.dgvDet1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDet1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDet1.RowHeadersWidth = 25;
            this.dgvDet1.RowTemplate.Height = 18;
            this.dgvDet1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDet1.Size = new System.Drawing.Size(994, 116);
            this.dgvDet1.StandardTab = true;
            this.dgvDet1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documentos";
            // 
            // dgvCab
            // 
            this.dgvCab.AllowUserToAddRows = false;
            this.dgvCab.AllowUserToDeleteRows = false;
            this.dgvCab.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Ivory;
            this.dgvCab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCab.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCab.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCab.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCab.Location = new System.Drawing.Point(0, 142);
            this.dgvCab.MultiSelect = false;
            this.dgvCab.Name = "dgvCab";
            this.dgvCab.PasarEnter = false;
            this.dgvCab.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCab.RowHeadersWidth = 25;
            this.dgvCab.RowTemplate.Height = 18;
            this.dgvCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCab.Size = new System.Drawing.Size(994, 152);
            this.dgvCab.StandardTab = true;
            this.dgvCab.TabIndex = 1;
            this.dgvCab.SelectionChanged += new System.EventHandler(this.dgvCab_SelectionChanged);
            // 
            // Stb
            // 
            this.Stb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMensaje});
            this.Stb.Location = new System.Drawing.Point(0, 294);
            this.Stb.Name = "Stb";
            this.Stb.Size = new System.Drawing.Size(994, 22);
            this.Stb.TabIndex = 663;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 27);
            this.panel3.TabIndex = 664;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAdicionales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 27);
            this.panel2.TabIndex = 665;
            // 
            // lblAdicionales
            // 
            this.lblAdicionales.AutoSize = true;
            this.lblAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionales.Location = new System.Drawing.Point(9, 6);
            this.lblAdicionales.Name = "lblAdicionales";
            this.lblAdicionales.Size = new System.Drawing.Size(72, 13);
            this.lblAdicionales.TabIndex = 0;
            this.lblAdicionales.Text = "Adicionales";
            // 
            // dgvAdicionales
            // 
            this.dgvAdicionales.AllowUserToAddRows = false;
            this.dgvAdicionales.AllowUserToDeleteRows = false;
            this.dgvAdicionales.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Ivory;
            this.dgvAdicionales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAdicionales.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdicionales.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAdicionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdicionales.Location = new System.Drawing.Point(0, 486);
            this.dgvAdicionales.MultiSelect = false;
            this.dgvAdicionales.Name = "dgvAdicionales";
            this.dgvAdicionales.PasarEnter = false;
            this.dgvAdicionales.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionales.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAdicionales.RowHeadersWidth = 25;
            this.dgvAdicionales.RowTemplate.Height = 18;
            this.dgvAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdicionales.Size = new System.Drawing.Size(994, 182);
            this.dgvAdicionales.StandardTab = true;
            this.dgvAdicionales.TabIndex = 666;
            // 
            // Frm_Con_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 668);
            this.Controls.Add(this.dgvAdicionales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDet1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Stb);
            this.Controls.Add(this.dgvCab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_Con_Registro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Consulta de Registros";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Con_Registro_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Con_Registro_KeyDown);
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCab)).EndInit();
            this.Stb.ResumeLayout(false);
            this.Stb.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private MigControls.MigDataGridView dgvCab;
        private MigControls.MigDataGridView dgvDet1;
        private System.Windows.Forms.Label label15;
        private MigControls.MigTextbox txtRazsoc;
        private System.Windows.Forms.Label label14;
        private MigControls.MigTextbox txtNombre;
        private System.Windows.Forms.Label label13;
        private MigControls.MigTextbox txtApemat;
        private System.Windows.Forms.Label label12;
        private MigControls.MigTextbox txtApepat;
        private System.Windows.Forms.Label lblNum;
        private MigControls.MigTextbox txtNum;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label9;
        private MigControls.MigTextbox txtCodim1;
        private System.Windows.Forms.StatusStrip Stb;
        private System.Windows.Forms.ToolStripStatusLabel LblMensaje;
        private System.Windows.Forms.ToolStripButton bExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MigControls.MigTextbox txtCodim2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdicionales;
        private MigControls.MigDataGridView dgvAdicionales;
        private System.Windows.Forms.Label lblcodcli;
        private MigControls.MigTextbox txtCodcli;
        private System.Windows.Forms.Label lblTipcar;
        private MigControls.MigCombobox cboTfile;
        private System.Windows.Forms.Label lblNroReclamacion;
        private MigControls.MigTextbox txtNroReclamacion;

    }
}