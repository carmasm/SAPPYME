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
    public partial class frmMarcaLista : Framework.frmBaseLista
    {
        frmMenuPrincipal MenuPrincipal;
        public frmMarcaLista(frmMenuPrincipal frm, string table, string tableID, string title)
            : base(table, tableID, title)
        {
            InitializeComponent();

            MenuPrincipal = frm;

            Mtable = table;
            MtableID = tableID;
        }

        //Creo un nuevo Marca
        private void sbNuevo_Click(object sender, EventArgs e)
        {
            frmMarcaCap Cap = new frmMarcaCap(-1, Mtable, MtableID);
            Cap.ShowDialog();

            tblBaseGeneral.Clear();
            adpMaestros.Fill(tblBaseGeneral);
        }

        //Edito Marca
        private void sbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.GetDataRow(dgv.FocusedRowHandle)[0] != null)
                {
                    int id = (int)dgv.GetDataRow(dgv.FocusedRowHandle)[0];
                    int row = (int)dgv.FocusedRowHandle;


                    frmMarcaCap Cap = new frmMarcaCap(id, Mtable, MtableID);
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
                ErrorSystem(exEditar.Message, Mtable, "frmMarcaLista: Actualizar Registro");
                MostrarMsjXtraMessage("Error al Editar el Registro: " + exEditar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Genera Reporte
        public override void sbReporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisualizador frmRpt = new frmVisualizador(MenuPrincipal, "Marca");

                crBaseGeneral crMarca = new crBaseGeneral();

                crMarca.SetDataSource(tblReporte);

                crMarca.SetParameterValue("@Titulo", "Reporte General de Marca");

                frmRpt.crViewer.ReportSource = crMarca;

                MenuPrincipal.AddWindowX("Reporte de Marca", frmRpt);
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
