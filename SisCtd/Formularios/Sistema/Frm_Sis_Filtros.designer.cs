namespace SisCtd
{
    partial class Frm_Sis_Filtros
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
            this.MenuBus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHastaR = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDesdeR = new System.Windows.Forms.DateTimePicker();
            this.lblOficina = new System.Windows.Forms.Label();
            this.txtOficina = new MigControls.MigTextbox();
            this.dtpHastaD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesdeD = new System.Windows.Forms.DateTimePicker();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new MigControls.MigTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new MigControls.MigTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.MenuBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBus
            // 
            this.MenuBus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.MenuBus.Name = "MenuBus";
            this.MenuBus.Size = new System.Drawing.Size(126, 70);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(502, 186);
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
            this.BtnAceptar.Location = new System.Drawing.Point(433, 186);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(66, 27);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Hasta";
            // 
            // dtpHastaR
            // 
            this.dtpHastaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaR.Location = new System.Drawing.Point(289, 37);
            this.dtpHastaR.Name = "dtpHastaR";
            this.dtpHastaR.ShowCheckBox = true;
            this.dtpHastaR.Size = new System.Drawing.Size(114, 22);
            this.dtpHastaR.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Desde";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Fechas  Recepcion  ";
            // 
            // dtpDesdeR
            // 
            this.dtpDesdeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeR.Location = new System.Drawing.Point(155, 37);
            this.dtpDesdeR.Name = "dtpDesdeR";
            this.dtpDesdeR.ShowCheckBox = true;
            this.dtpDesdeR.Size = new System.Drawing.Size(109, 22);
            this.dtpDesdeR.TabIndex = 81;
            // 
            // lblOficina
            // 
            this.lblOficina.BackColor = System.Drawing.SystemColors.Info;
            this.lblOficina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOficina.Location = new System.Drawing.Point(246, 100);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(308, 20);
            this.lblOficina.TabIndex = 85;
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
            this.txtOficina.Location = new System.Drawing.Point(156, 101);
            this.txtOficina.MaxLength = 10;
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.PasarEnter = true;
            this.txtOficina.Size = new System.Drawing.Size(75, 20);
            this.txtOficina.TabIndex = 84;
            this.txtOficina.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtOficina.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtOficina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // dtpHastaD
            // 
            this.dtpHastaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaD.Location = new System.Drawing.Point(289, 65);
            this.dtpHastaD.Name = "dtpHastaD";
            this.dtpHastaD.ShowCheckBox = true;
            this.dtpHastaD.Size = new System.Drawing.Size(114, 22);
            this.dtpHastaD.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Fechas  Documento";
            // 
            // dtpDesdeD
            // 
            this.dtpDesdeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeD.Location = new System.Drawing.Point(155, 65);
            this.dtpDesdeD.Name = "dtpDesdeD";
            this.dtpDesdeD.ShowCheckBox = true;
            this.dtpDesdeD.Size = new System.Drawing.Size(109, 22);
            this.dtpDesdeD.TabIndex = 87;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.Info;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(246, 127);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(308, 20);
            this.lblArea.TabIndex = 90;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.White;
            this.txtArea.Car_Años = 4;
            this.txtArea.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtArea.ColorSalida = System.Drawing.Color.White;
            this.txtArea.Decimales = 2;
            this.txtArea.Guiones = false;
            this.txtArea.Location = new System.Drawing.Point(156, 128);
            this.txtArea.MaxLength = 10;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasarEnter = true;
            this.txtArea.Size = new System.Drawing.Size(75, 20);
            this.txtArea.TabIndex = 89;
            this.txtArea.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtArea.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Oficina Recepcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Area Recepcion";
            // 
            // lblRuta
            // 
            this.lblRuta.BackColor = System.Drawing.SystemColors.Info;
            this.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRuta.Location = new System.Drawing.Point(246, 154);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(308, 20);
            this.lblRuta.TabIndex = 94;
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.Car_Años = 4;
            this.txtRuta.ColorEntrada = System.Drawing.Color.LemonChiffon;
            this.txtRuta.ColorSalida = System.Drawing.Color.White;
            this.txtRuta.Decimales = 2;
            this.txtRuta.Guiones = false;
            this.txtRuta.Location = new System.Drawing.Point(156, 155);
            this.txtRuta.MaxLength = 10;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.PasarEnter = true;
            this.txtRuta.Size = new System.Drawing.Size(75, 20);
            this.txtRuta.TabIndex = 93;
            this.txtRuta.Tipo = MigControls.MigTextbox.TipoVal.Numerico;
            this.txtRuta.TextChanged += new System.EventHandler(this.PonerDescrip_TextChanged);
            this.txtRuta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AyudaF1_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Ruta";
            // 
            // Frm_Sis_Filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(580, 225);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.dtpHastaD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDesdeD);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHastaR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpDesdeR);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sis_Filtros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros Avanzados";
            this.Load += new System.EventHandler(this.Frm_Sis_Filtros_Load);
            this.MenuBus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuBus;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHastaR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDesdeR;
        private System.Windows.Forms.Label lblOficina;
        private MigControls.MigTextbox txtOficina;
        private System.Windows.Forms.DateTimePicker dtpHastaD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesdeD;
        private System.Windows.Forms.Label lblArea;
        private MigControls.MigTextbox txtArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuta;
        private MigControls.MigTextbox txtRuta;
        private System.Windows.Forms.Label label8;
    }
}