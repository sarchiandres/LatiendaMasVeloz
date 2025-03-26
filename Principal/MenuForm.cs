using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuarioFrom fr = new CrearUsuarioFrom();
            fr.ShowDialog();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarioForm fr = new MostrarUsuarioForm();
            fr.ShowDialog();
        }
    }
}
