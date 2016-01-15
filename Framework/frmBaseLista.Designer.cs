namespace Framework
{
    partial class frmBaseLista
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
            this.gcControles = new DevExpress.XtraEditors.GroupControl();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.sbActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.sbReporte = new DevExpress.XtraEditors.SimpleButton();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbEditar = new DevExpress.XtraEditors.SimpleButton();
            this.sbGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcLista = new DevExpress.XtraGrid.GridControl();
            this.dgv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Icons = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcControles)).BeginInit();
            this.gcControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).BeginInit();
            this.SuspendLayout();
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // gcControles
            // 
            this.gcControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcControles.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.gcControles.Appearance.Options.UseFont = true;
            this.gcControles.Controls.Add(this.sbSalir);
            this.gcControles.Controls.Add(this.sbActualizar);
            this.gcControles.Controls.Add(this.sbReporte);
            this.gcControles.Controls.Add(this.sbEliminar);
            this.gcControles.Controls.Add(this.sbEditar);
            this.gcControles.Controls.Add(this.sbGuardar);
            this.gcControles.Location = new System.Drawing.Point(12, 41);
            this.gcControles.Name = "gcControles";
            this.gcControles.Size = new System.Drawing.Size(124, 347);
            this.gcControles.TabIndex = 0;
            this.gcControles.Text = "Controles";
            // 
            // sbSalir
            // 
            this.sbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSalir.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbSalir.Appearance.Options.UseFont = true;
            this.sbSalir.Image = global::Framework.Properties.Resources.Logout;
            this.sbSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbSalir.Location = new System.Drawing.Point(84, 307);
            this.sbSalir.Name = "sbSalir";
            this.sbSalir.Size = new System.Drawing.Size(35, 35);
            this.sbSalir.TabIndex = 5;
            this.sbSalir.Click += new System.EventHandler(this.sbSalir_Click);
            // 
            // sbActualizar
            // 
            this.sbActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbActualizar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbActualizar.Appearance.Options.UseFont = true;
            this.sbActualizar.Image = global::Framework.Properties.Resources.Actualizar;
            this.sbActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbActualizar.Location = new System.Drawing.Point(6, 307);
            this.sbActualizar.Name = "sbActualizar";
            this.sbActualizar.Size = new System.Drawing.Size(35, 35);
            this.sbActualizar.TabIndex = 4;
            // 
            // sbReporte
            // 
            this.sbReporte.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbReporte.Appearance.Options.UseFont = true;
            this.sbReporte.Image = global::Framework.Properties.Resources.impresora;
            this.sbReporte.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbReporte.Location = new System.Drawing.Point(6, 148);
            this.sbReporte.Name = "sbReporte";
            this.sbReporte.Size = new System.Drawing.Size(35, 35);
            this.sbReporte.TabIndex = 3;
            this.sbReporte.Click += new System.EventHandler(this.sbReporte_Click);
            // 
            // sbEliminar
            // 
            this.sbEliminar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbEliminar.Appearance.Options.UseFont = true;
            this.sbEliminar.Image = global::Framework.Properties.Resources.Eliminar;
            this.sbEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbEliminar.Location = new System.Drawing.Point(6, 107);
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(35, 35);
            this.sbEliminar.TabIndex = 2;
            this.sbEliminar.Click += new System.EventHandler(this.sbEliminar_Click);
            // 
            // sbEditar
            // 
            this.sbEditar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbEditar.Appearance.Options.UseFont = true;
            this.sbEditar.Image = global::Framework.Properties.Resources.editar;
            this.sbEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbEditar.Location = new System.Drawing.Point(6, 66);
            this.sbEditar.Name = "sbEditar";
            this.sbEditar.Size = new System.Drawing.Size(35, 35);
            this.sbEditar.TabIndex = 1;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbGuardar.Appearance.Options.UseFont = true;
            this.sbGuardar.Image = global::Framework.Properties.Resources.Nuevo;
            this.sbGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbGuardar.Location = new System.Drawing.Point(6, 25);
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(35, 35);
            this.sbGuardar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 113;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 112;
            // 
            // gcLista
            // 
            this.gcLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLista.Location = new System.Drawing.Point(137, 41);
            this.gcLista.MainView = this.dgv;
            this.gcLista.Name = "gcLista";
            this.gcLista.Size = new System.Drawing.Size(447, 445);
            this.gcLista.TabIndex = 1;
            this.gcLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv});
            this.gcLista.DataSourceChanged += new System.EventHandler(this.gcLista_DataSourceChanged);
            // 
            // dgv
            // 
            this.dgv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Codigo,
            this.Descripcion});
            this.dgv.GridControl = this.gcLista;
            this.dgv.Name = "dgv";
            this.dgv.OptionsView.ShowAutoFilterRow = true;
            this.dgv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgv.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            // 
            // Icons
            // 
            this.Icons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Icons.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.Icons.Location = new System.Drawing.Point(12, 394);
            this.Icons.Name = "Icons";
            this.Icons.Size = new System.Drawing.Size(122, 92);
            this.Icons.TabIndex = 115;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(0, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 19);
            this.lblTitulo.TabIndex = 116;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmBaseLista
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(601, 540);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Icons);
            this.Controls.Add(this.gcLista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcControles);
            this.Name = "frmBaseLista";
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcControles)).EndInit();
            this.gcControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcControles;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcLista;
        public DevExpress.XtraGrid.Views.Grid.GridView dgv;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        public DevExpress.XtraEditors.LabelControl lblTitulo;
        public DevExpress.XtraEditors.SimpleButton sbGuardar;
        public DevExpress.XtraEditors.SimpleButton sbSalir;
        public DevExpress.XtraEditors.SimpleButton sbActualizar;
        public DevExpress.XtraEditors.SimpleButton sbReporte;
        public DevExpress.XtraEditors.SimpleButton sbEliminar;
        public DevExpress.XtraEditors.SimpleButton sbEditar;
        public DevExpress.XtraGrid.Columns.GridColumn ID;
        public DevExpress.XtraEditors.Controls.ImageSlider Icons;
    }
}
