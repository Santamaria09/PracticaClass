using PracticaClass.CapaEntidades;
using PracticaClass.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaPresentación
{
    public partial class FrmCategoriaGestion : Form
    {
        public string Modo {  get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        CategoriaBLL bll= new CategoriaBLL();
        public FrmCategoriaGestion()
        {
            InitializeComponent();
        }

        private void FrmCategoriaGestion_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
               lblTitulo.Text = "AGREGAR CATEGORIA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                txtNombre.Text = Nombre;
                txtDescripcion.Text = Descripcion;
            }
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para la categoria", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Categoria c = new Categoria
                {
                    id = Id,
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };
                bll.Guardar(c);
                MessageBox.Show(Modo == "Nuevo" ? "La categoria ha sido registrada correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al interactuar con la base de datos.\n\nDetalles tecnicos:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado:\n" + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
