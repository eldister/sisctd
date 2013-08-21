namespace SisCtd
{
    partial class Frm_Sis_Acceso_Mod
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(232, 82);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(149, 82);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 1;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seleccione Perfil";
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Items.AddRange(new object[] {
            "Estandar",
            "Rrhh",
            "Nextel"});
            this.cboPerfiles.Location = new System.Drawing.Point(23, 34);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(224, 21);
            this.cboPerfiles.TabIndex = 0;
            // 
            // Frm_Sis_Accesol_Mod
            // 
            this.ClientSize = new System.Drawing.Size(331, 126);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboPerfiles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Accesol_Mod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Modificar Perfil";
            this.Load += new System.EventHandler(this.Frm_Sis_Acceso_Mod_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Acceso_Mod_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPerfiles;

    }
}