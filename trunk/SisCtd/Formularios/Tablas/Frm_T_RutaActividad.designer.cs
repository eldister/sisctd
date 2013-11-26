namespace SisCtd
{
    partial class Frm_T_RutaActividad
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
            this.txtCodigo = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActividad = new MigControls.MigTextbox();
            this.txtDuracionendias = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(458, 75);
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
            this.BtnGrabar.Location = new System.Drawing.Point(377, 75);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Car_Años = 4;
            this.txtCodigo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.ColorSalida = System.Drawing.Color.White;
            this.txtCodigo.Decimales = 2;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Guiones = false;
            this.txtCodigo.Location = new System.Drawing.Point(116, 9);
            this.txtCodigo.MaxLength = 12;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasarEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtCodigo.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 708;
            this.label1.Text = "Id Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
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
            this.txtActividad.Location = new System.Drawing.Point(116, 36);
            this.txtActividad.MaxLength = 10;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.PasarEnter = true;
            this.txtActividad.Size = new System.Drawing.Size(62, 20);
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
            this.txtDuracionendias.Location = new System.Drawing.Point(116, 61);
            this.txtDuracionendias.MaxLength = 10;
            this.txtDuracionendias.Name = "txtDuracionendias";
            this.txtDuracionendias.PasarEnter = true;
            this.txtDuracionendias.Size = new System.Drawing.Size(62, 20);
            this.txtDuracionendias.TabIndex = 748;
            this.txtDuracionendias.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtDuracionendias.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtDuracionendias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 750;
            this.label5.Text = "Durancion en Dias";
            // 
            // lblRuta
            // 
            this.lblRuta.BackColor = System.Drawing.SystemColors.Info;
            this.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta.Location = new System.Drawing.Point(183, 8);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(373, 20);
            this.lblRuta.TabIndex = 753;
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.SystemColors.Info;
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.Location = new System.Drawing.Point(184, 36);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(373, 20);
            this.lblActividad.TabIndex = 754;
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_T_RutaActividad
            // 
            this.ClientSize = new System.Drawing.Size(562, 108);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtDuracionendias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_T_RutaActividad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruta_Actividad";
            this.Load += new System.EventHandler(this.Frm_T_RutaActividad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private MigControls.MigTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtActividad;
        private MigControls.MigTextbox txtDuracionendias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblActividad;

    }
}