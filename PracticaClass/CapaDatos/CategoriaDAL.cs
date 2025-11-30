using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaDatos
{
    public class CategoriaDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "Select Id, Nombre, Descripcion From Categoria";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);


                }




            }
            return dt;



        }
        public int Insertar(Categoria c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"Insert into Categoria (Nombre, Descripcion) Values (@nombre, @descripcion); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (Object)c.Descripcion ?? DBNull.Value);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }


        }

        public bool Actualizar(Categoria c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"UPDATE Categoria SET Nombre =@nombre, Descripcion =@descripcion WHERE Id= @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (Object)c.Descripcion ?? DBNull.Value);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Categoria WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable Buscar(String filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, Descripcion FROM Categoria WHERE Nombre LIKE @filtro OR Descripcion LIKE @flitro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);

                }
            }
            return dt;


        }

        public bool ExisteNombre(String Nombre)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT COUNT(*) FROM Categoria WHERE Nombre = @nombre";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool ExisteNombreEnOtraC(String Nombre, int Id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT COUNT(*) FROM Categoria WHERE Nombre = @nombre AND Id <> @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@id", Id);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool TieneProductosAsociados(int IdCategoria)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT COUNT(*) FROM Producto WHERE Id_Categoria= @IdCategoria";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }
}

  



    

