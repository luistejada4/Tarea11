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

namespace Tarea11
{
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                Categorias c = new Categorias();
                c.Descripcion = DescripcionTextBox.Text;
                BLL.CategoriasBLL.Guardar(c);
            }
            else
            {
                errorProvider.SetError(DescripcionTextBox, "Descripcion Vacia!");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTextBox.Text) || IdTextBox.Text.All(char.IsLetter))
            {

                errorProvider.SetError(IdTextBox, "ID vacio o invalido.");

            }
            else
            {
                var Categoria = BLL.CategoriasBLL.Buscar(Convert.ToInt32(IdTextBox.Text));

                if (Categoria != null)
                {
                    DescripcionTextBox.Text = Categoria.Descripcion;
                }
                else
                {
                    MessageBox.Show("No existe categoria con ese codigo...");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var descripcion = BLL.CategoriasBLL.Buscar(int.Parse(IdTextBox.Text));

            if (descripcion != null)
            {
                BLL.CategoriasBLL.Eliminar(descripcion);
                MessageBox.Show("Se elimino la categoria...");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria...");
            }
        }
    }
}
