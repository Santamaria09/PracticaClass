using PracticaClass.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaPresentación
{
    public partial class FrmCategoriaEliminar : Form
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        CategoriaBLL bll = new CategoriaBLL();

        public FrmCategoriaEliminar()
        {
            InitializeComponent();
        }

        private void FrmCategoriaEliminar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Nombre;
            txtDescripcion.Text = Descripcion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var r = MessageBox.Show($"¿Estas seguro que desea eliminar la categoria" + "Esta accion no se puede deshacer", "Confirmar eliminacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.No)
                    return;

                bll.Eliminar(Id);
                MessageBox.Show("La categoria ha sido eliminada correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar esta esta categoria porque esta asociada a otros registros\n" + "Actualice o elimine esos registros primero", "Eliminacion no permitida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                MessageBox.Show("Ocurrio un error al intertar eliminar la categoria\n\nDetalles tecnicos:\n" +  ex.Message,"Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado:\n" + ex.Message,"Error general",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
