namespace SAPPYME
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.xTabContenedor = new DevExpress.XtraTab.XtraTabControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.MenuBar = new DevExpress.XtraBars.Bar();
            this.bArchivo = new DevExpress.XtraBars.BarSubItem();
            this.bbtnCambiarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bCaja = new DevExpress.XtraBars.BarSubItem();
            this.bbtnCaja = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnConcepto = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.bConfiguracion = new DevExpress.XtraBars.BarSubItem();
            this.bbiUnidad = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImpuesto = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoneda = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.pbcProgreso = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTabContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcProgreso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // xTabContenedor
            // 
            this.xTabContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xTabContenedor.Location = new System.Drawing.Point(0, 30);
            this.xTabContenedor.Name = "xTabContenedor";
            this.xTabContenedor.Size = new System.Drawing.Size(622, 337);
            this.xTabContenedor.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MenuBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bArchivo,
            this.bbtnCambiarUsuario,
            this.bbtnSalir,
            this.bCaja,
            this.bbtnConcepto,
            this.bbtnCaja,
            this.bConfiguracion,
            this.bbiUnidad,
            this.bbiImpuesto,
            this.bbiMoneda,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem6,
            this.barSubItem3,
            this.barButtonItem7,
            this.barSubItem4,
            this.barButtonItem8,
            this.barSubItem5,
            this.barSubItem6,
            this.barButtonItem9,
            this.barSubItem7,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13});
            this.barManager1.MainMenu = this.MenuBar;
            this.barManager1.MaxItemId = 29;
            // 
            // MenuBar
            // 
            this.MenuBar.BarName = "Menú principal";
            this.MenuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MenuBar.DockCol = 0;
            this.MenuBar.DockRow = 0;
            this.MenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MenuBar.HideWhenMerging = DevExpress.Utils.DefaultBoolean.True;
            this.MenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bArchivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bCaja),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.bConfiguracion)});
            this.MenuBar.OptionsBar.AllowQuickCustomization = false;
            this.MenuBar.OptionsBar.DrawBorder = false;
            this.MenuBar.OptionsBar.MultiLine = true;
            this.MenuBar.OptionsBar.UseWholeRow = true;
            this.MenuBar.Text = "Menú principal";
            // 
            // bArchivo
            // 
            this.bArchivo.Caption = "Archivo";
            this.bArchivo.Id = 0;
            this.bArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnCambiarUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnSalir)});
            this.bArchivo.Name = "bArchivo";
            // 
            // bbtnCambiarUsuario
            // 
            this.bbtnCambiarUsuario.Caption = "Cambiar de Usuario";
            this.bbtnCambiarUsuario.Id = 2;
            this.bbtnCambiarUsuario.Name = "bbtnCambiarUsuario";
            // 
            // bbtnSalir
            // 
            this.bbtnSalir.Caption = "Salir";
            this.bbtnSalir.Id = 3;
            this.bbtnSalir.Name = "bbtnSalir";
            // 
            // bCaja
            // 
            this.bCaja.Caption = "Caja";
            this.bCaja.Id = 4;
            this.bCaja.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnCaja),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnConcepto),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bCaja.Name = "bCaja";
            // 
            // bbtnCaja
            // 
            this.bbtnCaja.Caption = "Caja";
            this.bbtnCaja.Id = 6;
            this.bbtnCaja.Name = "bbtnCaja";
            // 
            // bbtnConcepto
            // 
            this.bbtnConcepto.Caption = "Conceptos de Caja";
            this.bbtnConcepto.Id = 5;
            this.bbtnConcepto.Name = "bbtnConcepto";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Saldo Actual";
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Cierre";
            this.barButtonItem5.Id = 12;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Reportes";
            this.barSubItem1.Id = 13;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Venta";
            this.barSubItem2.Id = 14;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Cliente";
            this.barSubItem3.Id = 16;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Clientes Contado";
            this.barButtonItem12.Id = 27;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Clientes Credito";
            this.barButtonItem13.Id = 28;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cotización";
            this.barButtonItem6.Id = 15;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Facturación F7";
            this.barButtonItem7.Id = 17;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Reportes";
            this.barSubItem4.Id = 18;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Re-Impresión de Comprobantes";
            this.barButtonItem8.Id = 19;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Compras";
            this.barSubItem5.Id = 20;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Compra";
            this.barSubItem6.Id = 21;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Compra";
            this.barButtonItem10.Id = 24;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Orden Compra";
            this.barButtonItem11.Id = 26;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Proveedor";
            this.barButtonItem9.Id = 22;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "Reportes";
            this.barSubItem7.Id = 23;
            this.barSubItem7.Name = "barSubItem7";
            // 
            // bConfiguracion
            // 
            this.bConfiguracion.Caption = "Configuración";
            this.bConfiguracion.Id = 7;
            this.bConfiguracion.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiUnidad),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImpuesto),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMoneda)});
            this.bConfiguracion.Name = "bConfiguracion";
            // 
            // bbiUnidad
            // 
            this.bbiUnidad.Caption = "Unidad";
            this.bbiUnidad.Id = 8;
            this.bbiUnidad.Name = "bbiUnidad";
            this.bbiUnidad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUnidad_ItemClick);
            // 
            // bbiImpuesto
            // 
            this.bbiImpuesto.Caption = "Impuesto";
            this.bbiImpuesto.Id = 9;
            this.bbiImpuesto.Name = "bbiImpuesto";
            // 
            // bbiMoneda
            // 
            this.bbiMoneda.Caption = "Moneda";
            this.bbiMoneda.Id = 10;
            this.bbiMoneda.Name = "bbiMoneda";
            this.bbiMoneda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMoneda_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(621, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(621, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(621, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEmpresa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblEmpresa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmpresa.Location = new System.Drawing.Point(384, 368);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(237, 30);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "lblEmpresa";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.lblUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUsuario.Location = new System.Drawing.Point(141, 368);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(237, 30);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // pbcProgreso
            // 
            this.pbcProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbcProgreso.Location = new System.Drawing.Point(12, 373);
            this.pbcProgreso.MenuManager = this.barManager1;
            this.pbcProgreso.Name = "pbcProgreso";
            this.pbcProgreso.Properties.EditValueChangedDelay = 50;
            this.pbcProgreso.Properties.NullText = "0";
            this.pbcProgreso.ShowProgressInTaskBar = true;
            this.pbcProgreso.Size = new System.Drawing.Size(106, 18);
            this.pbcProgreso.TabIndex = 15;
            // 
            // frmMenuPrincipal
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(621, 401);
            this.Controls.Add(this.pbcProgreso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.xTabContenedor);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTabContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcProgreso.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarSubItem bArchivo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbtnCambiarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbtnSalir;
        private DevExpress.XtraBars.Bar MenuBar;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraBars.BarSubItem bCaja;
        private DevExpress.XtraBars.BarButtonItem bbtnConcepto;
        private DevExpress.XtraBars.BarButtonItem bbtnCaja;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.BarSubItem bConfiguracion;
        private DevExpress.XtraBars.BarButtonItem bbiUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiImpuesto;
        private DevExpress.XtraBars.BarButtonItem bbiMoneda;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        public DevExpress.XtraTab.XtraTabControl xTabContenedor;
        public DevExpress.XtraEditors.ProgressBarControl pbcProgreso;
    }
}
