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
    public partial class FrmCategoria : Form
    {
        CategoriaBLL bll = new CategoriaBLL();
        int CategoriaID = 0;
        string modo = "Nuevo";
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();

        }
        void HabilitarBotones()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dvgCategoria.ClearSelection();
            dvgCategoria.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgCategoria.SelectedRows.Count > 0;
                btnModificar.Enabled = filaSeleccionada;
                btnEliminar.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos ()
        {
            dvgCategoria.DataSource = bll.Listar();
            dvgCategoria.ClearSelection();
            CategoriaID = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dvgCategoria.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void dvgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CategoriaID = Convert.ToInt32(dvgCategoria.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriaGestion frm = new FrmCategoriaGestion();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (CategoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoria", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmCategoriaGestion frm = new FrmCategoriaGestion();
            frm.Modo = "Editar";
            frm.Id = CategoriaID;

            frm.Nombre = dvgCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Descripcion = dvgCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CategoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoria", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }
            FrmCategoriaEliminar frm = new FrmCategoriaEliminar();

            frm.Id = CategoriaID;
            frm.Nombre = dvgCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Descripcion = dvgCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
