using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass
{
    public partial class FrmProductos : Form
    {
        //Lista estatica para simular la conexion con la base de datos
        private static List<Producto> ListaProducto = new List<Producto>();
        public FrmProductos()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (!ListaProducto.Any())
            {
                ListaProducto.Add(new Producto
                {
                    ID = 1,
                    Nombre = "Cafe Pacamara",
                    Descripcion = "Importado",
                    Precio = 10.5m,
                    Stock = 100,
                    Estado = true,
                });
                ListaProducto.Add(new Producto
                {
                    ID = 2,
                    Nombre = "Capuccino",
                    Descripcion = "Galleta Oreo",
                    Precio = 10.5m,
                    Stock = 1,
                    Estado = true,
                });
                ListaProducto.Add(new Producto
                {
                    ID = 3,
                    Nombre = "Chocolate Caliente",
                    Descripcion = "Chocolate con Malvaviscos",
                    Precio = 20.0m,
                    Stock = 20,
                    Estado = true,
                });
            }
            //Metodo para refrescar 
            RefrescarListaProductos();
            DesabilitarBotones();
        }

        private void DesabilitarBotones()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnVolver.Enabled = true;
        }
        //Metodo para refrescar la lista de productos en el datagridview
        private void RefrescarListaProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ListaProducto;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("El precio debe de ser un valor decimal", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("Stock invalio", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Crear el nuevo Producto
            int nuevoID = ListaProducto.Any() ? ListaProducto.Max(x => x.ID) + 1 : 1;
            var p = new Producto
            {
                ID = nuevoID,
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = decimal.Parse(txtPrecio.Text.Trim()),
                Stock = int.Parse(txtStock.Text.Trim()),
                Estado = chkEstado.Checked
            };
            ListaProducto.Add(p);
            MessageBox.Show("Producto agregado exitosamente.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarListaProductos();
            //Limpiar los Controles 
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            chkEstado.Checked = false;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar los datos del producto seleccionado en los controles
            if (dgvProductos.CurrentRow == null) return;
            txtCodigo.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            chkEstado.Checked =
                Convert.ToBoolean(dgvProductos.CurrentRow.Cells[5].Value);

            //Habilitar Botones
            HabilitarBotones();
        }

        private void HabilitarBotones()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnVolver.Enabled = true;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int ID))
            {
                MessageBox.Show("Seleccione un producto valido para eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaProducto.FirstOrDefault(x => x.ID == ID);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado"); return;
            }
            if (MessageBox.Show("¿Esta seguro de eliminar el producto" + prod.Nombre + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaProducto.Remove(prod);
                MessageBox.Show("Producto eliminado exitosamente.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarListaProductos();
                LimpiarCampos();
                DesabilitarBotones();
            }
        }
        //Evento para editar un producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Validar que el ID sea el correcto 
            if (!int.TryParse(txtCodigo.Text, out int ID))
            {
                MessageBox.Show("Seleccione un producto valido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaProducto.FirstOrDefault(x => x.ID == ID);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado"); return;
            }
            //Validaciones 
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("El precio debe de ser un valor decimal", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("Stock invalio", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Actualizar el producto
            prod.Nombre = txtNombre.Text.Trim();
            prod.Descripcion = txtDescripcion.Text.Trim();
            prod.Precio = decimal.Parse(txtPrecio.Text.Trim());
            prod.Stock = int.Parse(txtStock.Text.Trim());
            prod.Estado = chkEstado.Checked;
            MessageBox.Show("Producto actualizado exitosamente", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarListaProductos();
            LimpiarCampos();
            DesabilitarBotones();

           

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Desea regresar al menu principal?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }


    

}

                    
         