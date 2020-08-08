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
        
        public string res1;
        public string res2;
        public string res3;
        public string res4;
        public string res5;

        public string res1a;
        public string res2b;
        public string res3c;
        public string res4d;
        public string res5e;

        private int indice;
   //Patron Singleton
        private Write()
        {
            InitializeComponent();
            indice = 0;
        }
        private static Write insWrite = null;
        public static Write GetWrite() 
        {
            if (insWrite == null) 
            {
                insWrite = new Write();
            }
            return insWrite;
        }//fin


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            indice++;
            if (indice == 4)
            {
                MessageBox.Show("end of the lesson");
                button1.Enabled = false;
                button3.Visible = true;
            }

            

            label1.ImageIndex = indice;
            label2.ImageIndex = indice;

            if(indice == 0)
            {res1 = textBox1.Text; }
            if(indice == 1)
            { res2 = textBox1.Text; }
            if (indice == 2)
            { res3 = textBox1.Text; }
            if (indice == 3)
            { res4 = textBox1.Text; }

            if (indice == 0)
            { res1 = textBox2.Text; }
            if (indice == 1)
            { res2 = textBox2.Text; }
            if (indice == 2)
            { res3 = textBox2.Text; }
            if (indice == 3)
            { res4 = textBox2.Text; }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos objmodulos = Modulos.GetModulos();
            objmodulos.Show();
            if (objmodulos.button1.Visible == false)
            {
                objmodulos.button1.Visible = true;
                objmodulos.button2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            nota nota1 = nota.getNota();
            nota1.MdiParent = Modulos.ActiveForm;
            nota1.Show();
        }

        private void Write_Load(object sender, EventArgs e)
        {

        }
    }
}
