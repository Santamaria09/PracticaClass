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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            cmbRol.Items.AddRange(new string[] { "Admin", "Cajero", "Mesero" });

        }
        private void CargarUsuarios()
        {
            dvgUsuarios.DataSource = UsuarioBLL.Listar().Select(u => new {
                u.Id,
                u.UserName,
                u.Rol,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            try
            {
                int id = UsuarioBLL.Insertar(txtNUsuario.Text.Trim(), txtClaveGU.Text.Trim(), cmbRol.Text);
                MessageBox.Show("Usuario creado ID: " + id);
                Limpiar();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Limpiar()
        {
            txtId.Text = "";
            txtNUsuario.Text = "";
            txtClaveGU.Text = "";
            cmbRol.SelectedIndex = -1;
            ChKEstadoGU.Checked = false;
        }

        private void btnActualzar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                bool estado = ChKEstadoGU.Checked;
                bool ok = UsuarioBLL.Actualizar(id, txtNUsuario.Text.Trim(), cmbRol.Text, estado);
                MessageBox.Show(ok ? "Actualizado" : "No se actualizó");
                CargarUsuarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var r = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bool ok = UsuarioBLL.Eliminar(id);
                    MessageBox.Show(ok ? "Eliminado" : "No eliminado");
                    CargarUsuarios();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void bbtnRefresU_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void dvgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dvgUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtNUsuario.Text = dvgUsuarios.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                cmbRol.Text = dvgUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                ChKEstadoGU.Checked = dvgUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Activo";
            }

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
