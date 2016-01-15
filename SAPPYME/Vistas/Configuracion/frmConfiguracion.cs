using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAPPYME.Vistas.Configuracion
{
    public partial class frmConfiguracion : Framework.frmBase
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            txtServidor.Text = Server;
            txtBD.Text = BD;
            txtUsuario.Text = User;
            txtContraseña.Text = Pass;
            txtDirIma.Text = Dir;
        }

        private void spGuardarConexion_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text.Length == 0)
            {
                MostrarMsjXtraMessage("Por favor Ingresar el Nombre del Servidor o la Direccion IP", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServidor.Focus();
                return;
            }
            if (txtBD.Text.Length == 0)
            {
                MostrarMsjXtraMessage("Por favor Ingresar el Nombre de la Base de Datos a Conectar", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBD.Focus();
                return;
            }
            if (txtUsuario.Text.Length == 0)
            {
                MostrarMsjXtraMessage("Por favor Ingresar el Usuario del Servidor", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (txtContraseña.Text.Length == 0)
            {
                MostrarMsjXtraMessage("Por favor Ingresar la Contraseña del Servidor", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            try
            {
                Server = txtServidor.Text;
                BD = txtBD.Text;
                User = txtUsuario.Text;
                Pass = txtContraseña.Text;
                Dir = txtDirIma.Text;

                SaveVarLocal();
                this.Hide();
            }
            catch (Exception ex)
            {
                ErrorSystem(ex.Message, "Configuracion", "frmConfiguracion");
                MostrarMsjXtraMessage("Ha Surguido un ERROR al momento de conectarse con el Servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbGuardarImpresoras_Click(object sender, EventArgs e)
        {

        }

        private void sbGuardarDirectorio_Click(object sender, EventArgs e)
        {

        }
    }
}
