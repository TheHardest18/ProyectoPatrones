using FireSharp.Extensions;
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
    public partial class Registro : Form
    {
        Usuarios us = new Usuarios();
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "El campo no puede estar vacio");
                errorProvider1.SetError(txtContraseña, "El campo no puede estar vacio");
            }
            else if (us.UsuarioRegistrado(txtUsuario.Text) == txtUsuario.Text)
            {
                MessageBox.Show(us.RegistrarUsuario(txtUsuario.Text, txtContraseña.Text));

            }
            else if(txtUsuario.Text!="" || txtContraseña.Text != "") 
            {
                errorProvider1.Clear();
                MessageBox.Show("Usuario ya existe\n intente con un usuario diferente");

            }
            
            

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
        }
    }
}
