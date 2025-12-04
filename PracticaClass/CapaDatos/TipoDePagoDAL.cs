using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaDatos
{
    public  class TipoDePagoDAL
    {
        public static List<TiposDePago> Listar()
        {
            List<TiposDePago> Lista = new List<TiposDePago>();

            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM TipoPago";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new TiposDePago
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),

                            });

                        }
                    }
                }
            }
            return Lista;

        }
    }
}
