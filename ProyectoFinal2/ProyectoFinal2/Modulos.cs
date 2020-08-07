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
    public partial class Modulos : Form
    {
        //Patron Singleton
        private Modulos()
        {
            InitializeComponent();
        }
        private static Modulos InsModulos = null;
        public static Modulos GetModulos() 
        {
            if (InsModulos == null)
            {
                InsModulos = new Modulos();
            }

            return InsModulos;

        }//fin

        private void Modulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Learn mLearn = Learn.getInstancia();
            mLearn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Write mWrite = Write.GetWrite();
            mWrite.Show();
        }
    }
}
