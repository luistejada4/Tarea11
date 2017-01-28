using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea11.Entidades;

namespace Tarea11.UI.Registros
{
    public partial class RegistrarUsuarioForm : Form
    {
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            ConfirmPasswordTextBox.Enabled = true;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            BLL.UsuariosBLL.Guardar(new Usuarios(0, NombreTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text));

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var u = BLL.UsuariosBLL.Buscar(Convert.ToInt32(IDTextBox.Text));

            if (u != null)
            {
                NombreTextBox.Text = u.Nombre;
                UserNameTextBox.Text = u.UserName;
                PasswordTextBox.Text = u.Password;
                ConfirmPasswordTextBox.Enabled = false;

            }
            else
            {
                MessageBox.Show("No existe categoria con ese codigo...");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(int.Parse(IDTextBox.Text));

            if (usuario != null)
            {
                BLL.UsuariosBLL.Eliminar(usuario);
                MessageBox.Show("Se elimino la categoria...");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria...");
            }
        }
    }
}
