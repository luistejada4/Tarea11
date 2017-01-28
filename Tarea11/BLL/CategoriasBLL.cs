using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea11.Entidades;

namespace Tarea11.BLL
{
    class CategoriasBLL
    {
        public static bool Guardar(Categorias categoria)
        {

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    db.Categorias.Add(categoria);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }
        public static Categorias Buscar(int idCategoria)
        {
            Categorias c;

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    c = db.Categorias.Find(idCategoria);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return c;
        }
        public static bool Eliminar(Categorias categoria)
        {
            using (var conec = new DAL.Tarea11DB())
            {
                try
                {
                    conec.Entry(categoria).State = EntityState.Deleted;
                    conec.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
    }
}
