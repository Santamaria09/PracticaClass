using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass
{
    public partial class FrmClientes : Form
    {
        //Lista estatica para simular la conexion con la base de datos
        private static List<Clientes> ListaClientes = new List<Clientes>();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (!ListaClientes.Any())
            {
                ListaClientes.Add(new Clientes
                {
                    ID = 1,
                    Nombre = "Juan Perezz",
                    Direccion = "Cuidad de Mexico, Mexico",
                    Telefono = "7712-1211",
                    Correo = "Juan.perez@estudiante.it.edu.mx",
                    Genero = "Masculino",
                });
                ListaClientes.Add(new Clientes
                {
                    ID = 2,
                    Nombre = "Maria Gonzales",
                    Direccion = "Santa Ana, El Salvador ",
                    Telefono = "7878-3221",
                    Correo = "maria.gonzalez@docente.it.edu.sv",
                    Genero = "Femenino",
                });
                ListaClientes.Add(new Clientes
                {
                    ID = 3,
                    Nombre = "Carlos Lopez",
                    Direccion = "La Union, El Salvador",
                    Telefono = "6767-5656",
                    Correo = "carlos.lopez@coordinador.it.edu.sv",
                    Genero = "Masculino",
                });
                ListaClientes.Add(new Clientes
                {
                    ID = 4,
                    Nombre = "Ana Rodriguez",
                    Direccion = "San Salvador, El Salvador",
                    Telefono = "7979-1513",
                    Correo = "ana.rodriguez@director.it.edu.sv",
                    Genero = "Femenino",
                });
            }
            //Metodo para refrescar 
            RefrescarListaClientes();
            DesabilitarBotones();
        }
        private void DesabilitarBotones()
        {
            btnUsuario.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminarC.Enabled = false;
            btnCampo.Enabled = true;
            btnVolverC.Enabled = true;
        }
        private void RefrescarListaClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ListaClientes;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreC.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La direccion es obligatoria", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El telefono es obligatorio", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.TelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El Telefono debe contener 8 digitos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Crear un nuevo cliente 
            int nuevoID = ListaClientes.Any() ? ListaClientes.Max(x => x.ID) + 1 : 1;
            var C = new Clientes
            {
                ID = nuevoID,
                Nombre = txtNombreC.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Genero = txtGenero.Text.Trim()
            };
            ListaClientes.Add(C);
            MessageBox.Show("Cliente agregado exitosamente.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarListaClientes();
            //Limpiar los Controles 
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombreC.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtGenero.Clear();
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar los datos del Usuario seleccionado en los controles
            if (dgvClientes.CurrentRow == null) return;
            txtID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombreC.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtGenero.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            HabilitarBotones();
        }

        private void HabilitarBotones()
        {
            btnUsuario.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminarC.Enabled = true;
            btnCampo.Enabled = true;
            btnVolverC.Enabled = true;
        }
        private void gpbCliente_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCampo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int ID))
            {
                MessageBox.Show("Seleccione un usuario valido para eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaClientes.FirstOrDefault(x => x.ID == ID);
            if (prod == null)
            {
                MessageBox.Show("Usuario no encontrado"); return;
            }
            if (MessageBox.Show("¿Esta seguro de eliminar al usuario" + prod.Nombre + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaClientes.Remove(prod);
                MessageBox.Show("Registros del usuario eliminado exitosamente.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarListaClientes();
                LimpiarCampos();
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Validar que el ID sea el correcto 
            if (!int.TryParse(txtID.Text, out int ID))
            {
                MessageBox.Show("Seleccione un dato valido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaClientes.FirstOrDefault(x => x.ID == ID);
            if (prod == null)
            {
                MessageBox.Show("Usuario no encontrado"); return;
            }
            //Validaciones 
            if (string.IsNullOrWhiteSpace(txtNombreC.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La direccion es obligatoria", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El correo es obligatorio", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            //Actualizar el producto
            prod.Nombre = txtNombreC.Text.Trim();
            prod.Direccion = txtDireccion.Text.Trim();
            prod.Telefono = txtTelefono.Text.Trim();
            prod.Correo = txtCorreo.Text.Trim();
            prod.Genero = txtGenero.Text.Trim();
            MessageBox.Show("Datos del Usuarui han sido actualizados exitosamente", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarListaClientes();
            LimpiarCampos();
            HabilitarBotones();


        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Desea regresar al menu principal?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

       

    
    }
}
