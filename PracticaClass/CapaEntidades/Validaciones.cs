using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticaClass.CapaEntidades
{
    public static class Validaciones
    {
        public static bool EsDecimal(String s)
        {
            decimal d;
            return decimal.TryParse(s, out d);
        }
        public static bool EsEntero(String s)
        {
            int i;
            return int.TryParse(s, out i);
        }
        public static bool EsCorreoValido(String email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            var patron = @"^[@\s]+@[^@\s]+\.[@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        public static bool TelefonoValido(String Telefono)
        {
            return Telefono.Length == 8
                && Telefono.All(char.IsDigit);
        }
    }

}
