using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaEntidades
{
    public class Cliente
    {
       public int Id { get; set; }
        public string Nombre { get; set; }
        public string DUI { get; set; }
            public string Telefono { get; set; }
        public string Correo { get; set; }

        public bool Estado { get; set; }
    }
}
