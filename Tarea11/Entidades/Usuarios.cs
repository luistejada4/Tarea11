using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string UserName { get; set;}
        public string Password { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(int UsuariodID, string Nombre, string UserName, string Password)
        {
            this.UsuarioID = UsuariodID;
            this.Nombre = Nombre;
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
