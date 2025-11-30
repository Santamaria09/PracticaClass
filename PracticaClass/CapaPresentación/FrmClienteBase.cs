using PracticaClass.CapaEntidades;
using PracticaClass.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaPresentación
{
    public partial class FrmClienteBase : Form
    {
        int ClienteId = 0;
        ClienteBLL bll = new ClienteBLL();  

        public FrmClienteBase()
        {
            InitializeComponent();
        }

        private void FrmClienteBase_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Limpiar();
        }
        void CargarDatos()
        {
            dvgCliente.DataSource = bll.Listar();
        }
        void Limpiar()
        {
            ClienteId = 0;
                txtNombre.Clear();
            txtDui.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtBuscar.Clear();
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente
                {
                    Id = ClienteId,
                    Nombre = txtNombre.Text.Trim(),
                    DUI = txtDui.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Estado = ChkEstado.Checked

                };
                int id = bll.Guardar(c);
                MessageBox.Show("El cliente se ha guardado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ClienteId = Convert.ToInt32(dvgCliente.Rows[e.RowIndex].Cells["ID"].Value);
                txtNombre.Text = dvgCliente.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDui.Text = dvgCliente.Rows[e.RowIndex].Cells["DUI"].Value.ToString();
                txtTelefono.Text = dvgCliente.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dvgCliente.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                ChkEstado.Checked = Convert.ToBoolean(dvgCliente.Rows[e.RowIndex].Cells["Estado"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ClienteId == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
                return;
            }
            if (MessageBox.Show("¿Estas seguro de eliminar el cliente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(ClienteId);
                CargarDatos();
                Limpiar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dvgCliente.DataSource = bll.Buscar(txtBuscar.Text.Trim());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
    }
}
