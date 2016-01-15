using SAPPYME.Reporte;
using SAPPYME.Reporte.Maestro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME.Vistas.Maestros
{
    public partial class frmMonedaLista : Framework.frmBaseLista
    {
        frmMenuPrincipal MenuPrincipal;
        public frmMonedaLista(frmMenuPrincipal frm, string table, string tableID, string title)
      : base(table, tableID, title)
        {
            InitializeComponent();

            MenuPrincipal = frm;

            Mtable = table;
            MtableID = tableID;
        }

        //Creo un nuevo moneda
        private void sbGuardar_Click(object sender, EventArgs e)
        {
            frmMonedaCap Cap = new frmMonedaCap(-1, Mtable, MtableID);
            Cap.ShowDialog();

            tblBaseGeneral.Clear();
            adpMaestros.Fill(tblBaseGeneral);
        }

        //Edito Moneda
        private void sbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.GetDataRow(dgv.FocusedRowHandle)[0] != null)
                {
                    int id = (int)dgv.GetDataRow(dgv.FocusedRowHandle)[0];
                    int row = (int)dgv.FocusedRowHandle;


                    frmMonedaCap Cap = new frmMonedaCap(id, Mtable, MtableID);
                    Cap.ShowDialog();

                    tblBaseGeneral.Clear();
                    adpMaestros.Fill(tblBaseGeneral);

                    dgv.FocusedRowHandle = row;
                }
                else
                {
                    MostrarMsjXtraMessage("Por favor Seleccionar un Registro Para Poder Editarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exEditar)
            {
                ErrorSystem(exEditar.Message, Mtable, "frmMonedaLista: Actualizar Registro");
                MostrarMsjXtraMessage("Error al Editar el Registro: " + exEditar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Genera Reporte
        public override void sbReporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisualizador frmRpt = new frmVisualizador(MenuPrincipal, "Moneda");

                crBaseGeneral crMoneda = new crBaseGeneral();

                crMoneda.SetDataSource(tblReporte);

                crMoneda.SetParameterValue("@Titulo", "Reporte General de Moneda");

                frmRpt.crViewer.ReportSource = crMoneda;

                MenuPrincipal.AddWindowX("Reporte de Moneda", frmRpt);
            }
            catch (Exception rep)
            {
                MostrarMsjXtraMessage("Error al momento de Generar Reporte de " + Mtable + ": " + rep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void sbSalir_Click(object sender, EventArgs e)
        {
            if (MostrarMsjXtraMessage("Estas seguro de Salir de la Ventana (" + MenuPrincipal.xTabContenedor.TabPages[MenuPrincipal.xTabContenedor.SelectedTabPageIndex].Text + ") " + "?", "Eliminar Ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MenuPrincipal.xTabContenedor.TabPages.RemoveAt(MenuPrincipal.xTabContenedor.SelectedTabPageIndex);
                this.Dispose();
            }  
        }
    }
}
