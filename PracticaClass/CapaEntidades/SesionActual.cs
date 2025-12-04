using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaEntidades
{
    public static class SesionActual
    {
        public static int Id { get; set; }
        public static string UserName { get; set; }
        public static string Rol { get; set; }

        public static void Cerrar()
        {
            Id = 0;
            UserName = null;
            Rol = null;
        }
    }
}
