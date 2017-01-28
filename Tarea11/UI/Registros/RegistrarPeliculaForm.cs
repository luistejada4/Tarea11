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
    public partial class RegistrarPeliculaForm : Form
    {
        public RegistrarPeliculaForm()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
          

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Peliculas p = new Peliculas();
            p.CategoriaID = int.Parse(CategoriaIDTextBox.Text);
            p.Descripcion = NombreTextBox.Text;
            p.Estreno = FechaTextBox.Text;
            BLL.PeliculasBLL.Guardar(p);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var p = BLL.PeliculasBLL.Buscar(int.Parse(IDTextBox.Text));

            if (p != null)
            {
                BLL.PeliculasBLL.Eliminar(p);
                MessageBox.Show("Se elimino la categoria...");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria...");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var u = BLL.PeliculasBLL.Buscar(Convert.ToInt32(IDTextBox.Text));

            if (u != null)
            {
                NombreTextBox.Text = u.Descripcion;
                FechaTextBox.Text = u.Estreno;
                CategoriaIDTextBox.Text = u.CategoriaID.ToString();
            }
            else
            {
                MessageBox.Show("No existe categoria con ese codigo...");
            }
        }
    }
}
