namespace BESisCtd
{
    partial class Frm_Sis_Perfil_Det
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescrip = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(350, 97);
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
            this.BtnGrabar.Image = global::BESisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(267, 97);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 1;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripción *";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Car_Años = 4;
            this.txtDescrip.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDescrip.ColorSalida = System.Drawing.Color.White;
            this.txtDescrip.Decimales = 2;
            this.txtDescrip.Guiones = false;
            this.txtDescrip.Location = new System.Drawing.Point(107, 49);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasarEnter = true;
            this.txtDescrip.Size = new System.Drawing.Size(323, 20);
            this.txtDescrip.TabIndex = 0;
            this.txtDescrip.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id. Perfil";
            // 
            // lblIdPerfil
            // 
            this.lblIdPerfil.BackColor = System.Drawing.SystemColors.Info;
            this.lblIdPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdPerfil.Location = new System.Drawing.Point(107, 17);
            this.lblIdPerfil.Name = "lblIdPerfil";
            this.lblIdPerfil.Size = new System.Drawing.Size(40, 19);
            this.lblIdPerfil.TabIndex = 3;
            this.lblIdPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Sis_Perfil_Det
            // 
            this.ClientSize = new System.Drawing.Size(439, 138);
            this.Controls.Add(this.lblIdPerfil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Perfil_Det";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Perifles";
            this.Activated += new System.EventHandler(this.Frm_Sis_Perfil_Det_Activated);
            this.Load += new System.EventHandler(this.Frm_Sis_Perfil_Det_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Perfil_Det_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private MigControls.MigTextbox txtDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdPerfil;

    }
}