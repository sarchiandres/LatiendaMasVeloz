using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class MostrarUsuarioForm : Form
    {
        public MostrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            var usuarioActual = controller.MostrarUsuario();
            lbResultado.Text = usuarioActual.Name + " - " + usuarioActual.Description;
        }
    }
}
