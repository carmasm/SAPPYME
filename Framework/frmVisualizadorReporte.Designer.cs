namespace Framework
{
    partial class frmVisualizadorReporte
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizadorReporte));
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.Icons = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).BeginInit();
            this.SuspendLayout();
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(1, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 19);
            this.lblTitulo.TabIndex = 120;
            this.lblTitulo.Text = "Titulo";
            // 
            // Icons
            // 
            this.Icons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Icons.Images.Add(((System.Drawing.Image)(resources.GetObject("Icons.Images"))));
            this.Icons.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.Icons.Location = new System.Drawing.Point(13, 413);
            this.Icons.Name = "Icons";
            this.Icons.Size = new System.Drawing.Size(122, 92);
            this.Icons.TabIndex = 119;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 118;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 117;
            // 
            // sbSalir
            // 
            this.sbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSalir.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbSalir.Appearance.Options.UseFont = true;
            this.sbSalir.Image = global::Framework.Properties.Resources.Logout;
            this.sbSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbSalir.Location = new System.Drawing.Point(100, 372);
            this.sbSalir.Name = "sbSalir";
            this.sbSalir.Size = new System.Drawing.Size(35, 35);
            this.sbSalir.TabIndex = 122;
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.CachedPageNumberPerDoc = 10;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.EnableRefresh = false;
            this.crViewer.Location = new System.Drawing.Point(149, 47);
            this.crViewer.Name = "crViewer";
            this.crViewer.ShowCloseButton = false;
            this.crViewer.ShowCopyButton = false;
            this.crViewer.ShowGroupTreeButton = false;
            this.crViewer.ShowLogo = false;
            this.crViewer.ShowParameterPanelButton = false;
            this.crViewer.ShowRefreshButton = false;
            this.crViewer.ShowTextSearchButton = false;
            this.crViewer.Size = new System.Drawing.Size(440, 458);
            this.crViewer.TabIndex = 144;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmVisualizadorReporte
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(601, 540);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.sbSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Icons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVisualizadorReporte";
            this.Load += new System.EventHandler(this.frmVisualizadorReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.Controls.ImageSlider Icons;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton sbSalir;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}
