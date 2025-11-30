using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaDatos
{
    public class ProductoDAL
    {
        public static int ObtenerStock(int IdProducto)
        {
            int Stock = 0;
         
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "Select Stock FROM Producto WHERE ID=@id";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@id", IdProducto);
                    cn.Open();// Abrir la conexion
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                   
                        Stock = Convert.ToInt32(result);
                    
                }
              
            }
            return Stock;


        }
        public static DataTable Listar()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"Select p.Id, p.Nombre, p.Precio, p.Stock, c.Categoria As Categoria FROM Producto p INNER JOIN Categoria c ON p.Id_Categoria =c.Id WHERE p.Estado = 1;";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Tabla.Load(dr);
                    }
                }

            }
            return Tabla;
        }

            
    }
}
