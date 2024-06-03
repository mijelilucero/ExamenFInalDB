using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFInalDB
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.ToLower();
            string contra = textBoxContrasena.Text.ToLower();

            if (usuario.Equals("viajero2024") && contra.Equals("destino"))
            {
                FormCRUD formulario = new FormCRUD();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
                textBoxUsuario.Text = "";
                textBoxContrasena.Text = "";
            }
        }
    }
}
