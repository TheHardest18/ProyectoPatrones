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
            
            
            Learn mLearn = Learn.getInstancia();
            mLearn.txtValidacion.Text = TxtValidacion.Text;
            mLearn.MdiParent = this;
            mLearn.Show();

            button1.Visible = false;
            button2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Write mWrite = Write.GetWrite();
            mWrite.MdiParent = this;
            mWrite.Show();
            button2.Visible = false;
            button1.Visible = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
