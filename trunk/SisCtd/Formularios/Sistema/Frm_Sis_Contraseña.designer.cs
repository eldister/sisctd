namespace BESisCtd
{
    partial class Frm_Sis_Contraseña
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtActual = new MigControls.MigTextbox();
            this.TxtNuevo = new MigControls.MigTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmar = new MigControls.MigTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña Nueva *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña actual *";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(215, 140);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(66, 26);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(147, 140);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(66, 26);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtActual
            // 
            this.TxtActual.BackColor = System.Drawing.Color.White;
            this.TxtActual.Car_Años = 4;
            this.TxtActual.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.TxtActual.ColorSalida = System.Drawing.Color.White;
            this.TxtActual.Decimales = 2;
            this.TxtActual.Guiones = false;
            this.TxtActual.Location = new System.Drawing.Point(136, 46);
            this.TxtActual.MaxLength = 10;
            this.TxtActual.Name = "TxtActual";
            this.TxtActual.PasarEnter = true;
            this.TxtActual.PasswordChar = '*';
            this.TxtActual.Size = new System.Drawing.Size(145, 20);
            this.TxtActual.TabIndex = 0;
            this.TxtActual.Tipo = MigControls.MigTextbox.TipoVal.Texto;
            // 
            // TxtNuevo
            // 
            this.TxtNuevo.BackColor = System.Drawing.Color.White;
            this.TxtNuevo.Car_Años = 4;
            this.TxtNuevo.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.TxtNuevo.ColorSalida = System.Drawing.Color.White;
            this.TxtNuevo.Decimales = 2;
            this.TxtNuevo.Guiones = false;
            this.TxtNuevo.Location = new System.Drawing.Point(136, 76);
            this.TxtNuevo.MaxLength = 10;
            this.TxtNuevo.Name = "TxtNuevo";
            this.TxtNuevo.PasarEnter = true;
            this.TxtNuevo.PasswordChar = '*';
            this.TxtNuevo.Size = new System.Drawing.Size(145, 20);
            this.TxtNuevo.TabIndex = 1;
            this.TxtNuevo.Tipo = MigControls.MigTextbox.TipoVal.Texto;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirmar Contraseña *";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.White;
            this.txtConfirmar.Car_Años = 4;
            this.txtConfirmar.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtConfirmar.ColorSalida = System.Drawing.Color.White;
            this.txtConfirmar.Decimales = 2;
            this.txtConfirmar.Guiones = false;
            this.txtConfirmar.Location = new System.Drawing.Point(136, 106);
            this.txtConfirmar.MaxLength = 10;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasarEnter = true;
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(145, 20);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.Tipo = MigControls.MigTextbox.TipoVal.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Location = new System.Drawing.Point(136, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(145, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Sis_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 176);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNuevo);
            this.Controls.Add(this.TxtActual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Contraseña";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cambiar Contraseña";
            this.Load += new System.EventHandler(this.Frm_Sis_Contraseña_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sis_Contraseña_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private MigControls.MigTextbox TxtActual;
        private MigControls.MigTextbox TxtNuevo;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
    }
}