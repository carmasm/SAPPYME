﻿namespace SAPPYME.Vistas.Maestros
{
    partial class frmUnidadCap
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
            this.seUnidad = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUnidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-5, 194);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(380, 157);
            this.sbCancelar.TabIndex = 4;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Location = new System.Drawing.Point(339, 157);
            this.sbGuardar.TabIndex = 3;
            // 
            // skinForm
            // 
            this.skinForm.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // seUnidad
            // 
            this.seUnidad.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seUnidad.Location = new System.Drawing.Point(104, 126);
            this.seUnidad.Name = "seUnidad";
            this.seUnidad.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.seUnidad.Properties.Appearance.Options.UseFont = true;
            this.seUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seUnidad.Properties.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.seUnidad.Properties.Mask.EditMask = "0.00";
            this.seUnidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.seUnidad.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seUnidad.Size = new System.Drawing.Size(106, 22);
            this.seUnidad.TabIndex = 2;
            this.seUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seUnidad_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.labelControl3.Location = new System.Drawing.Point(13, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 16);
            this.labelControl3.TabIndex = 116;
            this.labelControl3.Text = "Cantidad Und:";
            // 
            // frmUnidadCap
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(427, 217);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.seUnidad);
            this.Name = "frmUnidadCap";
            this.Load += new System.EventHandler(this.frmUnidadCap_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGuardar, 0);
            this.Controls.SetChildIndex(this.seUnidad, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSAPPYME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUnidad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit seUnidad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
