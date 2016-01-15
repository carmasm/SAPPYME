using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Framework
{
    public partial class frmBaseCap : Framework.frmBase
    {
        //Variables del Formulario
        public string Mtable;
        public string MtableID;

        public frmBaseCap()
        {
            InitializeComponent();
        }

        public frmBaseCap(int ID, string table, string tableID)
        {
            InitializeComponent();

            //Se limpia el dataset por si existen datos
            dsSAPPYME.Clear();

            //Se dan valores a la variables
            Mtable = table;
            MtableID = tableID;

            //Inicializo el adapter
            adpMaestros = new SqlDataAdapter();

            //Sentencia para recuperar los registros
            dmlselect = "select * from " + table + " where " + tableID + " = " + ID;

            //Inicialiazacion del Select
            adpMaestros.SelectCommand = new SqlCommand();
            adpMaestros.SelectCommand.CommandText = dmlselect;
            adpMaestros.SelectCommand.CommandType = CommandType.Text;
            adpMaestros.SelectCommand.Connection = cn;

            //Inicialiazacion del Insert
            adpMaestros.InsertCommand = new SqlCommand();

            //Inicialiazacion del Update
            adpMaestros.UpdateCommand = new SqlCommand();
        }

        public virtual void sbGuardar_Click(object sender, EventArgs e)
        {

        }

        public virtual void sbCancelar_Click(object sender, EventArgs e)
        {
            //Verifica si desea salir del formulario
            if (MostrarMsjXtraMessage("Desea Salir de este formulario? \n Se perderán todos los cambios", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        public virtual void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Pasa el focus a otro control
            PressEnter(e, txtDescripcion);
        }
    }
}
