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
    public class ClienteDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
                //Conexion con la base de datos
            { 
                string sql = "Select ID, Nombre, DUI, Telefono, Correo, Estado FROM Cliente";
                //Los datos registrados en la base de datos
                using(SqlCommand cmd = new SqlCommand(sql,cn))
                    //Devuelva los datos registrados 
                {
                    cn.Open();// Abrir la conexion
                    new SqlDataAdapter(cmd).Fill(dt);
                    //Ejecuta el comando y muestra los datos ingresados
                }

            }
            return dt;
        }
        //Agregar y actualizar datos de la tabla cliente
        public int insertar(Cliente c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "INSERT INTO Cliente (Nombre, DUI, Telefono, Correo, Estado) values(@nombre,@dui, @telefono, @correo, @estado); SELECT SCOPE_IDENTITY();";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.DUI);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
        }

        public bool Actualizar(Cliente c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "Update Cliente SET Nombre=@nombre, DUI=@dui, Telefono=@telefono, Correo=@correo, Estado= @estado where ID=@id;";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.DUI);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
        }
        //Filtrar datos
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = @"Select ID, Nombre, DUI, Telefono, Correo, Estado FROM Cliente 
                    where Nombre like @filtro or Telefono like @filtro";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;

                }
            }


        }

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "DELETE FROM Cliente where ID=@id;";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
        }

        public static List<Cliente>ListarActivos()
        {
            List<Cliente>Lista = new List<Cliente>();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Cliente WHERE Estado = 1";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader dr =  cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Cliente
                            { 
                                Id = Convert.ToInt32(dr["ID"]),
                                Nombre = dr["Nombre"].ToString(),
                                DUI = dr["DUI"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])

                            });
                        }
                    }
                }
            }
                return Lista;

        }


    }
}
    