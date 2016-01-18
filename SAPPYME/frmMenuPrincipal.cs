using SAPPYME.Vistas.Configuracion;
using SAPPYME.Vistas.Maestros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME
{
    public partial class frmMenuPrincipal : Framework.frmBase
    {

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region "Metodos especiales para el menu principal"
        //Metodo para ajustar el fomulario a pantalla
        public void ResolucionForm()
        {
            //Se toma el tamaño de la pantalla principal
            this.Size = SystemInformation.PrimaryMonitorSize;
            this.Height = this.Height - 40;
        }

        public void AddWindowX(string title, DevExpress.XtraEditors.XtraForm forms)
        {
            try
            {
                ControlBar(pbcProgreso, "Cargando", 25);
            
                bool add = true;

                //Recorro el xtabContenedor para saber si ya existe un tab de ese nombre abierto
                //de ser asi lo selecciono o si no creeo uno nuevo
                for (int x = 0; x < xTabContenedor.TabPages.Count; x++)
                {
                    //Comparo todos los tab con el nombre del nuevo tab que quiero crear
                    if (xTabContenedor.TabPages[x].Text == title)
                    {

                        ControlBar(pbcProgreso, "Terminado", 100); 
                    
                        xTabContenedor.TabPages[x].BackColor = Color.Azure;
                        xTabContenedor.SelectedTabPageIndex = x;
                        add = false;
                        break;
                    }
                    //Si no existe un abierto "add" sera true
                    else
                    {
                        ControlBar(pbcProgreso, "Cargando", 50); 
                    
                        add = true;
                    }
                }

                if (add)
                {
                    ControlBar(pbcProgreso, "Cargando", 75); 

                    //Creo un XtraTabPage que sera el que contendra el formulario 
                    DevExpress.XtraTab.XtraTabPage myTabPage = new DevExpress.XtraTab.XtraTabPage();

                    myTabPage.Text = title;
                    forms.TopLevel = false;
                    forms.Visible = true;
                    forms.FormBorderStyle = FormBorderStyle.None;
                    forms.Dock = DockStyle.Fill;

                    myTabPage.BackColor = Color.Azure;
                    myTabPage.Controls.Add(forms);

                    xTabContenedor.TabPages.Add(myTabPage);

                    xTabContenedor.SelectedTabPageIndex = xTabContenedor.TabPages.Count - 1;

                    ControlBar(pbcProgreso, "Terminado", 100); 
                }
            }
            catch (Exception exAddWindowsX)
            {
                ErrorSystem(exAddWindowsX.Message, "", "MenuPrincipal: AddWwindowX");
            }
        }

        //Verifica si existe una cadena de Conexion valida
        public void VerificarServidor()
        {
            if (Server.Length == 0)
            {
                frmConfiguracion frm = new frmConfiguracion();
                frm.ShowDialog();
                frm.Close();

                Application.Restart();
            }
        }

        #endregion

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //Resolucion de la Pantalla Principal
            ResolucionForm();

            //Si existe una cadena de Conexion
            VerificarServidor();
        }

        private void bbiMoneda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddWindowX("Moneda", new frmMonedaLista(this, "Moneda", "MonedaID", "Listado de Monedas"));
        }

        private void bbiUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddWindowX("Unidad", new frmUnidadLista(this, "Unidad", "UnidadID", "Listado de Unidades"));
        }

        private void bbiImpuesto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddWindowX("Impuesto", new frmImpuestoLista(this, "Impuesto", "ImpuestoID", "Listado de Impuestos"));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddWindowX("Marca", new frmMarcaLista(this, "Marca", "MarcaID", "Listado de Marcas"));
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddWindowX("Impuesto", new frmCategoriaLista(this, "Categoria", "CategoriaID", "Listado de Categorias"));
        }
    }
}
