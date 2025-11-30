using PracticaClass.CapaDatos;
using PracticaClass.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClass.CapaNegocio
{
    public class CategoriaBLL
    {
        CategoriaDAL dal = new CategoriaDAL();

        public DataTable Listar()
        {
            return dal.Listar();

        }
        private void ValidarCategoria(Categoria c, bool EsEdicion = false)
        {
            if (String.IsNullOrWhiteSpace(c.Nombre))
                throw new Exception("El nombre de la categoria es obligatoria");

            if (c.Nombre.Length > 50)
                throw new Exception("El nombre no debe de superar los 50 caracteres");

            if (!String.IsNullOrWhiteSpace(c.Descripcion) && c.Descripcion.Length > 250)
                throw new Exception("La descripcion no debe superar los 250 caracterres");

            if (!EsEdicion)
            {
                if (dal.ExisteNombre(c.Nombre))
                    throw new Exception("Ya existe una categoria con ese nombre");

            }
            else
            {
                if (dal.ExisteNombreEnOtraC(c.Nombre, c.id))
                    throw new Exception("Ya existe otra categoria con ese nombre");
                    
            }
            
        }

        public int Guardar(Categoria c)
        {
            if (c.id == 0)
            {
                ValidarCategoria(c, EsEdicion: false);
                return dal.Insertar(c);
            }
            else
            {
                ValidarCategoria(c, EsEdicion: true);
                bool actualizado = dal.Actualizar(c);
                if (!actualizado)
                    throw new Exception("No se puede actualzar la categoria");
                return c.id;
            }
        }

        public bool Eliminar (int id)
        {
            if (dal.TieneProductosAsociados(id))
                throw new Exception("No se puede eliminar esta categoria porque tiene productos asociados");
            return dal.Eliminar(id);    

        }

        public DataTable Buscar(string filtro)
        {
            return dal.Buscar(filtro);

        }

    }

     
 }

