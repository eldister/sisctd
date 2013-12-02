namespace SisCtd
{
    partial class Frm_Reg_Control_Actividad
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtActividad = new MigControls.MigTextbox();
            this.txtDuracionendias = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(472, 68);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(386, 68);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 736;
            this.label3.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.BackColor = System.Drawing.Color.White;
            this.txtActividad.Car_Años = 4;
            this.txtActividad.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtActividad.ColorSalida = System.Drawing.Color.White;
            this.txtActividad.Decimales = 2;
            this.txtActividad.Guiones = false;
            this.txtActividad.Location = new System.Drawing.Point(116, 12);
            this.txtActividad.MaxLength = 10;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.PasarEnter = true;
            this.txtActividad.Size = new System.Drawing.Size(73, 20);
            this.txtActividad.TabIndex = 3;
            this.txtActividad.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtActividad.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtActividad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // txtDuracionendias
            // 
            this.txtDuracionendias.BackColor = System.Drawing.Color.White;
            this.txtDuracionendias.Car_Años = 4;
            this.txtDuracionendias.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDuracionendias.ColorSalida = System.Drawing.Color.White;
            this.txtDuracionendias.Decimales = 2;
            this.txtDuracionendias.Guiones = false;
            this.txtDuracionendias.Location = new System.Drawing.Point(116, 41);
            this.txtDuracionendias.MaxLength = 10;
            this.txtDuracionendias.Name = "txtDuracionendias";
            this.txtDuracionendias.PasarEnter = true;
            this.txtDuracionendias.Size = new System.Drawing.Size(40, 20);
            this.txtDuracionendias.TabIndex = 748;
            this.txtDuracionendias.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtDuracionendias.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtDuracionendias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 750;
            this.label5.Text = "Durancion en Dias";
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.SystemColors.Info;
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.Location = new System.Drawing.Point(191, 12);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(361, 20);
            this.lblActividad.TabIndex = 754;
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Reg_Control_Actividad
            // 
            this.ClientSize = new System.Drawing.Size(562, 108);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.txtDuracionendias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reg_Control_Actividad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Agregar Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtActividad;
        private MigControls.MigTextbox txtDuracionendias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblActividad;

    }
}