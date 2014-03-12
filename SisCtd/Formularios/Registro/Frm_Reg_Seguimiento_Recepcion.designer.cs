namespace SisCtd
{
    partial class Frm_Reg_Seguimiento_Recepcion
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesTipoDocumento = new System.Windows.Forms.Label();
            this.lblDesMaestroCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.txtIdControl = new MigControls.MigTextbox();
            this.lblIdTipoDocumento = new System.Windows.Forms.Label();
            this.lblIdMaestroCliente = new System.Windows.Forms.Label();
            this.lblIdActividad = new System.Windows.Forms.Label();
            this.lblDesActividad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblFechaDocumento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new MigControls.MigTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacionGeneral = new MigControls.MigTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDesOficinaRecepcion = new System.Windows.Forms.Label();
            this.lblIdOficinaRecepcion = new System.Windows.Forms.Label();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDesEmpleado = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDesAreaRecepcion = new System.Windows.Forms.Label();
            this.lblIdAreaRecepcion = new System.Windows.Forms.Label();
            this.lblHoraRecepcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id Control *";
            // 
            // lblDesTipoDocumento
            // 
            this.lblDesTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesTipoDocumento.Location = new System.Drawing.Point(222, 41);
            this.lblDesTipoDocumento.Name = "lblDesTipoDocumento";
            this.lblDesTipoDocumento.Size = new System.Drawing.Size(322, 20);
            this.lblDesTipoDocumento.TabIndex = 10;
            this.lblDesTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesMaestroCliente
            // 
            this.lblDesMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesMaestroCliente.Location = new System.Drawing.Point(222, 67);
            this.lblDesMaestroCliente.Name = "lblDesMaestroCliente";
            this.lblDesMaestroCliente.Size = new System.Drawing.Size(322, 20);
            this.lblDesMaestroCliente.TabIndex = 11;
            this.lblDesMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Número / Referencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Documento";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(464, 390);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(381, 390);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 2;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // txtIdControl
            // 
            this.txtIdControl.BackColor = System.Drawing.Color.White;
            this.txtIdControl.Car_Años = 4;
            this.txtIdControl.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdControl.ColorSalida = System.Drawing.Color.White;
            this.txtIdControl.Decimales = 2;
            this.txtIdControl.Guiones = false;
            this.txtIdControl.Location = new System.Drawing.Point(128, 15);
            this.txtIdControl.MaxLength = 25;
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.PasarEnter = false;
            this.txtIdControl.Size = new System.Drawing.Size(191, 20);
            this.txtIdControl.TabIndex = 0;
            this.txtIdControl.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdControl.TextChanged += new System.EventHandler(this.txtIdControl_TextChanged);
            this.txtIdControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdControl_KeyPress);
            // 
            // lblIdTipoDocumento
            // 
            this.lblIdTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdTipoDocumento.Location = new System.Drawing.Point(128, 41);
            this.lblIdTipoDocumento.Name = "lblIdTipoDocumento";
            this.lblIdTipoDocumento.Size = new System.Drawing.Size(91, 20);
            this.lblIdTipoDocumento.TabIndex = 1;
            this.lblIdTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdMaestroCliente
            // 
            this.lblIdMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdMaestroCliente.Location = new System.Drawing.Point(128, 67);
            this.lblIdMaestroCliente.Name = "lblIdMaestroCliente";
            this.lblIdMaestroCliente.Size = new System.Drawing.Size(91, 20);
            this.lblIdMaestroCliente.TabIndex = 2;
            this.lblIdMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdActividad
            // 
            this.lblIdActividad.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdActividad.Location = new System.Drawing.Point(128, 181);
            this.lblIdActividad.Name = "lblIdActividad";
            this.lblIdActividad.Size = new System.Drawing.Size(91, 20);
            this.lblIdActividad.TabIndex = 4;
            this.lblIdActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesActividad
            // 
            this.lblDesActividad.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesActividad.Location = new System.Drawing.Point(222, 181);
            this.lblDesActividad.Name = "lblDesActividad";
            this.lblDesActividad.Size = new System.Drawing.Size(322, 20);
            this.lblDesActividad.TabIndex = 38;
            this.lblDesActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Actividad";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNroDocumento.Location = new System.Drawing.Point(128, 93);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(191, 20);
            this.lblNroDocumento.TabIndex = 3;
            this.lblNroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaDocumento.Location = new System.Drawing.Point(461, 93);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(83, 20);
            this.lblFechaDocumento.TabIndex = 39;
            this.lblFechaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Observacion Actividad";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Car_Años = 4;
            this.txtObservacion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtObservacion.ColorSalida = System.Drawing.Color.White;
            this.txtObservacion.Decimales = 2;
            this.txtObservacion.Guiones = false;
            this.txtObservacion.Location = new System.Drawing.Point(128, 316);
            this.txtObservacion.MaxLength = 300;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasarEnter = true;
            this.txtObservacion.Size = new System.Drawing.Size(416, 64);
            this.txtObservacion.TabIndex = 1;
            this.txtObservacion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Observación General";
            // 
            // txtObservacionGeneral
            // 
            this.txtObservacionGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.txtObservacionGeneral.Car_Años = 4;
            this.txtObservacionGeneral.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtObservacionGeneral.ColorSalida = System.Drawing.Color.White;
            this.txtObservacionGeneral.Decimales = 2;
            this.txtObservacionGeneral.Guiones = false;
            this.txtObservacionGeneral.Location = new System.Drawing.Point(128, 121);
            this.txtObservacionGeneral.MaxLength = 200;
            this.txtObservacionGeneral.Multiline = true;
            this.txtObservacionGeneral.Name = "txtObservacionGeneral";
            this.txtObservacionGeneral.PasarEnter = true;
            this.txtObservacionGeneral.ReadOnly = true;
            this.txtObservacionGeneral.Size = new System.Drawing.Size(416, 42);
            this.txtObservacionGeneral.TabIndex = 4;
            this.txtObservacionGeneral.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Oficina Recepción";
            // 
            // lblDesOficinaRecepcion
            // 
            this.lblDesOficinaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesOficinaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesOficinaRecepcion.Location = new System.Drawing.Point(222, 261);
            this.lblDesOficinaRecepcion.Name = "lblDesOficinaRecepcion";
            this.lblDesOficinaRecepcion.Size = new System.Drawing.Size(322, 20);
            this.lblDesOficinaRecepcion.TabIndex = 46;
            this.lblDesOficinaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdOficinaRecepcion
            // 
            this.lblIdOficinaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaRecepcion.Location = new System.Drawing.Point(128, 261);
            this.lblIdOficinaRecepcion.Name = "lblIdOficinaRecepcion";
            this.lblIdOficinaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblIdOficinaRecepcion.TabIndex = 44;
            this.lblIdOficinaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(128, 208);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblFechaRecepcion.TabIndex = 43;
            this.lblFechaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Fecha Recepcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Empleado Recepción";
            // 
            // lblDesEmpleado
            // 
            this.lblDesEmpleado.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesEmpleado.Location = new System.Drawing.Point(222, 234);
            this.lblDesEmpleado.Name = "lblDesEmpleado";
            this.lblDesEmpleado.Size = new System.Drawing.Size(322, 20);
            this.lblDesEmpleado.TabIndex = 49;
            this.lblDesEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdEmpleado.Location = new System.Drawing.Point(128, 234);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(91, 20);
            this.lblIdEmpleado.TabIndex = 48;
            this.lblIdEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Area Recepción";
            // 
            // lblDesAreaRecepcion
            // 
            this.lblDesAreaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesAreaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesAreaRecepcion.Location = new System.Drawing.Point(222, 288);
            this.lblDesAreaRecepcion.Name = "lblDesAreaRecepcion";
            this.lblDesAreaRecepcion.Size = new System.Drawing.Size(322, 20);
            this.lblDesAreaRecepcion.TabIndex = 52;
            this.lblDesAreaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdAreaRecepcion
            // 
            this.lblIdAreaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdAreaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdAreaRecepcion.Location = new System.Drawing.Point(128, 288);
            this.lblIdAreaRecepcion.Name = "lblIdAreaRecepcion";
            this.lblIdAreaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblIdAreaRecepcion.TabIndex = 51;
            this.lblIdAreaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoraRecepcion
            // 
            this.lblHoraRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblHoraRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoraRecepcion.Location = new System.Drawing.Point(222, 208);
            this.lblHoraRecepcion.Name = "lblHoraRecepcion";
            this.lblHoraRecepcion.Size = new System.Drawing.Size(72, 20);
            this.lblHoraRecepcion.TabIndex = 92;
            this.lblHoraRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHoraRecepcion.Click += new System.EventHandler(this.lblHoraRecepcion_Click);
            // 
            // Frm_Reg_Seguimiento_Recepcion
            // 
            this.ClientSize = new System.Drawing.Size(558, 430);
            this.Controls.Add(this.lblHoraRecepcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDesAreaRecepcion);
            this.Controls.Add(this.lblIdAreaRecepcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDesEmpleado);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDesOficinaRecepcion);
            this.Controls.Add(this.lblIdOficinaRecepcion);
            this.Controls.Add(this.lblFechaRecepcion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtObservacionGeneral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblFechaDocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblIdActividad);
            this.Controls.Add(this.lblDesActividad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblIdMaestroCliente);
            this.Controls.Add(this.lblIdTipoDocumento);
            this.Controls.Add(this.txtIdControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDesMaestroCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDesTipoDocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reg_Seguimiento_Recepcion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Recepción de Documentos";
            this.Load += new System.EventHandler(this.Frm_Reg_Seguimiento_Recepcion_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Reg_Seguimiento_Recepcion_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesTipoDocumento;
        private System.Windows.Forms.Label lblDesMaestroCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private MigControls.MigTextbox txtIdControl;
        private System.Windows.Forms.Label lblIdTipoDocumento;
        private System.Windows.Forms.Label lblIdMaestroCliente;
        private System.Windows.Forms.Label lblIdActividad;
        private System.Windows.Forms.Label lblDesActividad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblFechaDocumento;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtObservacion;
        private System.Windows.Forms.Label label3;
        private MigControls.MigTextbox txtObservacionGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDesOficinaRecepcion;
        private System.Windows.Forms.Label lblIdOficinaRecepcion;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDesEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDesAreaRecepcion;
        private System.Windows.Forms.Label lblIdAreaRecepcion;
        private System.Windows.Forms.Label lblHoraRecepcion;

    }
}