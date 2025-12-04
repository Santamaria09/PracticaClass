using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaNegocio
{
    public class UsuarioBLL
    {
        public static Usuario Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("Debe ingresar el usuario y contraseña.");

            string hash = Seguridad.Hash_SHA256(clave);
            return UsuarioDAL.Login(usuario, hash);

        }
        public static List<Usuario> Listar()
        {
            return UsuarioDAL.Listar();
        }

        public static int Insertar(string userName, string clave, string rol)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("Usuario y contraseña requeridos.");

            string hash = Seguridad.Hash_SHA256(clave);
            return UsuarioDAL.Insertar(userName.Trim(), hash, rol);
        }
        public static bool Actualizar(int id, string userName, string rol, bool estado)
        {
            return UsuarioDAL.Actualizar(id, userName.Trim(), rol, estado);
        }

        public static bool Eliminar(int id)
        {
            return UsuarioDAL.Eliminar(id);
        }
        public static bool CambiarClave(int id, string claveNueva)
        {
            if (string.IsNullOrWhiteSpace(claveNueva))
                throw new ArgumentException("La nueva contraseña no puede estar vacía.");

            string hash = Seguridad.Hash_SHA256(claveNueva);
            return UsuarioDAL.CambiarClave(id, hash);
        }

    }





}

