using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace Framework
{
    public partial class frmBaseLista : Framework.frmBase
    {
        //Variables del Formulario
        public string Mtable;
        public string MtableID;
        
        public frmBaseLista()
        {
            InitializeComponent();
        }

        public frmBaseLista(string table, string tableID, string title)
        {
            InitializeComponent();
            try
            {
                //Inicializo las variables del formulario
                Mtable = table;
                MtableID = tableID;

                //Limpio el dataset
                dsSAPPYME.Clear();

                //Inicializo los adapters
                adpMaestros = new SqlDataAdapter();
                adpReportes = new SqlDataAdapter();

                //Inicializo los datatables
                tblReporte = new DataTable("Reporte" + table);
                tblBaseGeneral = new DataTable("Lista" + table);

                //Creo el query para el table y reporte
                dmlselect = "select * from " + table;
                dmlreporte = "select * from Reporte" + table;

                //Select
                adpMaestros.SelectCommand = new SqlCommand();
                adpMaestros.SelectCommand.CommandText = dmlselect;
                adpMaestros.SelectCommand.CommandType = CommandType.Text;
                adpMaestros.SelectCommand.Connection = cn;

                //Eliminar
                adpMaestros.DeleteCommand = new SqlCommand();
                adpMaestros.DeleteCommand.CommandText = "delete from " + table + " where " + tableID + "= @ID";
                adpMaestros.DeleteCommand.CommandType = CommandType.Text;
                adpMaestros.DeleteCommand.Connection = cn;
                adpMaestros.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 4, tableID);

                lblTitulo.Text = title;

                adpMaestros.Fill(tblBaseGeneral);

                gcLista.DataSource = tblBaseGeneral;

                //Reporte
                adpReportes.SelectCommand = new SqlCommand();
                adpReportes.SelectCommand.CommandText = dmlreporte;
                adpReportes.SelectCommand.CommandType = CommandType.Text;
                adpReportes.SelectCommand.Connection = cn;
                adpReportes.Fill(tblReporte);
            }
            catch (Exception exBuild)
            {
                ErrorSystem(exBuild.Message, Mtable + " en el Load", "frmBaseLista");
                MostrarMsjXtraMessage("No se pudo Cargar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        //Usado para modificar el ancho de la columna cada vez que se cambie el source
        public virtual void gcLista_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv.VisibleColumns.Count > 0)
            {
                //Defino el Tamaño de las columnas
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Width = 30;
                dgv.Columns[2].Width = 250;

                NoShorMode(dgv);
                NoAllowEdit(dgv);
            }
        }

        //Eliminar en general
        public virtual void sbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.GetDataRow(dgv.FocusedRowHandle)[0] != null)
                {
                    if (MostrarMsjXtraMessage("Estas seguro de eliminar (" + Mtable + ") : " + dgv.GetDataRow(dgv.FocusedRowHandle)["Descripcion"] + "?", "Eliminar " + Mtable, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                           tblBaseGeneral= (DataTable)gcLista.DataSource;

                            //Eliminar
                            dgv.DeleteRow(dgv.FocusedRowHandle);

                            adpMaestros.Update(tblBaseGeneral);
                            
                            tblBaseGeneral.Clear();
                            adpMaestros.Fill(tblBaseGeneral);
                            
                    }
                }
                else
                {
                    MostrarMsjXtraMessage("Por favor Seleccionar un Registro Para Poder Eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exEliminar)
            {
                ErrorSystem(exEliminar.Message, Mtable, "Formularios Base: Borrando en la tabla: " + Mtable);
                MostrarMsjXtraMessage("Error al momento de Eliminar " + Mtable + ": " + exEliminar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Actualizo el source del gridcontrol
        public virtual void btnActualizar_Click(object sender, EventArgs e)
        {
            tblBaseGeneral.Clear();
            adpMaestros.Fill(tblBaseGeneral);
            gcLista.DataSource = tblBaseGeneral;
        }

        public virtual void sbReporte_Click(object sender, EventArgs e)
        {

        }

        public virtual void sbSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
