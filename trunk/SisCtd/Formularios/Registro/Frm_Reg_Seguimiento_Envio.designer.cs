namespace SisCtd
{
    partial class Frm_Reg_Seguimiento_Envio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdOficinaRecepcionDes = new System.Windows.Forms.Label();
            this.lblIdOficinaRecepcion = new System.Windows.Forms.Label();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDetalle = new MigControls.MigTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new MigControls.MigTextbox();
            this.lblFechaDocumento = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblIdActividad = new System.Windows.Forms.Label();
            this.lblDesActividad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIdMaestroCliente = new System.Windows.Forms.Label();
            this.lblIdTipoDocumento = new System.Windows.Forms.Label();
            this.txtIdControl = new MigControls.MigTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesMaestroCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDesTipoDocumento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdOficinaDestinatarioDes = new System.Windows.Forms.Label();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdOficinaDestinatario = new MigControls.MigTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgDetalle = new MigControls.MigDataGridView();
            this.IdImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Oficina Recepción";
            // 
            // lblIdOficinaRecepcionDes
            // 
            this.lblIdOficinaRecepcionDes.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaRecepcionDes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaRecepcionDes.Location = new System.Drawing.Point(218, 219);
            this.lblIdOficinaRecepcionDes.Name = "lblIdOficinaRecepcionDes";
            this.lblIdOficinaRecepcionDes.Size = new System.Drawing.Size(322, 20);
            this.lblIdOficinaRecepcionDes.TabIndex = 72;
            this.lblIdOficinaRecepcionDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdOficinaRecepcion
            // 
            this.lblIdOficinaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaRecepcion.Location = new System.Drawing.Point(124, 219);
            this.lblIdOficinaRecepcion.Name = "lblIdOficinaRecepcion";
            this.lblIdOficinaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblIdOficinaRecepcion.TabIndex = 70;
            this.lblIdOficinaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(124, 192);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(91, 20);
            this.lblFechaRecepcion.TabIndex = 69;
            this.lblFechaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Fecha Recepcion";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.Control;
            this.txtDetalle.Car_Años = 4;
            this.txtDetalle.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtDetalle.ColorSalida = System.Drawing.Color.White;
            this.txtDetalle.Decimales = 2;
            this.txtDetalle.Guiones = false;
            this.txtDetalle.Location = new System.Drawing.Point(124, 143);
            this.txtDetalle.MaxLength = 200;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PasarEnter = true;
            this.txtDetalle.ReadOnly = true;
            this.txtDetalle.Size = new System.Drawing.Size(416, 42);
            this.txtDetalle.TabIndex = 55;
            this.txtDetalle.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Car_Años = 4;
            this.txtObservacion.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtObservacion.ColorSalida = System.Drawing.Color.White;
            this.txtObservacion.Decimales = 2;
            this.txtObservacion.Guiones = false;
            this.txtObservacion.Location = new System.Drawing.Point(124, 326);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasarEnter = true;
            this.txtObservacion.Size = new System.Drawing.Size(416, 43);
            this.txtObservacion.TabIndex = 49;
            this.txtObservacion.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaDocumento.Location = new System.Drawing.Point(457, 90);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(83, 20);
            this.lblFechaDocumento.TabIndex = 65;
            this.lblFechaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNroDocumento.Location = new System.Drawing.Point(124, 90);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(191, 20);
            this.lblNroDocumento.TabIndex = 54;
            this.lblNroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdActividad
            // 
            this.lblIdActividad.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdActividad.Location = new System.Drawing.Point(124, 116);
            this.lblIdActividad.Name = "lblIdActividad";
            this.lblIdActividad.Size = new System.Drawing.Size(91, 20);
            this.lblIdActividad.TabIndex = 56;
            this.lblIdActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesActividad
            // 
            this.lblDesActividad.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesActividad.Location = new System.Drawing.Point(218, 116);
            this.lblDesActividad.Name = "lblDesActividad";
            this.lblDesActividad.Size = new System.Drawing.Size(322, 20);
            this.lblDesActividad.TabIndex = 64;
            this.lblDesActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Actividad";
            // 
            // lblIdMaestroCliente
            // 
            this.lblIdMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdMaestroCliente.Location = new System.Drawing.Point(124, 64);
            this.lblIdMaestroCliente.Name = "lblIdMaestroCliente";
            this.lblIdMaestroCliente.Size = new System.Drawing.Size(91, 20);
            this.lblIdMaestroCliente.TabIndex = 52;
            this.lblIdMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdTipoDocumento
            // 
            this.lblIdTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdTipoDocumento.Location = new System.Drawing.Point(124, 38);
            this.lblIdTipoDocumento.Name = "lblIdTipoDocumento";
            this.lblIdTipoDocumento.Size = new System.Drawing.Size(91, 20);
            this.lblIdTipoDocumento.TabIndex = 50;
            this.lblIdTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdControl
            // 
            this.txtIdControl.BackColor = System.Drawing.Color.White;
            this.txtIdControl.Car_Años = 4;
            this.txtIdControl.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdControl.ColorSalida = System.Drawing.Color.White;
            this.txtIdControl.Decimales = 2;
            this.txtIdControl.Guiones = false;
            this.txtIdControl.Location = new System.Drawing.Point(124, 12);
            this.txtIdControl.MaxLength = 25;
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.PasarEnter = false;
            this.txtIdControl.Size = new System.Drawing.Size(191, 20);
            this.txtIdControl.TabIndex = 48;
            this.txtIdControl.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            this.txtIdControl.TextChanged += new System.EventHandler(this.txtIdControl_TextChanged);
            this.txtIdControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdControl_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Fecha Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Número / Referencia";
            // 
            // lblDesMaestroCliente
            // 
            this.lblDesMaestroCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesMaestroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesMaestroCliente.Location = new System.Drawing.Point(218, 64);
            this.lblDesMaestroCliente.Name = "lblDesMaestroCliente";
            this.lblDesMaestroCliente.Size = new System.Drawing.Size(322, 20);
            this.lblDesMaestroCliente.TabIndex = 58;
            this.lblDesMaestroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cliente";
            // 
            // lblDesTipoDocumento
            // 
            this.lblDesTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDesTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesTipoDocumento.Location = new System.Drawing.Point(218, 38);
            this.lblDesTipoDocumento.Name = "lblDesTipoDocumento";
            this.lblDesTipoDocumento.Size = new System.Drawing.Size(322, 20);
            this.lblDesTipoDocumento.TabIndex = 57;
            this.lblDesTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id Control *";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.BtnCancelar.Location = new System.Drawing.Point(520, 477);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.Text = "&Cerrar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = global::SisCtd.Properties.Resources.Toolbar_Save;
            this.BtnGrabar.Location = new System.Drawing.Point(437, 477);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(80, 28);
            this.BtnGrabar.TabIndex = 51;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Oficina Envio";
            // 
            // lblIdOficinaDestinatarioDes
            // 
            this.lblIdOficinaDestinatarioDes.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdOficinaDestinatarioDes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdOficinaDestinatarioDes.Location = new System.Drawing.Point(218, 299);
            this.lblIdOficinaDestinatarioDes.Name = "lblIdOficinaDestinatarioDes";
            this.lblIdOficinaDestinatarioDes.Size = new System.Drawing.Size(322, 20);
            this.lblIdOficinaDestinatarioDes.TabIndex = 77;
            this.lblIdOficinaDestinatarioDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaEnvio.Location = new System.Drawing.Point(124, 272);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(91, 20);
            this.lblFechaEnvio.TabIndex = 74;
            this.lblFechaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Fecha Envio";
            // 
            // txtIdOficinaDestinatario
            // 
            this.txtIdOficinaDestinatario.BackColor = System.Drawing.Color.White;
            this.txtIdOficinaDestinatario.Car_Años = 4;
            this.txtIdOficinaDestinatario.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtIdOficinaDestinatario.ColorSalida = System.Drawing.Color.White;
            this.txtIdOficinaDestinatario.Decimales = 2;
            this.txtIdOficinaDestinatario.Guiones = false;
            this.txtIdOficinaDestinatario.Location = new System.Drawing.Point(124, 299);
            this.txtIdOficinaDestinatario.MaxLength = 25;
            this.txtIdOficinaDestinatario.Name = "txtIdOficinaDestinatario";
            this.txtIdOficinaDestinatario.PasarEnter = true;
            this.txtIdOficinaDestinatario.Size = new System.Drawing.Size(91, 20);
            this.txtIdOficinaDestinatario.TabIndex = 79;
            this.txtIdOficinaDestinatario.Tipo = MigControls.MigTextbox.TipoVal.TextoMayuscula;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Datos Adjuntos";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            this.dgDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalle.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImagen,
            this.Nombre,
            this.Formato});
            this.dgDetalle.Location = new System.Drawing.Point(14, 398);
            this.dgDetalle.MultiSelect = false;
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.PasarEnter = false;
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersWidth = 25;
            this.dgDetalle.RowTemplate.Height = 18;
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(412, 74);
            this.dgDetalle.StandardTab = true;
            this.dgDetalle.TabIndex = 81;
            // 
            // IdImagen
            // 
            this.IdImagen.HeaderText = "IdImagen";
            this.IdImagen.Name = "IdImagen";
            this.IdImagen.ReadOnly = true;
            this.IdImagen.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Archivo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            this.Formato.Width = 60;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.Image = global::SisCtd.Properties.Resources._16__Db_delete_;
            this.btnQuitarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarArchivo.Location = new System.Drawing.Point(136, 477);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(110, 23);
            this.btnQuitarArchivo.TabIndex = 83;
            this.btnQuitarArchivo.Text = "&Quitar Archivo";
            this.btnQuitarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarArchivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Image = global::SisCtd.Properties.Resources._16__Db_insert_;
            this.btnAgregarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarImagen.Location = new System.Drawing.Point(14, 477);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarImagen.TabIndex = 82;
            this.btnAgregarImagen.Text = "&Agregar Archivo";
            this.btnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // Frm_Reg_Seguimiento_Envio
            // 
            this.ClientSize = new System.Drawing.Size(609, 516);
            this.Controls.Add(this.btnQuitarArchivo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIdOficinaDestinatario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIdOficinaDestinatarioDes);
            this.Controls.Add(this.lblFechaEnvio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIdOficinaRecepcionDes);
            this.Controls.Add(this.lblIdOficinaRecepcion);
            this.Controls.Add(this.lblFechaRecepcion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDetalle);
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
            this.Name = "Frm_Reg_Seguimiento_Envio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Envio de Documentos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Reg_Seguimiento_Envio_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdOficinaRecepcionDes;
        private System.Windows.Forms.Label lblIdOficinaRecepcion;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.Label label15;
        private MigControls.MigTextbox txtDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MigControls.MigTextbox txtObservacion;
        private System.Windows.Forms.Label lblFechaDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblIdActividad;
        private System.Windows.Forms.Label lblDesActividad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIdMaestroCliente;
        private System.Windows.Forms.Label lblIdTipoDocumento;
        private MigControls.MigTextbox txtIdControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesMaestroCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDesTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIdOficinaDestinatarioDes;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.Label label13;
        private MigControls.MigTextbox txtIdOficinaDestinatario;
        private System.Windows.Forms.Label label11;
        private MigControls.MigDataGridView dgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.Button btnQuitarArchivo;
        private System.Windows.Forms.Button btnAgregarImagen;


    }
}