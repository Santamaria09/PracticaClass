using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClass.CapaNegocio
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL();

        public DataTable Listar()
        {
            return dal.Listar();
        }

        public int Guardar(Cliente c)
        {
            if (String.IsNullOrWhiteSpace(c.Nombre))
                throw new Exception("El nombre del cliente es obligatorio");
            if (c.Id == 0)
            {
                return dal.insertar(c);
                MessageBox.Show("Registro insertado correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dal.Actualizar(c);
                MessageBox.Show("Registro actualizado correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return c.Id;
            }
            
        }
        public bool Eliminar(int id)
        {
            return dal.Eliminar(id);
            MessageBox.Show("Registro eliminado correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        public DataTable Buscar(string filtro)
        {
            return dal.Buscar(filtro);
        }
        
                                                   


    }
}
