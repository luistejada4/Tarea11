using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea11.Entidades;

namespace Tarea11.DAL
{
    public class Tarea11DB : DbContext
    {
        public Tarea11DB() : base("ConStr")
        {

        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
