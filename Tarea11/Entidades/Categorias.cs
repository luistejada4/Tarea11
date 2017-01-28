using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Descripcion { get; set; }
    }

}
