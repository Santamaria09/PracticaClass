using PracticaClass.CapaEntidades;
using PracticaClass.CapaPresentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVentaRapida_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
          FrmProductos frm = new FrmProductos();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void LogoPOs_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Usuario:{SesionActual.UserName} - Rol:{SesionActual.Rol}";
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnUser.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnUser.Enabled = false;
                    break;

            }


        }

        private void panelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
        }

        private void CambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.Show();


        }
    }

 
}
