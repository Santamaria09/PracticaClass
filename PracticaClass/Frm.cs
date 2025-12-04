using PracticaClass.CapaDatos;
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

namespace PracticaClass
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            int Stock = ProductoDAL.ObtenerStock(1);
            MessageBox.Show("Stock del producto 1:" + Stock);
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            var Cliente = ClienteDAL.ListarActivos();
            MessageBox.Show("Clientes Activos: " +
                Cliente.Count);
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            var Pagos = TipoDePagoDAL.Listar();
            MessageBox.Show("Tipo de Pago:" + Pagos.Count);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta()
            {
                Fecha = DateTime.Now,
                MontoTotal = 5.00m,
                Id_Cliente = 1,
                Id_TipoPago = 1
            };

            var detalles = new List<DetalleVenta>()
            {
                new DetalleVenta()
                {
                    Id_Producto = 1,
                    Cantidad = 1,
                    PrecioUnitario = 5.00m,
                    SubTotal = 5.00m
                }
            };

            var r = VentaBLL.ValidarVenta(venta, detalles);
            MessageBox.Show(r.Mensaje);
        }

        private void btnRapidad_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta()
            {
                Fecha = DateTime.Now,
                MontoTotal = 10.00m,
                Id_Cliente = 1,
                Id_TipoPago = 1
            };

            var detalles = new List<DetalleVenta>()
            {
                new DetalleVenta()
                {
                    Id_Producto = 1,
                    Cantidad = 1,
                    PrecioUnitario =10.00m,
                    SubTotal = 10.00m

                }
            };

            var r = VentaDAL.RegistrarVentaTransaccional(venta, detalles);
            MessageBox.Show(r.Mensaje);
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
