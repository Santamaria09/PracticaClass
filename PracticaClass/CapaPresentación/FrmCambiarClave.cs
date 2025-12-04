using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using PracticaClass.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaPresentación
{
    public partial class FrmCambiarClave : Form
    {
        public FrmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SesionActual.Id;
                if (id == 0) throw new Exception("No hay sesión activa.");

                // Verificar clave actual
                var user = UsuarioDAL.Login(SesionActual.UserName, PruebaHash(txtActual.Text));
                if (user == null)

                {
                    MessageBox.Show("La contraseña actual es incorrecta.");
                    return;
                }

                if (txtNueva.Text != txtCC.Text)
                {
                    MessageBox.Show("La nueva contraseña y su confirmación no coinciden.");
                    return;
                }
                bool ok = UsuarioBLL.CambiarClave(id, txtNueva.Text);
                MessageBox.Show(ok ? "Contraseña actualizada." : "No se pudo actualizar.");
                if (ok) this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private string PruebaHash(string pass)
        {
            return Seguridad.Hash_SHA256(pass);
        }

    }
}
