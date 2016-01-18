using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME.Vistas.Maestros
{
    public partial class frmMarcaCap : Framework.frmBaseCap
    {
        public frmMarcaCap(int ID, string table, string tableID)
            : base(ID, table, tableID)
        {
            InitializeComponent();

            dmlinsert = "insert into " + table + " values (@Codigo, @Descripcion)";
            dmlupdate = "update " + table + " set Codigo = @Codigo, Descripcion= @Descripcion where " + tableID + "= @ID";

            adpMaestros.InsertCommand.CommandText = dmlinsert;
            adpMaestros.InsertCommand.CommandType = CommandType.Text;
            adpMaestros.InsertCommand.Connection = cn;
            adpMaestros.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10, "Codigo");
            adpMaestros.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion");

            adpMaestros.UpdateCommand.CommandText = dmlupdate;
            adpMaestros.UpdateCommand.CommandType = CommandType.Text;
            adpMaestros.UpdateCommand.Connection = cn;
            adpMaestros.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 4, tableID);
            adpMaestros.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10, "Codigo");
            adpMaestros.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion");

            adpMaestros.Fill(dsSAPPYME, table);
        }

        private void frmMarcaCap_Load(object sender, EventArgs e)
        {
            try
            {
                if (dsSAPPYME.Tables[Mtable].Rows.Count > 0)
                {
                    txtCodigo.Text = dsSAPPYME.Tables[Mtable].Rows[0]["Codigo"].ToString();
                    txtDescripcion.Text = dsSAPPYME.Tables[Mtable].Rows[0]["Descripcion"].ToString();
                }
                else
                {
                    dsSAPPYME.Tables[Mtable].Rows.Add();
                }
            }
            catch (Exception exRecuperar)
            {
                ErrorSystem(exRecuperar.Message, Mtable, "frmMarcaCap: Recuperar Registro");
                MostrarMsjXtraMessage("Error al Recuperar el Registro: " + exRecuperar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressEnter(e, sbGuardar);
        }

        public override void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valido que los campos no vallan vacios
                if (txtCodigo.Text.Length == 0)
                {
                    MostrarMsjXtraMessage("Por favor Ingresar el Codigo", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }
                if (txtDescripcion.Text.Length == 0)
                {
                    MostrarMsjXtraMessage("Por favor Ingresar la Descripcion", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return;
                }

                dsSAPPYME.Tables[Mtable].Rows[0]["Codigo"] = txtCodigo.Text;
                dsSAPPYME.Tables[Mtable].Rows[0]["Descripcion"] = txtDescripcion.Text;

                adpMaestros.Update(dsSAPPYME.Tables[Mtable]);

                this.Close();
            }
            catch (Exception ExGuardar)
            {
                ErrorSystem(ExGuardar.Message, Mtable, "frmMarcaCap: Insertar Registro");
                MostrarMsjXtraMessage("Error al Guardar el Registro: " + ExGuardar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
