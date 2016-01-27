using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;

namespace Framework
{
    public partial class frmBase : DevExpress.XtraEditors.XtraForm
    {
        //Declaracion de Variables
        public DataSet dsSAPPYME = new DataSet("SAPPYME");

        public SqlDataAdapter adpEstandar;
        public SqlDataAdapter adpMaestros;
        public SqlDataAdapter adpReportes;
        public SqlDataAdapter adpTransaccionEnc;
        public SqlDataAdapter adpTransaccionDet;
        public SqlDataAdapter adpID;
        public SqlDataAdapter adpBusqueda;

        //DataTable
        public DataTable tblBaseGeneral;
        public DataTable tblEncabezado;
        public DataTable tblDetalle;
        public DataTable tblID;
        public DataTable tblReporte;
        public DataTable tblBusqueda;

        //Command
        public SqlCommand query;

        //Variables dml
        public string dmlinsert;
        public string dmlupdate;
        public string dmlselect;
        public string dmldelete;
        public string dmlreporte;

        //Variables de Conexion
        public string Server = Properties.Settings.Default.Servidor;
        public string BD = Properties.Settings.Default.BD;
        public string User = Properties.Settings.Default.User;
        public string Pass = Properties.Settings.Default.Pass;
        public string Dir = Properties.Settings.Default.DirIma;
        public string Sucursal = "";
        public string Version = "";

        //Connections
        public SqlConnection cn;
        public SqlConnection cnTran;

        public SqlTransaction Transaccion;

        //Creo variables para Usuario, Caja, Empresa, etc
        public string usuario;
        public string caja;
        public string empresa;

        public frmBase()
        {
            InitializeComponent();

            //Creo la Conexion
            cn = new SqlConnection("Data Source=" + Server + "; Initial Catalog=" + BD + "; User ID=" + User + ";Password=" + Pass + ";");
        }

        #region "Guarda los nuevos Parametros Locales"
        public void SaveVarLocal()
        {
            //Cambio el valor de las variables internas
            Properties.Settings.Default.Servidor = Server;
            Properties.Settings.Default.BD = BD;
            Properties.Settings.Default.User = User;
            Properties.Settings.Default.Pass = Pass;
            Properties.Settings.Default.DirIma = Dir;

            //Guardo los cambios hechos
            Properties.Settings.Default.Save();
        }
        #endregion

        #region "Métodos del GridControl"
        //Se prohibe que las columnas se puedan ordenar de asc a desc
        public void NoShorMode(DevExpress.XtraGrid.Views.Grid.GridView dgv)
        {
            //No dejara que ninguna columna pueda ordenarse
            for (int x = 0; x < dgv.Columns.Count; x++)
            {
                dgv.Columns[x].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            }
        }

        //Se prohibe que las filas se pueda editar
        public void NoAllowEdit(DevExpress.XtraGrid.Views.Grid.GridView dgv)
        {
            //No dejara editar ninguna fila del gridvieww
            for (int x = 0; x <= dgv.VisibleColumns.Count; x++)
            {
                dgv.Columns[x].OptionsColumn.AllowEdit = false;
            }
        }
        #endregion

        #region "Métodos del Sistema"
        //Guardara todos los errores que se generen en el sistema
        public void ErrorSystem(string Error, string Tabla, string Formulario)
        {
            try
            {
                dmlinsert = "insert into ErrorSystem values ('" + Error.Replace("'", "") + "','" +
                                                                  Tabla + "','" + 
                                                                  Formulario + "','" + 
                                                                  DateTime.Today.ToString("MM/dd/yyyy") + "'," +
                                                                  "Convert(time(4), GETDATE(), 108),'" + 
                                                                  AssemblyInfo.Version.ToString() + "')";
                cn.Open();
                query = new SqlCommand(dmlinsert, cn);
                query.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception exErrorSystem)
            {
                MostrarMsjXtraMessage("Error al momento de Insertar en ErrorSystem: " + exErrorSystem.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Se utilizara para mostrar mensajes de informacion hasta mensajes SI/NO devolviendo su repuesta
        public bool MostrarMsjXtraMessage(string msj, string title, MessageBoxButtons type, MessageBoxIcon icon)
        {
            bool sino = false;

            if (type.Equals(MessageBoxButtons.YesNo))
            {
                DialogResult result = XtraMessageBox.Show(msj, title, type, icon);
                if (DialogResult.Yes == result)
                {
                    sino = true;
                }
                else if (DialogResult.No == result)
                {
                    sino = false;
                }
            }
            else
            {
                XtraMessageBox.Show(msj, title, type, icon);
                sino = true;
            }

            return sino;
        }
        #endregion

        #region "Focus de todos los objetos"
        //TextEdit
        public void PressEnter(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit txt)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt.Focus();
            }
        }
        //SimpleButton
        public void PressEnter(KeyPressEventArgs e, DevExpress.XtraEditors.SimpleButton sb)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                sb.Focus();
            }
        }
        #endregion

        #region "Menu Principal"
        public void crearWait()
        {
            
        }
        #endregion
    }
}
