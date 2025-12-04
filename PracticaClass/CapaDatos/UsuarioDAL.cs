    using PracticaClass.CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaDatos
{
    public class UsuarioDAL
    {
        public static Usuario Login(string userName, string claveHASH)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Id, UserName, Rol, Estado FROM Usuario WHERE UserName=@u AND ClaveHash=@h AND Estado=1", cn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@h", claveHASH);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Usuario
                            {

                                Id = Convert.ToInt32(dr["Id"]),
                                UserName = dr["UserName"].ToString(),
                                Rol = dr["Rol"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            };
                        }
                    }
                }
            }
            return null;
        }
        public static List<Usuario> Listar()
        {
            var Lista = new List<Usuario>();

            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, UserName, Rol, Estado FROM Usuario", cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Lista.Add(new Usuario
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            UserName = dr["UserName"].ToString(),
                            Rol = dr["Rol"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"])
                        });

                    }
                }
            }
            return Lista;
        }

        public static int Insertar(string userName, string claveHash, string rol)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (UserName, ClaveHash, Rol, Estado) VALUES (@u, @h, @r, 1); SELECT SCOPE_IDENTITY();", cn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@h", claveHash);
                    cmd.Parameters.AddWithValue("@r", rol);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }


        }
        public static bool Actualizar(int id, string userName, string rol, bool estado)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Usuario SET UserName=@u, Rol=@r, Estado=@e WHERE Id=@id", cn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@r", rol);
                    cmd.Parameters.AddWithValue("@e", estado);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Id=@id", cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool CambiarClave(int id, string claveHashNueva)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Usuario SET ClaveHash=@h WHERE Id=@id", cn))
                {
                    cmd.Parameters.AddWithValue("@h", claveHashNueva);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }



}

           
                
            
        

    

