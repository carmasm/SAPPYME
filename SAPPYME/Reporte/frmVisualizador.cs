using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME.Reporte
{
    public partial class frmVisualizador : Framework.frmVisualizadorReporte
    {
        frmMenuPrincipal MenuPrincipal;
        public frmVisualizador(frmMenuPrincipal frm, string title)
        {
            InitializeComponent();

            MenuPrincipal = frm;
            lblTitulo.Text = title;
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            if (MostrarMsjXtraMessage("Estas seguro de Salir de la Ventana (" + MenuPrincipal.xTabContenedor.TabPages[MenuPrincipal.xTabContenedor.SelectedTabPageIndex].Text + ") " + "?", "Eliminar Ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MenuPrincipal.xTabContenedor.TabPages.RemoveAt(MenuPrincipal.xTabContenedor.SelectedTabPageIndex);
                this.Dispose();
            }
        }

        private void sbSalir_Click_1(object sender, EventArgs e)
        {
            if (MostrarMsjXtraMessage("Estas seguro de Salir de la Ventana (" + MenuPrincipal.xTabContenedor.TabPages[MenuPrincipal.xTabContenedor.SelectedTabPageIndex].Text + ") " + "?", "Eliminar Ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MenuPrincipal.xTabContenedor.TabPages.RemoveAt(MenuPrincipal.xTabContenedor.SelectedTabPageIndex);
                this.Dispose();
            }
        }
    }
}
