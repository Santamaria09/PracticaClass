using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaNegocio
{
    public class VentaDAL
    {
        public static (bool Exito, String Mensaje) RegistrarVentaTransaccional(Venta venta, List<DetalleVenta> detalles)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                SqlTransaction tx = cn.BeginTransaction();

                try
                {
                    string sqlVenta = @"INSERT INTO Venta(Fecha, Monto Total, Id_TipoPago, Id_Cliente) Values (@Fecha, @MontoTotal, @Id_TipoPago, @Id_Cliente); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(sqlVenta, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                        cmd.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                        cmd.Parameters.AddWithValue("@Id_TipoPago", venta.Id_TipoPago);
                        cmd.Parameters.AddWithValue("@Id_Cliente", venta.Id_Cliente);
                        venta.id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string sqlDetalle = @"INSER INTO DetalleVenta(Cantidad, PrecioUnitario, SubTotal, Id_Venta, Id_PRoducto) VALUES (@Cantidad, @PrecioUnitario, @SubTotal, @Id_Venta, @Id_Producto);";

                    var acumulador = new Dictionary<int, int>();

                    foreach (var d in detalles)
                    {
                        using (SqlCommand cmdDet = new SqlCommand(sqlDetalle, cn, tx))
                        {
                            cmdDet.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                            cmdDet.Parameters.AddWithValue("@PrecioUnitario", d.PrecioUnitario);
                            cmdDet.Parameters.AddWithValue("@SubTotal", d.SubTotal);
                            cmdDet.Parameters.AddWithValue("@Id_Venta", venta.id);
                            cmdDet.Parameters.AddWithValue("@Id_Producto", d.Id_Producto);

                            cmdDet.ExecuteNonQuery();
                        }

                        if (!acumulador.ContainsKey(d.Id_Producto))
                            acumulador[d.Id_Producto] = 0;
                        acumulador[d.Id_Producto] += d.Cantidad;


                    }

                    string sqlStock = @"UPDATE Producto SET Stock -@Cantidad WHERE Id= @IdProducto AND Stock >= @Cant;";

                    foreach (var item in acumulador)
                    {
                        using (SqlCommand cmdStock = new SqlCommand(sqlStock, cn, tx))
                        {
                            cmdStock.Parameters.AddWithValue("@Cant", item.Value);
                            cmdStock.Parameters.AddWithValue("@IdProducto", item.Key);

                            int filas = cmdStock.ExecuteNonQuery();

                            if (filas == 0)
                                throw new Exception("Stock insuficiente para el Producto ID: " + item.Key);
                        }
                    }
                    tx.Commit();
                    return (true, "Venta registrada con exito. ID generado:" + venta.id);

                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return (false, "Error al registrar la Venta:" + ex.Message);
                }

            }

        }

    }

}
        