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
    public partial class frmImpuestoLista : Framework.frmBaseLista
    {
        frmMenuPrincipal MenuPrincipal;
        public frmImpuestoLista(frmMenuPrincipal frm, string table, string tableID, string title)
            : base(table, tableID, title)
        {
            InitializeComponent();
            
            MenuPrincipal = frm;

            Mtable = table;
            MtableID = tableID;
        
        }

        //Creo un nuevo Impuesto
        private void sbNuevo_Click(object sender, EventArgs e)
        {
            frmImpuestoCap Cap = new frmImpuestoCap(-1, Mtable, MtableID);
            Cap.ShowDialog();

            tblBaseGeneral.Clear();
            adpMaestros.Fill(tblBaseGeneral);
        }

        //Edito Impuesto
        private void sbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.GetDataRow(dgv.FocusedRowHandle)[0] != null)
                {
                    int id = (int)dgv.GetDataRow(dgv.FocusedRowHandle)[0];
                    int row = (int)dgv.FocusedRowHandle;


                    frmImpuestoCap Cap = new frmImpuestoCap(id, Mtable, MtableID);
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
                ErrorSystem(exEditar.Message, Mtable, "frmImpuestoLista: Actualizar Registro");
                MostrarMsjXtraMessage("Error al Editar el Registro: " + exEditar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Genera Reporte
        public override void sbReporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisualizador frmRpt = new frmVisualizador(MenuPrincipal, "Impuesto");

                crBaseGeneral crUnidad = new crBaseGeneral();

                crUnidad.SetDataSource(tblReporte);

                crUnidad.SetParameterValue("@Titulo", "Reporte General de Impuesto");

                frmRpt.crViewer.ReportSource = crUnidad;

                MenuPrincipal.AddWindowX("Reporte de Impuesto", frmRpt);
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
