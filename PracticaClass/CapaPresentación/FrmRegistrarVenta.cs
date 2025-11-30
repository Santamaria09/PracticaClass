using PracticaClass.CapaDatos;
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

namespace PracticaClass.CapaPresentación
{
    public partial class FrmRegistrarVenta : Form
    {
        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void lblPago_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            //Clientes
            cboCliente.DataSource = TipoDePagoDAL.Listar();
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";

            //TipoPago
            cboPago.DataSource = TipoDePagoDAL.Listar();
            cboPago.DisplayMember = "Nombre";
            cboPago.ValueMember = "Id";

            //Fecha
            dtpFecha.Value = DateTime.Now;

            CargarProductos(String.Empty);

            //Columnas
            ConfigurarTablaDetalle();

        }

        private void CargarProductos(String filtro)
        {
            var Tabla = ProductoDAL.Listar();

            if(!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = Tabla.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%";
                dvgProductosB.DataSource = dv;
            }
            else
            {
                dvgProductosB.DataSource = Tabla;
            }

            dvgProductosB.Columns["Id"].Visible = false;
        }


        private void ConfigurarTablaDetalle()
        {
            dvgDetalle.Columns.Clear();

            //Id producto
             DataGridViewTextBoxColumn colldProd= new DataGridViewTextBoxColumn();

            colldProd.Name = "Id_Producto";
            colldProd.HeaderText = "ID";
            colldProd.Visible = false;
            dvgDetalle.Columns.Add(colldProd);


            //Nombre producto
            dvgDetalle.Columns.Add("NomnreProducto", "Producto");

            //Cantidad
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cant";
            dvgDetalle.Columns.Add(colCant);

            //Precio U
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            dvgDetalle.Columns.Add(colPrecio);

            //Sub total
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "Sub Total";
            colSub.HeaderText = "SubTotal";
            dvgDetalle.Columns.Add(colSub);
            dvgDetalle.ReadOnly = false;

            //No editable
            dvgDetalle.Columns["SubTotal"].ReadOnly = true;
            dvgDetalle.Columns["PrecioUnitario"].ReadOnly = true;
            dvgDetalle.Columns["NombreProducto"].ReadOnly = true;
            dvgDetalle.Columns["Id_Producto"].ReadOnly = true;

            dvgDetalle.Columns["Cantidad"].ReadOnly= false;
        }


        private void dvgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBProducto.Text.Trim();
            CargarProductos(texto);
        }

        private void txtBProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarProductos(txtBProducto.Text.Trim());
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (dvgProductosB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DataGridViewRow row = dvgProductosB.SelectedRows[0];

            int IdProducto = Convert.ToInt32(row.Cells["Id"].Value);
            string Nombre = row.Cells["Nombre"].Value.ToString);
            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            int Cantidad = 1;
            decimal SubTotal = Precio * Cantidad;

            dvgDetalle.Rows.Add(
                IdProducto, Nombre, Cantidad, Precio, SubTotal );

            RecalcularTotal();
        }


        private void dvgProductosB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarP_Click (sender, e);
        }

        private void RecalcularTotal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dvgDetalle.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            lblTotal.Text = "Total:$" + Total.ToString("0.00");
        }

        private void dvgDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgDetalle.Columns[e.ColumnIndex].Name =="Cantidad")
            {
                DataGridViewRow row = dvgDetalle.Rows[e.ColumnIndex];

                int Cantidad;
                bool ok = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out Cantidad);
                if (!ok || Cantidad <= 0)
                {
                    MessageBox.Show("Cantidad invalida");
                    row.Cells["Cantidad"].Value = 1;
                    Cantidad = 1;
                }

                decimal Precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                decimal SubTotal = Cantidad * Precio;

                row.Cells["SubTotal"].Value = SubTotal;

                RecalcularTotal();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dvgDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
                return;
            }

            dvgDetalle.Rows.RemoveAt(dvgDetalle.SelectedRows[0].Index);
            RecalcularTotal();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("La venta no tiene productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Crear la venta
                Venta venta = new Venta
                {
                    Fecha = dtpFecha.Value,
                    MontoTotal = ObtenerTotalVenta(),
                    Id_Cliente = Convert.ToInt32(cboCliente.SelectedValue),
                    Id_TipoPago = Convert.ToInt32(cboPago.SelectedValue)

                };

                //Lista de detalles
                List<DetalleVenta> detalles = new List<DetalleVenta>();
                foreach (DataGridViewRow row in dvgDetalle.Rows)
                {
                    detalles.Add(new DetalleVenta()
                    {
                       Id_Producto = Convert.ToInt32(row)
                    }
                }
            }
        }
    }
}
