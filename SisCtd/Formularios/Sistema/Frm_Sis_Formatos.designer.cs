namespace SisCtd
{
    partial class Frm_Sis_Formatos
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
            this.BarraSis = new System.Windows.Forms.ToolStrip();
            this.bImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bCerrar = new System.Windows.Forms.ToolStripButton();
            this.Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BarraSis.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSis
            // 
            this.BarraSis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bImprimir,
            this.toolStripSeparator2,
            this.bCerrar});
            this.BarraSis.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BarraSis.Location = new System.Drawing.Point(0, 0);
            this.BarraSis.Name = "BarraSis";
            this.BarraSis.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraSis.Size = new System.Drawing.Size(814, 23);
            this.BarraSis.TabIndex = 169;
            // 
            // bImprimir
            // 
            this.bImprimir.Image = global::SisCtd.Properties.Resources.Toolbar_Print;
            this.bImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(65, 20);
            this.bImprimir.Text = "&Imprimir";
            this.bImprimir.ToolTipText = "Imprimir";
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bCerrar
            // 
            this.bCerrar.Image = global::SisCtd.Properties.Resources.Toolbar_Close;
            this.bCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(58, 20);
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Report
            // 
            this.Report.ActiveViewIndex = -1;
            this.Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report.DisplayGroupTree = false;
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report.Location = new System.Drawing.Point(0, 23);
            this.Report.Name = "Report";
            this.Report.SelectionFormula = "";
            this.Report.ShowCloseButton = false;
            this.Report.ShowExportButton = false;
            this.Report.ShowGotoPageButton = false;
            this.Report.ShowGroupTreeButton = false;
            this.Report.ShowPrintButton = false;
            this.Report.Size = new System.Drawing.Size(814, 457);
            this.Report.TabIndex = 170;
            this.Report.ViewTimeSelectionFormula = "";
            // 
            // Frm_Sis_Formatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(814, 480);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.BarraSis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_Sis_Formatos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Formatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmFormatos_KeyPress);
            this.BarraSis.ResumeLayout(false);
            this.BarraSis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraSis;
        private System.Windows.Forms.ToolStripButton bImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bCerrar;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer Report;
    }
}