namespace SAPPYME.Vistas.Configuracion
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xTabConexion = new DevExpress.XtraTab.XtraTabPage();
            this.spGuardarConexion = new DevExpress.XtraEditors.SimpleButton();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtabImpresoras = new DevExpress.XtraTab.XtraTabPage();
            this.sbGuardarImpresoras = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.xTabDirectorio = new DevExpress.XtraTab.XtraTabPage();
            this.sbGuardarDirectorio = new DevExpress.XtraEditors.SimpleButton();
            this.txtDirIma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xTabConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            this.xtabImpresoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.xTabDirectorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirIma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(225, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xTabConexion;
            this.xtraTabControl1.Size = new System.Drawing.Size(384, 254);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabConexion,
            this.xtabImpresoras,
            this.xTabDirectorio});
            // 
            // xTabConexion
            // 
            this.xTabConexion.Controls.Add(this.spGuardarConexion);
            this.xTabConexion.Controls.Add(this.txtContraseña);
            this.xTabConexion.Controls.Add(this.labelControl4);
            this.xTabConexion.Controls.Add(this.txtUsuario);
            this.xTabConexion.Controls.Add(this.labelControl3);
            this.xTabConexion.Controls.Add(this.txtBD);
            this.xTabConexion.Controls.Add(this.labelControl2);
            this.xTabConexion.Controls.Add(this.txtServidor);
            this.xTabConexion.Controls.Add(this.labelControl1);
            this.xTabConexion.Name = "xTabConexion";
            this.xTabConexion.Size = new System.Drawing.Size(379, 229);
            this.xTabConexion.Text = "Conexión";
            // 
            // spGuardarConexion
            // 
            this.spGuardarConexion.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.spGuardarConexion.Appearance.Options.UseFont = true;
            this.spGuardarConexion.Image = global::SAPPYME.Properties.Resources.Ok;
            this.spGuardarConexion.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.spGuardarConexion.Location = new System.Drawing.Point(341, 191);
            this.spGuardarConexion.Name = "spGuardarConexion";
            this.spGuardarConexion.Size = new System.Drawing.Size(35, 35);
            this.spGuardarConexion.TabIndex = 8;
            this.spGuardarConexion.Click += new System.EventHandler(this.spGuardarConexion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(134, 136);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContraseña.Properties.Appearance.Options.UseFont = true;
            this.txtContraseña.Size = new System.Drawing.Size(152, 22);
            this.txtContraseña.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl4.Location = new System.Drawing.Point(12, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(134, 99);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(152, 22);
            this.txtUsuario.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl3.Location = new System.Drawing.Point(12, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Usuario:";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(134, 62);
            this.txtBD.Name = "txtBD";
            this.txtBD.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBD.Properties.Appearance.Options.UseFont = true;
            this.txtBD.Size = new System.Drawing.Size(152, 22);
            this.txtBD.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Base de Datos:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(134, 25);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtServidor.Properties.Appearance.Options.UseFont = true;
            this.txtServidor.Size = new System.Drawing.Size(152, 22);
            this.txtServidor.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl1.Location = new System.Drawing.Point(12, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Servidor:";
            // 
            // xtabImpresoras
            // 
            this.xtabImpresoras.Controls.Add(this.sbGuardarImpresoras);
            this.xtabImpresoras.Controls.Add(this.comboBoxEdit3);
            this.xtabImpresoras.Controls.Add(this.labelControl7);
            this.xtabImpresoras.Controls.Add(this.comboBoxEdit2);
            this.xtabImpresoras.Controls.Add(this.labelControl6);
            this.xtabImpresoras.Controls.Add(this.comboBoxEdit1);
            this.xtabImpresoras.Controls.Add(this.labelControl5);
            this.xtabImpresoras.Name = "xtabImpresoras";
            this.xtabImpresoras.Size = new System.Drawing.Size(379, 229);
            this.xtabImpresoras.Text = "Impresoras";
            // 
            // sbGuardarImpresoras
            // 
            this.sbGuardarImpresoras.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.sbGuardarImpresoras.Appearance.Options.UseFont = true;
            this.sbGuardarImpresoras.Image = global::SAPPYME.Properties.Resources.Ok;
            this.sbGuardarImpresoras.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbGuardarImpresoras.Location = new System.Drawing.Point(341, 191);
            this.sbGuardarImpresoras.Name = "sbGuardarImpresoras";
            this.sbGuardarImpresoras.Size = new System.Drawing.Size(35, 35);
            this.sbGuardarImpresoras.TabIndex = 9;
            this.sbGuardarImpresoras.Click += new System.EventHandler(this.sbGuardarImpresoras_Click);
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(152, 99);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxEdit3.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Size = new System.Drawing.Size(224, 22);
            this.comboBoxEdit3.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl7.Location = new System.Drawing.Point(12, 101);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 18);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Impresora Carta:";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(152, 62);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(224, 22);
            this.comboBoxEdit2.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl6.Location = new System.Drawing.Point(12, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(122, 18);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Impresora Carta:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(152, 25);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(224, 22);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl5.Location = new System.Drawing.Point(12, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(122, 18);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Impresora Carta:";
            // 
            // xTabDirectorio
            // 
            this.xTabDirectorio.Controls.Add(this.sbGuardarDirectorio);
            this.xTabDirectorio.Controls.Add(this.txtDirIma);
            this.xTabDirectorio.Controls.Add(this.labelControl8);
            this.xTabDirectorio.Name = "xTabDirectorio";
            this.xTabDirectorio.Size = new System.Drawing.Size(379, 229);
            this.xTabDirectorio.Text = "Directorios";
            // 
            // sbGuardarDirectorio
            // 
            this.sbGuardarDirectorio.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.sbGuardarDirectorio.Appearance.Options.UseFont = true;
            this.sbGuardarDirectorio.Image = global::SAPPYME.Properties.Resources.Ok;
            this.sbGuardarDirectorio.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbGuardarDirectorio.Location = new System.Drawing.Point(341, 191);
            this.sbGuardarDirectorio.Name = "sbGuardarDirectorio";
            this.sbGuardarDirectorio.Size = new System.Drawing.Size(35, 35);
            this.sbGuardarDirectorio.TabIndex = 10;
            this.sbGuardarDirectorio.Click += new System.EventHandler(this.sbGuardarDirectorio_Click);
            // 
            // txtDirIma
            // 
            this.txtDirIma.Location = new System.Drawing.Point(191, 25);
            this.txtDirIma.Name = "txtDirIma";
            this.txtDirIma.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDirIma.Properties.Appearance.Options.UseFont = true;
            this.txtDirIma.Size = new System.Drawing.Size(185, 22);
            this.txtDirIma.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labelControl8.Location = new System.Drawing.Point(12, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(173, 18);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Directorio de Imagenes:";
            // 
            // imageSlider1
            // 
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(13, 60);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(207, 170);
            this.imageSlider1.TabIndex = 1;
            // 
            // frmConfiguracion
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(621, 278);
            this.ControlBox = false;
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.xtraTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xTabConexion.ResumeLayout(false);
            this.xTabConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            this.xtabImpresoras.ResumeLayout(false);
            this.xtabImpresoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.xTabDirectorio.ResumeLayout(false);
            this.xTabDirectorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirIma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xTabConexion;
        private DevExpress.XtraTab.XtraTabPage xtabImpresoras;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xTabDirectorio;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton spGuardarConexion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton sbGuardarImpresoras;
        private DevExpress.XtraEditors.TextEdit txtDirIma;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sbGuardarDirectorio;
    }
}
