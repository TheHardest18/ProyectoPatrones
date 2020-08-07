using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProyectoFinal2
{
   
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "PLVkEMQDn0cXiTp6JtG6aU3RedKhVu08RhUldYtT",
            BasePath = "https://proyectoprog2-41156.firebaseio.com/"


        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos mModulos = Modulos.GetModulos();
            mModulos.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null) 
            {
                MessageBox.Show("Conexion estable");
            }
        }
    }
}
