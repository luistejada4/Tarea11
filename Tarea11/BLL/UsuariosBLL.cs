using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea11.Entidades;

namespace Tarea11.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool interruptor = false;

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    db.Usuarios.Add(usuario);
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
        public static Usuarios Buscar(int idUsuario)
        {
            Usuarios u = new Usuarios();

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    u = db.Usuarios.Find(idUsuario);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return u;
        }
        public static bool Eliminar(Usuarios usuario)
        {
            bool interruptor = false;

            using (var db = new DAL.Tarea11DB())
            {
                try
                {
                    db.Entry(usuario).State = EntityState.Deleted;
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
