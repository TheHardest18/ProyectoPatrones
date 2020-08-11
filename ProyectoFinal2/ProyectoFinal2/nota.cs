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
    public partial class nota : Form
    {

        public static int check;
        public int x;

        Write notaWrite = Write.GetWrite();

        public static void bueno()
        {
            if (Write.res1 == " ")
            {
                check++;
            }
        }

        public int not;
        private nota()
        {
            InitializeComponent();
        }
        private static nota Instancia = null;
        public static nota getNota()
        {
            if (Instancia == null)
            {
                Instancia = new nota();
            }

            return Instancia;
        }

        private void nota1_Click(object sender, EventArgs e)
        {
            
        }

        private void nota_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           //* string label2 = check.ToString();

           // label2 = check; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos objmodulos = Modulos.GetModulos();
            objmodulos.button1.Visible = true;
            objmodulos.button2.Visible = true;
            objmodulos.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
