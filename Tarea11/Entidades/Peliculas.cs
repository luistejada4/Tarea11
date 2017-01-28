using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11.Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculaID { get; set; }
        public string Estreno { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaID { get; set; }

    }
}
