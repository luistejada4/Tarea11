using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11.UI.Consultas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistraCategoriaButton_Click(object sender, EventArgs e)
        {
            var f = new CategoriasForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f =new UI.Registros.RegistrarPeliculaForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f =new UI.Registros.RegistrarUsuarioForm();
            f.Show();
        }
    }
}
