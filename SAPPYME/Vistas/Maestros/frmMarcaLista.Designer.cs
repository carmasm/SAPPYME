namespace SAPPYME.Vistas.Maestros
{
    partial class frmMarcaLista
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
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbGuardar.Appearance.Options.UseFont = true;
            this.sbGuardar.Click += new System.EventHandler(this.sbNuevo_Click);
            // 
            // sbSalir
            // 
            this.sbSalir.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbSalir.Appearance.Options.UseFont = true;
            // 
            // sbActualizar
            // 
            this.sbActualizar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbActualizar.Appearance.Options.UseFont = true;
            // 
            // sbReporte
            // 
            this.sbReporte.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbReporte.Appearance.Options.UseFont = true;
            // 
            // sbEliminar
            // 
            this.sbEliminar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbEliminar.Appearance.Options.UseFont = true;
            // 
            // sbEditar
            // 
            this.sbEditar.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.sbEditar.Appearance.Options.UseFont = true;
            this.sbEditar.Click += new System.EventHandler(this.sbEditar_Click);
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // frmMarcaLista
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(601, 540);
            this.Name = "frmMarcaLista";
            ((System.ComponentModel.ISupportInitialize)(this.Icons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
