namespace SisCtd
{
    partial class Frm_Sis_Busquedas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuBus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBus = new System.Windows.Forms.Label();
            this.Dg1 = new MigControls.MigDataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblFil = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.txtBus = new MigControls.MigTextbox();
            this.MenuBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBus
            // 
            this.MenuBus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.MenuBus.Name = "MenuBus";
            this.MenuBus.Size = new System.Drawing.Size(129, 70);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBus.Location = new System.Drawing.Point(2, 10);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(74, 13);
            this.lblBus.TabIndex = 227;
            this.lblBus.Text = "Descripción";
            // 
            // Dg1
            // 
            this.Dg1.AllowUserToAddRows = false;
            this.Dg1.AllowUserToDeleteRows = false;
            this.Dg1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.Dg1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Dg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg1.Location = new System.Drawing.Point(4, 31);
            this.Dg1.MultiSelect = false;
            this.Dg1.Name = "Dg1";
            this.Dg1.PasarEnter = false;
            this.Dg1.ReadOnly = true;
            this.Dg1.RowHeadersWidth = 40;
            this.Dg1.RowTemplate.Height = 18;
            this.Dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg1.Size = new System.Drawing.Size(433, 338);
            this.Dg1.StandardTab = true;
            this.Dg1.TabIndex = 2;
            this.Dg1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg1_CellDoubleClick);
            this.Dg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dg1_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(378, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            // 
            // lblFil
            // 
            this.lblFil.AutoSize = true;
            this.lblFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFil.ForeColor = System.Drawing.Color.Maroon;
            this.lblFil.Location = new System.Drawing.Point(4, 383);
            this.lblFil.Name = "lblFil";
            this.lblFil.Size = new System.Drawing.Size(133, 13);
            this.lblFil.TabIndex = 669;
            this.lblFil.Text = "F7 = Filtrar por Código";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(371, 374);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(66, 27);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Location = new System.Drawing.Point(302, 374);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(66, 27);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.Car_Años = 4;
            this.txtBus.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtBus.ColorSalida = System.Drawing.Color.White;
            this.txtBus.Decimales = 2;
            this.txtBus.Guiones = false;
            this.txtBus.Location = new System.Drawing.Point(82, 6);
            this.txtBus.MaxLength = 30;
            this.txtBus.Name = "txtBus";
            this.txtBus.PasarEnter = false;
            this.txtBus.Size = new System.Drawing.Size(290, 20);
            this.txtBus.TabIndex = 0;
            this.txtBus.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtBus.TextChanged += new System.EventHandler(this.txtBus_TextChanged);
            this.txtBus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBus_KeyDown);
            // 
            // Frm_Sis_Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 409);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.lblFil);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Dg1);
            this.Controls.Add(this.lblBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Busquedas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Buscar Valor";
            this.Activated += new System.EventHandler(this.Frm_Sis_Busquedas_Activated);
            this.Load += new System.EventHandler(this.Frm_Sis_Busquedas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Sis_Busquedas_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Busquedas_KeyPress);
            this.MenuBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.ContextMenuStrip MenuBus;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MigControls.MigDataGridView Dg1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblFil;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private MigControls.MigTextbox txtBus;
    }
}