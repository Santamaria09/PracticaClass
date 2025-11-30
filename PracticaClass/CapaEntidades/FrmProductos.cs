using PracticaClass.CapaEntidades;
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
    public partial class FrmProductos : Form
    {
        //Lista estatica para simular la conecion de la base de datos
        private static List<Producto> ListaProducto = new List<Producto>();
        public FrmProductos()
        {
            //Lista estatica
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //Carga inicial para poblar la vista de algunos productos 
            if (!ListaProducto.Any())
            {
                ListaProducto.Add(new Producto
                {
                    ID = 1,
                    Nombre = "Cafe Pacamara",
                    Descripcion = "Bebida caliente hecha a base de granos de cafe molidos",
                    Precio = 2.50m,
                    Stock = 100,
                    Estado = true
                });
                ListaProducto.Add(new Producto
                {
                    ID = 2,
                    Nombre = "Capuccino",
                    Descripcion = "Galleta",
                    Precio = 10.5m,
                    Stock = 1,
                    Estado = true
                });
                ListaProducto.Add(new Producto
                {
                    ID = 3,
                    Nombre = "Chocolate Caliente",
                    Descripcion = "Chocolate con Malvaviscos",
                    Precio = 2.00m,
                    Stock = 20,
                    Estado = true
                });



            }
            // Metodo para refrescar 
            RefrescarListaProducto();
        }
        //Metodo para refrescar la lista de productos en el datagridview
        private void RefrescarListaProducto()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ListaProducto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones Basicas
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            }
        }

        if (!Validaciones.EsDecimal(txtPrecio.Text))
        { 
            MessageBox.Show("El precio debe ser un valor decimal.", "Error",
            MessageBoxButtons.OK, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


