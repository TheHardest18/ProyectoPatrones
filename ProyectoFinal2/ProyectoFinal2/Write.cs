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
    public partial class Write : Form
    {
        private int indice;
   
        public Write()
        {
            InitializeComponent();
            indice = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            indice++;
            if (indice > 4)
                indice = 0;

            label1.ImageIndex = indice;
            label2.ImageIndex = indice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos objmodulos = new Modulos();
            objmodulos.Show();
        }
    }
}
