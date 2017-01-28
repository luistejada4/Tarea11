using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea11.Entidades;

namespace Tarea11.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Peliculas pelicula)
        {
            bool interruptor = false;

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    db.Peliculas.Add(pelicula);
                    db.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return interruptor;
        }
        public static Peliculas Buscar(int idPelicula)
        {
            Peliculas p = new Peliculas();

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                   p = db.Peliculas.Find(idPelicula);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return p;
        }
        public static bool Eliminar(Peliculas pelicula)
        {
            bool interruptor = false;

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    db.Entry(pelicula).State = EntityState.Deleted;
                    db.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }
    }
}
