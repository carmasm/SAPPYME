using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME.Vistas.Maestros
{
    public partial class frmUnidadCap : Framework.frmBaseCap
    {
        public frmUnidadCap(int ID, string table, string tableID)
            : base(ID, table, tableID)
        {
            InitializeComponent();

            dmlinsert = "insert into " + table + " values (@Codigo, @Descripcion, @CantidadUnd)";
            dmlupdate = "update " + table + " set Codigo = @Codigo, Descripcion= @Descripcion, CantidadUnd = @CantidadUnd where " + tableID + "= @ID";

            adpMaestros.InsertCommand.CommandText = dmlinsert;
            adpMaestros.InsertCommand.CommandType = CommandType.Text;
            adpMaestros.InsertCommand.Connection = cn;
            adpMaestros.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10, "Codigo");
            adpMaestros.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion");
            adpMaestros.InsertCommand.Parameters.Add("@CantidadUnd", SqlDbType.Decimal, 10, "CantidadUnd");

            adpMaestros.UpdateCommand.CommandText = dmlupdate;
            adpMaestros.UpdateCommand.CommandType = CommandType.Text;
            adpMaestros.UpdateCommand.Connection = cn;
            adpMaestros.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 4, tableID);
            adpMaestros.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10, "Codigo");
            adpMaestros.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion");
            adpMaestros.UpdateCommand.Parameters.Add("@CantidadUnd", SqlDbType.Decimal, 10, "CantidadUnd");

            adpMaestros.Fill(dsSAPPYME, table);
        }
    }
}
