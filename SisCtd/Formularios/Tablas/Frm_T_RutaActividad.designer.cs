namespace BESisCtd
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new MigControls.MigTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.txtOficina = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::BESisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(544, 129);
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
            this.BtnGrabar.Image = global::BESisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(463, 129);
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
            this.txtCodigo.Location = new System.Drawing.Point(149, 9);
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
            this.label3.Location = new System.Drawing.Point(14, 37);
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
            this.txtActividad.Location = new System.Drawing.Point(149, 33);
            this.txtActividad.MaxLength = 10;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.PasarEnter = true;
            this.txtActividad.Size = new System.Drawing.Size(62, 20);
            this.txtActividad.TabIndex = 3;
            this.txtActividad.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtActividad.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtActividad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.SystemColors.Info;
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.Location = new System.Drawing.Point(217, 33);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(373, 20);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpleado.Location = new System.Drawing.Point(217, 70);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(373, 20);
            this.lblEmpleado.TabIndex = 746;
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.White;
            this.txtEmpleado.Car_Años = 4;
            this.txtEmpleado.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtEmpleado.ColorSalida = System.Drawing.Color.White;
            this.txtEmpleado.Decimales = 2;
            this.txtEmpleado.Guiones = false;
            this.txtEmpleado.Location = new System.Drawing.Point(149, 70);
            this.txtEmpleado.MaxLength = 10;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasarEnter = true;
            this.txtEmpleado.Size = new System.Drawing.Size(62, 20);
            this.txtEmpleado.TabIndex = 745;
            this.txtEmpleado.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 747;
            this.label4.Text = "Empleado";
            // 
            // lblOficina
            // 
            this.lblOficina.BackColor = System.Drawing.SystemColors.Info;
            this.lblOficina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOficina.Location = new System.Drawing.Point(217, 95);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(373, 20);
            this.lblOficina.TabIndex = 749;
            this.lblOficina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.Color.White;
            this.txtOficina.Car_Años = 4;
            this.txtOficina.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtOficina.ColorSalida = System.Drawing.Color.White;
            this.txtOficina.Decimales = 2;
            this.txtOficina.Guiones = false;
            this.txtOficina.Location = new System.Drawing.Point(149, 95);
            this.txtOficina.MaxLength = 10;
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.PasarEnter = true;
            this.txtOficina.Size = new System.Drawing.Size(62, 20);
            this.txtOficina.TabIndex = 748;
            this.txtOficina.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtOficina.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtOficina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 750;
            this.label5.Text = "Oficina";
            // 
            // lblRuta
            // 
            this.lblRuta.BackColor = System.Drawing.SystemColors.Info;
            this.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta.Location = new System.Drawing.Point(217, 9);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(373, 20);
            this.lblRuta.TabIndex = 751;
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_T_RutaActividad
            // 
            this.ClientSize = new System.Drawing.Size(636, 168);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActividad);
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
            this.Load += new System.EventHandler(this.Frm_T_RutaActividad_Load_1);
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
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblEmpleado;
        private MigControls.MigTextbox txtEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOficina;
        private MigControls.MigTextbox txtOficina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRuta;

    }
}