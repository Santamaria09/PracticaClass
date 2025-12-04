using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaEntidades
{
    public static class Seguridad
    {
        public static string  Hash_SHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                //Convertir texto a bytes
                byte[] bytes = Encoding.UTF8.GetBytes(texto);

                //Calculamos 
                byte[] hash =sha256.ComputeHash(bytes);

                //De bytes a string hexadecimal
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                //Retomamos 
                return sb.ToString();


            }
        }
    }
}
