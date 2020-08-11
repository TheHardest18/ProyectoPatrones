using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class Login : Form 
    {
        Usuarios us = new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "El campo no puede estar vacio");
                errorProvider1.SetError(txtContraseña, "El campo no puede estar vacio");
            }
            else
            {
                us.Usuario(txtUsuario.Text, txtContraseña.Text);
                this.Hide();
                Modulos mod = Modulos.GetModulos();

                mod.Show();
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }
    }
}
